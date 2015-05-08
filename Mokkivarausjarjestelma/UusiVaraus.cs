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
        protected string mokkityyppi;
        protected string toimipisteennimi;

        public UusiVaraus()
        {
            InitializeComponent();
        }

        private void UusiVaraus_Load(object sender, EventArgs e)
        {
            // Asetetaan dtpsaapuminen ja dtplahtopvm arvot
            //Jouduin hieman muuttamaan noita default Datetimejä, jotta saadaan myös kellonajoille default-arvot
            DateTime tulopaivamaara = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,15,0,0); // Tulopäiväksi tulee tämä päivä
            DateTime lahtopaivamaara = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day+1,12,0,0); // Lähtopäiväksi tulee nyt seuraava päivä
            dtpsaapuminen.Value = tulopaivamaara;
            dtplahtopvm.Value = lahtopaivamaara;
            ToimipisteCombobox(); //Täytetään toimipistecombobox heti kun form ladataan
            AsiakasCombobox(); //Täytetään asiakascombobox heti kun form ladataan
            LaskutusCombobox();
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
            cmbxtoimipiste.Text = "Valitse:";
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
            cmbxmokkityyppi.Text = "Valitse:";
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
        // Metodi Asiakas comboboxin täyttämiselle
        //Muutin vielä yksinkertaisemmaksi koodia. Asiakas-luokassa oli jo valmiina tuo metodi asiakkaiden listaamiselle. 
        //Muuten kyllä toimii ja saan nyt omasta testitietokannasta listattua asiakasnumerot ja nimet. 
        public void AsiakasCombobox()
        {
            Asiakas a = new Asiakas();
            a.HaeKaikkiAsiakkaatTietokannasta();
            cmbxasiakas.Items.AddRange(a.asiakaslista.ToArray());
            /*
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "Select asiakasnumero from asiakkaat";
            lukija = kasky.ExecuteReader();
            try
            {
                while (lukija.Read())
                {
                    cmbxasiakas.Items.Add(lukija.GetValue(0));
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
             * */
        }

        public void YopyjatCombobox()
        {
            cmbxyopyjat.Items.Clear();
            cmbxyopyjat.Text = "";
            int hlomaara = 0;
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "Select hlomaara from mokki where nimi=@mokinnimi";
            kasky.Parameters.AddWithValue("@mokinnimi", mokkityyppi);
            lukija = kasky.ExecuteReader();
            if(lukija.Read())
            {
                hlomaara = Convert.ToInt16(lukija.GetString("hlomaara"));
            }
            lukija.Close();
            t.SuljeYhteysTietokantaan(yhteys);
            for (int i = 1; i <= hlomaara; i++)
            {
                cmbxyopyjat.Items.Add(i.ToString());
            }
        }
        // Metodi LisapalvelutCheckedListBoxin täyttämiselle
        public void LisapalvelutCheckedListBox()
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "Select lisapalvelunimi from lisapalvelu where lisapalveluid in(select palvelu from toimipisteenpalvelut where toimipiste in (select toimipisteid from toimipisteet where nimi=@toimipisteennimi))";
            kasky.Parameters.AddWithValue("@toimipisteennimi", toimipisteennimi);
            lukija = kasky.ExecuteReader();
            try
            {
                while (lukija.Read())
                {
                    clblisapalvelut.Items.Add(lukija.GetString("lisapalvelunimi"));
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

        public void LaskutusCombobox()
        {
            cmbxlaskutus.Text = "Valitse:";
            cmbxlaskutus.Items.Add("Sähköpostilasku");
            cmbxlaskutus.Items.Add("Paperilasku");
        }


        private void cmbxmokkityyppi_SelectedIndexChanged(object sender, EventArgs e)
        {
            mokkityyppi = cmbxmokkityyppi.SelectedItem.ToString();
            YopyjatCombobox();
        }

        private void cmbxtoimipiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            MokkityyppiCombobox();
            toimipisteennimi = cmbxtoimipiste.SelectedItem.ToString();
            LisapalvelutCheckedListBox();
        }


        //Toiminto tarkastaa onko valitulle mökille olemassa jo varaus valittuina päivinä
        //Tällä hetkellü toimii tarkista-nappia painamalla, joka ilmoittaa MessageBoxilla, jos varaus on olemassa tai jos mökin voi varata.
        //Toteutus on hieman kömpelö. Tätä voi  yrittää soveltaa kalenteritoimintoon. 
        private void btntarkista_Click(object sender, EventArgs e)
        {
            txbxalennus.Text = "";
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            //kasky.CommandText = @"Select varausid from varaukset where mokkiid in(select mokkiid from mokki where nimi=@id)";
            kasky.CommandText = @"Select * from varaukset where mokkiid in(select mokkiid from mokki where nimi=@id) 
            and (@saapuminen between saapumispvm and lahtopvm or @lahto between saapumispvm and lahtopvm or saapumispvm between @saapuminen and 
            @lahto or lahtopvm between @saapuminen and @lahto)";
            string saapuminen = dtpsaapuminen.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string lahto = dtplahtopvm.Value.ToString("yyyy-MM-dd HH:mm:ss");
            kasky.Parameters.AddWithValue("@id", mokkityyppi);
            kasky.Parameters.AddWithValue("@saapuminen", saapuminen);
            kasky.Parameters.AddWithValue("@lahto", lahto);
            lukija = kasky.ExecuteReader();
            if(lukija.Read())
            {
                MessageBox.Show("Mökille on jo olemassa varaus valittuina päivinä!\nVarausid: " + lukija.GetString("varausid") + "\nSaapumispvm: " + lukija.GetString("saapumispvm") + "\nLähtöpvm: " + lukija.GetString("lahtopvm"));
            }
            else
            {
                MessageBox.Show("Mökin voi varata valituille päiville!");
            }
            t.SuljeYhteysTietokantaan(yhteys);
             
        }
       }

        }
  

