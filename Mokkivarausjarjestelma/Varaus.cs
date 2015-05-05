using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lisätyt luokat
using MySql.Data.MySqlClient;
using System.Windows.Forms;

/* Ei testattu, tehty Asiakas mallista */

namespace Mokkivarausjarjestelma
{
    public partial class Varaus
    {
        // Varauksen muuttujat
        private int varausid;
        private Toimipiste toimipisteid;
        private Asiakas asiakasnumero;
        private Mokki mokkinumero;
        private string saapumispvm;
        private string lahtopvm;
        private int paivat;
        private string vahvistettu;
        private string alennuskoodi;
        private int yopyjat;
        private string lisatietoja;
        private Decimal hinta;
        private string laskutus;

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


        // Varauksen päivittäminen


        // Varauksen lisääminen
        public void LisaaAsiakasTietokantaan(Asiakas a)
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = @"INSERT INTO varaus (varausid, toimipisteid, asiakasnumero, mokkinumero, saapumispvm, lahtopvm, paivat, vahvistettu, alennuskoodi, yopyjat, lisatietoja, hinta, laskutus)
                                VALUES (@varausid, @toimipisteid, @asiakasnumero, @mokkinumero, @saapumispvm, @lahtopvm, @paivat, @vahvistettu, @alennuskoodi, @yopyjat, @lisatietoja, @hinta, @laskutus)";
            kasky.Parameters.AddWithValue("@varausid", v.VarausId);
            kasky.Parameters.AddWithValue("@toimipisteid", v.toimipisteId);
            kasky.Parameters.AddWithValue("@asiakasnumero", v.Asiakasnumero);
            kasky.Parameters.AddWithValue("@mokkinumero", v.Mokkinumero);
            kasky.Parameters.AddWithValue("@saapumispvm", v.Saapumispvm);
            kasky.Parameters.AddWithValue("@lahtopvm", v.Lahtopvm);
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


    }
}
