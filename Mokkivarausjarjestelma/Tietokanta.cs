using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lisätyt luokat
using MySql.Data.MySqlClient;
using System.Windows.Forms;




namespace Mokkivarausjarjestelma
{
    public abstract class Tietokanta
    {
        protected MySqlConnection con=new MySqlConnection();
        protected MySqlCommand command;
        protected MySqlDataReader reader;

        //Metodi tietokantaan yhdistämistä varten 
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

        //Kantaluokan abstrakti metodi Select-lauseita varten 
        public abstract void SelectQuery();
                  
        
        //Kantaluokan abstrakti metodi Update-lauseille
        public abstract void UpdateQuery(Asiakas a);

        public abstract void InsertQuery(Asiakas a);
        

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
      
        //SelectQueryn toteutus asiakkaan tietojen hakemiseen
        public override void SelectQuery()
        {
            string kasky = "Select * from asiakas";
            command = con.CreateCommand();
            command.CommandText = kasky;
            reader = command.ExecuteReader(); 
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

        //UpdateQueryn toteutus asiakkaiden tietojen muokkaamiseen
        public override void UpdateQuery(Asiakas a)
        {
            command = con.CreateCommand();
            Connect();
            //Update Query @merkityt muuttujat? korvataan parametreillä
            command.CommandText = @"UPDATE asiakas SET etunimi=@etunimi, sukunimi=@sukunimi, syntymaaika=@syntymaaika,
            katuosoite=@katuosoite, postinumero=@postinumero, postitoimipaikka=@postitoimipaikka, maa=@maa, puhelinnumero=@puhelinnumero,sahkopostiosoite=@sahkopostiosoite WHERE asiakasnumero=@asiakasnumero";
            //Lisätään updatequeryyn parametrina annetun asiakkaan tiedot
            command.Parameters.AddWithValue("@etunimi", a.Etunimi);
            command.Parameters.AddWithValue("@sukunimi", a.Sukunimi);
            command.Parameters.AddWithValue("@syntymaaika", a.Syntymaaika);
            command.Parameters.AddWithValue("@katuosoite", a.Postiosoite);
            command.Parameters.AddWithValue("@postinumero", a.Postinumero);
            command.Parameters.AddWithValue("@postitoimipaikka", a.Postitoimipaikka);
            command.Parameters.AddWithValue("@maa", a.Maa);
            command.Parameters.AddWithValue("@puhelinnumero", a.Puhelinnumero);
            command.Parameters.AddWithValue("@sahkopostiosoite", a.Sahkoposti);
            command.ExecuteNonQuery();
            //Viesti, joka ilmoittaa tietojen päivityksen onnistuneen
            MessageBox.Show("Asiakastiedot päivitetty", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //Suljetaan yhteys
            CloseConnection();
        }

        public override void InsertQuery(Asiakas a)
        {
            command = con.CreateCommand();
            Connect();
            command.CommandText = @"INSERT INTO asiakas (etunimi,sukunimi,syntymaaika,katuosoite,postinumero,postitoimipaikka,maa,puhelinnumero,sahkopostiosoite)
                                VALUES (@etunimi, @sukunimi, @syntymaaika, @katuosoite, @postinumero, @postitoimipaikka, @maa, @puhelinnumero, @sahkopostiosoite)";
            command.Parameters.AddWithValue("@etunimi", a.Etunimi);
            command.Parameters.AddWithValue("@sukunimi", a.Sukunimi);
            command.Parameters.AddWithValue("@syntymaaika", a.Syntymaaika);
            command.Parameters.AddWithValue("@katuosoite", a.Postiosoite);
            command.Parameters.AddWithValue("@postinumero", a.Postinumero);
            command.Parameters.AddWithValue("@postitoimipaikka", a.Postitoimipaikka);
            command.Parameters.AddWithValue("@maa", a.Maa);
            command.Parameters.AddWithValue("@puhelinnumero", a.Puhelinnumero);
            command.Parameters.AddWithValue("@sahkopostiosoite", a.Sahkoposti);
            command.ExecuteNonQuery();
            //Viesti, joka ilmoittaa tietojen päivityksen onnistuneen
            MessageBox.Show("Uusi asiakas lisätty", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //Suljetaan yhteys
            CloseConnection();
        }
       
    }
}
