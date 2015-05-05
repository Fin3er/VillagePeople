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
        private string mokkitunnus;
	    private string m_osoite;
	    private string m_postinumero;
	    private string m_toimipiste;
        private string m_postitoimipaikka;
	    private string m_maa;
	    private string vuorokausihinta;
	    private string huoneita;
	    private string makuuhuoneita;
	    private string pintaala;
	    private string vuodepaikat;
	    private string verkkoyhteys;
	    private string m_lisatietoa;
		
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
                m.Mokkitunnus = lukija.GetString("mokkitunnus");
                m.M_osoite = lukija.GetString("katuosoite");
                m.M_postinumero = lukija.GetString("postinumero");
                m.M_toimipiste = lukija.GetString("toimipiste");
                m.M_postitoimipaikka = lukija.GetString("postitoimipaikka");
                m.M_maa = lukija.GetString("maa");
                m.Vuorokausihinta = lukija.GetString("vuorokausihinta");
                m.Huoneita = lukija.GetString("huoneita");
                m.Makuuhuoneita = lukija.GetString("makuuhuoneita");
                m.Pintaala = lukija.GetString("pinta-ala");
                m.Vuodepaikat = lukija.GetString("vuodepaikat");
                m.M_lisatietoa = lukija.GetString("lisatietoa");
                m.Verkkoyhteys = lukija.GetString("verkkoyhteys");
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
        kasky.CommandText = @"UPDATE mokki SET katuosoite=@katuosoite, postinumero=@postinumero,
            toimipiste=@toimipiste, postitoimipaikka=@postitoimipaikka maa=@maa, vuorokausihinta=@vuorokaushinta, huoneita=@huoneita, makuuhuoneita=@makuuhuoneita, 
            pintaala=@pintaala, vuodepaikat=@vuodepaikat, lisatietoa=@lisatietoa, verkkoyhteys=@verkkoyhteys WHERE mokkitunnus=@mokkitunnus";
        //Lisätään updatequeryyn parametrina annetun asiakkaan tiedot
        kasky.Parameters.AddWithValue("@mokkitunnus", m.Mokkitunnus);
        kasky.Parameters.AddWithValue("@katuosoite", m.M_osoite);
        kasky.Parameters.AddWithValue("@postinumero", m.M_postinumero);
        kasky.Parameters.AddWithValue("@toimipiste", m.M_toimipiste);
        kasky.Parameters.AddWithValue("@postitoimipaikka", m.M_postitoimipaikka);
        kasky.Parameters.AddWithValue("@maa", m.M_maa);
        kasky.Parameters.AddWithValue("@vuorokausihinta", m.Vuorokausihinta);
        kasky.Parameters.AddWithValue("@huoneita", m.Huoneita);
        kasky.Parameters.AddWithValue("@makuuhuoneita", m.Makuuhuoneita);
        kasky.Parameters.AddWithValue("@pintaala", m.Pintaala);
        kasky.Parameters.AddWithValue("@vuodepaikat", m.Vuodepaikat);
        kasky.Parameters.AddWithValue("@lisatietoa", m.M_lisatietoa);
        kasky.Parameters.AddWithValue("@verkkoyhteys", m.Verkkoyhteys);
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
        kasky.CommandText = @"INSERT INTO mokki (katuosoite, postinumero, toimipiste, postitoimipaikka, maa, vuorokausihinta, huoneita, makuuhuoneita, pintaala, vuodepaikat, lisatietoa, verkkoyhteys)
                                VALUES (@katuosoite, @postinumero, @toimipaikka, @maa, @vuorokaushinta, @huoneita, @makuuhuoneita, @pintaala, @vuodepaikat, @lisatietoa, @verkkoyhteys)";
        kasky.Parameters.AddWithValue("@katuosoite", m.M_osoite);
        kasky.Parameters.AddWithValue("@postinumero", m.M_postinumero);
        kasky.Parameters.AddWithValue("@toimipiste", m.M_toimipiste);
        kasky.Parameters.AddWithValue("@postitoimipaikka", m.M_postitoimipaikka);
        kasky.Parameters.AddWithValue("@maa", m.M_maa);
        kasky.Parameters.AddWithValue("@vuorokausihinta", m.Vuorokausihinta);
        kasky.Parameters.AddWithValue("@huoneita", m.Huoneita);
        kasky.Parameters.AddWithValue("@makuuhuoneita", m.Makuuhuoneita);
        kasky.Parameters.AddWithValue("@pintaala", m.Pintaala);
        kasky.Parameters.AddWithValue("@vuodepaikat", m.Vuodepaikat);
        kasky.Parameters.AddWithValue("@lisatietoa", m.M_lisatietoa);
        kasky.Parameters.AddWithValue("@verkkoyhteys", m.Verkkoyhteys);
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
        kasky.CommandText = "DELETE FROM mokki WHERE mokkitunnus=@mokkitunnus";
        kasky.Parameters.AddWithValue("@mokkitunnus", m.Mokkitunnus);
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
