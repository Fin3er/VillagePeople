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
                Toimipisteid = value;
            }
        }
        public string Toimipistepuhelinnumero
        {
            get
            {
                return toimipistepuhelinnumero;
            }
            set
            {
                toimipistepuhelinnumero = value;
            }
        }
        public string Toimipistesahkoposti
        {
            get
            {
                return toimipistesahkoposti;
            }
            set
            {
               Toimipistesahkoposti  = value;
            }
        }
        public string Toimipistekatuosoite
        {
            get
            {
                return toimipistekatuosoite;
            }
            set
            {
                 Toimipistekatuosoite = value;
            }
        }
        public string Toimipistepostinumero
        {
            get
            {
                return toimipistekatuosoite;
            }
            set
            {
              Toimipistekatuosoite = value;
            }
        }
        public string Toimipistepostitoimipaikka
        {
            get
            {
                return toimipistepostitoimipaikka;
            }
            set
            {
                Toimipistepostitoimipaikka = value;
            }
        }
        public string Toimipistemaa
        {
            get
            {
                return toimipistemaa;
            }
            set
            {
                Toimipistemaa = value;
            }
        }
        public string Vastuuhenkilo
        {
            get
            {
                return vastuuhenkilo;
            }
            set
            {
                Vastuuhenkilo = value;
            }
        }
        public string Vastuupuhelinnumero
        {
            get
            {
                return vastuupuhelinnumero;
            }
            set
            {
                Vastuupuhelinnumero = value;
            }
        }
        public string Vastuusahkoposti
        {
            get
            {
                return vastuusahkoposti;
            }
            set
            {
                Vastuusahkoposti = value;
            }
        }
    }
}
