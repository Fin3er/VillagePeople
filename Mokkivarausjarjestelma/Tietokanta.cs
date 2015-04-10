using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lisätyt luokat
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.ComponentModel;

namespace Mokkivarausjarjestelma
{
    public abstract class Tietokanta
    {
        protected MySqlConnection con=new MySqlConnection();
        protected MySqlCommand command;
        protected MySqlDataReader reader;

        //Metodi tietokantaan yhdistämistä varten (pitäisikö ConnectionString antaa parametrinä? Ei jos aina vain sama tietokanta kyseessä. Salasanan käyttöä pitää pohtia!)
        public void Connect()
        {
            //Yritetään avata yhteys
            try
            {
                con.ConnectionString = "server = localhost; user id = newuser; password = uusi1234; database = asiakkaat";
                con.Open();
                MessageBox.Show("Connected to MySQL Database");
            }
            catch (Exception ex) { MessageBox.Show("Connection Failed due to:" + ex.ToString()); }
        }

        //Metodi tietokanta yhteyden sulkemiselle
        public void CloseConnection()
        {
            try
            {
                //Yritetään sulkea yhteys tietokantaan
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection could not be closed due to:" + ex.ToString());
            }
        }

        //Kantaluokan virtuaalinen metodi Select-lauseita varten 
        public virtual void SelectQuery(string kasky)
        {
            command = con.CreateCommand();
            command.CommandText = kasky;
            reader = command.ExecuteReader();
        }

        public virtual void InsertQuery()
        {
            command = con.CreateCommand();
        
        }

        //Tietokanta luokan konstruktori
        public Tietokanta() {}

        //Tietokanta luokan destruktori
        ~Tietokanta() {
            /* En tiedä vielä olisko tässä vielä hyvä varmistaa yhteyden sulkeminen
            try
            {
                //Yritetään sulkea yhteys tietokantaan
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection could not be closed due to:" + ex.ToString());
            }
             */
        }

    }


    //Luokka, jolla hallitaan tietokannan asiakastietoja
    public class Asiakastietokanta:Tietokanta
    {
        //Lista löytyneitä asiakkaita varten
        public List<Asiakas> lista = new List<Asiakas>();
      
        //Ylikirjoitetaan kantaluokan metodi. Lisätoimintona asiakkaan tietojen lukeminen ja lisääminen listaan + readerin sulkeminen
        public override void SelectQuery(string kasky)
        {
            base.SelectQuery(kasky);
            while (reader.Read())
            {
                //Luodaan, jokaista taulun riviä varten asiakasolioita 
                Asiakas t = new Asiakas();
                t.Asiakasnumero = reader.GetString("asiakasnumero");
                t.Etunimi = reader.GetString("etunimi");
                t.Sukunimi = reader.GetString("sukunimi");
                t.Syntymaaika = reader.GetString("syntymaaika");
                t.Postiosoite = reader.GetString("katuosoite");
                t.Postinumero = reader.GetString("postinumero");
                t.Postitoimipaikka = reader.GetString("postitoimipaikka");
                t.Maa = reader.GetString("maa");
                t.Puhelinnumero = reader.GetString("puhelinnumero");
                t.Sahkoposti = reader.GetString("sahkopostiosoite");
                //Lisätään luotu olio listaan
                lista.Add(t);
                //Alustetaan t nollaksi
                t = null;
            }
            //Suljetaan reader
            reader.Close();
        }

        public override void InsertQuery()
        {
            base.InsertQuery(kasky);
            command.CommandText = ("INSERT INTO asiakas(asiakasnumero,etunimi,sukunimi,syntymaaika,katuosoite,postinumero,postitoimipaikka,maa,puhelinnumero,sahkopostiosoite)"
                +"VALUES(@asiakasnumero,@etunimi,@sukunimi,@syntymaaika,@katuosoite,@postinumero,@postitoimipaikka,@maa,@puhelinnumero,@sahkopostiosoite)");
            command.Parameters.AddWithValue("@asiakasnumero",txbxAsiakasnumero.Text)
        }
    }
}
