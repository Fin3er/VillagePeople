using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkivarausjarjestelma
{
    //Osittainen luokka Asiakas, joka sisältää aksessorit ja mutaattorit
    public partial class Asiakas
    {
        public string Asiakasnumero
        {
            get
            {
                return asiakasnumero;
            }
            set
            {
                asiakasnumero = value;
            }
        }
        public string Nimitys
        {
            get
            {
                return nimitys;
            }
            set
            {
                nimitys = value;
            }
        }

        public string Etunimi
        {
            get
            {
                return etunimi;
            }
            set
            {
                etunimi = value;
            }
        }

        public string Sukunimi
        {
            get
            {
                return sukunimi;
            }
            set
            {
                sukunimi = value;
            }
        }

        public string Syntymaaika
        {
            get
            {
                return syntymaaika;
            }
            set
            {
                syntymaaika = value;
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

        public string Sahkoposti
        {
            get
            {
                return sahkoposti;
            }
            set
            {
                sahkoposti = value;
            }
        }
    }
}
