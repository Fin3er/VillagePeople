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
    public partial class Asiakkaat : Form
    {
        public Asiakkaat()
        {
            InitializeComponent();
            valikko1.TabPages[1].Controls.Add(new FormAsiakkaanHallinta());
            valikko1.TabPages[2].Controls.Add(new Mokinhallinta());
            valikko1.TabPages[3].Controls.Add(new Toimipisteenhallinta());
            valikko1.TabPages[4].Controls.Add(new Varaustenhallinta());

        }
        
       
    }
}
