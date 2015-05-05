/* MYSQL: IDENTITY => AUTO_INCREMENT ? */

CREATE TABLE Asiakas (
	Asiakasnumero INTEGER(15) NOT NULL IDENTITY PRIMARY KEY UNIQUE,
	Titteli VARCHAR(5) NOT NULL,
	Etunimi VARCHAR(30) NOT NULL, 
	Sukunimi VARCHAR(40) NOT NULL,
	SyntymaAika VARCHAR(10) NOT NULL, /* pp-kk-vvvv */
	Katuosoite VARCHAR(45) NOT NULL,  
	Postinumero VARCHAR(20) NOT NULL,
	Postitoimipaikka VARCHAR(20) NOT NULL,
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
	Lemmikit TINYINT(1),
	/* Palvelut VARCHAR(256),
	Kuvaus VARCHAR(256),
	Kuvat VARCHAR(30)*/
);
CREATE TABLE Toimipiste (
	ToimipisteId INTEGER(15) NOT NULL IDENTITY PRIMARY KEY UNIQUE,
	Nimi VARCHAR(30) NOT NULL,
	Katuosoite VARCHAR(30),
	Postinumero VARCHAR(10),
	Postitoimipaikka VARCHAR(30),
	Puhelinumero VARCHAR(15),
	Sahkopostiosoite VARCHAR(50),
	Yhteyshenkilo VARCHAR(30) NOT NULL,
	AukioloAika VARCHAR(30)
);
CREATE TABLE Lisapalvelu (
	Hinta INTEGER(8) NOT NULL,
	Kuvaus VARCHAR(256),
	Aika VARCHAR(30),
	/* Ajankohta */
);
CREATE TABLE Kayttaja (
	Kayttajanumero INTEGER(15) NOT NULL IDENTITY PRIMARY KEY UNIQUE,
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
	LaskuId INTEGER(15) NOT NULL IDENTITY PRIMARY KEY UNIQUE,
	Asiakasnumero INTEGER(15) NOT NULL,
	Mokkinumero INTEGER(15) NOT NULL,
	Hinta INTEGER(10),
	HintaErittely INTEGER(10),
	Tilitiedot INTEGER(10),
	Viitenumero INTEGER(12),
	Vastaanottaja VARCHAR(40),
	EraPaiva VARCHAR(15),
	LaskutusPaiva VARCHAR(15),	
	FOREIGN KEY (Asiakasnumero) REFERENCES Asiakas(Asiakasnumero),
	FOREIGN KEY (Mokkinumero) REFERENCES Mokki(Mokkinumero)
);

CREATE TABLE varaus (
	VarausId INTEGER(6) PRIMARY KEY IDENTITY NOT NULL UNIQUE,
	ToimipisteId INTEGER(3) NOT NULL,
	Asiakasnumero INTEGER(15) NOT NULL,
	Mokkinumero INTEGER(15) NOT NULL,
	Saapumispvm DATETIME NOT NULL,
	Lahtopvm DATETIME NOT NULL,
	Vahvistuspvm DATETIME NOT NULL,
	Paivat INTEGER(3) NOT NULL,
	Vahvistettu  VARCHAR(5) NOT NULL,
	Alennuskoodi VARCHAR(10),
	Yopyjat INTEGER(3),
	Lisatietoja VARCHAR(250) NOT NULL,
	Hinta DECIMAL(4) NOT NULL,
	Laskutus VARCHAR(10) NOT NULL,
	Lisatty DATETIME NOT NULL DEFAULT NOW(),
	FOREIGN KEY (ToimipisteId)  REFERENCES Toimipiste(ToimipisteId),
	FOREIGN KEY (Asiakasnumero) REFERENCES Asiakas(Asiakasnumero),
	FOREIGN KEY (Mokkinumero) REFERENCES Mokki(Mokkinumero),
);  /*Paivat = paattymispvm-alkpvm, hinta=paivat*mökin hinta*/


CREATE TABLE Salasanat (
	Id INTEGER(50),
	Salasana VARCHAR(100),
	FOREIGN KEY (Id) REFERENCES Kayttaja(Kayttajanumero)
);