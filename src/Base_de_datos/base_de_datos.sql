-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.1.38-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             10.1.0.5464
-- --------------------------------------------------------


-- Volcando estructura de base de datos para pirojo12
DROP DATABASE IF EXISTS `pirojo`;
CREATE DATABASE IF NOT EXISTS `pirojo` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `pirojo`;


-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla pirojo12.usuario
DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `ID_Usuario` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre_Usuario` varchar(25) NOT NULL,
  `descripcion` varchar(50) DEFAULT NULL,
  `Correo` varchar(35) NOT NULL,
  `Contraseña` varchar(25) NOT NULL,
  `NºReceta` int(11) NOT NULL,
  `NºSeguidor` int(11) NOT NULL,
  PRIMARY KEY (`ID_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

-- Volcando estructura para tabla pirojo12.recetas
DROP TABLE IF EXISTS `recetas`;
CREATE TABLE IF NOT EXISTS `recetas` (
  `ID_Receta` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Usuario_P` int(11) NOT NULL,
  `Nombre_Receta` varchar(25) NOT NULL,
  `pasos` varchar(255) DEFAULT NULL,
  `Ingredientes` varchar(255) DEFAULT NULL,
  `Foto_Video` blob,
  `Tag` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`ID_Receta`),
  KEY `ID_Usuario_P` (`ID_Usuario_P`),
  CONSTRAINT `recetas_ibfk_1` FOREIGN KEY (`ID_Usuario_P`) REFERENCES `usuario` (`ID_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla pirojo12.retos
DROP TABLE IF EXISTS `retos`;
CREATE TABLE IF NOT EXISTS `retos` (
  `ID_Reto` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Usuario_P` int(11) NOT NULL,
  `Nombre_Reto` varchar(25) NOT NULL,
  `Descripcion_Reto` varchar(255) NOT NULL,
  `Fecha_Inicial` datetime NOT NULL,
  `Fecha_Final` datetime NOT NULL,
  PRIMARY KEY (`ID_Reto`),
  KEY `ID_Usuario_P` (`ID_Usuario_P`),
  CONSTRAINT `retos_ibfk_1` FOREIGN KEY (`ID_Usuario_P`) REFERENCES `usuario` (`ID_Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla pirojo12.seguidores
DROP TABLE IF EXISTS `seguidores`;
CREATE TABLE IF NOT EXISTS `seguidores` (
  `ID_USUARIO` int(11) NOT NULL,
  `ID_SIGUIENDO` int(11) NOT NULL,
  PRIMARY KEY (`ID_USUARIO`,`ID_SIGUIENDO`),
  KEY `ID_SIGUIENDO` (`ID_SIGUIENDO`),
  CONSTRAINT `seguidores_ibfk_1` FOREIGN KEY (`ID_USUARIO`) REFERENCES `usuario` (`ID_Usuario`),
  CONSTRAINT `seguidores_ibfk_2` FOREIGN KEY (`ID_SIGUIENDO`) REFERENCES `usuario` (`ID_Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- La exportación de datos fue deseleccionada.
-- Volcando estructura para disparador pirojo12.recetas_after_delete
DROP TRIGGER IF EXISTS `recetas_after_delete`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `recetas_after_delete` AFTER DELETE ON `recetas` FOR EACH ROW BEGIN
Update usuario set NºReceta=NºReceta-1 where ID_Usuario=old.ID_Usuario_P;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Volcando estructura para disparador pirojo12.recetas_before_insert
DROP TRIGGER IF EXISTS `recetas_before_insert`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `recetas_before_insert` BEFORE INSERT ON `recetas` FOR EACH ROW BEGIN
Update usuario set NºReceta=NºReceta+1 where ID_Usuario=NEW.ID_Usuario_P;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Volcando estructura para disparador pirojo12.seguidores_before_delete
DROP TRIGGER IF EXISTS `seguidores_before_delete`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `seguidores_before_delete` BEFORE DELETE ON `seguidores` FOR EACH ROW BEGIN
Update usuario set NºSeguidor=NºSeguidor-1 where ID_Usuario=old.ID_Usuario;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Volcando estructura para disparador pirojo12.seguidores_before_insert
DROP TRIGGER IF EXISTS `seguidores_before_insert`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `seguidores_before_insert` BEFORE INSERT ON `seguidores` FOR EACH ROW BEGIN
Update usuario set NºSeguidor=NºSeguidor+1 where ID_Usuario=NEW.ID_Usuario;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

