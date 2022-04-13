-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 13 avr. 2022 à 08:10
-- Version du serveur : 10.4.24-MariaDB
-- Version de PHP : 7.4.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mon_espace_sante`
--

-- --------------------------------------------------------

--
-- Structure de la table `agenda`
--

CREATE TABLE `agenda` (
  `Id_Agenda` int(11) NOT NULL,
  `Doc_id` int(255) NOT NULL,
  `Age_Pat` int(255) NOT NULL,
  `Sexe` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `Taille_Pat` varchar(255) NOT NULL,
  `Poids_Pat` varchar(255) NOT NULL,
  `Maladie_Pat` varchar(255) NOT NULL,
  `Alergie_Pat` varchar(255) NOT NULL,
  `Medicament_Pat` varchar(255) NOT NULL,
  `Medecin_Pat` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `agenda`
--

INSERT INTO `agenda` (`Id_Agenda`, `Doc_id`, `Age_Pat`, `Sexe`, `email`, `Taille_Pat`, `Poids_Pat`, `Maladie_Pat`, `Alergie_Pat`, `Medicament_Pat`, `Medecin_Pat`) VALUES
(3, 20220002, 24, 'Homme', 'tahar@hotmail.fr', '180', '81', 'Urinaire', 'pollen', 'GP 200 ml', 'Elyas AMROUCHE'),
(5, 0, 25, 'Femme', 'fatma@gmail.com', '', '', '', '', '', ''),
(8, 0, 24, 'Femme', 'melanie@gmail.com', '160', '60', '', '', '', '');

-- --------------------------------------------------------

--
-- Structure de la table `bloodgroup`
--

CREATE TABLE `bloodgroup` (
  `bg_id` int(11) NOT NULL,
  `bg_name` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `bloodgroup`
--

INSERT INTO `bloodgroup` (`bg_id`, `bg_name`) VALUES
(1, 'O+'),
(2, 'O-'),
(3, 'AB+'),
(4, 'AB-'),
(5, 'A+'),
(6, 'A-'),
(7, 'B+'),
(8, 'B-');

-- --------------------------------------------------------

--
-- Structure de la table `booking`
--

CREATE TABLE `booking` (
  `booking_id` int(22) NOT NULL,
  `dname` varchar(22) NOT NULL,
  `userid` int(22) NOT NULL,
  `dcontact` varchar(22) NOT NULL,
  `expertise` varchar(22) NOT NULL,
  `fee` varchar(22) NOT NULL,
  `pname` varchar(22) NOT NULL,
  `pcontact` varchar(22) NOT NULL,
  `email` varchar(111) NOT NULL,
  `address` varchar(22) NOT NULL,
  `dates` date NOT NULL,
  `tyme` varchar(22) NOT NULL,
  `payment` varchar(22) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `booking`
--

INSERT INTO `booking` (`booking_id`, `dname`, `userid`, `dcontact`, `expertise`, `fee`, `pname`, `pcontact`, `email`, `address`, `dates`, `tyme`, `payment`) VALUES
(2, 'Daniel GERI', 20220003, '0767911911', 'Rhumatologie', '80', 'ELYAS AMROUCHE', '0667911910', 'elyas@gmail.com', 'Villejuif', '2022-04-13', '11.00am', 'Cash'),
(9, 'Elyas AMROUCHE', 20220002, '0667911910', 'Cardiologie', '120', 'TAHAR AMROUCHE', '0667911910', 'tahar@hotmail.fr', '49 Avenu de paris', '2022-04-14', '03.00pm', 'Carte bancaire');

-- --------------------------------------------------------

--
-- Structure de la table `category`
--

CREATE TABLE `category` (
  `id` int(22) NOT NULL,
  `cat` varchar(22) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `category`
--

INSERT INTO `category` (`id`, `cat`) VALUES
(1, 'Medicine'),
(2, 'Heart'),
(3, 'Bone'),
(4, 'Kedney'),
(5, 'Cardiologist'),
(6, 'Plastic Surgeon'),
(7, 'General Physician'),
(8, 'Neurologist');

-- --------------------------------------------------------

--
-- Structure de la table `consultation`
--

CREATE TABLE `consultation` (
  `Id_con` int(11) NOT NULL,
  `Id_Pat` int(11) NOT NULL,
  `Date_Cons` date NOT NULL,
  `Type_Cons` int(11) NOT NULL,
  `Heure` time NOT NULL,
  `poids` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `Prix` float NOT NULL,
  `Observation` varchar(1000) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `consultation`
--

INSERT INTO `consultation` (`Id_con`, `Id_Pat`, `Date_Cons`, `Type_Cons`, `Heure`, `poids`, `Prix`, `Observation`) VALUES
(27, 34, '2019-02-11', 0, '16:47:00', '90', 200, 'iuysdiub SHSD sdis'),
(28, 35, '2019-02-11', 1, '16:53:00', '12', 0, 'ds'),
(29, 34, '2019-02-11', 1, '16:56:00', '98', 0, 'dsd'),
(30, 36, '2019-02-11', 0, '17:30:00', '150 KG', 300, 'fdsf'),
(31, 37, '2019-02-11', 1, '17:32:00', '70', 0, 'ds'),
(32, 0, '1970-01-01', 0, '19:24:00', '', 0, ''),
(33, 37, '1970-01-01', 0, '11:54:00', '', 0, ''),
(34, 38, '2019-02-17', 0, '12:04:00', '45', 300, 'jdd dd sq '),
(44, 44, '2019-02-18', 0, '17:57:00', '60kg', 300, 'votre observation');

-- --------------------------------------------------------

--
-- Structure de la table `contact`
--

CREATE TABLE `contact` (
  `contact_id` int(11) NOT NULL,
  `firstname` varchar(10) NOT NULL,
  `lastname` varchar(10) NOT NULL,
  `email` varchar(15) NOT NULL,
  `comment` varchar(111) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `contact`
--

INSERT INTO `contact` (`contact_id`, `firstname`, `lastname`, `email`, `comment`) VALUES
(1, 'Rayan', 'BEDEK', 'rayan@gmail.com', 'Commentaire de rayan');

-- --------------------------------------------------------

--
-- Structure de la table `doctor`
--

CREATE TABLE `doctor` (
  `doc_id` int(22) NOT NULL,
  `doctor_id` varchar(22) NOT NULL,
  `name` varchar(22) NOT NULL,
  `address` varchar(100) NOT NULL,
  `contact` varchar(14) NOT NULL,
  `email` varchar(22) NOT NULL,
  `expertise` varchar(22) NOT NULL,
  `id` int(11) NOT NULL,
  `fee` varchar(111) NOT NULL,
  `userid` varchar(22) NOT NULL,
  `password` varchar(22) NOT NULL,
  `pic` varchar(111) CHARACTER SET latin1 COLLATE latin1_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `doctor`
--

INSERT INTO `doctor` (`doc_id`, `doctor_id`, `name`, `address`, `contact`, `email`, `expertise`, `id`, `fee`, `userid`, `password`, `pic`) VALUES
(2, '', 'Elyas AMROUCHE', '49 Avenu de paris', '0667911910', 'elyas@gmail.com', 'Cardiologie', 0, '120', '20220002', 'elyas2000', 'doctor1.jpg'),
(3, '', 'Daniel GERI', 'Villejuif', '0767911911', 'daniel@hotmail.fr', 'Rhumatologie', 0, '80', '20220003', 'daniel20220003', 'doctor3.jpg'),
(4, '', 'Klariss EDMAND', 'Evry', '0767911998', 'klariss@gmail.com', 'Dermatologie', 0, '80', '20220004', 'klariss', 'fb.png'),
(8, '', 'Melissa AMIRAT', '49 Avenu de paris', '0767911911', 'melissa@gmail.com', 'Rhumatologie', 0, '80', '20220006', 'melissa', 'médecin.jpeg');

-- --------------------------------------------------------

--
-- Structure de la table `donation`
--

CREATE TABLE `donation` (
  `donation_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `address` varchar(100) NOT NULL,
  `unit` varchar(2) NOT NULL,
  `dates` date NOT NULL,
  `email` varchar(222) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `feedback`
