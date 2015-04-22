CREATE TABLE Asiakas (
	Asiakasnumero INTEGER(15) NOT NULL IDENTITY PRIMARY KEY UNIQUE,
	Titteli VARCHAR(5) NOT NULL,
	Etunimi VARCHAR(30) NOT NULL, 
	Sukunimi VARCHAR(40) NOT NULL,
	SyntymaAika VARCHAR(10) NOT NULL, /* pp-kk-vvvv */
	Katuosoite VARCHAR(45) NOT NULL,  
	Postinumero VARCHAR(20) NOT NULL,
	Maa VARCHAR(80) NOT NULL,  /* Al Jumahiriyah al Arabiyah al Libiyah ash Shabiyah al Ishtirakiyah al Uzma = libya */
	Kansalaisuus VARCHAR(40) NOT NULL,
	Puhelinumero VARCHAR(40) NOT NULL,
	Sahkopostiosoite VARCHAR(60),
);
CREATE TABLE Mokki (
	Mokkinumero INTEGER(15) NOT NULL IDENTITY PRIMARY KEY UNIQUE,
	Nimi VARCHAR(15) NOT NULL,
	Hinta INTEGER(8) NOT NULL,
	HenkiloMaara INTEGER(3) NOT NULL,
	PintaAla INTEGER(4),
	Lemmikit BOOLEAN,
	/* Palvelut VARCHAR(256),
	Kuvaus VARCHAR(256),
	Kuvat VARCHAR(30)*/
);
CREATE TABLE Toimipiste (
	Nimi VARCHAR(30),
	Katuosoite VARCHAR(30),
	Postinumero VARCHAR(10),
	Postitoimipaikka VARCHAR(30),
	Puhelinumero VARCHAR(15),
	Sahkopostiosoite VARCHAR(50),
	Yhteyshenkilo VARCHAR(30)
);
CREATE TABLE Lisapalvelu (
	Hinta INTEGER(8),
	Kuvaus VARCHAR(256),
	Aika VARCHAR(30)
);
CREATE TABLE Kayttaja (
	Kayttajanumero INTEGER(15) NOT NULL IDENTITY PRIMARY KEY UNIQUE,
	Etunimi VARCHAR(30) NOT NULL, 
	Sukunimi VARCHAR(40) NOT NULL,	
	SyntymaAika VARCHAR(10) NOT NULL, /* pp-kk-vvvv */
	Katuosoite VARCHAR(45) NOT NULL,  
	Postinumero VARCHAR(20) NOT NULL,
	Maa VARCHAR(80) NOT NULL,  /* Al Jumahiriyah al Arabiyah al Libiyah ash Shabiyah al Ishtirakiyah al Uzma = libya */
	Kansalaisuus VARCHAR(40) NOT NULL,
	Puhelinumero VARCHAR(40) NOT NULL,
	Sahkopostiosoite VARCHAR(60),
	Tyonimike VARCHAR(40),
	Tyopiste VARCHAR(40),

);
CREATE TABLE Lasku (
	Asiakasnumero INTEGER(15) NOT NULL,
	Hinta INTEGER(10),
	HintaErittely INTEGER(10),
	Tilitiedot INTEGER(10),
	Viitenumero INTEGER(12),
	Vastaanottaja VARCHAR(40),
	EraPaiva VARCHAR(15),
	LaskutusPaiva VARCHAR(15),	
	FOREIGN KEY (Asiakasnumero) REFERENCES Asiakas(Asiakasnumero)
);
CREATE TABLE Salasanat (
	Id INTEGER(50),
	Salasana VARCHAR(100)	
);