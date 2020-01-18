-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Jan 18. 12:23
-- Kiszolgáló verziója: 10.1.34-MariaDB
-- PHP verzió: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `jarmukolcsonzo1`
--
CREATE DATABASE IF NOT EXISTS `jarmukolcsonzo1` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `jarmukolcsonzo1`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jarmu`
--

DROP TABLE IF EXISTS `jarmu`;
CREATE TABLE IF NOT EXISTS `jarmu` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `rendszam` varchar(10) NOT NULL,
  `kategoriaId` int(11) NOT NULL,
  `tipus` varchar(50) DEFAULT NULL,
  `modell` varchar(60) DEFAULT NULL,
  `ferohely` int(2) DEFAULT NULL,
  `fogyasztas` double DEFAULT NULL,
  `elerheto` tinyint(1) DEFAULT '1',
  `szervizbe` tinyint(1) DEFAULT '0',
  `szervizDatum` datetime DEFAULT CURRENT_TIMESTAMP,
  `muszakiDatum` datetime DEFAULT NULL,
  `beszerzesDatum` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`),
  KEY `kategoriaId` (`kategoriaId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jarmukategoria`
--

DROP TABLE IF EXISTS `jarmukategoria`;
CREATE TABLE IF NOT EXISTS `jarmukategoria` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `kategorianNev` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `jarmukategoria`
--

INSERT INTO `jarmukategoria` (`Id`, `kategorianNev`) VALUES
(1, 'Személygépkocsi'),
(2, 'Teherautó'),
(3, 'Kamion0000000');

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `jarmu`
--
ALTER TABLE `jarmu`
  ADD CONSTRAINT `jarmu_ibfk_1` FOREIGN KEY (`kategoriaId`) REFERENCES `jarmukategoria` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
