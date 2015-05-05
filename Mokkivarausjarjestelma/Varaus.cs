using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lisätyt luokat
using MySql.Data.MySqlClient;
using System.Windows.Forms;

/* Ei testattu, tehty Asiakas mallista */

namespace Mokkivarausjarjestelma
{
    public partial class Varaus
    {
        // Varauksen muuttujat
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

        //Lista löytyneitä varauksia varten
        public List<Varaus> varauslista = new List<Varaus>();

        //Muuttujat tietokantakyselyjä varten
        protected MySqlConnection yhteys;
        protected MySqlCommand kasky;
        protected MySqlDataReader lukija;

        //Varaus konstruktori
        public Varaus() { }
        //Varaus destruktori
        ~Varaus() { }

        // Varauksen hakeminen


        // Varauksen päivittäminen


        // Varauksen lisääminen


        // Varauksen poistaminen


    }
}
