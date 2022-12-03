-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 03-Dez-2022 às 21:58
-- Versão do servidor: 8.0.27
-- versão do PHP: 7.3.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `api_corridas`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `competidores`
--

DROP TABLE IF EXISTS `competidores`;
CREATE TABLE IF NOT EXISTS `competidores` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Sexo` varchar(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `TempMedCorpo` double NOT NULL,
  `Peso` double NOT NULL,
  `Altura` double NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `competidores`
--

INSERT INTO `competidores` (`Id`, `Nome`, `Sexo`, `TempMedCorpo`, `Peso`, `Altura`) VALUES
(3, 'Lucas Cola', 'M', 36, 87, 1.8),
(2, 'Bruno Picoli', 'M', 36, 70, 1.85),
(4, 'Laura Nogueira', 'F', 35, 69, 1.69),
(5, 'Silvia Regina', 'F', 36, 69, 1.69);

-- --------------------------------------------------------

--
-- Estrutura da tabela `historicocorridas`
--

DROP TABLE IF EXISTS `historicocorridas`;
CREATE TABLE IF NOT EXISTS `historicocorridas` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `CompetidorId` int NOT NULL,
  `PistaId` int NOT NULL,
  `DataCorrida` datetime(6) NOT NULL,
  `TempoGasto` double NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_HistoricoCorridas_CompetidorId` (`CompetidorId`),
  KEY `IX_HistoricoCorridas_PistaId` (`PistaId`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `historicocorridas`
--

INSERT INTO `historicocorridas` (`Id`, `CompetidorId`, `PistaId`, `DataCorrida`, `TempoGasto`) VALUES
(1, 2, 1, '2022-12-01 00:00:00.000000', 60),
(2, 2, 1, '2022-11-30 00:00:00.000000', 45),
(3, 3, 1, '2022-11-30 00:00:00.000000', 80),
(4, 3, 1, '2022-12-01 00:00:00.000000', 70),
(5, 3, 2, '2022-12-01 00:00:00.000000', 90),
(6, 5, 2, '2022-12-02 00:00:00.000000', 100);

-- --------------------------------------------------------

--
-- Estrutura da tabela `pistas`
--

DROP TABLE IF EXISTS `pistas`;
CREATE TABLE IF NOT EXISTS `pistas` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Descricao` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `pistas`
--

INSERT INTO `pistas` (`Id`, `Descricao`) VALUES
(1, 'Nurburing'),
(2, 'Monza 1966');

-- --------------------------------------------------------

--
-- Estrutura da tabela `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
CREATE TABLE IF NOT EXISTS `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20221201000656_inicial', '6.0.2');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