--

CREATE TABLE `feedback` (
  `id` int(11) NOT NULL,
  `email` varchar(22) NOT NULL,
  `feedback` varchar(22) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `feedback`
--

INSERT INTO `feedback` (`id`, `email`, `feedback`) VALUES
(1, 'tahar@hotmail.fr', 'message test'),
(2, 'tahar@hotmail.fr', 'Je suis malade');

-- --------------------------------------------------------

--
-- Structure de la table `medicament`
--

CREATE TABLE `medicament` (
  `Id_Med` int(11) NOT NULL,
  `Nom_Med` varchar(400) COLLATE utf8_unicode_ci NOT NULL,
  `Commentaire` text COLLATE utf8_unicode_ci NOT NULL,
  `Date_Ce` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `medicament`
--

INSERT INTO `medicament` (`Id_Med`, `Nom_Med`, `Commentaire`, `Date_Ce`) VALUES
(13, 'HELICOCIN 750/500 , ComprimÃ© enrobÃ© ', '', '2019-02-18'),
(14, 'IRBESAR SUN 150MG, COMPRIMÃ‰ ', '', '2019-02-18'),
(15, 'MEZOR 40 MG, GÃ©lule ', '', '2019-02-18'),
(16, 'TAREG 160 MG, ComprimÃ© pelliculÃ© ', '', '2019-02-18'),
(17, 'DOLIPRANE 1000 MG', '', '2019-02-18');

-- --------------------------------------------------------

--
-- Structure de la table `ordonnance`
--

CREATE TABLE `ordonnance` (
  `Id_ord` int(11) NOT NULL,
  `Doc_id` int(11) NOT NULL,
  `Medicament_Pat` varchar(1000) COLLATE utf8_unicode_ci NOT NULL,
  `Date_Ord` date NOT NULL,
  `Observation` varchar(1000) COLLATE utf8_unicode_ci NOT NULL,
  `Nom_Med` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `Nom_Pat` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `Contact_Pat` int(11) NOT NULL,
  `Age_Pat` int(255) NOT NULL,
  `Contact_Med` int(255) NOT NULL,
  `email_Pat` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `ordonnance`
--

INSERT INTO `ordonnance` (`Id_ord`, `Doc_id`, `Medicament_Pat`, `Date_Ord`, `Observation`, `Nom_Med`, `Nom_Pat`, `Contact_Pat`, `Age_Pat`, `Contact_Med`, `email_Pat`) VALUES
(51, 20220002, 'GP 100 mlg', '2022-04-09', 'test observation', 'Elyas AMROUCHE', 'Tahar AMROUCHE', 667911911, 25, 667911910, 'tahar@hotmail.fr'),
(55, 20220002, 'Dolibrane 100 mg', '2022-04-12', 'Maladie', 'Elyas AMROUCHE', 'Melissa AMIRAT', 765456763, 23, 667911910, 'melissa@gmail.com'),
(57, 20220002, 'Dolibrane 100 mg', '2022-04-13', 'Prendre médicament 2 fois par jour', 'Elyas AMROUCHE', 'Ludivine BOURDE', 765456652, 32, 667911910, 'ludivine@gmail.com'),
(58, 20220002, 'Dolibrane 100 mg', '2022-04-12', 'Prendre médicament 2 fois par jour', 'Elyas AMROUCHE', 'Mael moulin', 765456763, 33, 667911910, 'mael@gmail.com');

-- --------------------------------------------------------

--
-- Structure de la table `patient`
--

CREATE TABLE `patient` (
  `Id_pat` int(11) NOT NULL,
  `NIR` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `Nom_Pat` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `Prenom_Pat` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `Age_Pat` int(11) NOT NULL,
  `Telephone` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Adresse` varchar(400) COLLATE utf8_unicode_ci NOT NULL,
  `Sexe` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `Mdp` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `patient`
--

INSERT INTO `patient` (`Id_pat`, `NIR`, `Nom_Pat`, `Prenom_Pat`, `Age_Pat`, `Telephone`, `email`, `Adresse`, `Sexe`, `Mdp`) VALUES
(46, '1345673456', 'AMROUCHE', 'TAHAR', 25, '0667911910', 'tahar@hotmail.fr', '49 Avenue de Paris', 'Homme', 'tahar1996'),
(47, '1345673457', 'AMROUCHE', 'ELYAS', 21, '0767911911', 'elyas@gmail.com', '49 Avenue de Paris', 'Homme', 'elyas'),
(56, '1478937289274', 'BOURBIA', 'FATMA', 25, '0662257856', 'fatma@gmail.com', 'Paris', 'Femme', 'fatma1998'),
(57, '1478937289945', 'BOURDIN', 'MELANIE', 25, '0662257856', 'melanie@gmail.com', 'Paris', 'Femme', 'melanie2000'),
(58, '14789372892983', 'MAINDOU', 'XAVIER', 29, '0662257866', 'xavier@gmail.com', 'Lyon', 'Homme', 'xavier');

-- --------------------------------------------------------

--
-- Structure de la table `registration`
--

CREATE TABLE `registration` (
  `donar_id` int(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `age` varchar(100) NOT NULL,
  `contact` varchar(100) NOT NULL,
  `type` varchar(22) NOT NULL,
  `city` varchar(221) NOT NULL,
  `address` varchar(100) NOT NULL,
  `bgroup` varchar(100) NOT NULL,
  `dates` date NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` int(100) NOT NULL,
  `pic` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `requestes`
--

CREATE TABLE `requestes` (
  `reg_id` int(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `age` int(100) NOT NULL,
  `mobile` varchar(100) NOT NULL,
  `bgroup` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `reqdate` date NOT NULL,
  `detail` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

CREATE TABLE `users` (
  `id_admin` varchar(100) NOT NULL,
  `mdp_admin` varchar(100) NOT NULL,
  `type` varchar(100) NOT NULL,
  `email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`id_admin`, `mdp_admin`, `type`, `email`) VALUES
('adnim', '123', 'admin', ''),
('', '123', '', ''),
('[value-1]', '[value-2]', '[value-3]', 'adminespacesante@gmail.com'),
('administrateur', 'admin', 'admin', 'adminmonespacesante@gmail.com');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `agenda`
--
ALTER TABLE `agenda`
  ADD PRIMARY KEY (`Id_Agenda`);

--
-- Index pour la table `bloodgroup`
--
ALTER TABLE `bloodgroup`
  ADD PRIMARY KEY (`bg_id`);

--
-- Index pour la table `booking`
--
ALTER TABLE `booking`
  ADD PRIMARY KEY (`booking_id`);

--
-- Index pour la table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `consultation`
--
ALTER TABLE `consultation`
  ADD PRIMARY KEY (`Id_con`);

--
-- Index pour la table `contact`
--
ALTER TABLE `contact`
  ADD PRIMARY KEY (`contact_id`);

--
-- Index pour la table `doctor`
--
ALTER TABLE `doctor`
  ADD PRIMARY KEY (`doc_id`);

--
-- Index pour la table `donation`
--
ALTER TABLE `donation`
  ADD PRIMARY KEY (`donation_id`);

--
-- Index pour la table `feedback`
--
ALTER TABLE `feedback`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `medicament`
--
ALTER TABLE `medicament`
  ADD PRIMARY KEY (`Id_Med`);

--
-- Index pour la table `ordonnance`
--
ALTER TABLE `ordonnance`
  ADD PRIMARY KEY (`Id_ord`);

--
-- Index pour la table `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`Id_pat`),
  ADD UNIQUE KEY `CIN` (`NIR`);

--
-- Index pour la table `registration`
--
ALTER TABLE `registration`
  ADD PRIMARY KEY (`donar_id`);

--
-- Index pour la table `requestes`
--
ALTER TABLE `requestes`
  ADD PRIMARY KEY (`reg_id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `agenda`
--
ALTER TABLE `agenda`
  MODIFY `Id_Agenda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT pour la table `bloodgroup`
--
ALTER TABLE `bloodgroup`
  MODIFY `bg_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT pour la table `booking`
--
ALTER TABLE `booking`
  MODIFY `booking_id` int(22) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `category`
--
ALTER TABLE `category`
  MODIFY `id` int(22) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT pour la table `consultation`
--
ALTER TABLE `consultation`
  MODIFY `Id_con` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT pour la table `contact`
--
ALTER TABLE `contact`
  MODIFY `contact_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `doctor`
--
ALTER TABLE `doctor`
  MODIFY `doc_id` int(22) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT pour la table `donation`
--
ALTER TABLE `donation`
  MODIFY `donation_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `feedback`
--
ALTER TABLE `feedback`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `medicament`
--
ALTER TABLE `medicament`
  MODIFY `Id_Med` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT pour la table `ordonnance`
--
ALTER TABLE `ordonnance`
  MODIFY `Id_ord` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT pour la table `patient`
--
ALTER TABLE `patient`
  MODIFY `Id_pat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT pour la table `registration`
--
ALTER TABLE `registration`
  MODIFY `donar_id` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `requestes`
--
ALTER TABLE `requestes`
  MODIFY `reg_id` int(100) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
