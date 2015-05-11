using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lisätyt luokat
using MySql.Data.MySqlClient;
using System.Windows.Forms;

/* Ei testattu, tehty Asiakas mallista, ei lupauksia minkäänlaisesta toiminnasta */

namespace Mokkivarausjarjestelma
{
    
    public partial class Varaus
    {
        // Varauksen muuttujat
        private int varausid;
        private string toimipisteid;
        private Toimipiste toimipiste;
        private int asiakasnumero;
        private Asiakas asiakas;
        private int mokkiid;
        private Mokki mokki;
        //private List<Lisapalvelu> lisapalvelut;
        private string saapumispvm;
        private string lahtopvm;
        private int paivat;
        private string vahvistettu;
        private string vahvistuspvm;
        private string alennuskoodi;
        private int yopyjat;
        private string lisatietoja;
        private float hinta;
        private string laskutus;
        private string yhteenveto;
        private string lisayspvm;

        //Lista löytyneitä varauksia varten
        public List<Varaus> varauslista = new List<Varaus>();

        //Muuttujat tietokantakyselyjä varten
        protected MySqlConnection yhteys;
        protected MySqlCommand kasky;
        protected MySqlDataReader lukija;

        //Varaus konstruktori
        public Varaus() { }
        //Varaus destruktori
        ~Varaus() { }

        // Varauksen hakeminen
        public void HaeKaikkiVarauksetTietokannasta()
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "Select * from Varaus";
            lukija = kasky.ExecuteReader();
            try
            {
                while (lukija.Read())
                {
                    //Luodaan, jokaista taulun riviä varten varausolioita 
                    Varaus v = new Varaus();
                    v.Varausid = Convert.ToInt32(lukija.GetString("varausid"));
                    v.Toimipisteid = lukija.GetString("toimipisteid");
                    v.Asiakasnumero = Convert.ToInt32(lukija.GetString("asiakasnumero"));
                    v.Mokkiid = Convert.ToInt32(lukija.GetString("mokkiid"));
                    v.Saapumispvm = lukija.GetString("saapumispvm");
                    v.Lahtopvm = lukija.GetString("lahtopvm");
                    v.Vahvistuspvm = lukija.GetString("vahvistuspvm");
                    v.Paivat = Convert.ToInt32(lukija.GetString("paivat"));
                    v.Vahvistettu = lukija.GetString("vahvistettu");
                    v.Alennuskoodi = lukija.GetString("alennuskoodi");
                    v.Yopyjat = Convert.ToInt32(lukija.GetString("yopyjat"));
                    v.Lisatietoja = lukija.GetString("lisatietoja");
                    v.Hinta = Convert.ToInt32(lukija.GetString("hinta"));
                    v.Laskutus = lukija.GetString("laskutus");
                    //Lisätään luotu olio listaan
                    varauslista.Add(v);
                    //Alustetaan t nollaksi
                    v = null;
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
                MessageBox.Show("Lukijaa sulkiessa tapahtui virhe:" + ex.ToString());
            }
            t.SuljeYhteysTietokantaan(yhteys);
        }

