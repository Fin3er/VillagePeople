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
    public partial class Asiakkaat_lisaa_muokkaa : Form
    {
        public Asiakkaat_lisaa_muokkaa()
        {
            InitializeComponent();
        }

        private void btntallenna_Click(object sender, EventArgs e)
        {
            var result=MessageBox.Show("Haluatko varmasti lisätä uuden asiakkaan?", "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Asiakas a = new Asiakas();
                a.Asiakasnumero = Convert.ToString(txbxAsiakasnumero.Text);
                a.Etunimi = Convert.ToString(txtbEtunimi.Text);
                a.Sukunimi = Convert.ToString(txtbSukunimi.Text);
                a.Syntymaaika = Convert.ToString(dtpSyntymaaika.Value);
                a.Postiosoite = Convert.ToString(txtbKatuosoite.Text);
                a.Postinumero = Convert.ToString(txtbPostinumero.Text);
                a.Postitoimipaikka = Convert.ToString(txtbPostitoimipaikka.Text);
                a.Maa = Convert.ToString(txtbMaa.Text);
                a.Puhelinnumero = Convert.ToString(txtbPostinumero.Text);
                a.Sahkoposti = Convert.ToString(txtbSahkopostiosoite.Text);
                Asiakastietokanta b = new Asiakastietokanta();
                b.InsertQuery(a);
            }
        }
    }
}
