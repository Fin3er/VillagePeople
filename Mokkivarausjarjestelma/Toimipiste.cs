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
        private string toimipistetunnus;
        private string toimipistepuhelinnumero;
        private string toimipistesahkoposti;
        private string toimipistekatuosoite;
        private string toimipistepostinumero;
        private string toimipistepostitoimipaikka;
        private string toimipistemaa;
        private string vastuuhenkilo;
        private string vastuupuhelinnumero;
        private string vastuusahkoposti;

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

        //SelectQueryn toteutus asiakkaan tietojen hakemiseen
        public void HaeKaikkiToimipisteetTietokannasta()
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "Select * from toimipiste";
            lukija = kasky.ExecuteReader();
            try
            {
                while (lukija.Read())
                {
                    //Luodaan, jokaista taulun riviä varten toimipisteolioita 
                    Toimipiste tp = new Toimipiste();
                    tp.Toimipistetunnus = lukija.GetString("toimipistetunnus");
                    tp.Toimipistepuhelinnumero = lukija.GetString("puhelinnumero");
                    tp.Toimipistesahkoposti = lukija.GetString("sahkopostiosoite");
                    tp.Toimipistekatuosoite = lukija.GetString("katuosoite");
                    tp.Toimipistepostinumero = lukija.GetString("postinumero");
                    tp.Toimipistepostitoimipaikka = lukija.GetString("postitoimipaikka");
                    tp.Toimipistemaa = lukija.GetString("maa");
                    tp.Vastuuhenkilo = lukija.GetString("vastuuhenkilo");
                    tp.Vastuupuhelinnumero = lukija.GetString("vastuupuhelinnumero");
                    tp.Vastuusahkoposti = lukija.GetString("vastuusahkoposti");
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
            kasky.CommandText = @"UPDATE toimipiste SET puhelinnumero=@puhelinnumero, sahkopostiosoite=@sahkopostiosoite,
            toimipistekatuosoite=@katuosoite, toimipistepostinumero=@postinumero, toimipistepostitoimipaikka=@postitoimipaikka, toimipistemaa=@maa, vastuuhenkilo=@vastuuhenkilo, vastuupuhelinnumero=@vastuupuhelinnumero, vastuusahkoposti=@vastuusahkoposti WHERE toimipistetunnus=@toimipistetunnus";
            //Lisätään updatequeryyn parametrina annetun toimipisteen tiedot
            kasky.Parameters.AddWithValue("@toimipistetunnus", tp.Toimipistetunnus);
            kasky.Parameters.AddWithValue("@puhelinnumero", tp.Toimipistepuhelinnumero);
            kasky.Parameters.AddWithValue("@sahkopostiosoite", tp.Toimipistesahkoposti);
            kasky.Parameters.AddWithValue("@katuosoite", tp.Toimipistekatuosoite);
            kasky.Parameters.AddWithValue("@postinumero", tp.Toimipistepostinumero);
            kasky.Parameters.AddWithValue("@postitoimipaikka", tp.Toimipistepostitoimipaikka);
            kasky.Parameters.AddWithValue("@maa", tp.Toimipistemaa);
            kasky.Parameters.AddWithValue("@vastuuhenkilo", tp.Vastuuhenkilo);
            kasky.Parameters.AddWithValue("@vastuupuhelinnumero", tp.Vastuupuhelinnumero);
            kasky.Parameters.AddWithValue("@vastuusahkoposti", tp.Vastuusahkoposti);
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
        //Metodi asiakkaan tietokantaan lisäämiselle
        public void LisaaToimipisteTietokantaan(Toimipiste tp)
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = @"INSERT INTO toimipiste (toimipistetunnus, puhelinnumero, sahkopostiosoite, katuosoite, postinumero, postitoimipaikka, maa, vastuuhenkilo, vastuupuhelinnumero, vastuusahkoposti)
                                VALUES (@toimipistetunnus, @puhelinnumero, @sahkopostiosoite, @katuosoite, @postinumero, @postitoimipaikka, @maa, @vastuuhenkilo, @vastuupuhelinnumero, @vastuusahkoposti)";
            kasky.Parameters.AddWithValue("@toimipistetunnus", tp.Toimipistetunnus);
            kasky.Parameters.AddWithValue("@puhelinnumero", tp.Toimipistepuhelinnumero);
            kasky.Parameters.AddWithValue("@sahkopostiosoite", tp.Toimipistesahkoposti);
            kasky.Parameters.AddWithValue("@katuosoite", tp.Toimipistekatuosoite);
            kasky.Parameters.AddWithValue("@postinumero", tp.Toimipistepostinumero);
            kasky.Parameters.AddWithValue("@postitoimipaikka", tp.Toimipistepostitoimipaikka);
            kasky.Parameters.AddWithValue("@maa", tp.Toimipistemaa);
            kasky.Parameters.AddWithValue("@vastuuhenkilo", tp.Vastuuhenkilo);
            kasky.Parameters.AddWithValue("@vastuupuhelinnumero", tp.Vastuupuhelinnumero);
            kasky.Parameters.AddWithValue("@vastuusahkoposti", tp.Vastuusahkoposti);
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
        //Metodi asiakkaan poistamiselle tietokannasta
        public void PoistaToimipisteTietokannasta(Toimipiste tp)
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "DELETE FROM toimipiste WHERE toimipistetunnus=@toimipistetunnus";
            kasky.Parameters.AddWithValue("@toimipistetunnus", tp.Toimipistetunnus);
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
