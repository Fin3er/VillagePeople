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
	    private string mokkiosoite;
	    private string mokkipostinumero;
	    private string mokkitoimipiste;
        private string mokkipostitoimipaikka;
	    private string mokkimaa;
	    private string mokkivuorokausihinta;
	    private string mokkihuoneita;
	    private string mokkimakuuhuoneita;
	    private string mokkipintaala;
	    private string mokkivuodepaikat;
	    private string mokkiverkkoyhteys;
	    private string mokkilisatietoa;
		
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
                m.Mokkiosoite = lukija.GetString("katuosoite");
                m.Mokkipostinumero = lukija.GetString("postinumero");
                m.Mokkitoimipiste = lukija.GetString("toimipiste");
                m.Mokkipostitoimipaikka = lukija.GetString("postitoimipaikka");
                m.Mokkimaa = lukija.GetString("maa");
                m.Mokkivuorokausihinta = lukija.GetString("vuorokausihinta");
                m.Mokkihuoneita = lukija.GetString("huoneita");
                m.Mokkimakuuhuoneita = lukija.GetString("makuuhuoneita");
                m.Mokkipintaala = lukija.GetString("pinta-ala");
                m.Mokkivuodepaikat = lukija.GetString("vuodepaikat");
                m.Mokkilisatietoa = lukija.GetString("lisatietoa");
                m.Mokkiverkkoyhteys = lukija.GetString("verkkoyhteys");
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
        kasky.Parameters.AddWithValue("@katuosoite", m.Mokkiosoite);
        kasky.Parameters.AddWithValue("@postinumero", m.Mokkipostinumero);
        kasky.Parameters.AddWithValue("@toimipiste", m.Mokkitoimipiste);
        kasky.Parameters.AddWithValue("@postitoimipaikka", m.Mokkipostitoimipaikka);
        kasky.Parameters.AddWithValue("@maa", m.Mokkimaa);
        kasky.Parameters.AddWithValue("@vuorokausihinta", m.Mokkivuorokausihinta);
        kasky.Parameters.AddWithValue("@huoneita", m.Mokkihuoneita);
        kasky.Parameters.AddWithValue("@makuuhuoneita", m.Mokkimakuuhuoneita);
        kasky.Parameters.AddWithValue("@pintaala", m.Mokkipintaala);
        kasky.Parameters.AddWithValue("@vuodepaikat", m.Mokkivuodepaikat);
        kasky.Parameters.AddWithValue("@lisatietoa", m.Mokkilisatietoa);
        kasky.Parameters.AddWithValue("@verkkoyhteys", m.Mokkiverkkoyhteys);
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
        kasky.Parameters.AddWithValue("@katuosoite", m.Mokkiosoite);
        kasky.Parameters.AddWithValue("@postinumero", m.Mokkipostinumero);
        kasky.Parameters.AddWithValue("@toimipiste", m.Mokkitoimipiste);
        kasky.Parameters.AddWithValue("@postitoimipaikka", m.Mokkipostitoimipaikka);
        kasky.Parameters.AddWithValue("@maa", m.Mokkimaa);
        kasky.Parameters.AddWithValue("@vuorokausihinta", m.Mokkivuorokausihinta);
        kasky.Parameters.AddWithValue("@huoneita", m.Mokkihuoneita);
        kasky.Parameters.AddWithValue("@makuuhuoneita", m.Mokkimakuuhuoneita);
        kasky.Parameters.AddWithValue("@pintaala", m.Mokkipintaala);
        kasky.Parameters.AddWithValue("@vuodepaikat", m.Mokkivuodepaikat);
        kasky.Parameters.AddWithValue("@lisatietoa", m.Mokkilisatietoa);
        kasky.Parameters.AddWithValue("@verkkoyhteys", m.Mokkiverkkoyhteys);
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
