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

    //Luokka tietokannalle, metodit tietokantaan yhdistämiselle ja yhteyden sulkemiselle
    public class Tietokanta
    {
        //Tietokanta luokan muuttujat
        protected MySqlConnection yhteys=new MySqlConnection();

        // Get/set con
        public MySqlConnection Yhteys
        {
            get
            {
                return yhteys;
            }
            set
            {
                yhteys = value;
            }
            
        }

        //Tietokanta luokan konstruktori
        public Tietokanta() { }


        //Tietokanta luokan destruktori
        ~Tietokanta()
        {
            /* En tiedä vielä olisko tässä vielä hyvä varmistaa yhteyden sulkeminen
            try
            {
                //Yritetään sulkea yhteys tietokantaan
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection could not be closed due to:" + ex.ToString());
            }
             */
        }

        //Metodi tietokantaan yhdistämistä varten, palauttaa avoimen tietokantayhteyden
        public MySqlConnection YhdistaTietokantaan()
        {
            //Yritetään avata yhteys
            try
            {
                /* Mikko S */
                /* yhteys.ConnectionString = "server = 192.168.1.222; user id = newuser; password = uusi1234; database = tietokanta";*/
                /* Tuomas */
                yhteys.ConnectionString = "server = 192.168.2.101; user id = newuser; password = uusi1234; database = villagepeople";
                yhteys.Open();
                MessageBox.Show("Yhdistetty MySql-tietokantaan");
                return yhteys;
            }
            catch (Exception ex) { MessageBox.Show("Yhteys epäonnistui:" + ex.ToString()); }
            return null;
        }

        //Metodi tietokanta yhteyden sulkemiselle, saa parametriksi suljettavan tietokantayhteyden
        public void SuljeYhteysTietokantaan(MySqlConnection con)
        {
            try
            {
                //Yritetään sulkea yhteys tietokantaan
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yhteyttä ei voitu sulkea:" + ex.ToString());
            }
        }
        

        

    }
         
}
