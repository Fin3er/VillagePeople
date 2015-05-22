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
    public partial class Mokinhallinta : UserControl 
    {
        public Mokinhallinta()
        {
            InitializeComponent();
        }
        //Lista Mökkiolioita varten
        private List<Mokki> mokkilista = new List<Mokki>();
        //Saa arvoksi Mokki-luokan olion
        private Mokki mokki;
        protected MySqlConnection yhteys;
        protected MySqlCommand kasky;
        protected MySqlDataReader lukija;

        public DataTable TaytaDatatable()
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "Select * from mokki";
            lukija = kasky.ExecuteReader();
            DataSet dsmokit = new DataSet();
            DataTable dtmokit = new DataTable();
            dsmokit.Tables.Add(dtmokit);
            dtmokit.Load(lukija);
            return dtmokit;
        }

        private void lblSukunimi_Click(object sender, EventArgs e)
        {

        }

        private void Mokinhallinta_Load(object sender, EventArgs e)
        {
            dgvMokit.DataSource=TaytaDatatable();
        }

        //Metodi mokkilistan päivittämiselle
        public void PaivitaMokkiLista()
        {
            //Tyhjennetään listbox
            lstbxMokkilista.Items.Clear();
            //Luodaan uusi instanssi mökkiluokasta
            Mokki m = new Mokki();
            //Käytetään mökkiluokan metodia HaeKaikkiMokit
            m.HaeKaikkiMokitTietokannasta();
            //Mökkilista saa arvokseen mökkiluokan mökkilistan
            mokkilista = m.mokkilista;
            //Tällä saadaan listbox näyttämään listan sisältämät oliot, muutetaan lista Arrayksi
            lstbxMokkilista.Items.AddRange(mokkilista.ToArray());
        }

        //Metodi, joka näyttää Mokin tiedot formilla
        public void NaytaMokki()
        {
            //Jos olio on olemassa näytetään tiedot txtboxeissa
            txbxMokkiNumero.Text = mokki != null ? Convert.ToString(mokki.Mokkitunnus) : "";
            txtbxMokkiToimipiste.Text = mokki != null ? Convert.ToString(mokki.Mokkitoimipiste) : "";
            txtbxMokkiPostiosoite.Text = mokki != null ? Convert.ToString(mokki.Mokkiosoite) : "";
            txtbxMokkiMaa.Text = mokki != null ? Convert.ToString(mokki.Mokkimaa) : "";
            txtbxMokkiPostinumero.Text = mokki != null ? Convert.ToString(mokki.Mokkipostinumero) : "";
            txtbxMokkiPostitoimipaikka.Text = mokki != null ? Convert.ToString(mokki.Mokkipostitoimipaikka) : "";
            txtbxMokkiHuoneita.Text = mokki != null ? Convert.ToString(mokki.Mokkihuoneita) : "";
            txtbxMokkiMakuuhuoneita.Text = mokki != null ? Convert.ToString(mokki.Mokkimakuuhuoneita) : "";
            txtbxMokkiVuodepaikat.Text = mokki != null ? Convert.ToString(mokki.Mokkivuodepaikat) : "";
            txtbxMokkiVuorokausihinta.Text = mokki != null ? Convert.ToString(mokki.Mokkivuorokausihinta) : "";
            txtbxMokkiPintaala.Text = mokki != null ? Convert.ToString(mokki.Mokkipintaala) : "";
            txtbxMokkiVerkkoyhteys.Text = mokki != null ? Convert.ToString(mokki.Mokkiverkkoyhteys) : "";
            richtxtbxMokkiLisatietoa.Text = mokki != null ? Convert.ToString(mokki.Mokkilisatietoa) : "";
        }

        //Tässä toiminto, joka suoritetaan kun klikataan nimiä listboxissa
        private void lstbxMokkilista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //asiakas saa arvokseen valitun Itemin listasta, joka on Asiakas tyyppiä
            this.mokki = lstbxMokkilista.SelectedItem as Mokki;
            //Kutsutaan show-metodi valitulle asiakkaalle
            NaytaMokki();
        }
        //"Lisää uusi mökki" -painikkeesta avataan Mökin lisäys ja muokkausform, joka on vielä toistaiseksi tyhjä.
        private void btnLisaaUusiMokki_Click(object sender, EventArgs e)
        {
            new Mokki_lisaa_muokkaa().Show();
        }
        //"Muokkaa tietoja" -napin toiminto. Vielä tarvitsee vähän koodia.
        private void btnTallennaMokkiTiedot_Click(object sender, EventArgs e)
        {
            new Mokki_lisaa_muokkaa().Show();
        }
        //"Poista mökki" -napin toiminto.
        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            this.mokki = lstbxMokkilista.SelectedItem as Mokki;
            MessageBox.Show("Haluatko varmasti poistaa valitun asiakkaan?", "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Mokki n = new Mokki();
            n.PoistaMokkiTietokannasta(this.mokki);
            PaivitaMokkiLista();
        }


    }
}
