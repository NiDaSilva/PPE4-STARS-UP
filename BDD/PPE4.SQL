-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Dim 03 Janvier 2016 à 02:53
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `ppe4`
--

-- --------------------------------------------------------

--
-- Structure de la table `avoir`
--

CREATE TABLE IF NOT EXISTS `avoir` (
  `ID_TYPE_CUISINE` int(11) NOT NULL,
  `ID_HEBERGEMENT` int(11) NOT NULL,
  PRIMARY KEY (`ID_TYPE_CUISINE`,`ID_HEBERGEMENT`),
  KEY `I_FK_AVOIR_TYPE_CUISINE` (`ID_TYPE_CUISINE`),
  KEY `I_FK_AVOIR_HOTEL` (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `camping`
--

CREATE TABLE IF NOT EXISTS `camping` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `NOM_HEBERGEMENT` varchar(128) DEFAULT NULL,
  `ADRESSE_HEBERGEMENT` varchar(128) DEFAULT NULL,
  `VILLE_HEBERGEMENT` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `chambre_hote`
--

CREATE TABLE IF NOT EXISTS `chambre_hote` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `NOMBRE_CHAMBRE_HOTE` smallint(6) DEFAULT NULL,
  `CUISINE_CHAMBRE_HOTE` tinyint(1) DEFAULT NULL,
  `NOM_HEBERGEMENT` varchar(128) DEFAULT NULL,
  `ADRESSE_HEBERGEMENT` varchar(128) DEFAULT NULL,
  `VILLE_HEBERGEMENT` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `departement`
--

CREATE TABLE IF NOT EXISTS `departement` (
  `ID_DEPARTEMENT` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE_DEPARTEMENT` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`ID_DEPARTEMENT`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=101 ;

--
-- Contenu de la table `departement`
--

INSERT INTO `departement` (`ID_DEPARTEMENT`, `LIBELLE_DEPARTEMENT`) VALUES
(1, 'Ain'),
(2, 'Aisne'),
(3, 'Allier'),
(30, 'Gard'),
(34, 'Hérault'),
(44, 'Loire Atlantique'),
(49, 'Maine et Loire'),
(85, 'Vendée'),
(86, 'Vienne'),
(87, 'Haute-Vienne'),
(88, 'Vosges'),
(89, 'Yonne'),
(90, 'Territoire de Belfort'),
(91, 'Essonne'),
(92, 'Hauts de Seine'),
(93, 'Seine Saint Denis'),
(94, 'Val de Marne'),
(95, 'Val d''Oise');

-- --------------------------------------------------------

--
-- Structure de la table `equipement_camping`
--

CREATE TABLE IF NOT EXISTS `equipement_camping` (
  `ID_EQUIPEMENT_CAMPING` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE_EQUIPEMENT_CAMPING` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`ID_EQUIPEMENT_CAMPING`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Contenu de la table `equipement_camping`
--

INSERT INTO `equipement_camping` (`ID_EQUIPEMENT_CAMPING`, `LIBELLE_EQUIPEMENT_CAMPING`) VALUES
(1, 'Piscine'),
(2, 'Terrain de jeux'),
(3, 'Supérette'),
(4, 'Salle de sport'),
(5, 'Salle de jeux');

-- --------------------------------------------------------

--
-- Structure de la table `gerant`
--

CREATE TABLE IF NOT EXISTS `gerant` (
  `ID_GERANT` int(11) NOT NULL AUTO_INCREMENT,
  `NOM_GERANT` varchar(128) DEFAULT NULL,
  `PRENOM_GERANT` varchar(128) DEFAULT NULL,
  `LOGIN` varchar(50) NOT NULL,
  `MDP` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_GERANT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `gerer`
--

CREATE TABLE IF NOT EXISTS `gerer` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `ID_GERANT` int(11) NOT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`,`ID_GERANT`),
  KEY `I_FK_GERER_HEBERGEMENT` (`ID_HEBERGEMENT`),
  KEY `I_FK_GERER_GERANT` (`ID_GERANT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `hebergement`
--

CREATE TABLE IF NOT EXISTS `hebergement` (
  `ID_HEBERGEMENT` int(11) NOT NULL AUTO_INCREMENT,
  `ID_DEPARTEMENT` int(11) NOT NULL,
  `NOM_HEBERGEMENT` varchar(128) DEFAULT NULL,
  `ADRESSE_HEBERGEMENT` varchar(128) DEFAULT NULL,
  `VILLE_HEBERGEMENT` varchar(128) DEFAULT NULL,
  `HORAIRES` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`),
  KEY `I_FK_HEBERGEMENT_DEPARTEMENT` (`ID_DEPARTEMENT`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `hebergement`
--

INSERT INTO `hebergement` (`ID_HEBERGEMENT`, `ID_DEPARTEMENT`, `NOM_HEBERGEMENT`, `ADRESSE_HEBERGEMENT`, `VILLE_HEBERGEMENT`, `HORAIRES`) VALUES
(1, 49, 'L''Océane', 'Route Nationale 323', 'Villevêque', NULL),
(2, 34, 'Royal Hotel', '8 Rue de Maguelone', 'Montpellier', NULL),
(3, 92, 'Hotel ibis Nanterre La Défense', '36/38 avenue Champs Pierreux', 'Nanterre', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `hotel`
--

CREATE TABLE IF NOT EXISTS `hotel` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `RESTAURANT_HOTEL` tinyint(1) DEFAULT NULL,
  `CHEF_RESTAURANT_HOTEL` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `hotel`
--

INSERT INTO `hotel` (`ID_HEBERGEMENT`, `RESTAURANT_HOTEL`, `CHEF_RESTAURANT_HOTEL`) VALUES
(1, 1, 'Gerard Paillote');

-- --------------------------------------------------------

--
-- Structure de la table `inspecteur`
--

CREATE TABLE IF NOT EXISTS `inspecteur` (
  `ID_INSPECTEUR` int(11) NOT NULL AUTO_INCREMENT,
  `ID_SPECIALITE` int(11) NOT NULL,
  `NOM_INSPECTEUR` varchar(128) DEFAULT NULL,
  `PERNOM_INSPECTEUR` varchar(128) DEFAULT NULL,
  `LOGIN` varchar(50) NOT NULL,
  `MDP` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_INSPECTEUR`),
  KEY `I_FK_INSPECTEUR_SPECIALITE` (`ID_SPECIALITE`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Contenu de la table `inspecteur`
--

INSERT INTO `inspecteur` (`ID_INSPECTEUR`, `ID_SPECIALITE`, `NOM_INSPECTEUR`, `PERNOM_INSPECTEUR`, `LOGIN`, `MDP`) VALUES
(1, 2, 'Grondin', 'Nicolas', 'NGrondin', 'azerty1234'),
(2, 3, 'Bouhours', 'Natacha', 'NBouhours', 'azerty1234'),
(3, 2, 'Da Silva', 'Nicolas', 'NDSilva', 'azerty1234'),
(4, 1, 'Robin', 'Dimitry', 'Drobin', 'vtyde'),
(5, 3, 'Hermange', 'Pierre', 'PHermange', 'azerty1234'),
(6, 1, 'Menant', 'Kévin', 'KMenant', 'azerty1234');

-- --------------------------------------------------------

--
-- Structure de la table `posseder`
--

CREATE TABLE IF NOT EXISTS `posseder` (
  `ID_EQUIPEMENT_CAMPING` int(11) NOT NULL,
  `ID_HEBERGEMENT` int(11) NOT NULL,
  PRIMARY KEY (`ID_EQUIPEMENT_CAMPING`,`ID_HEBERGEMENT`),
  KEY `I_FK_POSSEDER_EQUIPEMENT_CAMPING` (`ID_EQUIPEMENT_CAMPING`),
  KEY `I_FK_POSSEDER_CAMPING` (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `saison`
--

CREATE TABLE IF NOT EXISTS `saison` (
  `ID_SAISON` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE_SAISON` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`ID_SAISON`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `saison`
--

INSERT INTO `saison` (`ID_SAISON`, `LIBELLE_SAISON`) VALUES
(1, '2015'),
(2, '2016'),
(3, '2017');

-- --------------------------------------------------------

--
-- Structure de la table `specialite`
--

CREATE TABLE IF NOT EXISTS `specialite` (
  `ID_SPECIALITE` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE_SPECIALITE` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`ID_SPECIALITE`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `specialite`
--

INSERT INTO `specialite` (`ID_SPECIALITE`, `LIBELLE_SPECIALITE`) VALUES
(1, 'Hôtel'),
(2, 'Camping'),
(3, 'Chambres d''hôtes');

-- --------------------------------------------------------

--
-- Structure de la table `type_cuisine`
--

CREATE TABLE IF NOT EXISTS `type_cuisine` (
  `ID_TYPE_CUISINE` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE_TYPE_CUISINE` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_TYPE_CUISINE`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `type_cuisine`
--

INSERT INTO `type_cuisine` (`ID_TYPE_CUISINE`, `LIBELLE_TYPE_CUISINE`) VALUES
(1, 'Gastronomique'),
(2, 'Chinoise'),
(3, 'Rapide');

-- --------------------------------------------------------

--
-- Structure de la table `visiter`
--

CREATE TABLE IF NOT EXISTS `visiter` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `ID_INSPECTEUR` int(11) NOT NULL,
  `ID_SAISON` int(11) NOT NULL,
  `NOMBRE_ETOILE_VISITE` smallint(6) DEFAULT NULL,
  `DATE_HEURE_VISITE` datetime DEFAULT NULL,
  `CONTRE_VISITE` tinyint(1) DEFAULT NULL,
  `COMMENTAIRE_VISITE` varchar(255) DEFAULT NULL,
  `TYPE_VISITE` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`,`ID_INSPECTEUR`,`ID_SAISON`),
  KEY `I_FK_VISITER_HEBERGEMENT` (`ID_HEBERGEMENT`),
  KEY `I_FK_VISITER_INSPECTEUR` (`ID_INSPECTEUR`),
  KEY `I_FK_VISITER_SAISON` (`ID_SAISON`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `visiter`
--

INSERT INTO `visiter` (`ID_HEBERGEMENT`, `ID_INSPECTEUR`, `ID_SAISON`, `NOMBRE_ETOILE_VISITE`, `DATE_HEURE_VISITE`, `CONTRE_VISITE`, `COMMENTAIRE_VISITE`, `TYPE_VISITE`) VALUES
(1, 4, 2, NULL, '2016-07-18 15:00:00', NULL, NULL, NULL),
(2, 4, 3, NULL, '2016-01-05 10:00:00', NULL, 'Poutre à nettoyé', NULL),
(3, 5, 3, NULL, '2017-02-22 14:00:00', NULL, NULL, NULL);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `avoir`
--
ALTER TABLE `avoir`
  ADD CONSTRAINT `avoir_ibfk_2` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hotel` (`ID_HEBERGEMENT`),
  ADD CONSTRAINT `avoir_ibfk_1` FOREIGN KEY (`ID_TYPE_CUISINE`) REFERENCES `type_cuisine` (`ID_TYPE_CUISINE`);

--
-- Contraintes pour la table `camping`
--
ALTER TABLE `camping`
  ADD CONSTRAINT `camping_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`);

--
-- Contraintes pour la table `chambre_hote`
--
ALTER TABLE `chambre_hote`
  ADD CONSTRAINT `chambre_hote_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`);

--
-- Contraintes pour la table `gerer`
--
ALTER TABLE `gerer`
  ADD CONSTRAINT `gerer_ibfk_2` FOREIGN KEY (`ID_GERANT`) REFERENCES `gerant` (`ID_GERANT`),
  ADD CONSTRAINT `gerer_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`);

--
-- Contraintes pour la table `hebergement`
--
ALTER TABLE `hebergement`
  ADD CONSTRAINT `hebergement_ibfk_1` FOREIGN KEY (`ID_DEPARTEMENT`) REFERENCES `departement` (`ID_DEPARTEMENT`);

--
-- Contraintes pour la table `hotel`
--
ALTER TABLE `hotel`
  ADD CONSTRAINT `hotel_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`);

--
-- Contraintes pour la table `inspecteur`
--
ALTER TABLE `inspecteur`
  ADD CONSTRAINT `inspecteur_ibfk_1` FOREIGN KEY (`ID_SPECIALITE`) REFERENCES `specialite` (`ID_SPECIALITE`);

--
-- Contraintes pour la table `posseder`
--
ALTER TABLE `posseder`
  ADD CONSTRAINT `posseder_ibfk_2` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `camping` (`ID_HEBERGEMENT`),
  ADD CONSTRAINT `posseder_ibfk_1` FOREIGN KEY (`ID_EQUIPEMENT_CAMPING`) REFERENCES `equipement_camping` (`ID_EQUIPEMENT_CAMPING`);

--
-- Contraintes pour la table `visiter`
--
ALTER TABLE `visiter`
  ADD CONSTRAINT `visiter_ibfk_4` FOREIGN KEY (`ID_INSPECTEUR`) REFERENCES `inspecteur` (`ID_INSPECTEUR`),
  ADD CONSTRAINT `visiter_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`),
  ADD CONSTRAINT `visiter_ibfk_3` FOREIGN KEY (`ID_SAISON`) REFERENCES `saison` (`ID_SAISON`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
