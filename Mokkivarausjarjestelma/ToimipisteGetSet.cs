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
    //Osittainen luokka Toimipiste, joka sisältää aksessorit ja mutaattorit
    public partial class Toimipiste
    {
        public string Toimipisteid
        {
            get
            {
                return toimipisteid;
            }
            set
            {
                toimipisteid = value;
            }
        }

        public string Nimi
        {
            get
            {
                return nimi;
            }
            set
            {
                nimi = value;
            }
        }

        public string Puhelinnumero
        {
            get
            {
                return puhelinnumero;
            }
            set
            {
                puhelinnumero = value;
            }
        }
        public string Sahkopostiosoite
        {
            get
            {
                return sahkopostiosoite;
            }
            set
            {
               sahkopostiosoite = value;
            }
        }
        public string Postiosoite
        {
            get
            {
                return postiosoite;
            }
            set
            {
                 postiosoite = value;
            }
        }
        public string Postinumero
        {
            get
            {
                return postinumero;
            }
            set
            {
              postinumero = value;
            }
        }
        public string Postitoimipaikka
        {
            get
            {
                return postitoimipaikka;
            }
            set
            {
                postitoimipaikka = value;
            }
        }
        public string Maa
        {
            get
            {
                return maa;
            }
            set
            {
                maa = value;
            }
        }
        public string Yhteyshenkilo
        {
            get
            {
                return yhteyshenkilo;
            }
            set
            {
                yhteyshenkilo = value;
            }
        }
       
        public string Aukioloaika
        {
            get
            {
                return aukioloaika;
            }
            set
            {
                aukioloaika = value;
            }
        }
    }
}
