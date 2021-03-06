﻿using System;
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
    public partial class Mokinhallinta : UserControl 
    {
        public Mokinhallinta()
        {
            InitializeComponent();
        }
        //Lista Mökkiolioita varten
        private List<Mokki> mokkilista = new List<Mokki>();
        //Saa arvoksi Mokki-luokan olion
        private Mokki mokki;
        protected MySqlConnection yhteys;
        protected MySqlCommand kasky;
        protected MySqlDataReader lukija;


        private void Mokinhallinta_Load(object sender, EventArgs e)
        {
            Mokki m = new Mokki();
            m.HaeKaikkiMokitTietokannasta();
            mokkilista = m.mokkilista;
            dgvMokit.DataSource = mokkilista;
        }

       

       

       
        //"Lisää uusi mökki" -painikkeesta avataan Mökin lisäys ja muokkausform, joka on vielä toistaiseksi tyhjä.
        private void btnLisaaUusiMokki_Click(object sender, EventArgs e)
        {
            new Mokki_lisaa().Show();
        }
        
        
        

        private void btnTallennaMokkiTiedot_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Haluatko varmasti muokata valitun mökin tietoja?", "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                new Mokki_muokkaa(mokki).Show();
            
        }

        private void dgvMokit_SelectionChanged(object sender, EventArgs e)
        {
            mokki = (Mokki)dgvMokit.CurrentRow.DataBoundItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Haluatko varmasti poistaa valitun mökin?", "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                mokki.PoistaMokkiTietokannasta(mokki);
        }


    }
}
