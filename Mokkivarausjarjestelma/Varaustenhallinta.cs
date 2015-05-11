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
    public partial class Varaustenhallinta : Form
    {
        public Varaustenhallinta()
        {
            InitializeComponent();
        }
        protected MySqlConnection yhteys;
        protected MySqlCommand kasky;
        protected MySqlDataReader lukija;
         public DataTable TaytaDatatable()
        {
            Tietokanta t = new Tietokanta();
            yhteys = t.YhdistaTietokantaan();
            kasky = yhteys.CreateCommand();
            kasky.CommandText = "Select * from varaukset";
            lukija = kasky.ExecuteReader();
            DataSet dsvaraukset = new DataSet();
            DataTable dtvaraukset = new DataTable();
            dsvaraukset.Tables.Add(dtvaraukset);
            dtvaraukset.Load(lukija);
            return dtvaraukset;
        }

         private void Varaustenhallinta_Load(object sender, EventArgs e)
         {
             dataGridView1.DataSource = TaytaDatatable();
         }

         private void btnUusiVaraus_Click(object sender, EventArgs e)
         {
             new UusiVaraus().Show();
         }
    }
}
