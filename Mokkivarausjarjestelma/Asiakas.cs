using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkivarausjarjestelma
{
    //Osittainen luokka Asiakas, toinen osa on AsiakasSetGet, joka sisältää attributtien setterit ja getterit
    public partial class Asiakas
    {
        //Asiakkaan muuttujat, pitää miettiä vielä tyypit. Nyt kaikki stringeinä, mikä tässä vaiheessa tuntuu toimivimmalta
        private string asiakasnumero;
        private string nimitys;
        private string etunimi;
        private string sukunimi;
        private string syntymaaika;
        private string postiosoite;
        private string postinumero;
        private string postitoimipaikka;
        private string maa;
        private string puhelinnumero;
        private string sahkoposti;

        //Asiakkaan konstruktori, ei ota ainakaan vielä parametrejä
        public Asiakas() { }
        //Asiakkaan destruktori
        ~Asiakas() { }

        //Ylikirjoitetaan metodi toString, jotta listboxissa näkyisi etu- ja sukunimi
        public override string ToString()
        {
            return this.Etunimi + " " + this.Sukunimi;
        }
    }
}
