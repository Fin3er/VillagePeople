/*Tämä on vain tähänastiseen testikäyttöön tehty tietokanta, ei siis lopullinen tietokanta. 
CREATE DATABASE IF NOT EXISTS asiakkaat;
USE asiakkaat;

DROP TABLE IF EXISTS `asiakas`;

CREATE TABLE `asiakas` (
  `asiakasnumero` varchar(45) NOT NULL,
  `nimitys` varchar(3) DEFAULT NULL,
  `etunimi` varchar(45) DEFAULT NULL,
  `sukunimi` varchar(45) DEFAULT NULL,
  `syntymaaika` varchar(45) DEFAULT NULL,
  `katuosoite` varchar(45) DEFAULT NULL,
  `postinumero` varchar(45) DEFAULT NULL,
  `postitoimipaikka` varchar(45) DEFAULT NULL,
  `maa` varchar(45) DEFAULT NULL,
  `puhelinnumero` varchar(45) DEFAULT NULL,
  `sahkopostiosoite` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`asiakasnumero`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='	';