        // Varauksen päivittäminen
        public void PaivitaVarausTietokantaan(Varaus v)
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            //Update Query @merkityt muuttujat? korvataan parametreillä
            kasky.CommandText = @"INSERT INTO varaus (varausid, toimipisteid, asiakasnumero, mokkiid, saapumispvm, lahtopvm,vahvistuspvm, paivat, vahvistettu, alennuskoodi, yopyjat, lisatietoja, hinta, laskutus)
                                VALUES (@varausid, @toimipisteid, @asiakasnumero, @mokkinumero, @saapumispvm, @lahtopvm, @vahvistuspvm, @paivat, @vahvistettu, @alennuskoodi, @yopyjat, @lisatietoja, @hinta, @laskutus)";
            //Lisätään updatequeryyn parametrina annetun asiakkaan tiedot
            kasky.Parameters.AddWithValue("@varausid", v.Varausid);
            kasky.Parameters.AddWithValue("@toimipisteid", v.Toimipisteid);
            kasky.Parameters.AddWithValue("@asiakasnumero", v.Asiakasnumero);
            kasky.Parameters.AddWithValue("@mokkiid", v.Mokkiid);
            kasky.Parameters.AddWithValue("@saapumispvm", v.Saapumispvm);
            kasky.Parameters.AddWithValue("@lahtopvm", v.Lahtopvm);
            kasky.Parameters.AddWithValue("@vahvistuspvm", v.Vahvistuspvm);
            kasky.Parameters.AddWithValue("@paivat", v.Paivat);
            kasky.Parameters.AddWithValue("@vahvistettu", v.Vahvistettu);
            kasky.Parameters.AddWithValue("@alennuskoodi", v.Alennuskoodi);
            kasky.Parameters.AddWithValue("@yopyjat", v.yopyjat);
            kasky.Parameters.AddWithValue("@lisatietoja", v.Lisatietoja);
            kasky.Parameters.AddWithValue("@hinta", v.Hinta);
            kasky.Parameters.AddWithValue("@laskutus", v.Laskutus);
            try
            {
                kasky.ExecuteNonQuery();
                //Viesti, joka ilmoittaa tietojen päivityksen onnistuneen
                MessageBox.Show("Varaustiedot päivitetty", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Päivitettäessä tietoja tapahtui virhe: " + ex.ToString());
            }

            //Suljetaan yhteys
            t.SuljeYhteysTietokantaan(yhteys);
        }

        // Varauksen lisääminen
        public void LisaaVarausTietokantaan(Varaus v)
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = @"INSERT INTO varaus (varausid, toimipisteid, asiakasnumero, mokkinumero, saapumispvm, lahtopvm,vahvistuspvm, paivat, vahvistettu, alennuskoodi, yopyjat, lisatietoja, hinta, laskutus)
                                VALUES (@varausid, @toimipisteid, @asiakasnumero, @mokkinumero, @saapumispvm, @lahtopvm, @paivat, @vahvistettu, @alennuskoodi, @yopyjat, @lisatietoja, @hinta, @laskutus)";
            kasky.Parameters.AddWithValue("@varausid", v.Varausid);
            kasky.Parameters.AddWithValue("@toimipisteid", v.Toimipisteid);
            kasky.Parameters.AddWithValue("@asiakasnumero", v.Asiakasnumero);
            kasky.Parameters.AddWithValue("@mokkinumero", v.Mokkiid);
            kasky.Parameters.AddWithValue("@saapumispvm", v.Saapumispvm);
            kasky.Parameters.AddWithValue("@lahtopvm", v.Lahtopvm);
            kasky.Parameters.AddWithValue("vahvistuspvm", v.Vahvistuspvm);
            kasky.Parameters.AddWithValue("@paivat", v.Paivat);
            kasky.Parameters.AddWithValue("@vahvistettu", v.Vahvistettu);
            kasky.Parameters.AddWithValue("@alennuskoodi", v.Alennuskoodi);
            kasky.Parameters.AddWithValue("@yopyjat", v.yopyjat);
            kasky.Parameters.AddWithValue("@lisatietoja", v.Lisatietoja);
            kasky.Parameters.AddWithValue("@hinta", v.Hinta);
            kasky.Parameters.AddWithValue("@laskutus", v.Laskutus);

            try
            {
                kasky.ExecuteNonQuery();
                //Viesti, joka ilmoittaa tietojen päivityksen onnistuneen
                MessageBox.Show("Uusi varaus lisätty", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe lisättäessä varausta:" + ex.ToString());
            }
            //Suljetaan yhteys
            t.SuljeYhteysTietokantaan(yhteys);
        }

        // Varauksen poistaminen
        public void PoistaVarausTietokannasta(Varaus v)
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "DELETE FROM varaus WHERE varausid=@varausid";
            kasky.Parameters.AddWithValue("@varausid", v.varausid);
            try
            {
                kasky.ExecuteNonQuery();
                MessageBox.Show("Varaus poistettu", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe varausta poistettaessa:" + ex.ToString());
            }
            t.SuljeYhteysTietokantaan(yhteys);
        }

       

    }
}
     
