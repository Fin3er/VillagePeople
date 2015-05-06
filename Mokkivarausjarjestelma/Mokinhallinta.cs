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
    public partial class Mokinhallinta : Form
    {
        public Mokinhallinta()
        {
            InitializeComponent();
        }
        //Lista Mökkiolioita varten
        private List<Mokki> mokkilista = new List<Mokki>();
        //Saa arvoksi Mokki-luokan olion
        private Mokki mokki;

        private void lblSukunimi_Click(object sender, EventArgs e)
        {

        }

        private void Mokinhallinta_Load(object sender, EventArgs e)
        {
            PaivitaMokkiLista();
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
            txtbxMokkiToimipiste.Text = mokki != null ? Convert.ToString(mokki.M_toimipiste) : "";
            txtbxMokkiPostiosoite.Text = mokki != null ? Convert.ToString(mokki.M_osoite) : "";
            txtbxMokkiMaa.Text = mokki != null ? Convert.ToString(mokki.M_maa) : "";
            txtbxMokkiPostinumero.Text = mokki != null ? Convert.ToString(mokki.M_postinumero) : "";
            txtbxMokkiPostitoimipaikka.Text = mokki != null ? Convert.ToString(mokki.M_postitoimipaikka) : "";
            txtbxMokkiHuoneita.Text = mokki != null ? Convert.ToString(mokki.Huoneita) : "";
            txtbxMokkiMakuuhuoneita.Text = mokki != null ? Convert.ToString(mokki.Makuuhuoneita) : "";
            txtbxMokkiVuodepaikat.Text = mokki != null ? Convert.ToString(mokki.Vuodepaikat) : "";
            txtbxMokkiVuorokausihinta.Text = mokki != null ? Convert.ToString(mokki.Vuorokausihinta) : "";
            txtbxMokkiPintaala.Text = mokki != null ? Convert.ToString(mokki.Pintaala) : "";
            txtbxMokkiVerkkoyhteys.Text = mokki != null ? Convert.ToString(mokki.Verkkoyhteys) : "";
            richtxtbxMokkiLisatietoa.Text = mokki != null ? Convert.ToString(mokki.M_lisatietoa) : "";
        }

        //Tässä toiminto, joka suoritetaan kun klikataan nimiä listboxissa
        private void lstbxMokkilista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //asiakas saa arvokseen valitun Itemin listasta, joka on Asiakas tyyppiä
            this.mokki = lstbxMokkilista.SelectedItem as Mokki;
            //Kutsutaan show-metodi valitulle asiakkaalle
            NaytaMokki();
        }


    }
}
