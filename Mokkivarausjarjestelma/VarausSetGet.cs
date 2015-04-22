using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkivarausjarjestelma
{
    //Tämä luokka sisältää setterit ja getterit Varaus-luokan attribuuteille
    public partial class Varaus
    {
        public string Varausid
        {
            get
            {
                return varausid;
            }
            set
            {
                value = varausid;
            }
        }

        public Toimipiste Toimipiste
        {
            get
            {
                return toimipiste;
            }
            set
            {
                value = toimipiste;
            }
        }

        public Mokki Mokki
        {
            get
            {
                return mokki;
            }
            set
            {
                value = mokki;
            }
        }

        public string Saapumispvm
        {
            get
            {
                return saapumispvm;
            }
            set
            {
                value = saapumispvm;
            }
        }

        public string Lahtopvm
        {
            get
            {
                return lahtopvm;
            }
            set
            {
                value = lahtopvm;
            }
        }

        public int Paivat
        {
            get
            {
                return paivat;
            }
            set
            {
                value = paivat;
            }
        }

        public string Alennuskoodi
        {
            get
            {
                return alennuskoodi;
            }
            set
            {
                value = alennuskoodi;
            }
        }

        public Asiakas Asiakas
        {
            get
            {
                return asiakas;
            }
            set
            {
                value = asiakas;
            }
        }

        public int Yopyjat
        {
            get
            {
                return yopyjat;
            }
            set
            {
                value = yopyjat;
            }
        }

        public string Lisatietoja
        {
            get
            {
                return lisatietoja;
            }
            set
            {
                value = lisatietoja;
            }
        }

        public string Yhteenveto
        {
            get
            {
                return yhteenveto;
            }
            set
            {
                value = yhteenveto;
            }
        }

        public string Laskutus
        {
            get
            {
                return laskutus;
            }
            set
            {
                value = laskutus;
            }
        }

        public double Hinta
        {
            get
            {
                return hinta;
            }
            set
            {
                value = hinta;
            }
        }
    }
}
