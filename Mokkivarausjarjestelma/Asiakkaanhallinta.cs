using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mokkivarausjarjestelma
{
    //Tämä luokka sisältää Asiakas-pääikkunan käyttöliittymän toiminnot 
    public partial class FormAsiakkaanHallinta : Form
    {
        public FormAsiakkaanHallinta()
        {
            InitializeComponent();
        }

        //Luodaan lista asiakasolioita varten
        private List<Asiakas> asiakaslista = new List<Asiakas>();
        
        //Saa arvoksi Asiakas-luokan olion
        private Asiakas asiakas;
        
        //Tehdään kun Asiakkaanhallinta-form ladataan, päivitetään asiakaslista
        private void Asiakkaanhallinta_Load(object sender, EventArgs e)
        {
            PaivitaAsiakasLista();
            //Comboboxin vaihtoehdot
            cbbxNimitys.Items.Add("Mr.");
            cbbxNimitys.Items.Add("Mrs.");
            cbbxNimitys.Items.Add("Ms.");
            cbbxNimitys.Items.Add("Dr.");
        }

        //Metodi asiakaslistan päivittämiselle
        public void PaivitaAsiakasLista()
        {
            //Tyhjennetään listbox
            lstbxAsiakaslista.Items.Clear();
            //Luodaan uusi instanssi asiakasluokasta
            Asiakas a = new Asiakas();
            //Käytetään asiakasluokan metodia HaeKaikkiAsiakkaat
            a.HaeKaikkiAsiakkaatTietokannasta();
            //Asiakaslista saa arvokseen asiakasluokan asiakaslistan
            asiakaslista = a.asiakaslista;
            //Tällä saadaan listbox näyttämään listan sisältämät oliot, muutetaan lista Arrayksi
            lstbxAsiakaslista.Items.AddRange(asiakaslista.ToArray());
        }

        //Metodi asiakkaan tietojen päivittämiseen, parametriksi muokattava asiakas
        public void PaivitaAsiakasTiedot(Asiakas a)
        {
            //Tehdään vain jos asiakas on olemassa
            if(a!=null)
            {
                a.Asiakasnumero = Convert.ToString(txbxAsiakasnumero.Text);
                a.Etunimi = Convert.ToString(txtbEtunimi.Text);
                a.Sukunimi = Convert.ToString(txtbSukunimi.Text);
                a.Syntymaaika = Convert.ToString(txtbSyntymaaika.Text);
                a.Postiosoite = Convert.ToString(txtbPostiosoite.Text);
                a.Postinumero = Convert.ToString(txtbPostinumero.Text);
                a.Postitoimipaikka = Convert.ToString(txtbPostitoimipaikka.Text);
                a.Maa = Convert.ToString(txtbMaa.Text);
                a.Puhelinnumero = Convert.ToString(txtbPostinumero.Text);
                a.Sahkoposti = Convert.ToString(txtbSahkopostiosoite.Text);
            }
            
        }

        //Metodi, joka näyttää Asiakkaan tiedot formilla
        public void NaytaAsiakas()
        {
            //Jos olio on olemassa näytetään tiedot txtboxeissa
            txbxAsiakasnumero.Text = asiakas != null ? Convert.ToString(asiakas.Asiakasnumero) : "";
            txtbEtunimi.Text = asiakas != null ? Convert.ToString(asiakas.Etunimi) : "";
            txtbSukunimi.Text = asiakas != null ? Convert.ToString(asiakas.Sukunimi) : "";
            txtbPostiosoite.Text = asiakas != null ? Convert.ToString(asiakas.Postiosoite) : "";
            txtbPostinumero.Text = asiakas != null ? Convert.ToString(asiakas.Postinumero) : "";
            txtbPostitoimipaikka.Text=asiakas!=null?Convert.ToString(asiakas.Postitoimipaikka):"";
            txtbSyntymaaika.Text = asiakas != null ? Convert.ToString(asiakas.Syntymaaika) : "";
            txtbMaa.Text = asiakas != null ? Convert.ToString(asiakas.Maa) : "";
            txtbSahkopostiosoite.Text = asiakas != null ? Convert.ToString(asiakas.Sahkoposti) : "";
            txtbPuhelinnumero.Text = asiakas != null ? Convert.ToString(asiakas.Puhelinnumero) : "";
        }

        
        //Tässä toiminto, joka suoritetaan kun klikataan nimiä listboxissa
        private void lstbxAsiakaslista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //asiakas saa arvokseen valitun Itemin listasta, joka on Asiakas tyyppiä
            this.asiakas=lstbxAsiakaslista.SelectedItem as Asiakas;
            //Kutsutaan show-metodi valitulle asiakkaalle
            NaytaAsiakas();
        }

        //Tallenna tiedot painikkeesta tallennetaan asiakkaan tiedot
        private void btnTallennaTiedot_Click(object sender, EventArgs e)
        {
            this.asiakas = lstbxAsiakaslista.SelectedItem as Asiakas;
            MessageBox.Show("Haluatko varmasti tallettaa muokatut tiedot asiakkaalle?","Vahvistus",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            PaivitaAsiakasTiedot(this.asiakas);
            Asiakas b=new Asiakas();
            b.PaivitaAsiakasTietokantaan(this.asiakas);            
        }

        //Lisää uusi asiakas painikkeesta avataan Asiakkaan lisäys ja muokkausform
        private void btnLisaaUusiAsiakas_Click(object sender, EventArgs e)
        {
            new Asiakkaat_lisaa_muokkaa().Show();
        }

        private void btnPoistaAsiakas_Click(object sender, EventArgs e)
        {
            this.asiakas = lstbxAsiakaslista.SelectedItem as Asiakas;
            MessageBox.Show("Haluatko varmasti poistaa valitun asiakkaan?", "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Asiakas b = new Asiakas();
            b.PoistaAsiakasTietokannasta(this.asiakas);
            PaivitaAsiakasLista();
            
        }

        
    }
}
