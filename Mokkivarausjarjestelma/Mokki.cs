using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Mokkivarausjarjestelma
{
    public partial class Mokki
    {
        /* laitoin joihinkin muuttujiin etuliitteen, koska ajattelin, 
        että muissa osissa tulee samannimisiä muuttujia ja aiheuttaa epäselvyyksiä */
        private string mokkiid;
	    //private Toimipiste toimipiste;
	    private string nimi;
	    private string postiosoite;
        private string postinumero;
	    private string postitoimipaikka;
        private string maa;
	    private decimal hinta;
        private string huoneita;
	    private string vuodepaikat;
	    private string verkkoyhteys;
        private string lemmikit;
        private string pintaala;
        private string lisatietoja;
		
	public Mokki()
	{
	}
	
	~Mokki()
	{
	}

    //Lista löytyneitä mökkejä varten
    public List<Mokki> mokkilista = new List<Mokki>();

    //Muuttujat tietokantakyselyjä varten
    protected MySqlConnection yhteys;
    protected MySqlCommand kasky;
    protected MySqlDataReader lukija;

    public void HaeKaikkiMokitTietokannasta()
    {
        Tietokanta t = new Tietokanta();
        yhteys = t.YhdistaTietokantaan();
        kasky = yhteys.CreateCommand();
        kasky.CommandText = "Select * from mokki";
        lukija = kasky.ExecuteReader();
        try
        {
            while (lukija.Read())
            {
                //Luodaan, jokaista taulun riviä varten asiakasolioita 
                Mokki m = new Mokki();
                m.Mokkiid = lukija.GetString("mokkiid");
                m.Nimi = lukija.GetString("nimi");
                m.Postiosoite = lukija.GetString("postiosoite");
                m.Postinumero = lukija.GetString("postinumero");
                m.Postitoimipaikka = lukija.GetString("postitoimipaikka");
                m.Maa = lukija.GetString("maa");
                m.Hinta = Convert.ToDecimal(lukija.GetString("hinta"));
                m.Huoneita = lukija.GetString("huoneita");
                m.Pintaala = lukija.GetString("pintaala");
                m.Vuodepaikat = lukija.GetString("vuodepaikat");
                m.Lisatietoja = lukija.GetString("lisatietoja");
                m.Verkkoyhteys = lukija.GetString("verkkoyhteys");
                m.Lemmikit = lukija.GetString("lemmikit");
                //Lisätään luotu olio listaan
                mokkilista.Add(m);
                //Alustetaan t nollaksi
                m = null;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Tietoja haettaessa tapahtui virhe:" + ex.ToString());
        }
        try
        {
            //Suljetaan reader
            lukija.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Readeria sulkiessa tapahtui virhe:" + ex.ToString());
        }
        t.SuljeYhteysTietokantaan(yhteys);
    }

    public void PaivitaMokkiTietokantaan(Mokki m)
    {
        Tietokanta t = new Tietokanta();
        yhteys = t.YhdistaTietokantaan();
        kasky = yhteys.CreateCommand();
        //Update Query @merkityt muuttujat? korvataan parametreillä
        kasky.CommandText = @"UPDATE mokki SET nimi=@nimi,postiosoite=@postiosoite, postinumero=@postinumero,
            postitoimipaikka=@postitoimipaikka maa=@maa, hinta=@hinta, huoneita=@huoneita,
            pintaala=@pintaala, vuodepaikat=@vuodepaikat, lisatietoja=@lisatietoja, verkkoyhteys=@verkkoyhteys, lemmikit=@lemmikit WHERE mokkiid=@mokkiid";
        //Lisätään updatequeryyn parametrina annetun asiakkaan tiedot
        kasky.Parameters.AddWithValue("@mokkiid", m.Mokkiid);
        kasky.Parameters.AddWithValue("@nimi", m.Nimi);
        kasky.Parameters.AddWithValue("@postiosoite", m.Postiosoite);
        kasky.Parameters.AddWithValue("@postinumero", m.Postinumero);
        kasky.Parameters.AddWithValue("@postitoimipaikka", m.Postitoimipaikka);
        kasky.Parameters.AddWithValue("@maa", m.Maa);
        kasky.Parameters.AddWithValue("@hinta", m.Hinta);
        kasky.Parameters.AddWithValue("@huoneita", m.Huoneita);
        kasky.Parameters.AddWithValue("@pintaala", m.Pintaala);
        kasky.Parameters.AddWithValue("@vuodepaikat", m.Vuodepaikat);
        kasky.Parameters.AddWithValue("@lisatietoja", m.Lisatietoja);
        kasky.Parameters.AddWithValue("@verkkoyhteys", m.Verkkoyhteys);
        kasky.Parameters.AddWithValue("@lemmikit", m.Lemmikit);
        try
        {
            kasky.ExecuteNonQuery();
            //Viesti, joka ilmoittaa tietojen päivityksen onnistuneen
            MessageBox.Show("Mokkitiedot päivitetty", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Päivitettäessä tietoja tapahtui virhe: " + ex.ToString());
        }

        //Suljetaan yhteys
        t.SuljeYhteysTietokantaan(yhteys);
    }

    //Metodi asiakkaan tietokantaan lisäämiselle
    public void LisaaMokkiTietokantaan(Mokki m)
    {
        Tietokanta t = new Tietokanta();
        yhteys = t.YhdistaTietokantaan();
        kasky = yhteys.CreateCommand();
        kasky.CommandText = @"INSERT INTO mokki (nimi, postiosoite, postinumero, postitoimipaikka, maa, hinta, huoneita, pintaala, vuodepaikat, lisatietoja, verkkoyhteys, lemmikit)
                                VALUES (@postiosoite, @postinumero, @postitoimipaikka, @maa, @hinta, @huoneita, @pintaala, @vuodepaikat, @lisatietoja, @verkkoyhteys, @lemmikit)";
        kasky.Parameters.AddWithValue("@nimi", m.Nimi);
        kasky.Parameters.AddWithValue("@postiosoite", m.Postiosoite);
        kasky.Parameters.AddWithValue("@postinumero", m.Postinumero);
        kasky.Parameters.AddWithValue("@postitoimipaikka", m.Postitoimipaikka);
        kasky.Parameters.AddWithValue("@maa", m.Maa);
        kasky.Parameters.AddWithValue("@hinta", m.Hinta);
        kasky.Parameters.AddWithValue("@huoneita", m.Huoneita);
        kasky.Parameters.AddWithValue("@pintaala", m.Pintaala);
        kasky.Parameters.AddWithValue("@vuodepaikat", m.Vuodepaikat);
        kasky.Parameters.AddWithValue("@lisatietoja", m.Lisatietoja);
        kasky.Parameters.AddWithValue("@verkkoyhteys", m.Verkkoyhteys);
        kasky.Parameters.AddWithValue("@lemmikit", m.Lemmikit);
        try
        {
            kasky.ExecuteNonQuery();
            //Viesti, joka ilmoittaa tietojen päivityksen onnistuneen
            MessageBox.Show("Uusi mokki lisätty", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Tapahtui virhe lisättäessä mokkia:" + ex.ToString());
        }
        //Suljetaan yhteys
        t.SuljeYhteysTietokantaan(yhteys);
    }
        //Metodi asiakkaan poistamiselle tietokannasta
    public void PoistaMokkiTietokannasta(Mokki m)
    {
        Tietokanta t = new Tietokanta();
        yhteys = t.YhdistaTietokantaan();
        kasky = yhteys.CreateCommand();
        kasky.CommandText = "DELETE FROM mokki WHERE mokkiid=@mokkiid";
        kasky.Parameters.AddWithValue("@mokkiid", m.Mokkiid);
        try
        {
            kasky.ExecuteNonQuery();
            MessageBox.Show("Mokki poistettu", "Vahvistus", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Tapahtui virhe mokkia poistettaessa:" + ex.ToString());
        }
        t.SuljeYhteysTietokantaan(yhteys);
    }

    }
}
