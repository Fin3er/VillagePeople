using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lisätyt luokat
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Mokkivarausjarjestelma
{
    public partial class Varaus
    {
        private string varausid;
        private Toimipiste toimipiste; 
        private Mokki mokki; 
        private string saapumispvm;
        private string lahtopvm;
        private int paivat;
        private string alennuskoodi;
        private Asiakas asiakas;
        private int yopyjat;
        private string lisatietoja;
        private string yhteenveto;
        private string laskutus;
        private double hinta;
    }
}
