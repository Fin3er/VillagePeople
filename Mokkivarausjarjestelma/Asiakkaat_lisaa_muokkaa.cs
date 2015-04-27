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
    //Sisältää asiakkaan lisäys- ja muokkauskäyttöliittymän toiminnallisuuden
    public partial class Asiakkaat_lisaa_muokkaa : Form
    {
        public Asiakkaat_lisaa_muokkaa()
        {
            InitializeComponent();
        }

        public Asiakkaat_lisaa_muokkaa(Asiakas a)
        {
            InitializeComponent();
            txtbEtunimi.Text = a.Etunimi;
            txtbSukunimi.Text = a.Sukunimi;
            dtpSyntymaaika.Value = Convert.ToDateTime(a.Syntymaaika);
            txtbKatuosoite.Text = a.Postiosoite;
            txtbPostinumero.Text = a.Postinumero;
            txtbPostitoimipaikka.Text = a.Postitoimipaikka;
            txtbMaa.Text = a.Maa;
            txtbPuhelinnumero.Text = a.Puhelinnumero;
            txtbSahkopostiosoite.Text = a.Sahkoposti;
        }

        //Tapahtuu kun painetaan tallenna painiketta
        private void btntallenna_Click(object sender, EventArgs e)
        {
            //Varmistetaan uuden asiakkaan lisääminen
            var result=MessageBox.Show("Haluatko varmasti lisätä uuden asiakkaan?", "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Luodaan uusi asiakasolio
                Asiakas a = new Asiakas();
                try
                { 
                    //Lisätään formin tiedot asiakasolion tiedoiksi
                    a.Etunimi = Convert.ToString(txtbEtunimi.Text);
                    a.Sukunimi = Convert.ToString(txtbSukunimi.Text);
                    a.Syntymaaika = Convert.ToString(dtpSyntymaaika.Value);
                    a.Postiosoite = Convert.ToString(txtbKatuosoite.Text);
                    a.Postinumero = Convert.ToString(txtbPostinumero.Text);
                    a.Postitoimipaikka = Convert.ToString(txtbPostitoimipaikka.Text);
                    a.Maa = Convert.ToString(txtbMaa.Text);
                    a.Puhelinnumero = Convert.ToString(txtbPuhelinnumero.Text);
                    a.Sahkoposti = Convert.ToString(txtbSahkopostiosoite.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe: " + ex.ToString());
                }
                try
                {
                    //Annetaan luotu asiakasolio parametrina Tietokanta-luokan LisaaAsiakasTietokantaan-metodille, joka lisää asiakkaan tietokantaan
                    Asiakas b = new Asiakas();
                    b.LisaaAsiakasTietokantaan(a);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe: " + ex.ToString());
                }
                
            }
        }

        //Tapahtuu peruuta-nappia painettaessa
        private void btnperuuta_Click(object sender, EventArgs e)
        {
            //Varmistetaan käyttäjältä haluaako varmasti perua toiminnon ja sulkea avoimen formin
            var result=MessageBox.Show("Haluatko varmasti peruuttaa tekemäsi muutokset ja sulkea ikkunan?", "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Jos vastaus kyllä, suljetaan form
            if(result==DialogResult.Yes)
            {
                ActiveForm.Close();
            }
        }


        private void Asiakkaat_lisaa_muokkaa_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
