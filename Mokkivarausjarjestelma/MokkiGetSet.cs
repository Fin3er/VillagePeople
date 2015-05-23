using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkivarausjarjestelma
{
    public partial class Mokki
	{
	
	public string Mokkiid
	{
		get {return mokkiid; }
		set {mokkiid = value; }
	}

    public string Nimi
    {
        get { return nimi; }
        set { nimi = value; }
    }
	
	
	public string Postiosoite
	{
		get {return postiosoite; }
		set {postiosoite = value; }
	}
	
	
	public string Postinumero
	{
		get {return postinumero; }
		set {postinumero = value; }
	}

	
	/*public Toimipiste Toimipiste
	{
		get {return toimipiste; }
		set {toimipiste = value; }
	} */

    public string Postitoimipaikka
    {
        get { return postitoimipaikka; }
        set { postitoimipaikka = value; }
    }
	
	
	public string Maa
	{
		get {return maa; }
		set {maa = value; }
	}
	
	
	public decimal Hinta
	{
		get {return hinta; }
		set {hinta = value; }
	}
	
	
	public string Huoneita
	{
		get {return huoneita; }
		set {huoneita = value; }
	}

	
	
	public string Vuodepaikat
	{
		get {return vuodepaikat; }
		set {vuodepaikat = value; }
	}
	
	
	public string Pintaala
	{
		get {return pintaala; }
		set {pintaala = value; }
	}
	
	
	
	public string Lisatietoja
	{
		get {return lisatietoja; }
		set {lisatietoja = value; }
	}
        

	public string Verkkoyhteys
	{
		get {return verkkoyhteys; }
		set {verkkoyhteys = value; }
	}

    public string Lemmikit
    {
        get{return lemmikit;}
        set { lemmikit = value; }
    }
	
	}
}
