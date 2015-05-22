/* MYSQL workbench testattu */
/*
CREATE TABLE asiakkaat (
	asiakasnumero INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
	titteli VARCHAR(5) NOT NULL,
	etunimet VARCHAR(30) NOT NULL, 
	sukunimi VARCHAR(40) NOT NULL,
	syntymaaika VARCHAR(10) NOT NULL, /* pp-kk-vvvv */
	tunnus VARCHAR(50) NOT NULL, /* passi, hetu*/
	postiosoite VARCHAR(50) NOT NULL,  
	postinumero VARCHAR(20) NOT NULL,
	postitoimipaikka VARCHAR(30) NOT NULL,
	maa VARCHAR(80) NOT NULL,  /* Al Jumahiriyah al Arabiyah al Libiyah ash Shabiyah al Ishtirakiyah al Uzma = libya */
	kansalaisuus VARCHAR(40) NOT NULL,
	puhelinumero VARCHAR(40) NOT NULL,
	sahkoposti VARCHAR(60),
	lisatietoja VARCHAR(250)
);
CREATE TABLE mokki (
	mokkiid INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
	nimi VARCHAR(15) NOT NULL UNIQUE,
	hinta INTEGER NOT NULL,
	hlomaara INTEGER NOT NULL,
	pintaala INTEGER,
	lemmikit TINYINT
	/* palvelut VARCHAR(250),
	kuvaus VARCHAR(256),
	kuvat VARCHAR(30)*/
);
CREATE TABLE toimipiste (
	toimipisteid INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
	nimi VARCHAR(40) NOT NULL UNIQUE,
	katuosoite VARCHAR(40),
	postinumero VARCHAR(10),
	postitoimipaikka VARCHAR(30),
	puhelinumero VARCHAR(15),
	sahkopostiosoite VARCHAR(60),
	yhteyshenkilo VARCHAR(30) NOT NULL,
	aukioloaika VARCHAR(30)
);
CREATE TABLE toimipistemokit (
	id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
	toimipiste INTEGER NOT NULL,
	mokki INTEGER NOT NULL,
	FOREIGN KEY (toimipiste) REFERENCES Toimipiste(toimipisteid),
	FOREIGN KEY (mokki) REFERENCES mokki(mokkinumero)
);
CREATE TABLE lisapalvelu (
	lisapalveluid INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
	lisapalvelunimi VARCHAR(40) NOT NULL,
	lisapalveluhinta DOUBLE NOT NULL,
	lisapalvelukuvaus VARCHAR(250),
	lisapalveluaika VARCHAR(30)
	/* ajankohta */
);
CREATE TABLE lasku (
	laskuid INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
	asiakasnumero INTEGER NOT NULL,
	mokkinumero INTEGER NOT NULL,
	hinta INTEGER,
	hintaerittely INTEGER,
	tilitiedot INTEGER,
	viitenumero INTEGER,
	vastaanottaja VARCHAR(40),
	eraPaiva VARCHAR(15),
	laskutuspaiva VARCHAR(15),	
	FOREIGN KEY (asiakasnumero) REFERENCES asiakas(asiakasnumero),
	FOREIGN KEY (mokkinumero) REFERENCES mokki(mokkinumero)
);
CREATE TABLE kayttaja (
	kayttajanumero INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
	etunimi VARCHAR(30) NOT NULL, 
	sukunimi VARCHAR(40) NOT NULL,	
	syntymaaika VARCHAR(10) NOT NULL, /* pp-kk-vvvv */
	katuosoite VARCHAR(45) NOT NULL,  
	postinumero VARCHAR(20) NOT NULL,
	postitoimipaikka VARCHAR(30),
	maa VARCHAR(80) NOT NULL,  /* Al Jumahiriyah al Arabiyah al Libiyah ash Shabiyah al Ishtirakiyah al Uzma = libya */
	kansalaisuus VARCHAR(40) NOT NULL,
	puhelinumero VARCHAR(40) NOT NULL,
	sahkopostiosoite VARCHAR(60),
	tyonimike VARCHAR(40),
	tyopiste VARCHAR(40),
	FOREIGN KEY (tyopiste) REFERENCES toimipiste(nimi)
);
CREATE TABLE salasanat (
	id INTEGER,
	salasana VARCHAR(100),
	FOREIGN KEY (id) REFERENCES kayttaja(kayttajanumero)
);
CREATE TABLE varaukset (
	varausid INTEGER PRIMARY KEY AUTO_INCREMENT NOT NULL UNIQUE,
	toimipisteid INTEGER NOT NULL,
	asiakasnumero INTEGER NOT NULL,
	mokkinumero INTEGER NOT NULL,
	saapumispvm DATETIME NOT NULL,
	lahtopvm DATETIME NOT NULL,
	vahvistuspvm DATETIME NOT NULL,
	paivat INTEGER NOT NULL,
	vahvistettu  VARCHAR(5) NOT NULL,
	alennuskoodi VARCHAR(10),
	yopyjat INTEGER,
	lisatietoja VARCHAR(250) NOT NULL,
	hinta DECIMAL(4) NOT NULL,
	laskutus VARCHAR(10) NOT NULL,
	lisatty DATETIME NOT NULL DEFAULT NOW(),
	FOREIGN KEY (toimipisteid)  REFERENCES toimipiste(toimipisteid),
	FOREIGN KEY (asiakasnumero) REFERENCES asiakas(asiakasnumero),
	FOREIGN KEY (mokkinumero) REFERENCES mokki(mokkinumero)
);  /*paivat = paattymispvm-alkpvm, hinta=paivat*mokin hinta*/ */