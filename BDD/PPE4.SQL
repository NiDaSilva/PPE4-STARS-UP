-- phpMyAdmin SQL Dump
-- version 4.5.2
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mer 20 Avril 2016 à 12:11
-- Version du serveur :  5.7.9
-- Version de PHP :  5.6.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `ppe4`
--

-- --------------------------------------------------------

--
-- Structure de la table `avoir`
--

DROP TABLE IF EXISTS `avoir`;
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

DROP TABLE IF EXISTS `camping`;
CREATE TABLE IF NOT EXISTS `camping` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `NOM_HEBERGEMENT` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `ADRESSE_HEBERGEMENT` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `VILLE_HEBERGEMENT` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `chambre_hote`
--

DROP TABLE IF EXISTS `chambre_hote`;
CREATE TABLE IF NOT EXISTS `chambre_hote` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `NOMBRE_CHAMBRE_HOTE` smallint(6) DEFAULT NULL,
  `CUISINE_CHAMBRE_HOTE` tinyint(1) DEFAULT NULL,
  `NOM_HEBERGEMENT` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `ADRESSE_HEBERGEMENT` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `VILLE_HEBERGEMENT` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `departement`
--

DROP TABLE IF EXISTS `departement`;
CREATE TABLE IF NOT EXISTS `departement` (
  `ID_DEPARTEMENT` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE_DEPARTEMENT` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID_DEPARTEMENT`)
) ENGINE=InnoDB AUTO_INCREMENT=977 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `departement`
--

INSERT INTO `departement` (`ID_DEPARTEMENT`, `LIBELLE_DEPARTEMENT`) VALUES
(1, 'Ain'),
(2, 'Aisne'),
(3, 'Allier'),
(4, 'Alpes-de-Haute-Provence'),
(5, 'Hautes-Alpes'),
(6, 'Alpes-Maritimes'),
(7, 'Ardèche'),
(8, 'Ardennes'),
(9, 'Ariège'),
(10, 'Aube'),
(11, 'Aude'),
(12, 'Aveyron'),
(13, 'Bouches-du-Rhône'),
(14, 'Calvados'),
(15, 'Cantal'),
(16, 'Charente'),
(17, 'Charente-Maritime'),
(18, 'Cher'),
(19, 'Corrèze'),
(20, 'Corse'),
(21, 'Côte-d''or'),
(22, 'Côtes-d''armor'),
(23, 'Creuse'),
(24, 'Dordogne'),
(25, 'Doubs'),
(26, 'Drôme'),
(27, 'Eure'),
(28, 'Eure-et-Loir'),
(29, 'Finistère'),
(30, 'Gard'),
(31, 'Haute-Garonne'),
(32, 'Gers'),
(33, 'Gironde'),
(34, 'Hérault'),
(35, 'Ile-et-Vilaine'),
(36, 'Indre'),
(37, 'Indre-et-Loire'),
(38, 'Isère'),
(39, 'Jura'),
(40, 'Landes'),
(41, 'Loir-et-Cher'),
(42, 'Loire'),
(43, 'Haute-Loire'),
(44, 'Loire-Atlantique'),
(45, 'Loiret'),
(46, 'Lot'),
(47, 'Lot-et-Garonne'),
(48, 'Lozère'),
(49, 'Maine-et-Loire'),
(50, 'Manche'),
(51, 'Marne'),
(52, 'Haute-Marne'),
(53, 'Mayenne'),
(54, 'Meurthe-et-Moselle'),
(55, 'Meuse'),
(56, 'Morbihan'),
(57, 'Moselle'),
(58, 'Nièvre'),
(59, 'Nord'),
(60, 'Oise'),
(61, 'Orne'),
(62, 'Pas-de-Calais'),
(63, 'Puy-de-Dôme'),
(64, 'Pyrénées-Atlantiques'),
(65, 'Hautes-Pyrénées'),
(66, 'Pyrénées-Orientales'),
(67, 'Bas-Rhin'),
(68, 'Haut-Rhin'),
(69, 'Rhône'),
(70, 'Haute-Saône'),
(71, 'Saône-et-Loire'),
(72, 'Sarthe'),
(73, 'Savoie'),
(74, 'Haute-Savoie'),
(75, 'Paris'),
(76, 'Seine-Maritime'),
(77, 'Seine-et-Marne'),
(78, 'Yvelines'),
(79, 'Deux-Sèvres'),
(80, 'Somme'),
(81, 'Tarn'),
(82, 'Tarn-et-Garonne'),
(83, 'Var'),
(84, 'Vaucluse'),
(85, 'Vendée'),
(86, 'Vienne'),
(87, 'Haute-Vienne'),
(88, 'Vosges'),
(89, 'Yonne'),
(90, 'Territoire de Belfort'),
(91, 'Essonne'),
(92, 'Hauts-de-Seine'),
(93, 'Seine-Saint-Denis'),
(94, 'Val-de-Marne'),
(95, 'Val-d''oise'),
(971, 'Guadeloupe'),
(972, 'Martinique'),
(973, 'Guyane'),
(974, 'Réunion'),
(976, 'Mayotte');

