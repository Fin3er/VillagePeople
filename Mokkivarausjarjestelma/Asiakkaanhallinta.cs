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
    //Lisää, poista, tallenna tiedot painikkeet kesken. Combobox kesken.
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
            //Luodaan uusi instanssi asiakastietokannasta
            Asiakastietokanta testi = new Asiakastietokanta();
            //Yhdistetään tietokantaan
            testi.Connect();
            //Annetaan querylause asiakastietojen hakemiseen
            testi.SelectQuery("Select * from asiakas");
            //Lista saa arvokseen asiakastietokantaluokan listan
            lista = testi.lista;
            //Suljetaan yhteys tietokantaan
            testi.CloseConnection();
            //Tällä saadaan listbox näyttämään listan sisältämät oliot, muutetaan lista Arrayksi
            lstbxAsiakaslista.Items.AddRange(lista.ToArray());
            //Comboboxin vaihtoehdot
            cbbxNimitys.Items.Add("Mr.");
            cbbxNimitys.Items.Add("Mrs.");
            cbbxNimitys.Items.Add("Ms.");
            cbbxNimitys.Items.Add("Dr.");
        }

        //Metodi asiakkaan tietojen päivittämiseen
        public void updateAsiakasData()
        {
            //Tehdään vain jos asiakas on olemassa
            if(this.asiakas!=null)
            {
                this.asiakas.Asiakasnumero = Convert.ToString(txbxAsiakasnumero);
                this.asiakas.Etunimi = Convert.ToString(txtbEtunimi);
                this.asiakas.Sukunimi = Convert.ToString(txtbSukunimi);
                this.asiakas.Syntymaaika = Convert.ToString(txtbSyntymaaika);
                this.asiakas.Postiosoite = Convert.ToString(txtbKatuosoite);
                this.asiakas.Postinumero = Convert.ToString(txtbPostinumero);
                this.asiakas.Postitoimipaikka = Convert.ToString(txtbPostitoimipaikka);
                this.asiakas.Maa = Convert.ToString(txtbMaa);
                this.asiakas.Puhelinnumero = Convert.ToString(txtbPostinumero);
                this.asiakas.Sahkoposti = Convert.ToString(txtbSahkopostiosoite);
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

        
    }
}
