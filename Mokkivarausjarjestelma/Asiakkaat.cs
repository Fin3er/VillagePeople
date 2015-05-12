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
            tabControl1.TabPages[0].Controls.Add(new FormAsiakkaanHallinta());
            tabControl1.TabPages[1].Controls.Add(new Mokinhallinta());
            tabControl1.TabPages[2].Controls.Add(new Toimipisteenhallinta());
            tabControl1.TabPages[3].Controls.Add(new Varaustenhallinta());

        }
        
       
    }
}
