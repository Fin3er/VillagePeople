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
    //Poista painike kesken Combobox kesken. KÄYTTÖLIITTYMÄ KESKEN, TIETOKANTA KESKEN, KAIKKI KESKEN!!
    public partial class FormAsiakkaanHallinta : Form
    {
        public FormAsiakkaanHallinta()
        {
            InitializeComponent();
        }

        //Luodaan lista asiakasolioita varten
        private List<Asiakas> lista = new List<Asiakas>();
        
        //Saa arvoksi Asiakas-luokan olion
        private Asiakas asiakas;
        
        //Tehdään kun Asiakkaanhallinta-form ladataan
        private void Asiakkaanhallinta_Load(object sender, EventArgs e)
        {
            PaivitaAsiakasLista();
            //Comboboxin vaihtoehdot
            cbbxNimitys.Items.Add("Mr.");
            cbbxNimitys.Items.Add("Mrs.");
            cbbxNimitys.Items.Add("Ms.");
            cbbxNimitys.Items.Add("Dr.");
        }

        public void PaivitaAsiakasLista()
        {
            //Tyhjennetään listbox
            lstbxAsiakaslista.Items.Clear();
            //Luodaan uusi instanssi asiakastietokannasta
            Asiakastietokanta testi = new Asiakastietokanta();
            //Yhdistetään tietokantaan
            testi.Connect();
            //Annetaan querylause asiakastietojen hakemiseen
            testi.SelectQuery();
            //Lista saa arvokseen asiakastietokantaluokan listan
            lista = testi.lista;
            //Suljetaan yhteys tietokantaan
            testi.CloseConnection();
            //Tällä saadaan listbox näyttämään listan sisältämät oliot, muutetaan lista Arrayksi
            lstbxAsiakaslista.Items.AddRange(lista.ToArray());
        }

        //Metodi asiakkaan tietojen päivittämiseen, parametriksi muokattava asiakas
        public void updateAsiakasData(Asiakas a)
        {
            //Tehdään vain jos asiakas on olemassa
            if(a!=null)
            {
                a.Asiakasnumero = Convert.ToString(txbxAsiakasnumero.Text);
                a.Etunimi = Convert.ToString(txtbEtunimi.Text);
                a.Sukunimi = Convert.ToString(txtbSukunimi.Text);
                a.Syntymaaika = Convert.ToString(txtbSyntymaaika.Text);
                a.Postiosoite = Convert.ToString(txtbKatuosoite.Text);
                a.Postinumero = Convert.ToString(txtbPostinumero.Text);
                a.Postitoimipaikka = Convert.ToString(txtbPostitoimipaikka.Text);
                a.Maa = Convert.ToString(txtbMaa.Text);
                a.Puhelinnumero = Convert.ToString(txtbPostinumero.Text);
                a.Sahkoposti = Convert.ToString(txtbSahkopostiosoite.Text);
            }
            
        }

        //Metodi, joka näyttää Asiakkaan tiedot formilla
        public void showAsiakas()
        {
            //Jos olio on olemassa näytetään tiedot txtboxeissa
            txbxAsiakasnumero.Text = asiakas != null ? Convert.ToString(asiakas.Asiakasnumero) : "";
            txtbEtunimi.Text = asiakas != null ? Convert.ToString(asiakas.Etunimi) : "";
            txtbSukunimi.Text = asiakas != null ? Convert.ToString(asiakas.Sukunimi) : "";
            txtbKatuosoite.Text = asiakas != null ? Convert.ToString(asiakas.Postiosoite) : "";
            txtbPostinumero.Text = asiakas != null ? Convert.ToString(asiakas.Postinumero) : "";
            txtbPostitoimipaikka.Text=asiakas!=null?Convert.ToString(asiakas.Postitoimipaikka):"";
            txtbSyntymaaika.Text = asiakas != null ? Convert.ToString(asiakas.Syntymaaika) : "";
            txtbMaa.Text = asiakas != null ? Convert.ToString(asiakas.Maa) : "";
            txtbSahkopostiosoite.Text = asiakas != null ? Convert.ToString(asiakas.Sahkoposti) : "";
            txtbPuhelinnumero.Text = asiakas != null ? Convert.ToString(asiakas.Puhelinnumero) : "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        //Tässä toiminto, joka suoritetaan kun klikataan nimiä listboxissa
        private void lstbxAsiakaslista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //asiakas saa arvokseen valitun Itemin listasta, joka on Asiakas tyyppiä
            this.asiakas=lstbxAsiakaslista.SelectedItem as Asiakas;
            //Kutsutaan show-metodi valitulle asiakkaalle
            showAsiakas();
        }

        private void btnTallennaTiedot_Click(object sender, EventArgs e)
        {
            this.asiakas = lstbxAsiakaslista.SelectedItem as Asiakas;
            MessageBox.Show("Haluatko varmasti tallettaa muokatut tiedot asiakkaalle?","Vahvistus",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            updateAsiakasData(this.asiakas);
            Asiakastietokanta b=new Asiakastietokanta();
            b.UpdateQuery(this.asiakas);

                      
        }

        private void btnLisaaUusiAsiakas_Click(object sender, EventArgs e)
        {
            new Asiakkaat_lisaa_muokkaa().Show();
        }

        private void btnPoistaAsiakas_Click(object sender, EventArgs e)
        {
            this.asiakas = lstbxAsiakaslista.SelectedItem as Asiakas;
            MessageBox.Show("Haluatko varmasti poistaa valitun asiakkaan?", "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Asiakastietokanta b = new Asiakastietokanta();
            b.DeleteQuery(this.asiakas);
            PaivitaAsiakasLista();
            
        }

        
    }
}
