-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-08-2015 a las 08:48:22
-- Versión del servidor: 5.5.34
-- Versión de PHP: 5.4.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `codicedb`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contenidoventa`
--

CREATE TABLE IF NOT EXISTS `contenidoventa` (
  `idContenidoVenta` int(11) NOT NULL AUTO_INCREMENT,
  `idVenta` int(11) NOT NULL,
  `idProducto` int(11) NOT NULL,
  `CantidadProducto` int(11) NOT NULL,
  `PrecioUnitario` float NOT NULL,
  `CostoUnitario` float NOT NULL,
  PRIMARY KEY (`idContenidoVenta`,`idVenta`,`idProducto`),
  KEY `fk_ContenidoVenta_Venta1_idx` (`idVenta`),
  KEY `fk_ContenidoVenta_Producto1_idx` (`idProducto`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `contenidoventa`
--

INSERT INTO `contenidoventa` (`idContenidoVenta`, `idVenta`, `idProducto`, `CantidadProducto`, `PrecioUnitario`, `CostoUnitario`) VALUES
(1, 5, 1, 1, 200, 100),
(2, 6, 7, 2, 900, 600);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modelo`
--

CREATE TABLE IF NOT EXISTS `modelo` (
  `idModelo` int(11) NOT NULL AUTO_INCREMENT,
  `Talla` varchar(45) NOT NULL,
  PRIMARY KEY (`idModelo`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=8 ;

--
-- Volcado de datos para la tabla `modelo`
--

INSERT INTO `modelo` (`idModelo`, `Talla`) VALUES
(1, 'Sin talla'),
(2, 'Unitalla'),
(3, 'Extra chico'),
(4, 'Chico'),
(5, 'Mediano'),
(6, 'Grande'),
(7, 'Extra Grande');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE IF NOT EXISTS `producto` (
  `idProducto` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Stock` int(11) NOT NULL,
  `Costo` float NOT NULL,
  `Precio` float NOT NULL,
  `idTipo` int(11) NOT NULL,
  `idModelo` int(11) NOT NULL,
  PRIMARY KEY (`idProducto`,`idTipo`,`idModelo`),
  KEY `fk_Producto_Tipo_idx` (`idTipo`),
  KEY `fk_Producto_Modelo1_idx` (`idModelo`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=13 ;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`idProducto`, `Nombre`, `Stock`, `Costo`, `Precio`, `idTipo`, `idModelo`) VALUES
(1, 'Zapato General', 9, 100, 200, 1, 1),
(2, 'Huarache Escoses', 10, 100, 200, 1, 2),
(3, 'Huarache Hipster', 10, 100, 200, 1, 1),
(4, 'Huarache Erotico', 2, 100, 200, 3, 4),
(5, 'Collar de perlas negras', 5, 250, 360, 1, 1),
(6, 'Bolsa de Mesa', 2, 39, 58, 1, 1),
(7, 'Cuadro de Ajedrez', 0, 600, 900, 1, 2),
(8, 'Huarache de Vinil', 2, 200, 400, 1, 3),
(9, 'Mocasin', 23, 280, 380, 1, 3),
(10, 'Zapato Danes', 10, 250, 666, 3, 6),
(11, 'qqqq', 11, 1111, 11112, 3, 2),
(12, 'aaaa', 111, 123, 234, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo`
--

CREATE TABLE IF NOT EXISTS `tipo` (
  `idTipo` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Descripcion` varchar(100) NOT NULL,
  PRIMARY KEY (`idTipo`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `tipo`
--

INSERT INTO `tipo` (`idTipo`, `Nombre`, `Descripcion`) VALUES
(1, 'Artificial', 'Artificial es...'),
(2, 'Recocido', 'Recodido es...'),
(3, 'Metalico', 'Metalico es...'),
(4, 'Silvestre', 'Silvestre es...'),
(5, 'Industrial', 'Industrial es...'),
(6, 'Poetico', 'Descripcionpoetica');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE IF NOT EXISTS `venta` (
  `idVenta` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` datetime NOT NULL,
  `CostoBruto` float NOT NULL,
  `PrecioBrutro` float NOT NULL,
  PRIMARY KEY (`idVenta`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`idVenta`, `Fecha`, `CostoBruto`, `PrecioBrutro`) VALUES
(1, '2015-08-02 00:00:00', 1, 1),
(2, '2015-08-03 00:00:00', 1, 2),
(3, '2015-08-01 00:00:00', 111, 222),
(4, '2015-08-01 00:00:00', 111, 1111),
(5, '2015-08-06 00:00:00', 100, 200),
(6, '2015-08-06 00:00:00', 600, 900);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `contenidoventa`
--
ALTER TABLE `contenidoventa`
  ADD CONSTRAINT `fk_ContenidoVenta_Venta1` FOREIGN KEY (`idVenta`) REFERENCES `venta` (`idVenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_ContenidoVenta_Producto1` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `fk_Producto_Modelo1` FOREIGN KEY (`idModelo`) REFERENCES `modelo` (`idModelo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Producto_Tipo` FOREIGN KEY (`idTipo`) REFERENCES `tipo` (`idTipo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
