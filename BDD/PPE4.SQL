-- phpMyAdmin SQL Dump
-- version 4.5.2
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 21 Avril 2016 à 20:07
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
-- Structure de la table `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `ID_ADMIN` int(11) NOT NULL AUTO_INCREMENT,
  `NOM_ADMIN` varchar(128) COLLATE utf8_bin DEFAULT NULL,
  `PRENOM_ADMIN` varchar(128) COLLATE utf8_bin DEFAULT NULL,
  `LOGIN_ADMIN` varchar(50) COLLATE utf8_bin NOT NULL,
  `MDP_ADMIN` varchar(50) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`ID_ADMIN`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `admin`
--

INSERT INTO `admin` (`ID_ADMIN`, `NOM_ADMIN`, `PRENOM_ADMIN`, `LOGIN_ADMIN`, `MDP_ADMIN`) VALUES
(1, 'Da Silva', 'Nicolas', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997');

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
) ENGINE=InnoDB AUTO_INCREMENT=121 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `hebergement`
--

INSERT INTO `hebergement` (`ID_HEBERGEMENT`, `ID_GERANT`, `ID_DEPARTEMENT`, `NOM_HEBERGEMENT`, `ADRESSE_HEBERGEMENT`, `VILLE_HEBERGEMENT`, `HORAIRES`, `ID_SPECIALITE`) VALUES
(1, 1, 49, 'Hotel Mercure', '2 Allée Du Grand Launay', '49000 Angers', '8h - 18h', 1),
(2, 2, 49, 'BEST WESTERN', '1 Boulevard Maréchal Foch', '49100 Angers', '8h - 18h', 1),
(3, 51, 44, 'Ibis Styles', '3 rue du Couedic', '44000 Nantes', '8h - 18h', 1),
(4, 52, 44, 'Hotel F1', '155 Route De Gachet', '44300 Nantes', '8h - 18h', 1),
(5, 53, 69, 'Studio Part Dieu', '23 rue Riboud', '69003 Lyon', '8h - 18h', 1),
(6, 54, 69, 'Appart Coeur de Lyon', '72 boulevard Vivier Merle', '69003 Lyon', '8h - 18h', 1),
(7, 55, 75, 'George Washington', '43 rue Washington', '75008 Paris', '8h - 18h', 1),
(8, 51, 75, 'Opera-Louvre', 'Passage Choiseul', '75002 Paris', '8h - 18h', 1),
(9, 53, 13, 'Grand Tonic', '43 Quai des Belges', '13001 Marseille', '8h - 18h', 1),
(10, 2, 13, 'Golden Tulip', '17 Place Louis Bonnefon', '13008 Marseille', '8h - 18h', 1),
(11, 54, 31, 'Le Clocher de Rodez', '15 Place Jeanne d''Arc', '31000 Toulouse', '8h - 18h', 1),
(12, 55, 31, 'Hotel de Brienne', '20 Boulevard Maréchal Leclerc', '31000 Toulouse', '8h - 18h', 1),
(13, 1, 21, 'hotel Mercure', '22 Boulevard De la Mane', '21071 Dijon', '8h - 18h', 1),
(14, 52, 21, 'hotel Ibis', '2 avenue de Marbotte', '21000 Dijon', '8h - 18h', 1),
(15, 53, 10, 'Le Flore habitat jeunes', '23 Rue Maupertuis', '72000 Le Mans', '8h - 18h', 1),
(16, 52, 89, 'La Maison des Oliviers', '77 Chemin de Montaigu', '72000 Le Mans', '8h - 18h', 1),
(17, 51, 10, 'Centre de l''Etoile', ' 26 Rue Albert Maignan', '72000 Le Mans', '8h - 18h', 1),
(18, 55, 5, 'Hôtel de la Pommeraie', '314 Rue de l''Éventail', '72000 Le Mans', '8h - 18h', 1),
(19, 54, 89, 'Hôtel Novotel', 'Bords de l''Huisne, Bd Robert Schuman', '72100 Le Mans', '8h - 18h', 1),
(20, 1, 55, 'Le Logis de la Contrescarpe', '67 Rue de la Porte Sainte-Anne', '72000 Le Mans', '8h - 18h', 1),
(21, 51, 7, 'Cras Dolor Dolor Inc.', 'Appartement 850-5503 Lacus. Rd.', '68394 Andenne', '8h - 18h', 1),
(22, 51, 60, 'Nec Orci Consulting', '645-7033 Sed Ave', '15571 Cantal', '8h - 18h', 1),
(23, 51, 45, 'Metus Institute', 'Appartement 827-7062 Erat Avenue', '03693 Allier', '8h - 18h', 1),
(24, 51, 23, 'Amet Inc.', '6104 Lectus Impasse', '72435 Sarthe', '8h - 18h', 1),
(25, 51, 38, 'A Felis Incorporated', 'Appartement 896-458 Proin Avenue', '68860 Haut-Rhin', '8h - 18h', 1),
(26, 51, 71, 'Quisque Libero Lacus LLC', 'Appartement 791-4783 Elit, Av.', '25842 Ancenis', '8h - 18h', 1),
(27, 51, 21, 'Pede Suspendisse Dui Institute', 'Appartement 316-6086 Nam Rue', '89592 Riom', '8h - 18h', 1),
(28, 51, 13, 'Eu Sem Corporation', '3052 In Avenue', '62564 Arras', '8h - 18h', 1),
(29, 51, 55, 'Risus A LLC', 'Appartement 423-6059 Sit Impasse', '74107 Arles', '8h - 18h', 1),
(30, 51, 65, 'Eget Laoreet LLC', 'Appartement 921-5170 Ultricies Rue', '18153 Pau', '8h - 18h', 1),
(31, 51, 36, 'Morbi Non Institute', '1800 Blandit Avenue', '36200 Prades', '8h - 18h', 1),
(32, 51, 25, 'Velit Foundation', 'CP 252, 4731 Pharetra, Impasse', '57654 Corte', '8h - 18h', 1),
(33, 51, 51, 'Nullam Nisl Industries', '798-867 Enim Ave', '76531 Saverne', '8h - 18h', 1),
(34, 51, 65, 'Vitae PC', 'Appartement 784-2442 Proin Chemin', '98897 Lyon', '8h - 18h', 1),
(35, 51, 44, 'Nibh Phasellus Institute', 'Appartement 311-4149 Dolor Rue', '12569 Brignoles', '8h - 18h', 1),
(36, 51, 2, 'Imperdiet PC', '4809 Nonummy Ave', '08016 Castres', '8h - 18h', 1),
(37, 51, 38, 'Risus Nunc Company', '1562 Dignissim Chemin', '05475 Céret', '8h - 18h', 1),
(38, 51, 81, 'Dui Lectus Ltd', 'Appartement 200-3251 Sagittis Av.', '15956 Charolles', '8h - 18h', 1),
(39, 51, 3, 'Scelerisque Sed Sapien Company', 'Appartement 125-3200 Dignissim Impasse', '84455 Chaumont', '8h - 18h', 1),
(40, 51, 35, 'Dui Nec Ltd', '2647 Cursus Av.', '86566 Créteil', '8h - 18h', 1),
(41, 52, 23, 'Nec Urna Limited', '895-4952 Sit Av.', '50004 Cholet', '8h - 18h', 2),
(42, 52, 67, 'Convallis Ligula Donec Inc.', '9765 At Avenue', '97735 Cognac', '8h - 18h', 2),
(43, 52, 66, 'Scelerisque Industries', 'Appartement 978-1179 Aliquet Rd.', '14869 Chinon', '8h - 18h', 2),
(44, 52, 61, 'Odio Company', 'CP 855, 250 Commodo Rd.', '98940 Verdun', '8h - 18h', 2),
(45, 52, 84, 'Scelerisque Neque PC', 'CP 481, 7669 Facilisis. Impasse', '65656 Vannes', '8h - 18h', 2),
(46, 52, 50, 'Mollis Ltd', '5991 Accumsan Route', '69438 Ussel', '8h - 18h', 2),
(47, 52, 29, 'Turpis Vitae Purus Ltd', '497-2018 Sagittis Ave', '40308 Vichy', '8h - 18h', 2),
(48, 52, 25, 'Consequat Dolor Vitae Inc.', '370-4979 Quam Impasse', '64209 Versailles', '8h - 18h', 2),
(49, 52, 38, 'Enim Incorporated', 'CP 143, 7781 Nunc, Rue', '31422 Vitré', '8h - 18h', 2),
(50, 52, 44, 'Arcu Nunc LLP', 'Appartement 517-3388 Auctor Ave', '94060 Vire', '8h - 18h', 2),
(51, 52, 42, 'Nunc Associates', '918 In Impasse', '01271 Nontron', '8h - 18h', 2),
(52, 52, 79, 'Non Associates', 'Appartement 768-1987 Lorem. Route', '39834 Nyons', '8h - 18h', 2),
(53, 52, 26, 'Ut Aliquam Iaculis LLC', '780-5221 Donec Rue', '70367 Dieppe', '8h - 18h', 2),
(54, 52, 78, 'Elit Pharetra LLC', 'CP 548, 6119 Curae; Av.', '37222 Die', '8h - 18h', 2),
(55, 52, 43, 'Phasellus At Augue Consulting', '829-7270 Magnis Av.', '69373 Dax', '8h - 18h', 2),
(56, 52, 71, 'Vitae Odio Company', 'Appartement 323-8876 Sed, Rue', '33178 Niort', '8h - 18h', 2),
(57, 52, 25, 'Dolor Dapibus Industries', '769-3515 Vestibulum Avenue', '00517 Muret', '8h - 18h', 2),
(58, 52, 31, 'Dis Parturient Montes Industries', 'CP 341, 9746 Purus. Avenue', '88163 Trinité', '8h - 18h', 2),
(59, 52, 29, 'Nibh Associates', 'Appartement 234-1330 Fusce Impasse', '95463 Saumur', '8h - 18h', 2),
(60, 52, 78, 'Dictum Augue Malesuada Foundation', '619-3980 Convallis Impasse', '27209 Sartène', '8h - 18h', 2),
(61, 53, 78, 'Tincidunt Nibh Phasellus Company', 'Appartement 543-149 Semper Av.', '58874 Lodève', '8h - 18h', 2),
(62, 53, 76, 'In Associates', '1252 Mauris, Ave', '09018 Loches', '8h - 18h', 2),
(63, 53, 1, 'Convallis Foundation', 'Appartement 709-6345 Pede, Avenue', '97305 Aube', '8h - 18h', 2),
(64, 53, 66, 'Neque Sed LLP', '553-7057 Proin Impasse', '73856 Bastia', '8h - 18h', 2),
(65, 53, 9, 'Nunc Mauris Elit Limited', '706-1260 Donec Chemin', '83850 Bellay', '8h - 18h', 2),
(66, 53, 77, 'Imperdiet Ullamcorper Duis Corporation', 'CP 475, 7172 Pharetra, Rue', '51526 Blaye', '8h - 18h', 2),
(67, 53, 50, 'Ut PC', '9972 Vestibulum Av.', '76630 Lille', '8h - 18h', 2),
(68, 53, 14, 'Eget Metus Limited', 'CP 881, 5812 Mi Avenue', '30144 Strasbourg', '8h - 18h', 2),
(69, 53, 35, 'Donec At Arcu Institute', 'CP 963, 144 Enim. Chemin', '42603 Bayonne', '8h - 18h', 2),
(70, 53, 16, 'In Ornare Ltd', 'CP 766, 3288 Cubilia Av.', '60203 Issoire', '8h - 18h', 2),
(71, 53, 55, 'Malesuada Fames Ac Incorporated', '9580 Massa. Route', '66665 Riom', '8h - 18h', 2),
(72, 53, 82, 'Convallis LLC', '882-1132 Sociis Route', '80454 Roanne', '8h - 18h', 2),
(73, 53, 39, 'Sem Associates', 'Appartement 837-8823 Nec Ave', '72260 Loire', '8h - 18h', 2),
(74, 53, 15, 'Lacus Vestibulum Lorem Company', 'CP 941, 9792 Vitae Rue', '85421 Montreuil', '8h - 18h', 2),
(75, 53, 73, 'Tristique Corp.', '817-2576 Nisi. Ave', '50960 Seiches', '8h - 18h', 2),
(76, 53, 74, 'Felis Ullamcorper Ltd', 'Appartement 837-9629 Sit Route', '96679 Cheffes', '8h - 18h', 2),
(77, 53, 85, 'Curae; Donec PC', 'CP 754, 640 Nulla Avenue', '27583 Ecuillé', '8h - 18h', 2),
(78, 53, 71, 'Amet Lorem PC', '953-7193 Et Impasse', '03572 Chateauneuf', '8h - 18h', 2),
(79, 53, 7, 'Libero Dui Ltd', '1264 Vel Rue', '86280 Lens', '8h - 18h', 2),
(80, 53, 13, 'Ornare Lectus Corp.', '133-283 Ultrices. Rue', '00527 Laon', '8h - 18h', 2),
(81, 54, 74, 'Sed Dolor LLC', '8018 Id, Chemin', '69716 Saumur', '8h - 18h', 3),
(82, 54, 90, 'Aenean Company', '1146 Dictum Chemin', '73134 Sartène', '8h - 18h', 3),
(83, 54, 27, 'Dictum Eleifend Nunc Inc.', 'CP 993, 3351 Aliquam Ave', '79970 Brioude', '8h - 18h', 3),
(84, 54, 56, 'Mi Corporation', 'Appartement 460-3632 Mi, Av.', '49137 Briey', '8h - 18h', 3),
(85, 54, 87, 'Metus Corp.', 'Appartement 280-5277 Donec Impasse', '22675 Guingamps', '8h - 18h', 3),
(86, 54, 66, 'Dui Quis Accumsan PC', 'CP 625, 1169 Per Av.', '13885 Tiercé', '8h - 18h', 3),
(87, 54, 34, 'Mi Inc.', '7053 Leo, Rue', '87954 Lodève', '8h - 18h', 3),
(88, 54, 81, 'Erat Vel Industries', 'CP 260, 9380 Turpis. Chemin', '77002 Brest', '8h - 18h', 3),
(89, 54, 14, 'Quis Diam Incorporated', '488-289 Ornare Rd.', '21214 Blois', '8h - 18h', 3),
(90, 54, 18, 'Ornare Sagittis Consulting', '6937 Luctus. Ave', '65443 Lô', '8h - 18h', 3),
(91, 54, 53, 'Semper Limited', 'CP 753, 8385 Libero Impasse', '28887 Quimper', '8h - 18h', 3),
(92, 54, 22, 'Ullamcorper Corp.', 'Appartement 880-1664 Non, Impasse', '44401 Privas', '8h - 18h', 3),
(93, 54, 61, 'Rutrum LLC', 'CP 328, 6592 Amet Ave', '60488 Autun', '8h - 18h', 3),
(94, 54, 16, 'Euismod In LLC', 'Appartement 349-1926 Ridiculus Impasse', '11853 Aix', '8h - 18h', 3),
(95, 54, 81, 'Ut Quam Vel LLP', 'CP 924, 7228 Et, Ave', '41860 Ain', '8h - 18h', 3),
(96, 54, 5, 'Et Ultrices LLC', 'Appartement 609-4124 Ipsum Rue', '63079 Peronne', '8h - 18h', 3),
(97, 54, 28, 'Sed Consulting', 'Appartement 586-130 Enim Rue', '52104 Epinal', '8h - 18h', 3),
(98, 54, 13, 'Adipiscing Mauris Molestie Corp.', 'CP 851, 7997 Parturient Av.', '69930 Lyon', '8h - 18h', 3),
(99, 54, 52, 'Sed Industries', 'Appartement 692-648 Nisi. Ave', '45130 Loiret', '8h - 18h', 3),
(100, 54, 54, 'Lorem Incorporated', '2897 Et, Av.', '92746 Paris', '8h - 18h', 3),
(101, 55, 28, 'Magnis Dis Company', '144 Sit Av.', '91646 Paris', '8h - 18h', 3),
(102, 55, 4, 'Donec Non Associates', '1063 Nam Avenue', '65055 Alès', '8h - 18h', 3),
(103, 55, 30, 'Mi Lorem Vehicula Corp.', 'Appartement 313-628 Egestas. Rd.', '49322 Maine-et-loire', '8h - 18h', 3),
(104, 55, 56, 'Nulla Cras Incorporated', '725-6610 Aliquet Chemin', '07948 Pau', '8h - 18h', 3),
(105, 55, 46, 'Quisque Porttitor Eros Associates', 'CP 599, 5167 Vehicula. Ave', '65238 Rambouillet', '8h - 18h', 3),
(106, 55, 18, 'Nulla Eu LLP', 'CP 306, 262 Ipsum Av.', '13830 Bergerac', '8h - 18h', 3),
(107, 55, 58, 'Et Magna Industries', 'CP 788, 680 Nisl. Impasse', '92625 Langon', '8h - 18h', 3),
(108, 55, 15, 'Lorem Lorem Luctus Corporation', 'CP 622, 3939 Quam. Route', '48985 Rethel', '8h - 18h', 3),
(109, 55, 1, 'Quis Ltd', 'Appartement 754-4857 Libero. Impasse', '25775 Marseille', '8h - 18h', 3),
(110, 55, 68, 'Quisque Incorporated', 'Appartement 533-5769 Molestie Route', '34649 Grenoble', '8h - 18h', 3),
(111, 55, 31, 'Quis Diam Luctus Institute', '8466 Amet Av.', '10269 Arras', '8h - 18h', 3),
(112, 55, 79, 'Vulputate Incorporated', '3672 Enim. Avenue', '69658 Belfort', '8h - 18h', 3),
(113, 55, 21, 'Velit Sed Malesuada Foundation', 'CP 955, 6070 Tellus. Av.', '30454 Apt', '8h - 18h', 3),
(114, 55, 48, 'A Ltd', 'Appartement 476-2023 Quam, Chemin', '15856 Péronne', '8h - 18h', 3),
(115, 55, 87, 'Scelerisque Neque LLP', 'Appartement 192-2887 Velit. Av.', '64399 Pontoise', '8h - 18h', 3),
(116, 55, 41, 'Penatibus Inc.', '672-2649 Dapibus Rue', '83306 Forbach', '8h - 18h', 3),
(117, 55, 47, 'Dictum LLP', 'CP 651, 8431 Egestas. Chemin', '86590 Saint Flour', '8h - 18h', 3),
(118, 55, 4, 'Velit Foundation', 'CP 357, 8234 Nibh Chemin', '32482 La Rochelle', '8h - 18h', 3),
(119, 55, 76, 'Nullam Feugiat Placerat Limited', 'Appartement 683-633 Libero Rue', '29381 Auvergne', '8h - 18h', 3),
(120, 55, 19, 'Sem Institute', '307 A Chemin', '08001 Bordeaux', '8h - 18h', 3);

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
(14, NULL, NULL),
(16, 1, 'Grondin'),
(17, 1, 'Natacha'),
(18, 1, 'Pierre'),
(19, 1, 'Pierre'),
(20, 1, 'Jamain');

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
  `TEMPS_CONNEXION` bigint(255) NOT NULL,
  `ID_DEPARTEMENT` int(11) DEFAULT NULL,
  `DATE_NAISSANCE` date DEFAULT NULL,
  `NATIONALITE` varchar(30) NOT NULL,
  PRIMARY KEY (`ID_INSPECTEUR`),
  KEY `I_FK_INSPECTEUR_SPECIALITE` (`ID_SPECIALITE`),
  KEY `LIBELLE_DEPARTEMENT` (`ID_DEPARTEMENT`),
  KEY `ID_DEPARTEMENT` (`ID_DEPARTEMENT`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `inspecteur`
--

INSERT INTO `inspecteur` (`ID_INSPECTEUR`, `ID_SPECIALITE`, `NOM_INSPECTEUR`, `PERNOM_INSPECTEUR`, `LOGIN`, `MDP`, `PHOTO`, `TEMPS_CONNEXION`, `ID_DEPARTEMENT`, `DATE_NAISSANCE`, `NATIONALITE`) VALUES
(1, 1, 'Kadera', 'Tata', 'NGrondin', 'c6c4940b323ff81c66e02a02e0281c370c535008', 'PDP/NG.png', 800000000, 49, '1971-01-01', 'Mexicaine'),
(2, 2, 'Bouhours', 'Natacha', 'NBouhours', 'c6c4940b323ff81c66e02a02e0281c370c535008', 'PDP/NB.jpg', 0, 49, '1996-12-05', 'Française'),
(3, 3, 'Da Silva', 'Nicolas', 'NDSilva', 'c6c4940b323ff81c66e02a02e0281c370c535008', 'PDP/NDS.jpg', 0, 49, '1995-05-30', 'Française'),
(4, 1, 'Robin', 'Dimitry', 'Drobin', 'f356a267d8cd8a5f8b3d4ac4164a5ed1a101603f', 'PDP/DR.jpg', 6556595674445, 49, '1996-11-03', 'Française'),
(5, 2, 'Hermange', 'Pierre', 'PHermange', 'c6c4940b323ff81c66e02a02e0281c370c535008', 'PDP/PH.jpg', 0, 49, '1997-02-02', 'Française'),
(6, 3, 'Menant', 'Kévin', 'KMenant', 'c6c4940b323ff81c66e02a02e0281c370c535008', 'PDP/KM.jpg', 0, 49, '1995-10-05', 'Française');

--
-- Déclencheurs `inspecteur`
--
DROP TRIGGER IF EXISTS `after_insert_inspecteur`;
DELIMITER $$
CREATE TRIGGER `after_insert_inspecteur` AFTER INSERT ON `inspecteur` FOR EACH ROW BEGIN
	INSERT INTO temps_connexion (id_inspecteur) VALUES (new.id_inspecteur);
END
$$
DELIMITER ;

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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `saison`
--

INSERT INTO `saison` (`ID_SAISON`, `LIBELLE_SAISON`) VALUES
(1, 'Hiver 2016'),
(2, 'Printemps 2016'),
(3, 'Eté 2016'),
(4, 'Automne 2016'),
(5, 'Printemps 2019'),
(6, 'Hiver 2017');

--
-- Déclencheurs `saison`
--
DROP TRIGGER IF EXISTS `before_insert_saison`;
DELIMITER $$
CREATE TRIGGER `before_insert_saison` BEFORE INSERT ON `saison` FOR EACH ROW BEGIN
	IF EXISTS(SELECT LIBELLE_SAISON FROM saison where LIBELLE_SAISON = new.LIBELLE_SAISON)
    THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Deja existant';
    END IF;
END
$$
DELIMITER ;

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
  KEY `ifk_ID_INSPECTEUR` (`ID_INSPECTEUR`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `temps_connexion`
--

INSERT INTO `temps_connexion` (`ID_CONNEXION`, `ID_INSPECTEUR`, `DEBUT_CONNEXION`, `FIN_CONNEXION`) VALUES
(1, 1, '2016-04-21 09:06:07', '2016-04-21 09:07:27'),
(2, 2, NULL, NULL),
(3, 3, NULL, NULL),
(4, 4, '2016-04-21 09:40:43', '2016-04-21 09:40:53'),
(5, 5, NULL, NULL),
(6, 6, '2016-04-20 21:39:33', '2016-04-20 21:39:45');

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
) ENGINE=InnoDB AUTO_INCREMENT=121 DEFAULT CHARSET=latin1;

--
-- Contenu de la table `visite`
--

INSERT INTO `visite` (`ID_VISITE`, `ID_HEBERGEMENT`, `ID_INSPECTEUR`, `ID_SAISON`, `NOMBRE_ETOILE_VISITE`, `DATE_HEURE_VISITE`, `CONTRE_VISITE`, `COMMENTAIRE_VISITE`, `ID_CONTREVISITE`) VALUES
(1, 1, NULL, 2, NULL, NULL, NULL, NULL, NULL),
(2, 2, NULL, 1, NULL, NULL, NULL, NULL, NULL),
(3, 3, 4, 1, 3, '2016-04-18 14:30:00', NULL, 'placerat eget,', NULL),
(4, 4, 4, 3, 4, '2016-04-19 09:00:00', NULL, 'eget, dictum placerat, augue. Sed molestie. Sed', NULL),
(5, 5, 4, 5, 5, '2016-04-19 13:30:00', NULL, 'massa non ante bibendum ullamcorper. Duis cursus, diam', NULL),
(6, 6, 4, 2, 1, '2016-04-19 17:00:00', NULL, 'montes, nascetur ridiculus', NULL),
(7, 7, 4, 4, 4, '2016-04-20 08:00:00', NULL, 'arcu. Vestibulum ante ipsum primis in', NULL),
(8, 8, 4, 2, NULL, '2016-04-20 15:30:00', NULL, NULL, NULL),
(9, 9, 4, 4, NULL, '2016-04-21 10:00:00', NULL, NULL, NULL),
(10, 10, 4, 2, 2, '2016-04-21 13:00:00', NULL, 'odio. Phasellus at augue id ante dictum cursus.', NULL),
(11, 11, 4, 6, 1, '2016-04-22 09:00:00', NULL, 'Super bien!', NULL),
(12, 12, 4, 3, 1, '2016-04-22 12:30:00', NULL, 'Sed pharetra, felis eget varius ultrices, mauris ipsum porta', NULL),
(13, 13, 4, 6, 4, '2016-04-22 17:00:00', NULL, 'nisl arcu iaculis enim,', NULL),
(14, 14, 4, 6, 3, '2016-04-23 10:00:00', NULL, 'vestibulum lorem,', NULL),
(15, 15, 4, 4, 3, '2016-04-25 12:00:00', NULL, 'consectetuer ipsum nunc id', NULL),
(16, 16, 4, 1, 4, '2016-04-25 15:00:00', NULL, 'Donec tempus, lorem fringilla', NULL),
(17, 17, 4, 2, 4, '2016-04-25 17:30:00', NULL, 'orci luctus et ultrices', NULL),
(18, 18, 4, 4, 5, '2016-04-26 08:00:00', NULL, 'a neque. Nullam', NULL),
(19, 19, 4, 3, 3, '2016-04-26 15:00:00', NULL, 'justo. Proin non massa non ante bibendum ullamcorper. Duis', NULL),
(20, 20, 4, 3, 3, '2016-04-27 13:00:00', NULL, 'Proin velit. Sed malesuada augue ut lacus.', NULL),
(21, 21, NULL, 3, NULL, NULL, NULL, NULL, NULL),
(22, 22, NULL, 5, NULL, NULL, NULL, NULL, NULL),
(23, 23, 1, 1, 2, '2016-04-18 14:30:00', NULL, 'non, lobortis', NULL),
(24, 24, 1, 2, 5, '2016-04-19 09:00:00', NULL, 'Donec elementum, lorem', NULL),
(25, 25, 1, 3, 1, '2016-04-19 13:30:00', NULL, 'semper auctor. Mauris vel', NULL),
(26, 26, 1, 3, 1, '2016-04-19 17:00:00', NULL, 'tristique pellentesque, tellus sem', NULL),
(27, 27, 1, 4, 3, '2016-04-20 08:00:00', NULL, 'neque. Nullam nisl. Maecenas malesuada fringilla est. Mauris eu', NULL),
(28, 28, 1, 6, NULL, '2016-04-20 15:30:00', NULL, NULL, NULL),
(29, 29, 1, 5, NULL, '2016-04-21 10:00:00', NULL, NULL, NULL),
(30, 30, 1, 4, 1, '2016-04-21 13:00:00', NULL, 'Aliquam ornare, libero at auctor ullamcorper, nisl arcu iaculis', NULL),
(31, 31, 1, 2, 4, '2016-04-22 09:00:00', NULL, 'sollicitudin adipiscing ligula.', NULL),
(32, 32, 1, 5, 5, '2016-04-22 12:30:00', NULL, 'hendrerit consectetuer, cursus et, magna. Praesent interdum', NULL),
(33, 33, 1, 3, 3, '2016-04-22 17:00:00', NULL, 'sem elit, pharetra ut, pharetra sed,', NULL),
(34, 34, 1, 3, 2, '2016-04-23 10:00:00', NULL, 'nec tempus', NULL),
(35, 35, 1, 3, 3, '2016-04-25 12:00:00', NULL, 'Nuuul', NULL),
(36, 36, 1, 6, 1, '2016-04-25 15:00:00', NULL, 'pede,', NULL),
(37, 37, 1, 4, 4, '2016-04-25 17:30:00', NULL, 'Maecenas iaculis aliquet diam.', NULL),
(38, 38, 1, 1, 3, '2016-04-26 08:00:00', NULL, 'In at pede. Cras vulputate velit', NULL),
(39, 39, 1, 1, 3, '2016-04-26 15:00:00', NULL, 'erat. Vivamus nisi. Mauris', NULL),
(40, 40, 1, 1, 1, '2016-04-27 13:00:00', NULL, 'amet, consectetuer adipiscing', NULL),
(41, 41, NULL, 5, NULL, NULL, NULL, NULL, NULL),
(42, 42, NULL, 6, NULL, NULL, NULL, NULL, NULL),
(43, 43, 5, 6, 4, '2016-04-18 14:30:00', NULL, 'risus varius orci, in consequat enim diam vel', NULL),
(44, 44, 5, 2, 5, '2016-04-19 09:00:00', NULL, 'id, mollis nec, cursus a, enim. Suspendisse aliquet, sem ut', NULL),
(45, 45, 5, 1, 4, '2016-04-19 13:30:00', NULL, 'parturient', NULL),
(46, 46, 5, 1, 1, '2016-04-19 17:00:00', NULL, 'gravida. Praesent eu nulla', NULL),
(47, 47, 5, 2, 1, '2016-04-20 08:00:00', NULL, 'sociis natoque penatibus et magnis dis parturient montes,', NULL),
(48, 48, 5, 3, NULL, '2016-04-20 15:30:00', NULL, NULL, NULL),
(49, 49, 5, 4, NULL, '2016-04-21 10:00:00', NULL, NULL, NULL),
(50, 50, 5, 4, 2, '2016-04-21 13:00:00', NULL, 'ligula. Nullam feugiat placerat velit. Quisque varius. Nam porttitor', NULL),
(51, 51, 5, 1, 3, '2016-04-22 09:00:00', NULL, 'enim, condimentum eget, volutpat ornare, facilisis eget, ipsum. Donec sollicitudin', NULL),
(52, 52, 5, 6, 4, '2016-04-22 12:30:00', NULL, 'purus gravida', NULL),
(53, 53, 5, 2, 5, '2016-04-22 17:00:00', NULL, 'ac, fermentum vel, mauris. Integer sem elit,', NULL),
(54, 54, 5, 3, 3, '2016-04-23 10:00:00', NULL, 'consectetuer', NULL),
(55, 55, 5, 5, 2, '2016-04-25 12:00:00', NULL, 'consectetuer, cursus et,', NULL),
(56, 56, 5, 5, 5, '2016-04-25 15:00:00', NULL, 'purus, in molestie tortor nibh', NULL),
(57, 57, 5, 6, 5, '2016-04-25 17:30:00', NULL, 'Nam nulla magna, malesuada vel, convallis in, cursus et,', NULL),
(58, 58, 5, 5, 1, '2016-04-26 08:00:00', NULL, 'risus. Donec egestas. Aliquam nec', NULL),
(59, 59, 5, 2, 2, '2016-04-26 15:00:00', NULL, 'blandit', NULL),
(60, 60, 5, 1, 1, '2016-04-27 13:00:00', NULL, 'mattis. Integer eu lacus.', NULL),
(61, 61, NULL, 1, NULL, NULL, NULL, NULL, NULL),
(62, 62, NULL, 6, NULL, NULL, NULL, NULL, NULL),
(63, 63, 2, 2, 2, '2016-04-18 14:30:00', NULL, 'lacinia mattis. Integer', NULL),
(64, 64, 2, 4, 3, '2016-04-19 09:00:00', NULL, 'ornare tortor at risus. Nunc ac sem ut', NULL),
(65, 65, 2, 3, 1, '2016-04-19 13:30:00', NULL, 'D''accord..', NULL),
(66, 66, 2, 6, 5, '2016-04-19 17:00:00', NULL, 'aliquet, metus urna convallis erat, eget tincidunt', NULL),
(67, 67, 2, 2, 3, '2016-04-20 08:00:00', NULL, 'Vivamus molestie dapibus ligula.', NULL),
(68, 68, 2, 3, NULL, '2016-04-20 15:30:00', NULL, NULL, NULL),
(69, 69, 2, 1, NULL, '2016-04-21 10:00:00', NULL, NULL, NULL),
(70, 70, 2, 1, 5, '2016-04-21 13:00:00', NULL, 'vitae, orci. Phasellus', NULL),
(71, 71, 2, 6, 5, '2016-04-22 09:00:00', NULL, 'diam at pretium aliquet, metus urna convallis erat, eget tincidunt', NULL),
(72, 72, 2, 1, 4, '2016-04-22 12:30:00', NULL, 'pede. Nunc sed orci lobortis augue', NULL),
(73, 73, 2, 4, 4, '2016-04-22 17:00:00', NULL, 'justo faucibus lectus, a sollicitudin', NULL),
(74, 74, 2, 1, 2, '2016-04-23 10:00:00', NULL, 'amet, consectetuer adipiscing elit. Curabitur', NULL),
(75, 75, 2, 2, 2, '2016-04-25 12:00:00', NULL, 'dapibus', NULL),
(76, 76, 2, 5, 5, '2016-04-25 15:00:00', NULL, 'pretium', NULL),
(77, 77, 2, 4, 5, '2016-04-25 17:30:00', NULL, 'lorem ut aliquam iaculis, lacus pede sagittis', NULL),
(78, 78, 2, 6, 3, '2016-04-26 08:00:00', NULL, 'dui nec urna', NULL),
(79, 79, 2, 3, 5, '2016-04-26 15:00:00', NULL, 'mi felis, adipiscing fringilla,', NULL),
(80, 80, 2, 5, 2, '2016-04-27 13:00:00', NULL, 'sodales elit', NULL),
(81, 81, NULL, 1, NULL, NULL, NULL, NULL, NULL),
(82, 82, NULL, 6, NULL, NULL, NULL, NULL, NULL),
(83, 83, 6, 4, 4, '2016-04-18 14:30:00', NULL, 'Quisque ornare tortor at risus. Nunc', NULL),
(84, 84, 6, 6, 2, '2016-04-19 09:00:00', NULL, 'rutrum eu, ultrices sit amet, risus. Donec nibh', NULL),
(85, 85, 6, 6, 3, '2016-04-19 13:30:00', NULL, 'non dui nec urna suscipit nonummy. Fusce fermentum fermentum arcu.', NULL),
(86, 86, 6, 2, 5, '2016-04-19 17:00:00', NULL, 'fringilla mi lacinia mattis. Integer eu lacus.', NULL),
(87, 87, 6, 4, 5, '2016-04-20 08:00:00', NULL, 'tristique senectus et netus et malesuada', NULL),
(88, 88, 6, 4, NULL, '2016-04-20 15:30:00', NULL, NULL, NULL),
(89, 89, 6, 1, NULL, '2016-04-21 10:00:00', NULL, NULL, NULL),
(90, 90, 6, 3, 4, '2016-04-21 13:00:00', NULL, 'faucibus orci luctus et ultrices posuere cubilia Curae;', NULL),
(91, 91, 6, 2, 3, '2016-04-22 09:00:00', NULL, 'ad litora torquent', NULL),
(92, 92, 6, 4, 4, '2016-04-22 12:30:00', NULL, 'vitae, orci. Phasellus dapibus quam quis', NULL),
(93, 93, 6, 2, 3, '2016-04-22 17:00:00', NULL, 'tincidunt congue turpis. In condimentum. Donec at arcu.', NULL),
(94, 94, 6, 1, 2, '2016-04-23 10:00:00', NULL, 'lacus. Mauris non dui nec urna suscipit nonummy. Fusce fermentum', NULL),
(95, 95, 6, 6, 3, '2016-04-25 12:00:00', NULL, 'mauris a nunc. In at', NULL),
(96, 96, 6, 2, 2, '2016-04-25 15:00:00', NULL, 'malesuada ut, sem. Nulla interdum. Curabitur', NULL),
(97, 97, 6, 4, 4, '2016-04-25 17:30:00', NULL, 'neque. In ornare sagittis felis. Donec tempor, est ac mattis', NULL),
(98, 98, 6, 4, 2, '2016-04-26 08:00:00', NULL, 'feugiat metus sit amet ante. Vivamus non lorem vitae', NULL),
(99, 99, 6, 1, 4, '2016-04-26 15:00:00', NULL, 'porttitor scelerisque', NULL),
(100, 100, 6, 1, 3, '2016-04-27 13:00:00', NULL, 'Curabitur dictum. Phasellus in felis. Nulla tempor augue', NULL),
(101, 101, NULL, 2, NULL, NULL, NULL, NULL, NULL),
(102, 102, NULL, 1, NULL, NULL, NULL, NULL, NULL),
(103, 103, 3, 1, 3, '2016-04-18 14:30:00', NULL, 'placerat eget,', NULL),
(104, 104, 3, 3, 4, '2016-04-19 09:00:00', NULL, 'eget, dictum placerat, augue. Sed molestie. Sed', NULL),
(105, 105, 3, 5, 5, '2016-04-19 13:30:00', NULL, 'massa non ante bibendum ullamcorper. Duis cursus, diam', NULL),
(106, 106, 3, 2, 1, '2016-04-19 17:00:00', NULL, 'montes, nascetur ridiculus', NULL),
(107, 107, 3, 4, 4, '2016-04-20 08:00:00', NULL, 'arcu. Vestibulum ante ipsum primis in', NULL),
(108, 108, 3, 2, NULL, '2016-04-20 15:30:00', NULL, NULL, NULL),
(109, 109, 3, 4, NULL, '2016-04-21 10:00:00', NULL, NULL, NULL),
(110, 110, 3, 2, 2, '2016-04-21 13:00:00', NULL, 'odio. Phasellus at augue id ante dictum cursus.', NULL),
(111, 111, 3, 6, 1, '2016-04-22 09:00:00', NULL, 'Vraiment Nul ..', NULL),
(112, 112, 3, 3, 1, '2016-04-22 12:30:00', NULL, 'Sed pharetra, felis eget varius ultrices, mauris ipsum porta', NULL),
(113, 113, 3, 6, 4, '2016-04-22 17:00:00', NULL, 'nisl arcu iaculis enim,', NULL),
(114, 114, 3, 6, 3, '2016-04-23 10:00:00', NULL, 'vestibulum lorem,', NULL),
(115, 115, 3, 4, 3, '2016-04-25 12:00:00', NULL, 'consectetuer ipsum nunc id', NULL),
(116, 116, 3, 1, 4, '2016-04-25 15:00:00', NULL, 'Donec tempus, lorem fringilla', NULL),
(117, 117, 3, 2, 4, '2016-04-25 17:30:00', NULL, 'orci luctus et ultrices', NULL),
(118, 118, 3, 4, 5, '2016-04-26 08:00:00', NULL, 'a neque. Nullam', NULL),
(119, 119, 3, 3, 3, '2016-04-26 15:00:00', NULL, 'justo. Proin non massa non ante bibendum ullamcorper. Duis', NULL),
(120, 120, 3, 3, 3, '2016-04-27 13:00:00', NULL, 'Proin velit. Sed malesuada augue ut lacus.', NULL);

--
-- Contraintes pour les tables exportées
--

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
-- Contraintes pour la table `temps_connexion`
--
ALTER TABLE `temps_connexion`
  ADD CONSTRAINT `temps_connexion_ibfk_1` FOREIGN KEY (`ID_INSPECTEUR`) REFERENCES `inspecteur` (`ID_INSPECTEUR`) ON DELETE CASCADE;

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
