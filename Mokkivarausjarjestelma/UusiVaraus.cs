using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Mokkivarausjarjestelma
{
    public partial class UusiVaraus : Form
    {
        //Muuttujat tietokantakyselyjä varten
        protected MySqlConnection yhteys;
        protected MySqlCommand kasky;
        protected MySqlDataReader lukija;

        public UusiVaraus()
        {
            InitializeComponent();
        }

        private void UusiVaraus_Load(object sender, EventArgs e)
        {
            // Asetetaan dtpsaapuminen ja dtplahtopvm arvoksi tämä päivä
            DateTime paivamaara = DateTime.Today;
            dtpsaapuminen.Value = paivamaara;
            dtplahtopvm.Value = paivamaara;
            ToimipisteCombobox(); //Täytetään toimipistecombobox heti kun form ladataan
        }

        private void dtpsaapuminen_ValueChanged(object sender, EventArgs e)
        {
            // Kun dtpsaapuminen päivämäärää vaihdetaan niin vaihdettu päivämäärä näkyy dtp:ssä
            DateTime result = dtpsaapuminen.Value;
            this.Text = result.ToString();
            // Tämä tulostaa jos tulopäiväksi valitsee aikaisemman päivän kuin tämä päivä
            if (dtpsaapuminen.Value < DateTime.Today)
            {
                MessageBox.Show("Tulopäivä ei voi olla aikaisempi päivämäärä, kuin tämä päivä");
            }
        }

        private void dtplahtopvm_ValueChanged(object sender, EventArgs e)
        {
            // Kun dtplahtopvm päivämäärää vaihdetaan niin vaihdettu päivämäärä näkyy dtp:ssä
            DateTime result = dtplahtopvm.Value;
            this.Text = result.ToString();
            // Tämä tulostuu jos lähtöpäiväksi valitsee aikaisemman päivän kuin tämä päivä
            if (dtplahtopvm.Value < DateTime.Today)
            {
                MessageBox.Show("Lähtöpäivä ei voi olla aikaisempi päivämäärä, kuin tämä päivä.");
                return;
            }
            // Tämä tulostuu jos lähtöpäiväksi valitsee aikaisemman päivän kuin saapumispäivä
            if (dtpsaapuminen.Value < dtplahtopvm.Value)
            {
                MessageBox.Show("Lähtöpäivä ei voi olla aikaisempi päivämäärä, kuin tulopäivä.");
            }
        }

        // Metodi Toimipiste comboboxin täyttämiselle, en tiedä toimiiko
        public void ToimipisteCombobox()
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "Select nimi from toimipisteet";
            lukija = kasky.ExecuteReader();
            try
            {
                while (lukija.Read())
                {
                    cmbxtoimipiste.Items.Add(lukija.GetValue(0));
                }
            }
                  catch (Exception ex)
            {
                MessageBox.Show("Comboboxia täyttäessä tapahtui virhe:" + ex.ToString());
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
        // Metodi Mökkityypin comboboxin täyttämiselle, en tiedä toimiiko
        public void MokkityyppiCombobox()
        {
            cmbxmokkityyppi.Items.Clear();
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = @"Select nimi from mokki where mokkiid in (select mokki from toimipisteenmokit where toimipiste in(select toimipisteid from toimipisteet where nimi=@nimi))";
            string nimi = cmbxtoimipiste.SelectedText;
            kasky.Parameters.AddWithValue("@nimi", nimi);
            lukija = kasky.ExecuteReader();
            try
            {
                while (lukija.Read())
                {
                    cmbxmokkityyppi.Items.Add(lukija.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Comboboxia täyttäessä tapahtui virhe:" + ex.ToString());
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

        private void cmbxmokkityyppi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbxtoimipiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            MokkityyppiCombobox();
        }

        private void btntarkista_Click(object sender, EventArgs e)
        {
           
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = @"Select varausid from varaukset where mokkiid=@id and saapumispvm<=@saapuminen and lahtopvm>=@lahteminen";
            string id=cmbxmokkityyppi.SelectedText;
            DateTime saapuminen = dtpsaapuminen.Value;
            DateTime lahto = dtplahtopvm.Value;
            kasky.Parameters.AddWithValue("@nimi", id);
            kasky.Parameters.AddWithValue("@saapuminen", saapuminen);
            kasky.Parameters.AddWithValue("@lahto", lahto);
            lukija = kasky.ExecuteReader();
             
        }
       }

        }
  

