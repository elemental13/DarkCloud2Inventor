SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `darkcloud` DEFAULT CHARACTER SET utf8 ;
USE `darkcloud` ;

-- -----------------------------------------------------
-- Table `darkcloud`.`inventions`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `darkcloud`.`inventions` (
  `id` INT(11) NOT NULL DEFAULT '0' ,
  `name` VARCHAR(20) NULL DEFAULT NULL ,
  `chapter` INT(11) NULL DEFAULT NULL ,
  `description` TEXT NULL DEFAULT NULL ,
  `pic` VARCHAR(20) NULL DEFAULT NULL ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `darkcloud`.`inventions_have_inventtypes`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `darkcloud`.`inventions_have_inventtypes` (
  `inventID` INT(11) NOT NULL DEFAULT '0' ,
  `typeID` INT(11) NOT NULL DEFAULT '0' ,
  PRIMARY KEY (`inventID`, `typeID`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `darkcloud`.`inventions_have_items`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `darkcloud`.`inventions_have_items` (
  `inventID` INT(11) NOT NULL DEFAULT '0' ,
  `itemID` INT(11) NOT NULL DEFAULT '0' ,
  `amount` INT(11) NULL DEFAULT NULL ,
  PRIMARY KEY (`inventID`, `itemID`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `darkcloud`.`inventions_have_photos`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `darkcloud`.`inventions_have_photos` (
  `inventID` INT(11) NOT NULL DEFAULT '0' ,
  `photoID` INT(11) NOT NULL DEFAULT '0' ,
  PRIMARY KEY (`inventID`, `photoID`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `darkcloud`.`inventtypes`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `darkcloud`.`inventtypes` (
  `id` INT(11) NOT NULL DEFAULT '0' ,
  `category` VARCHAR(20) NULL DEFAULT NULL ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `darkcloud`.`items`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `darkcloud`.`items` (
  `id` INT(11) NOT NULL DEFAULT '0' ,
  `name` VARCHAR(20) NULL DEFAULT NULL ,
  `cost` INT(11) NULL DEFAULT NULL ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `darkcloud`.`photos`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `darkcloud`.`photos` (
  `id` INT(11) NOT NULL DEFAULT '0' ,
  `name` VARCHAR(20) NULL DEFAULT NULL ,
  `chapter` INT(11) NULL DEFAULT NULL ,
  `location` TEXT NULL DEFAULT NULL ,
  `pic` VARCHAR(20) NULL DEFAULT NULL ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `darkcloud`.`photos_have_phototypes`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `darkcloud`.`photos_have_phototypes` (
  `photoID` INT(11) NOT NULL DEFAULT '0' ,
  `typeID` INT(11) NOT NULL DEFAULT '0' ,
  PRIMARY KEY (`photoID`, `typeID`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `darkcloud`.`photostaken`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `darkcloud`.`photostaken` (
  `username` VARCHAR(20) NOT NULL DEFAULT '' ,
  `photoID` INT(11) NOT NULL DEFAULT '0' ,
  PRIMARY KEY (`username`, `photoID`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `darkcloud`.`phototypes`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `darkcloud`.`phototypes` (
  `id` INT(11) NOT NULL DEFAULT '0' ,
  `category` VARCHAR(20) NULL DEFAULT NULL ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `darkcloud`.`users`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `darkcloud`.`users` (
  `username` VARCHAR(20) NOT NULL DEFAULT '' ,
  `userpass` VARCHAR(20) NULL DEFAULT NULL ,
  PRIMARY KEY (`username`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
