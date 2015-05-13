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
    public partial class Toimipiste
    {
        //Toimipisteen muuttujat
        private string toimipisteid;
        private string nimi;
        private string postiosoite;
        private string postinumero;
        private string postitoimipaikka;
        private string puhelinnumero;
        private string sahkopostiosoite;
        private string yhteyshenkilo;
        private string aukioloaika;
        private string maa;

        //Lista toimipisteitä varten
        public List<Toimipiste> toimipistelista = new List<Toimipiste>();

        //Muuttujat tietokantakyselyjä varten
        protected MySqlConnection yhteys;
        protected MySqlCommand kasky;
        protected MySqlDataReader lukija;

        //Toimipisteen konstruktori
        public Toimipiste() { }
        //Toimipisteen destruktori
        ~Toimipiste() { }

        public override string ToString()
        {
            return this.Toimipisteid + " " + this.Nimi;
        }
        //SelectQueryn toteutus toimipisteen tietojen hakemiseen
        public void HaeKaikkiToimipisteetTietokannasta()
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "Select * from toimipisteet";
            lukija = kasky.ExecuteReader();
            try
            {
                while (lukija.Read())
                {
                    //Luodaan, jokaista taulun riviä varten toimipisteolioita 
                    Toimipiste tp = new Toimipiste();
                    tp.Toimipisteid = lukija.GetString("toimipisteid");
                    tp.Nimi = lukija.GetString("nimi");
                    tp.Postiosoite = lukija.GetString("postiosoite");
                    tp.Postinumero = lukija.GetString("postinumero");
                    tp.Postitoimipaikka = lukija.GetString("postitoimipaikka");
                    tp.Puhelinnumero = lukija.GetString("puhelinnumero");
                    tp.Sahkopostiosoite = lukija.GetString("sahkopostiosoite");
                    tp.Maa = lukija.GetString("maa");
                    tp.Yhteyshenkilo = lukija.GetString("yhteyshenkilo");
                    tp.Aukioloaika = lukija.GetString("aukioloaika");
                    //Lisätään luotu olio listaan
                    toimipistelista.Add(tp);
                    //Alustetaan tp nollaksi
                    tp = null;
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
        public void PaivitaToimipisteTietokantaan(Toimipiste tp)
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            //Update Query @merkityt muuttujat? korvataan parametreillä
            kasky.CommandText = @"UPDATE toimipisteet SET nimi=@nimi,postiosoite=@postiosoite,postinumero=@postinumero,postitoimipaikka=@postitoimipaikka, puhelinnumero=@puhelinnumero, sahkopostiosoite=@sahkopostiosoite,
              maa=@maa, yhteyshenkilo=@yhteyhenkilo,aukioloaika=@aukioloaika WHERE toimipisteid=@toimipisteid";
            //Lisätään updatequeryyn parametrina annetun toimipisteen tiedot
            kasky.Parameters.AddWithValue("@toimipisteid", tp.Toimipisteid);
            kasky.Parameters.AddWithValue("@nimi", tp.Nimi);
            kasky.Parameters.AddWithValue("@postiosoite", tp.Postiosoite);
            kasky.Parameters.AddWithValue("@postinumero", tp.Postinumero);
            kasky.Parameters.AddWithValue("@postitoimipaikka", tp.Postitoimipaikka);
            kasky.Parameters.AddWithValue("@puhelinnumero", tp.Puhelinnumero);
            kasky.Parameters.AddWithValue("@sahkopostiosoite", tp.Sahkopostiosoite);
            kasky.Parameters.AddWithValue("@maa", tp.Maa);
            kasky.Parameters.AddWithValue("@yhteyshenkilo", tp.Yhteyshenkilo);
            kasky.Parameters.AddWithValue("@aukioloaika", tp.Aukioloaika);
            try
            {
                kasky.ExecuteNonQuery();
                //Viesti, joka ilmoittaa tietojen päivityksen onnistuneen
                MessageBox.Show("Toimipisteet päivitetty", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Päivitettäessä tietoja tapahtui virhe: " + ex.ToString());
            }

            //Suljetaan yhteys
            t.SuljeYhteysTietokantaan(yhteys);
        }
        //Metodi toimipisteen tietokantaan lisäämiselle
        public void LisaaToimipisteTietokantaan(Toimipiste tp)
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = @"INSERT INTO toimipisteet (toimipisteid,nimi,postiosoite,postinumero,postitoimipaikka, puhelinnumero, sahkopostiosoite, maa, yhteyhenkilo)
                                VALUES (@toimipisteid,@nimi,@postiosoite, @postinumero, @postitoimipaikka, @puhelinnumero, @sahkopostiosoite,  @maa, @yhteyshenkilo)";
            kasky.Parameters.AddWithValue("@toimipisteid", tp.Toimipisteid);
            kasky.Parameters.AddWithValue("@nimi", tp.Nimi);
            kasky.Parameters.AddWithValue("@postiosoite", tp.Postiosoite);
            kasky.Parameters.AddWithValue("@postinumero", tp.Postinumero);
            kasky.Parameters.AddWithValue("@postitoimipaikka", tp.Postitoimipaikka);
            kasky.Parameters.AddWithValue("@puhelinnumero", tp.Puhelinnumero);
            kasky.Parameters.AddWithValue("@sahkopostiosoite", tp.Sahkopostiosoite);
            kasky.Parameters.AddWithValue("@maa", tp.Maa);
            kasky.Parameters.AddWithValue("@yhteyshenkilo", tp.Yhteyshenkilo);
    
            try
            {
                kasky.ExecuteNonQuery();
                //Viesti, joka ilmoittaa tietojen päivityksen onnistuneen
                MessageBox.Show("Uusi toimipiste lisätty", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe lisättäessä toimipistettä:" + ex.ToString());
            }
            //Suljetaan yhteys
            t.SuljeYhteysTietokantaan(yhteys);
        }
        //Metodi toimipisteen poistamiselle tietokannasta
        public void PoistaToimipisteTietokannasta(Toimipiste tp)
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "DELETE FROM toimipisteet WHERE toimipisteid=@toimipisteid";
            kasky.Parameters.AddWithValue("@toimipisteid", tp.Toimipisteid);
            try
            {
                kasky.ExecuteNonQuery();
                MessageBox.Show("Toimipiste poistettu", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe toimipistettä poistettaessa:" + ex.ToString());
            }
            t.SuljeYhteysTietokantaan(yhteys);

        }
    }
}
