-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema codicedb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema codicedb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `codicedb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `codicedb` ;

-- -----------------------------------------------------
-- Table `codicedb`.`Modelo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `codicedb`.`Modelo` (
  `idModelo` INT NOT NULL AUTO_INCREMENT,
  `Talla` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idModelo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `codicedb`.`Tipo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `codicedb`.`Tipo` (
  `idTipo` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(45) NOT NULL,
  `Descripcion` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`idTipo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `codicedb`.`Producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `codicedb`.`Producto` (
  `idProducto` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(45) NOT NULL,
  `Stock` INT NOT NULL,
  `Costo` FLOAT NOT NULL,
  `Precio` FLOAT NOT NULL,
  `idTipo` INT NOT NULL,
  `idModelo` INT NOT NULL,
  PRIMARY KEY (`idProducto`, `idTipo`, `idModelo`),
  INDEX `fk_Producto_Tipo_idx` (`idTipo` ASC),
  INDEX `fk_Producto_Modelo1_idx` (`idModelo` ASC),
  CONSTRAINT `fk_Producto_Tipo`
    FOREIGN KEY (`idTipo`)
    REFERENCES `codicedb`.`Tipo` (`idTipo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Producto_Modelo1`
    FOREIGN KEY (`idModelo`)
    REFERENCES `codicedb`.`Modelo` (`idModelo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `codicedb`.`Venta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `codicedb`.`Venta` (
  `idVenta` INT NOT NULL AUTO_INCREMENT,
  `Fecha` DATETIME NOT NULL,
  `CostoBruto` FLOAT NOT NULL,
  `PrecioBrutro` FLOAT NOT NULL,
  PRIMARY KEY (`idVenta`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `codicedb`.`ContenidoVenta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `codicedb`.`ContenidoVenta` (
  `idContenidoVenta` INT NOT NULL AUTO_INCREMENT,
  `idVenta` INT NOT NULL,
  `idProducto` INT NOT NULL,
  `CantidadProducto` INT NOT NULL,
  `PrecioUnitario` FLOAT NOT NULL,
  `CostoUnitario` FLOAT NOT NULL,
  PRIMARY KEY (`idContenidoVenta`, `idVenta`, `idProducto`),
  INDEX `fk_ContenidoVenta_Venta1_idx` (`idVenta` ASC),
  INDEX `fk_ContenidoVenta_Producto1_idx` (`idProducto` ASC),
  CONSTRAINT `fk_ContenidoVenta_Venta1`
    FOREIGN KEY (`idVenta`)
    REFERENCES `codicedb`.`Venta` (`idVenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ContenidoVenta_Producto1`
    FOREIGN KEY (`idProducto`)
    REFERENCES `codicedb`.`Producto` (`idProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
