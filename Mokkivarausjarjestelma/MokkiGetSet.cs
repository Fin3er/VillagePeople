using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkivarausjarjestelma
{
    public partial class Mokki
	{
	
	public string Mokkitunnus
	{
		get {return mokkitunnus; }
		set {mokkitunnus = value; }
	}
	
	
	public string M_osoite
	{
		get {return m_osoite; }
		set {m_osoite = value; }
	}
	
	
	public string M_postinumero
	{
		get {return m_postinumero; }
		set {m_postinumero = value; }
	}

	
	public string M_toimipaikka
	{
		get {return m_toimipaikka; }
		set {m_toimipaikka = value; }
	}
	
	
	public string M_maa
	{
		get {return m_maa; }
		set {m_maa = value; }
	}
	
	
	public string Vuorokausihinta
	{
		get {return vuorokausihinta; }
		set {vuorokausihinta = value; }
	}
	
	
	public string Huoneita
	{
		get {return huoneita; }
		set {huoneita = value; }
	}
	
	
	public string Makuuhuoneita
	{
		get {return makuuhuoneita; }
		set {makuuhuoneita = value; }
	}
	
	
	public string Pintaala
	{
		get {return pintaala; }
		set {pintaala = value; }
	}
	

	public string Vuodepaikat
	{
		get {return vuodepaikat; }
		set {vuodepaikat = value; }
	}
	
	
	public string M_lisatietoa
	{
		get {return m_lisatietoa; }
		set {m_lisatietoa = value; }
	}
        

	public string Verkkoyhteys
	{
		get {return verkkoyhteys; }
		set {verkkoyhteys = value; }
	}
	
	}
}
