/* MYSQL: IDENTITY => AUTO_INCREMENT ? */
/* mahdollisia muutoksia voi tulla, ilmoittakaa myös tarvittavat muutokset */

CREATE TABLE Asiakas (
	Asiakasnumero INTEGER NOT NULL IDENTITY PRIMARY KEY UNIQUE,
	Titteli VARCHAR(5) NOT NULL,
	Etunimi VARCHAR(30) NOT NULL, 
	Sukunimi VARCHAR(40) NOT NULL,
	SyntymaAika VARCHAR(10) NOT NULL, /* pp-kk-vvvv */
	Henkilotunnus VARCHAR(50) NOT NULL, /* passi, hetu*/
	Katuosoite VARCHAR(45) NOT NULL,  
	Postinumero VARCHAR(20) NOT NULL,
	Postitoimipaikka VARCHAR(20) NOT NULL,
	Maa VARCHAR(80) NOT NULL,  /* Al Jumahiriyah al Arabiyah al Libiyah ash Shabiyah al Ishtirakiyah al Uzma = libya */
	Kansalaisuus VARCHAR(40) NOT NULL,
	Puhelinumero VARCHAR(40) NOT NULL,
	Sahkopostiosoite VARCHAR(60),
	Lisatietoja VARCHAR(256)
);
CREATE TABLE Mokki (
	Mokkinumero INTEGER NOT NULL IDENTITY PRIMARY KEY UNIQUE,
	Nimi VARCHAR(15) NOT NULL,
	Hinta INTEGER(8) NOT NULL,
	HenkiloMaara INTEGER NOT NULL,
	PintaAla INTEGER,
	Lemmikit TINYINT,
	/* Palvelut VARCHAR(256),
	Kuvaus VARCHAR(256),
	Kuvat VARCHAR(30)*/
);
CREATE TABLE Toimipistemokit (
	Id INTEGER NOT NULL IDENTITY PRIMARY KEY UNIQUE,
	Toimipiste INTEGER NOT NULL,
	Mokki INTEGER NOT NULL,
	FOREIGN KEY (Toimipiste) REFERENCES Toimipiste(ToimipisteId),
	FOREIGN KEY (Mokki) REFERENCES Mokki(Mokkinumero),
);
CREATE TABLE Toimipiste (
	ToimipisteId INTEGER NOT NULL IDENTITY PRIMARY KEY UNIQUE,
	Nimi VARCHAR(30) NOT NULL,
	Katuosoite VARCHAR(30),
	Postinumero VARCHAR(10),
	Postitoimipaikka VARCHAR(30),
	Puhelinumero VARCHAR(15),
	Sahkopostiosoite VARCHAR(50),
	Yhteyshenkilo VARCHAR(30) NOT NULL,
	AukioloAika VARCHAR(30),
);
CREATE TABLE Lisapalvelu (
	Hinta INTEGER NOT NULL,
	Kuvaus VARCHAR(256),
	Aika VARCHAR(30),
	/* Ajankohta */
);
CREATE TABLE Kayttaja (
	Kayttajanumero INTEGER NOT NULL IDENTITY PRIMARY KEY UNIQUE,
	Etunimi VARCHAR(30) NOT NULL, 
	Sukunimi VARCHAR(40) NOT NULL,	
	SyntymaAika VARCHAR(10) NOT NULL, /* pp-kk-vvvv */
	Katuosoite VARCHAR(45) NOT NULL,  
	Postinumero VARCHAR(20) NOT NULL,
	Postitoimipaikka VARCHAR(30),
	Maa VARCHAR(80) NOT NULL,  /* Al Jumahiriyah al Arabiyah al Libiyah ash Shabiyah al Ishtirakiyah al Uzma = libya */
	Kansalaisuus VARCHAR(40) NOT NULL,
	Puhelinumero VARCHAR(40) NOT NULL,
	Sahkopostiosoite VARCHAR(60),
	Tyonimike VARCHAR(40),
	Tyopiste VARCHAR(40),
	FOREIGN KEY (Tyopiste) REFERENCES Toimipiste(Nimi)
);
CREATE TABLE Lasku (
	LaskuId INTEGER NOT NULL IDENTITY PRIMARY KEY UNIQUE,
	Asiakasnumero INTEGER NOT NULL,
	Mokkinumero INTEGER NOT NULL,
	Hinta INTEGER,
	HintaErittely INTEGER,
	Tilitiedot INTEGER,
	Viitenumero INTEGER,
	Vastaanottaja VARCHAR(40),
	EraPaiva VARCHAR(15),
	LaskutusPaiva VARCHAR(15),	
	FOREIGN KEY (Asiakasnumero) REFERENCES Asiakas(Asiakasnumero),
	FOREIGN KEY (Mokkinumero) REFERENCES Mokki(Mokkinumero),
);

CREATE TABLE varaus (
	VarausId INTEGER PRIMARY KEY IDENTITY NOT NULL UNIQUE,
	ToimipisteId INTEGER NOT NULL,
	Asiakasnumero INTEGER NOT NULL,
	Mokkinumero INTEGER NOT NULL,
	Saapumispvm DATETIME NOT NULL,
	Lahtopvm DATETIME NOT NULL,
	Vahvistuspvm DATETIME NOT NULL,
	Paivat INTEGER NOT NULL,
	Vahvistettu  VARCHAR(5) NOT NULL,
	Alennuskoodi VARCHAR(10),
	Yopyjat INTEGER,
	Lisatietoja VARCHAR(250) NOT NULL,
	Hinta DECIMAL(4) NOT NULL,
	Laskutus VARCHAR(10) NOT NULL,
	Lisatty DATETIME NOT NULL DEFAULT NOW(),
	FOREIGN KEY (ToimipisteId)  REFERENCES Toimipiste(ToimipisteId),
	FOREIGN KEY (Asiakasnumero) REFERENCES Asiakas(Asiakasnumero),
	FOREIGN KEY (Mokkinumero) REFERENCES Mokki(Mokkinumero),
);  /*Paivat = paattymispvm-alkpvm, hinta=paivat*mökin hinta*/


CREATE TABLE Salasanat (
	Id INTEGER,
	Salasana VARCHAR(100),
	FOREIGN KEY (Id) REFERENCES Kayttaja(Kayttajanumero),
);