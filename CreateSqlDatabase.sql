
CREATE TABLE inventions (
  id INT NOT NULL DEFAULT 0 ,
  name VARCHAR(20) NULL DEFAULT NULL ,
  chapter INT NULL DEFAULT NULL ,
  description TEXT NULL DEFAULT NULL ,
  pic VARCHAR(20) NULL DEFAULT NULL ,
  PRIMARY KEY (id) );



-- -----------------------------------------------------
-- Table inventions_have_inventtypes
-- -----------------------------------------------------
CREATE TABLE inventions_have_inventtypes (
  inventID INT NOT NULL DEFAULT 0 ,
  typeID INT NOT NULL DEFAULT 0 ,
  PRIMARY KEY (inventID, typeID) );



-- -----------------------------------------------------
-- Table inventions_have_items
-- -----------------------------------------------------
CREATE  TABLE inventions_have_items (
  inventID INT NOT NULL DEFAULT 0 ,
  itemID INT NOT NULL DEFAULT 0 ,
  amount INT NULL DEFAULT NULL ,
  PRIMARY KEY (inventID, itemID) );



-- -----------------------------------------------------
-- Table inventions_have_photos
-- -----------------------------------------------------
CREATE  TABLE inventions_have_photos (
  inventID INT NOT NULL DEFAULT 0 ,
  photoID INT NOT NULL DEFAULT 0 ,
  PRIMARY KEY (inventID, photoID) );



-- -----------------------------------------------------
-- Table inventtypes
-- -----------------------------------------------------
CREATE  TABLE inventtypes (
  id INT NOT NULL DEFAULT 0 ,
  category VARCHAR(20) NULL DEFAULT NULL ,
  PRIMARY KEY (id) );



-- -----------------------------------------------------
-- Table items
-- -----------------------------------------------------
CREATE  TABLE items (
  id INT NOT NULL DEFAULT 0 ,
  name VARCHAR(20) NULL DEFAULT NULL ,
  cost INT NULL DEFAULT NULL ,
  PRIMARY KEY (id) );



-- -----------------------------------------------------
-- Table photos
-- -----------------------------------------------------
CREATE  TABLE photos (
  id INT NOT NULL DEFAULT 0 ,
  name VARCHAR(20) NULL DEFAULT NULL ,
  chapter INT NULL DEFAULT NULL ,
  location TEXT NULL DEFAULT NULL ,
  pic VARCHAR(20) NULL DEFAULT NULL ,
  PRIMARY KEY (id) );



-- -----------------------------------------------------
-- Table photos_have_phototypes
-- -----------------------------------------------------
CREATE  TABLE photos_have_phototypes (
  photoID INT NOT NULL DEFAULT 0 ,
  typeID INT NOT NULL DEFAULT 0 ,
  PRIMARY KEY (photoID, typeID) );



-- -----------------------------------------------------
-- Table photostaken
-- -----------------------------------------------------
CREATE  TABLE photostaken (
  username VARCHAR(20) NOT NULL DEFAULT '' ,
  photoID INT NOT NULL DEFAULT 0 ,
  PRIMARY KEY (username, photoID) );



-- -----------------------------------------------------
-- Table phototypes
-- -----------------------------------------------------
CREATE  TABLE phototypes (
  id INT NOT NULL DEFAULT 0 ,
  category VARCHAR(20) NULL DEFAULT NULL ,
  PRIMARY KEY (id) );



-- -----------------------------------------------------
-- Table users
-- -----------------------------------------------------
CREATE  TABLE users (
  username VARCHAR(20) NOT NULL DEFAULT '' ,
  userpass VARCHAR(20) NULL DEFAULT NULL ,
  PRIMARY KEY (username) );

insert into inventions values(1,'Clown Shoes', 2, 'Clown Shoes...Might make you a snappy dancer!', 'clownshoes.png');

