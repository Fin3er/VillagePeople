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
    public partial class UusiVaraus : Form
    {
        public UusiVaraus()
        {
            InitializeComponent();
        }

        private void UusiVaraus_Load(object sender, EventArgs e)
        {
            // Asetetaan dtpsaapuminen ja dtplahtopvm arvoksi tämä päivä
            DateTime paivamaara = DateTime.Today;
            dtpsaapuminen.Value = paivamaara;
            dtplahtopvm.Value = paivamaara;
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


        }
    }