-- --------------------------------------------------------

--
-- Structure de la table `equipement_camping`
--

DROP TABLE IF EXISTS `equipement_camping`;
CREATE TABLE IF NOT EXISTS `equipement_camping` (
  `ID_EQUIPEMENT_CAMPING` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE_EQUIPEMENT_CAMPING` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID_EQUIPEMENT_CAMPING`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

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

DROP TABLE IF EXISTS `gerant`;
CREATE TABLE IF NOT EXISTS `gerant` (
  `ID_GERANT` int(11) NOT NULL AUTO_INCREMENT,
  `NOM_GERANT` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `PRENOM_GERANT` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `LOGIN` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `MDP` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`ID_GERANT`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `gerant`
--

INSERT INTO `gerant` (`ID_GERANT`, `NOM_GERANT`, `PRENOM_GERANT`, `LOGIN`, `MDP`) VALUES
(1, 'JAMAIN', 'Jordan', 'jj', 'jj'),
(2, 'Da Silva', 'Nicolas', 'Nico', 'Nico'),
(51, 'Autret', 'Carine', 'CAutret', 'btssio'),
(52, 'De Robien', 'Fréderique', 'DRFrederique', 'btssio'),
(53, 'Jousseaume', 'Bruno', 'BJousseaume', 'btssio'),
(54, 'Loiseau', 'Gilles', 'GLoiseau', 'btssio'),
(55, 'Tamisier', 'Magali', 'TMagali', 'btssio');

-- --------------------------------------------------------

--
-- Structure de la table `hebergement`
--

DROP TABLE IF EXISTS `hebergement`;
CREATE TABLE IF NOT EXISTS `hebergement` (
  `ID_HEBERGEMENT` int(11) NOT NULL AUTO_INCREMENT,
  `ID_GERANT` int(11) DEFAULT NULL,
  `ID_DEPARTEMENT` int(11) NOT NULL,
  `NOM_HEBERGEMENT` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `ADRESSE_HEBERGEMENT` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `VILLE_HEBERGEMENT` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `HORAIRES` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `ID_SPECIALITE` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`),
  KEY `I_FK_HEBERGEMENT_DEPARTEMENT` (`ID_DEPARTEMENT`),
  KEY `ID_GERANT` (`ID_GERANT`),
  KEY `ID_SPECIALITE` (`ID_SPECIALITE`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `hebergement`
--

INSERT INTO `hebergement` (`ID_HEBERGEMENT`, `ID_GERANT`, `ID_DEPARTEMENT`, `NOM_HEBERGEMENT`, `ADRESSE_HEBERGEMENT`, `VILLE_HEBERGEMENT`, `HORAIRES`, `ID_SPECIALITE`) VALUES
(1, 1, 49, 'Hotel Mercure', '2 Allée Du Grand Launay', '49000 Angers', '8h - 18h', 1),
(2, 2, 49, 'BEST WESTERN', '1 Boulevard Maréchal Foch', '49100 Angers', '8h - 18h', 1),
(3, 51, 44, 'Ibis Styles', '3 rue du Couedic', '44000 Nantes', '8h - 18h', 1),
(4, 52, 44, 'BEST WESTERN', '155 Route De Gachet', '44300 Nantes', '8h - 18h', 1),
(5, 53, 69, 'Studio Part Dieu', '23 rue Riboud', '69003 Lyon', '8h - 18h', 1),
(6, 54, 69, 'Appart Coeur de Lyon', '72 boulevard Vivier Merle', '69003 Lyon', '8h - 18h', 2),
(7, 55, 75, 'George Washington', '43 rue Washington', '75008 Paris', '8h - 18h', 2),
(8, 51, 75, 'Opera-Louvre', 'Passage Choiseul', '75002 Paris', '8h - 18h', 2),
(9, 53, 13, 'Grand Tonic', '43 Quai des Belges', '13001 Marseille', '8h - 18h', 2),
(10, 2, 13, 'Golden Tulip', '17 Place Louis Bonnefon', '13008 Marseille', '8h - 18h', 2),
(11, 54, 31, 'Le Clocher de Rodez', '15 Place Jeanne d''Arc', '31000 Toulouse', '8h - 18h', 3),
(12, 55, 31, 'Hotel de Brienne', '20 Boulevard Maréchal Leclerc', '31000 Toulouse', '8h - 18h', 3),
(13, 1, 21, 'hotel Mercure', '22 Boulevard De la Mane', '21071 Dijon', '8h - 18h', 3),
(14, 52, 21, 'hotel Ibis', '2 avenue de Marbotte', '21000 Dijon', '8h - 18h', 3);

-- --------------------------------------------------------

--
-- Structure de la table `hotel`
--

DROP TABLE IF EXISTS `hotel`;
CREATE TABLE IF NOT EXISTS `hotel` (
  `ID_HEBERGEMENT` int(11) NOT NULL,
  `RESTAURANT_HOTEL` tinyint(1) DEFAULT NULL,
  `CHEF_RESTAURANT_HOTEL` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID_HEBERGEMENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `hotel`
--

INSERT INTO `hotel` (`ID_HEBERGEMENT`, `RESTAURANT_HOTEL`, `CHEF_RESTAURANT_HOTEL`) VALUES
(1, 0, NULL),
(2, 1, 'Pierre Hermange'),
(3, 0, NULL),
(4, 0, NULL),
(5, 1, 'Natacha Bouhours'),
(6, 0, NULL),
(7, 1, 'Nicolas Grondin'),
(8, 1, 'Kevin Menant'),
(9, 0, NULL),
(10, 0, NULL),
(11, 1, 'Dimitri Robin'),
(12, 0, NULL),
(13, 0, NULL),
(14, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `inspecteur`
--

DROP TABLE IF EXISTS `inspecteur`;
CREATE TABLE IF NOT EXISTS `inspecteur` (
  `ID_INSPECTEUR` int(11) NOT NULL AUTO_INCREMENT,
  `ID_SPECIALITE` int(11) NOT NULL,
  `NOM_INSPECTEUR` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `PERNOM_INSPECTEUR` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `LOGIN` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `MDP` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `PHOTO` varchar(150) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `TEMPS_CONNEXION` time NOT NULL,
  `ID_DEPARTEMENT` int(11) DEFAULT NULL,
  `DATE_NAISSANCE` date DEFAULT NULL,
  `NATIONALITE` varchar(30) NOT NULL,
  PRIMARY KEY (`ID_INSPECTEUR`),
  KEY `I_FK_INSPECTEUR_SPECIALITE` (`ID_SPECIALITE`),
  KEY `LIBELLE_DEPARTEMENT` (`ID_DEPARTEMENT`),
  KEY `ID_DEPARTEMENT` (`ID_DEPARTEMENT`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `inspecteur`
--

INSERT INTO `inspecteur` (`ID_INSPECTEUR`, `ID_SPECIALITE`, `NOM_INSPECTEUR`, `PERNOM_INSPECTEUR`, `LOGIN`, `MDP`, `PHOTO`, `TEMPS_CONNEXION`, `ID_DEPARTEMENT`, `DATE_NAISSANCE`, `NATIONALITE`) VALUES
(1, 2, 'Grondin', 'Nicolas', 'NGrondin', 'c6c4940b323ff81c66e02a02e0281c370c535008', 'PDP/NG.jpg', '00:00:00', 49, NULL, 'Française'),
(2, 3, 'Bouhours', 'Natacha', 'NBouhours', 'c6c4940b323ff81c66e02a02e0281c370c535008', 'PDP/NB.jpg', '00:00:00', 49, '1996-12-05', 'Française'),
(3, 1, 'Da Silva', 'Nicolas', 'NDSilva', 'c6c4940b323ff81c66e02a02e0281c370c535008', 'PDP/NDS.jpg', '00:00:00', 49, '1995-05-30', 'Française'),
(4, 1, 'Robin', 'Dimitry', 'Drobin', 'f356a267d8cd8a5f8b3d4ac4164a5ed1a101603f', 'PDP/DR.jpg', '120:00:00', 49, '1996-11-03', 'Française'),
(5, 3, 'Hermange', 'Pierre', 'PHermange', 'c6c4940b323ff81c66e02a02e0281c370c535008', 'PDP/PH.jpg', '00:00:00', 49, '1997-02-02', 'Française'),
(6, 1, 'Menant', 'Kévin', 'KMenant', 'c6c4940b323ff81c66e02a02e0281c370c535008', 'PDP/KM.jpg', '00:00:00', 49, '1995-10-05', 'Française');

-- --------------------------------------------------------

--
-- Structure de la table `posseder`
--

DROP TABLE IF EXISTS `posseder`;
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

DROP TABLE IF EXISTS `saison`;
CREATE TABLE IF NOT EXISTS `saison` (
  `ID_SAISON` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE_SAISON` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID_SAISON`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `saison`
--

INSERT INTO `saison` (`ID_SAISON`, `LIBELLE_SAISON`) VALUES
(1, 'Hiver 2016'),
(2, 'Printemps 2016'),
(3, 'Eté 2016'),
(4, 'Automne 2016');

-- --------------------------------------------------------

--
-- Structure de la table `specialite`
--

DROP TABLE IF EXISTS `specialite`;
CREATE TABLE IF NOT EXISTS `specialite` (
  `ID_SPECIALITE` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE_SPECIALITE` varchar(128) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID_SPECIALITE`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `specialite`
--

INSERT INTO `specialite` (`ID_SPECIALITE`, `LIBELLE_SPECIALITE`) VALUES
(1, 'Hôtel'),
(2, 'Camping'),
(3, 'Chambres d''hôtes');

-- --------------------------------------------------------

--
-- Structure de la table `temps_connexion`
--

DROP TABLE IF EXISTS `temps_connexion`;
CREATE TABLE IF NOT EXISTS `temps_connexion` (
  `ID_CONNEXION` int(11) NOT NULL AUTO_INCREMENT,
  `ID_INSPECTEUR` int(11) DEFAULT NULL,
  `DEBUT_CONNEXION` datetime DEFAULT NULL,
  `FIN_CONNEXION` datetime DEFAULT NULL,
  PRIMARY KEY (`ID_CONNEXION`),
  KEY `ID_INSPECTEUR` (`ID_INSPECTEUR`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `temps_connexion`
--

INSERT INTO `temps_connexion` (`ID_CONNEXION`, `ID_INSPECTEUR`, `DEBUT_CONNEXION`, `FIN_CONNEXION`) VALUES
(1, 1, NULL, NULL),
(2, 2, NULL, NULL),
(3, 3, NULL, NULL),
(4, 4, NULL, NULL),
(5, 5, NULL, NULL),
(6, 6, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `type_cuisine`
--

DROP TABLE IF EXISTS `type_cuisine`;
CREATE TABLE IF NOT EXISTS `type_cuisine` (
  `ID_TYPE_CUISINE` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE_TYPE_CUISINE` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID_TYPE_CUISINE`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `type_cuisine`
--

INSERT INTO `type_cuisine` (`ID_TYPE_CUISINE`, `LIBELLE_TYPE_CUISINE`) VALUES
(1, 'Gastronomique'),
(2, 'Chinoise'),
(3, 'Rapide');

-- --------------------------------------------------------

--
-- Structure de la table `visite`
--

DROP TABLE IF EXISTS `visite`;
CREATE TABLE IF NOT EXISTS `visite` (
  `ID_VISITE` int(11) NOT NULL AUTO_INCREMENT,
  `ID_HEBERGEMENT` int(11) DEFAULT NULL,
  `ID_INSPECTEUR` int(11) DEFAULT NULL,
  `ID_SAISON` int(11) DEFAULT NULL,
  `NOMBRE_ETOILE_VISITE` smallint(6) DEFAULT NULL,
  `DATE_HEURE_VISITE` datetime DEFAULT NULL,
  `CONTRE_VISITE` tinyint(1) DEFAULT NULL,
  `COMMENTAIRE_VISITE` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `ID_CONTREVISITE` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_VISITE`),
  KEY `I_FK_VISITER_HEBERGEMENT` (`ID_HEBERGEMENT`),
  KEY `I_FK_VISITER_INSPECTEUR` (`ID_INSPECTEUR`),
  KEY `I_FK_VISITER_SAISON` (`ID_SAISON`),
  KEY `ID_CONTREVISITE` (`ID_CONTREVISITE`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `visite`
--

INSERT INTO `visite` (`ID_VISITE`, `ID_HEBERGEMENT`, `ID_INSPECTEUR`, `ID_SAISON`, `NOMBRE_ETOILE_VISITE`, `DATE_HEURE_VISITE`, `CONTRE_VISITE`, `COMMENTAIRE_VISITE`, `ID_CONTREVISITE`) VALUES
(20, 1, NULL, 1, NULL, NULL, NULL, NULL, NULL),
(21, 3, 4, 1, NULL, '2016-04-21 11:00:00', NULL, NULL, NULL),
(22, 8, 4, 1, 2, '2016-04-18 09:00:00', NULL, 'Nul !', NULL),
(23, 14, NULL, 1, NULL, NULL, NULL, NULL, NULL),
(24, 5, NULL, 1, NULL, NULL, NULL, NULL, NULL);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `avoir`
--
ALTER TABLE `avoir`
  ADD CONSTRAINT `avoir_ibfk_1` FOREIGN KEY (`ID_TYPE_CUISINE`) REFERENCES `type_cuisine` (`ID_TYPE_CUISINE`),
  ADD CONSTRAINT `avoir_ibfk_2` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hotel` (`ID_HEBERGEMENT`);

--
-- Contraintes pour la table `camping`
--
ALTER TABLE `camping`
  ADD CONSTRAINT `camping_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`);

--
-- Contraintes pour la table `chambre_hote`
--
ALTER TABLE `chambre_hote`
  ADD CONSTRAINT `chambre_hote_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`) ON DELETE CASCADE;

--
-- Contraintes pour la table `hebergement`
--
ALTER TABLE `hebergement`
  ADD CONSTRAINT `hebergement_ibfk_1` FOREIGN KEY (`ID_DEPARTEMENT`) REFERENCES `departement` (`ID_DEPARTEMENT`),
  ADD CONSTRAINT `hebergement_ibfk_2` FOREIGN KEY (`ID_GERANT`) REFERENCES `gerant` (`ID_GERANT`),
  ADD CONSTRAINT `hebergement_ibfk_3` FOREIGN KEY (`ID_SPECIALITE`) REFERENCES `specialite` (`ID_SPECIALITE`);

--
-- Contraintes pour la table `hotel`
--
ALTER TABLE `hotel`
  ADD CONSTRAINT `hotel_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`) ON DELETE CASCADE;

--
-- Contraintes pour la table `inspecteur`
--
ALTER TABLE `inspecteur`
  ADD CONSTRAINT `inspecteur_ibfk_1` FOREIGN KEY (`ID_SPECIALITE`) REFERENCES `specialite` (`ID_SPECIALITE`),
  ADD CONSTRAINT `inspecteur_ibfk_2` FOREIGN KEY (`ID_DEPARTEMENT`) REFERENCES `departement` (`ID_DEPARTEMENT`);

--
-- Contraintes pour la table `posseder`
--
ALTER TABLE `posseder`
  ADD CONSTRAINT `posseder_ibfk_1` FOREIGN KEY (`ID_EQUIPEMENT_CAMPING`) REFERENCES `equipement_camping` (`ID_EQUIPEMENT_CAMPING`),
  ADD CONSTRAINT `posseder_ibfk_2` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `camping` (`ID_HEBERGEMENT`);

--
-- Contraintes pour la table `visite`
--
ALTER TABLE `visite`
  ADD CONSTRAINT `visite_ibfk_1` FOREIGN KEY (`ID_HEBERGEMENT`) REFERENCES `hebergement` (`ID_HEBERGEMENT`),
  ADD CONSTRAINT `visite_ibfk_3` FOREIGN KEY (`ID_SAISON`) REFERENCES `saison` (`ID_SAISON`),
  ADD CONSTRAINT `visite_ibfk_4` FOREIGN KEY (`ID_INSPECTEUR`) REFERENCES `inspecteur` (`ID_INSPECTEUR`),
  ADD CONSTRAINT `visite_ibfk_5` FOREIGN KEY (`ID_CONTREVISITE`) REFERENCES `visite` (`ID_VISITE`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
