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
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe: " + ex.ToString());
                }
                try
                {
                    //Annetaan luotu asiakasolio parametrina Tietokanta-luokan InsertQuery-metodille, joka lisää asiakkaan tietokantaan
                    Asiakastietokanta b = new Asiakastietokanta();
                    b.InsertQuery(a);
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
