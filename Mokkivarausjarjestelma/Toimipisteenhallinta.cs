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
    public partial class Toimipisteenhallinta : UserControl
    {
        public Toimipisteenhallinta()
        {
            InitializeComponent();
        }
        //Luodaan lista toimipisteoliota varten
        private List<Toimipiste> toimipistelista = new List<Toimipiste>();

        //Saa arvoksi Toimipiste-luokan olion
        private Toimipiste toimipiste;

        //Tehdään kun Toimipisteenhallinta-form ladataan, päivitetään toimipistelista
        private void Toimipisteenhallinta_Load(object sender, EventArgs e)
        {
            PaivitaToimipisteLista();
        }

        //Metodi toimipistelistan päivittämiselle
        public void PaivitaToimipisteLista()
        {
            //Tyhjennetään listbox
            lstbxToimipiste.Items.Clear();
            //Luodaan uusi instanssi toimipisteluokasta
            Toimipiste tp = new Toimipiste();
            //Käytetään toimipisteluokan metodia HaeKaikkiToimipisteet
            tp.HaeKaikkiToimipisteetTietokannasta();
            //Toimipistelista saa arvokseen toimipisteluokan toimipistelistan
            toimipistelista = tp.toimipistelista;
            //Tällä saadaan listbox näyttämään listan sisältämät oliot, muutetaan lista Arrayksi
            lstbxToimipiste.Items.AddRange(toimipistelista.ToArray());
        }
        //Metodi, joka näyttää toimipisteen tiedot formilla
        public void NaytaToimipiste()
        {
            //Jos olio on olemassa näytetään tiedot txtboxeissa
            txbxToimipistetunnus.Text = toimipiste != null ? Convert.ToString(toimipiste.Toimipisteid) : "";
            txbxToimipistePuhelinnumero.Text = toimipiste != null ? Convert.ToString(toimipiste.Puhelinnumero) : "";
            txbxToimipisteSahkoposti.Text = toimipiste != null ? Convert.ToString(toimipiste.Sahkopostiosoite) : "";
            txbxToimipisteKatuosoite.Text = toimipiste != null ? Convert.ToString(toimipiste.Postiosoite) : "";
            txbxToimipistePostinumero.Text = toimipiste != null ? Convert.ToString(toimipiste.Postinumero) : "";
            txbxToimipistePostitoimipaikka.Text = toimipiste != null ? Convert.ToString(toimipiste.Postitoimipaikka) : "";
            txbxToimipisteMaa.Text = toimipiste != null ? Convert.ToString(toimipiste.Maa) : "";
            txbxVastuuhenkilo.Text = toimipiste != null ? Convert.ToString(toimipiste.Yhteyshenkilo) : "";
        }
        //Tässä toiminto, joka suoritetaan kun klikataan nimiä listboxissa
        private void lstbxToimipiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            //asiakas saa arvokseen valitun Itemin listasta, joka on Toimipiste tyyppiä
            this.toimipiste = lstbxToimipiste.SelectedItem as Toimipiste;
            //Kutsutaan show-metodi valitulle asiakkaalle
            NaytaToimipiste();
        }
        private void btnPoistaToimipiste_Click(object sender, EventArgs e)
        {
            this.toimipiste = lstbxToimipiste.SelectedItem as Toimipiste;
            MessageBox.Show("Haluatko varmasti poistaa valitun toimipisteen?", "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Toimipiste p = new Toimipiste();
            p.PoistaToimipisteTietokannasta(this.toimipiste);
            PaivitaToimipisteLista();

        }
    }
}
