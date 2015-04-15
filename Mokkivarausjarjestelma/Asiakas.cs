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
    /*Osittainen luokka Asiakas, toinen osa on AsiakasSetGet, joka sisältää attributtien setterit ja getterit
    Sisältää asiakkaan attribuutit ja metodeja asiakkaanhallintaa varten*/
    public partial class Asiakas
    {
        //Asiakkaan muuttujat, pitää miettiä vielä tyypit. Nyt kaikki stringeinä, mikä tässä vaiheessa tuntuu toimivimmalta
        private string asiakasnumero;
        private string nimitys;
        private string etunimi;
        private string sukunimi;
        private string syntymaaika;
        private string postiosoite;
        private string postinumero;
        private string postitoimipaikka;
        private string maa;
        private string puhelinnumero;
        private string sahkoposti;

        //Lista löytyneitä asiakkaita varten
        public List<Asiakas> asiakaslista = new List<Asiakas>();

        //Muuttujat tietokantakyselyjä varten
        protected MySqlConnection yhteys;
        protected MySqlCommand kasky;
        protected MySqlDataReader lukija;

        //Asiakkaan konstruktori
        public Asiakas() { }
        //Asiakkaan destruktori
        ~Asiakas() { }

        //Ylikirjoitetaan metodi toString, jotta listboxissa näkyisi etu- ja sukunimi
        public override string ToString()
        {
            return this.Etunimi + " " + this.Sukunimi;
        }



        //SelectQueryn toteutus asiakkaan tietojen hakemiseen
        public void HaeKaikkiAsiakkaatTietokannasta()
        {
            Tietokanta t=new Tietokanta();
            yhteys=t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "Select * from asiakas";
            lukija = kasky.ExecuteReader();
            try
            {
                while (lukija.Read())
                {
                    //Luodaan, jokaista taulun riviä varten asiakasolioita 
                    Asiakas a = new Asiakas();
                    a.Asiakasnumero = lukija.GetString("asiakasnumero");
                    a.Etunimi = lukija.GetString("etunimi");
                    a.Sukunimi = lukija.GetString("sukunimi");
                    a.Syntymaaika = lukija.GetString("syntymaaika");
                    a.Postiosoite = lukija.GetString("katuosoite");
                    a.Postinumero = lukija.GetString("postinumero");
                    a.Postitoimipaikka = lukija.GetString("postitoimipaikka");
                    a.Maa = lukija.GetString("maa");
                    a.Puhelinnumero = lukija.GetString("puhelinnumero");
                    a.Sahkoposti = lukija.GetString("sahkopostiosoite");
                    //Lisätään luotu olio listaan
                    asiakaslista.Add(a);
                    //Alustetaan t nollaksi
                    a = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tietoja haettaessa tapahtui virhe:" + ex.ToString());
            }
            try
            {
                //Suljetaan reader
                lukija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Readeria sulkiessa tapahtui virhe:" + ex.ToString());
            }
            t.SuljeYhteysTietokantaan(yhteys);
        }

        public void PaivitaAsiakasTietokantaan(Asiakas a)
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand(); 
            //Update Query @merkityt muuttujat? korvataan parametreillä
            kasky.CommandText = @"UPDATE asiakas SET etunimi=@etunimi, sukunimi=@sukunimi, syntymaaika=@syntymaaika,
            katuosoite=@katuosoite, postinumero=@postinumero, postitoimipaikka=@postitoimipaikka, maa=@maa, puhelinnumero=@puhelinnumero,sahkopostiosoite=@sahkopostiosoite WHERE asiakasnumero=@asiakasnumero";
            //Lisätään updatequeryyn parametrina annetun asiakkaan tiedot
            kasky.Parameters.AddWithValue("@asiakasnumero", a.Asiakasnumero);
            kasky.Parameters.AddWithValue("@etunimi", a.Etunimi);
            kasky.Parameters.AddWithValue("@sukunimi", a.Sukunimi);
            kasky.Parameters.AddWithValue("@syntymaaika", a.Syntymaaika);
            kasky.Parameters.AddWithValue("@katuosoite", a.Postiosoite);
            kasky.Parameters.AddWithValue("@postinumero", a.Postinumero);
            kasky.Parameters.AddWithValue("@postitoimipaikka", a.Postitoimipaikka);
            kasky.Parameters.AddWithValue("@maa", a.Maa);
            kasky.Parameters.AddWithValue("@puhelinnumero", a.Puhelinnumero);
            kasky.Parameters.AddWithValue("@sahkopostiosoite", a.Sahkoposti);
            try
            {
                kasky.ExecuteNonQuery();
                //Viesti, joka ilmoittaa tietojen päivityksen onnistuneen
                MessageBox.Show("Asiakastiedot päivitetty", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Päivitettäessä tietoja tapahtui virhe: " + ex.ToString());
            }

            //Suljetaan yhteys
            t.SuljeYhteysTietokantaan(yhteys);
        }

        //Metodi asiakkaan tietokantaan lisäämiselle
        public void LisaaAsiakasTietokantaan(Asiakas a)
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = @"INSERT INTO asiakas (etunimi,sukunimi,syntymaaika,katuosoite,postinumero,postitoimipaikka,maa,puhelinnumero,sahkopostiosoite)
                                VALUES (@etunimi, @sukunimi, @syntymaaika, @katuosoite, @postinumero, @postitoimipaikka, @maa, @puhelinnumero, @sahkopostiosoite)";
            kasky.Parameters.AddWithValue("@etunimi", a.Etunimi);
            kasky.Parameters.AddWithValue("@sukunimi", a.Sukunimi);
            kasky.Parameters.AddWithValue("@syntymaaika", a.Syntymaaika);
            kasky.Parameters.AddWithValue("@katuosoite", a.Postiosoite);
            kasky.Parameters.AddWithValue("@postinumero", a.Postinumero);
            kasky.Parameters.AddWithValue("@postitoimipaikka", a.Postitoimipaikka);
            kasky.Parameters.AddWithValue("@maa", a.Maa);
            kasky.Parameters.AddWithValue("@puhelinnumero", a.Puhelinnumero);
            kasky.Parameters.AddWithValue("@sahkopostiosoite", a.Sahkoposti);
            try
            {
                kasky.ExecuteNonQuery();
                //Viesti, joka ilmoittaa tietojen päivityksen onnistuneen
                MessageBox.Show("Uusi asiakas lisätty", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe lisättäessä asiakasta:" + ex.ToString());
            }
            //Suljetaan yhteys
            t.SuljeYhteysTietokantaan(yhteys);
        }

        //Metodi asiakkaan poistamiselle tietokannasta
        public void PoistaAsiakasTietokannasta(Asiakas a)
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "DELETE FROM asiakas WHERE asiakasnumero=@asiakasnumero";
            kasky.Parameters.AddWithValue("@asiakasnumero", a.Asiakasnumero);
            try
            {
                kasky.ExecuteNonQuery();
                MessageBox.Show("Asiakas poistettu", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe asiakasta poistettaessa:" + ex.ToString());
            }
            t.SuljeYhteysTietokantaan(yhteys);
        }
    }
}
