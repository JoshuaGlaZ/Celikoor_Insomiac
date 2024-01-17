-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: insomniac
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.27-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aktor_film`
--

DROP TABLE IF EXISTS `aktor_film`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aktor_film` (
  `aktors_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL,
  `peran` enum('UTAMA','PEMBANTU','FIGURAN') DEFAULT NULL,
  PRIMARY KEY (`aktors_id`,`films_id`),
  KEY `fk_aktors_has_films_films1_idx` (`films_id`),
  KEY `fk_aktors_has_films_aktors1_idx` (`aktors_id`),
  CONSTRAINT `fk_aktors_has_films_aktors1` FOREIGN KEY (`aktors_id`) REFERENCES `aktors` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_aktors_has_films_films1` FOREIGN KEY (`films_id`) REFERENCES `films` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aktor_film`
--

LOCK TABLES `aktor_film` WRITE;
/*!40000 ALTER TABLE `aktor_film` DISABLE KEYS */;
INSERT INTO `aktor_film` VALUES (1,1,'UTAMA'),(1,2,'UTAMA'),(1,3,'UTAMA'),(1,8,'PEMBANTU'),(2,1,'UTAMA'),(2,2,'UTAMA'),(2,3,'UTAMA'),(3,1,'PEMBANTU'),(3,8,'PEMBANTU'),(4,1,'PEMBANTU'),(4,2,'PEMBANTU'),(4,3,'PEMBANTU'),(5,1,'PEMBANTU'),(6,1,'PEMBANTU'),(6,2,'PEMBANTU'),(6,3,'PEMBANTU'),(7,2,'PEMBANTU'),(7,8,'PEMBANTU'),(8,2,'PEMBANTU'),(8,3,'PEMBANTU'),(9,2,'FIGURAN'),(10,2,'FIGURAN'),(11,3,'UTAMA'),(13,3,'PEMBANTU'),(14,3,'FIGURAN'),(15,3,'FIGURAN'),(16,4,'UTAMA'),(16,5,'UTAMA'),(16,8,'PEMBANTU'),(17,4,'UTAMA'),(17,5,'UTAMA'),(18,4,'PEMBANTU'),(19,4,'PEMBANTU'),(20,4,'PEMBANTU'),(20,5,'PEMBANTU'),(21,5,'PEMBANTU'),(21,8,'PEMBANTU'),(22,5,'PEMBANTU'),(23,5,'FIGURAN'),(24,5,'FIGURAN'),(26,6,'UTAMA'),(26,7,'UTAMA'),(26,8,'UTAMA'),(26,11,'PEMBANTU'),(26,21,'UTAMA'),(26,22,'UTAMA'),(27,6,'UTAMA'),(28,6,'PEMBANTU'),(29,6,'PEMBANTU'),(29,7,'FIGURAN'),(30,6,'PEMBANTU'),(30,12,'UTAMA'),(30,13,'UTAMA'),(30,14,'FIGURAN'),(31,7,'UTAMA'),(32,6,'PEMBANTU'),(32,7,'PEMBANTU'),(32,8,'UTAMA'),(33,7,'PEMBANTU'),(34,7,'FIGURAN'),(35,7,'FIGURAN'),(36,8,'UTAMA'),(36,21,'UTAMA'),(36,22,'UTAMA'),(37,8,'PEMBANTU'),(38,8,'FIGURAN'),(39,8,'FIGURAN'),(41,9,'UTAMA'),(41,10,'UTAMA'),(41,11,'UTAMA'),(41,19,'UTAMA'),(41,20,'UTAMA'),(41,21,'UTAMA'),(41,22,'UTAMA'),(42,9,'UTAMA'),(43,9,'UTAMA'),(44,9,'PEMBANTU'),(44,11,'UTAMA'),(45,9,'PEMBANTU'),(46,10,'PEMBANTU'),(46,11,'UTAMA'),(46,19,'UTAMA'),(46,20,'UTAMA'),(46,21,'UTAMA'),(46,22,'UTAMA'),(47,10,'PEMBANTU'),(48,10,'PEMBANTU'),(50,10,'PEMBANTU'),(51,11,'UTAMA'),(51,19,'UTAMA'),(51,20,'UTAMA'),(51,21,'UTAMA'),(51,22,'UTAMA'),(54,11,'UTAMA'),(54,22,'UTAMA'),(56,11,'UTAMA'),(56,12,'UTAMA'),(56,19,'UTAMA'),(56,20,'UTAMA'),(56,21,'UTAMA'),(56,22,'UTAMA'),(57,12,'PEMBANTU'),(58,12,'PEMBANTU'),(59,12,'PEMBANTU'),(60,12,'PEMBANTU'),(60,13,'UTAMA'),(61,13,'PEMBANTU'),(62,11,'PEMBANTU'),(62,14,'PEMBANTU'),(63,11,'PEMBANTU'),(63,13,'PEMBANTU'),(64,13,'PEMBANTU'),(66,14,'UTAMA'),(67,14,'PEMBANTU'),(68,14,'PEMBANTU'),(69,14,'PEMBANTU'),(71,15,'UTAMA'),(71,16,'UTAMA'),(71,17,'UTAMA'),(71,18,'UTAMA'),(71,19,'UTAMA'),(71,20,'UTAMA'),(71,21,'UTAMA'),(71,22,'UTAMA'),(72,15,'PEMBANTU'),(72,16,'PEMBANTU'),(73,15,'PEMBANTU'),(73,16,'PEMBANTU'),(73,18,'UTAMA'),(74,15,'PEMBANTU'),(74,16,'PEMBANTU'),(74,17,'UTAMA'),(75,15,'PEMBANTU'),(75,16,'PEMBANTU'),(76,16,'FIGURAN'),(77,16,'FIGURAN'),(78,16,'FIGURAN'),(80,17,'PEMBANTU'),(81,17,'PEMBANTU'),(82,17,'PEMBANTU'),(83,17,'PEMBANTU'),(84,17,'FIGURAN'),(86,18,'PEMBANTU'),(87,18,'PEMBANTU'),(88,18,'PEMBANTU'),(89,18,'PEMBANTU'),(90,18,'FIGURAN'),(91,17,'PEMBANTU'),(91,19,'UTAMA'),(91,20,'UTAMA'),(91,21,'UTAMA'),(91,22,'UTAMA'),(92,7,'UTAMA'),(92,10,'UTAMA'),(92,19,'PEMBANTU'),(93,19,'PEMBANTU'),(94,19,'PEMBANTU'),(95,19,'FIGURAN'),(101,20,'PEMBANTU'),(101,21,'PEMBANTU'),(102,20,'PEMBANTU'),(102,21,'PEMBANTU'),(103,20,'PEMBANTU'),(103,21,'PEMBANTU'),(104,20,'PEMBANTU'),(104,21,'PEMBANTU'),(105,20,'PEMBANTU'),(106,22,'PEMBANTU'),(107,22,'PEMBANTU'),(108,22,'PEMBANTU'),(109,22,'PEMBANTU'),(110,22,'PEMBANTU');
/*!40000 ALTER TABLE `aktor_film` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aktors`
--

DROP TABLE IF EXISTS `aktors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aktors` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `gender` enum('L','P') NOT NULL,
  `negara_asal` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=111 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aktors`
--

LOCK TABLES `aktors` WRITE;
/*!40000 ALTER TABLE `aktors` DISABLE KEYS */;
INSERT INTO `aktors` VALUES (1,'Tobey Maguire','1975-06-27','L','Amerika Serikat'),(2,'Kirsten Dunst','1982-04-30','P','Amerika Serikat'),(3,'Willem Dafoe','1955-07-22','L','Amerika Serikat'),(4,'James Franco','1978-04-19','L','Amerika Serikat'),(5,'Cliff Robertson','1923-09-09','L','Amerika Serikat'),(6,'Rosemary Harris','1927-09-19','P','Inggris'),(7,'Alfred Molina','1953-05-24','L','Inggris'),(8,'J.K. Simmons','1955-01-09','L','Amerika Serikat'),(9,'Donna Murphy','1959-03-07','P','Amerika Serikat'),(10,'Daniel Gillies','1976-03-14','L','Kanada'),(11,'Topher Grace','1978-07-12','L','Amerika Serikat'),(12,'Thomas Haden Church','1960-06-17','L','Amerika Serikat'),(13,'James Cromwell','1940-01-27','L','Amerika Serikat'),(14,'Theresa Russell','1957-03-20','P','Amerika Serikat'),(15,'Dylan Baker','1959-10-07','L','Amerika Serikat'),(16,'Andrew Garfield','1983-08-20','L','Amerika Serikat'),(17,'Emma Stone','1988-11-06','P','Amerika Serikat'),(18,'Rhys Ifans','1967-07-22','L','Inggris'),(19,'Irrfan Khan','1967-01-07','L','India'),(20,'Denis Leary','1957-08-18','L','Amerika Serikat'),(21,'Jamie Foxx','1967-12-13','L','Amerika Serikat'),(22,'Paul Giamatti','1967-06-06','L','Amerika Serikat'),(23,'Dane DeHaan','1986-02-06','L','Amerika Serikat'),(24,'Colm Feore','1958-08-22','L','Amerika Serikat'),(25,'Sally Field','1946-11-06','P','Amerika Serikat'),(26,'Tom Holland','1996-06-01','L','Inggris'),(27,'Michael Keaton','1951-09-05','L','Amerika Serikat'),(28,'Marisa Tomei','1964-12-04','P','Amerika Serikat'),(29,'Jon Favreau','1966-10-19','L','Amerika Serikat'),(30,'Gwyneth Paltrow','1972-09-27','P','Amerika Serikat'),(31,'Jake Gyllenhaal','1980-12-09','L','Amerika Serikat'),(32,'Zendaya','1996-09-01','P','Amerika Serikat'),(33,'Jacob Batalon','1996-09-09','L','Amerika Serikat'),(34,'Tony Revolori','1996-04-28','L','Amerika Serikat'),(35,'Angourie Rice','2001-01-01','P','Australia'),(36,'Benedict Cumberbatch','1976-07-19','L','Inggris'),(37,'Benedict Wong','1971-07-03','L','Inggris'),(38,'Arian Moayed','1980-04-15','L','Amerika Serikat'),(39,'Paula Newsome','1961-10-07','P','Amerika Serikat'),(40,'Hannibal Buress','1983-02-04','L','Amerika Serikat'),(41,'Chris Evans','1981-06-13','L','Amerika Serikat'),(42,'Hugo Weaving','1960-04-04','L','Nigeria'),(43,'Hayley Atwell','1982-04-05','P','Amerika Serikat'),(44,'Sebastian Stan','1982-08-13','L','Romania'),(45,'Dominic Cooper','1978-06-02','L','Inggris'),(46,'Scarlett Johansson','1984-11-22','P','Amerika Serikat'),(47,'Robert Redford','1936-08-18','L','Amerika Serikat'),(48,'Anthony Mackie','1978-09-23','L','Amerika Serikat'),(49,'Cobie Smulders','1982-04-03','P','Inggris'),(50,'Frank Grillo','1965-06-08','L','Amerika Serikat'),(51,'Jeremy Renner','1971-01-07','L','Amerika Serikat'),(52,'Chadwick Boseman','1976-11-29','L','Amerika Serikat'),(53,'Elizabeth Olsen','1989-02-16','P','Amerika Serikat'),(54,'Paul Rudd','1969-04-06','L','Amerika Serikat'),(55,'Paul Bettany','1971-05-27','L','Inggris'),(56,'Robert Downey Jr.','1965-04-04','L','Amerika Serikat'),(57,'Gwyneth Paltrow','1972-09-27','P','Amerika Serikat'),(58,'Terrence Howard','1969-03-11','L','Amerika Serikat'),(59,'Jeff Bridges','1949-12-04','L','Amerika Serikat'),(60,'Leslie Bibb','1974-11-17','P','Amerika Serikat'),(61,'Mickey Rourke','1952-09-16','L','Amerika Serikat'),(62,'Don Cheadle','1964-11-29','L','Amerika Serikat'),(63,'Sam Rockwell','1968-11-05','L','Amerika Serikat'),(64,'Clark Gregg','1962-04-02','L','Amerika Serikat'),(65,'Garry Shandling','1949-11-29','L','Amerika Serikat'),(66,'Guy Pearce','1967-10-05','L','Inggris'),(67,'Rebecca Hall','1982-05-03','P','Inggris'),(68,'Ben Kingsley','1943-12-31','L','Inggris'),(69,'James Badge Dale','1978-05-01','L','Amerika Serikat'),(70,'Stephanie Szostak','1975-08-05','P','Amerika Serikat'),(71,'Chris Hemsworth','1983-08-11','L','Australia'),(72,'Anthony Hopkins','1937-12-31','L','Inggris'),(73,'Natalie Portman','1981-06-09','P','Amerika Serikat'),(74,'Tom Hiddleston','1981-02-09','L','Inggris'),(75,'Stellan Skarsgård','1951-06-13','L','Swedia'),(76,'Christopher Eccleston','1964-02-16','L','Inggris'),(77,'Jaimie Alexander','1984-03-12','P','Amerika Serikat'),(78,'Zachary Levi','1980-09-29','L','Amerika Serikat'),(79,'Ray Stevenson','1964-05-25','L','Inggris'),(80,'Idris Elba','1972-09-06','L','Inggris'),(81,'Cate Blanchett','1969-05-14','P','Australia'),(82,'Jeff Goldblum','1952-10-22','L','Amerika Serikat'),(83,'Tessa Thompson','1983-10-03','P','Amerika Serikat'),(84,'Karl Urban','1972-06-07','L','Selandia Baru'),(85,'Tadanobu Asano','1973-11-27','L','Jepang'),(86,'Christian Bale','1974-01-30','L','Inggris'),(87,'Russell Crowe','1964-04-07','L','Selandia Baru'),(88,'Chris Pratt','1979-06-21','L','Amerika Serikat'),(89,'Dave Bautista','1969-01-18','L','Amerika Serikat'),(90,'Brett Goldstein','1980-07-17','L','Inggris'),(91,'Mark Ruffalo','1967-11-22','L','Amerika Serikat'),(92,'Samuel L. Jackson','1948-12-21','L','Amerika Serikat'),(93,'Alexis Denisof','1966-02-25','L','Amerika Serikat'),(94,'Jerzy Skolimowski','1938-05-05','L','Polandia'),(95,'Kirill Nikiforov','1980-07-09','L','Russia'),(96,'James Spader','1960-02-07','L','Amerika Serikat'),(97,'Aaron Taylor-Johnson','1990-06-13','L','Inggris'),(98,'Linda Cardellini','1975-06-25','P','Amerika Serikat'),(99,'Claudia Kim','1985-01-25','P','Korea'),(100,'Stan Lee','1922-12-28','L','Amerika Serikat'),(101,'Zoe Saldana','1978-06-19','P','Amerika Serikat'),(102,'Karen Gillan','1987-11-28','P','Inggris'),(103,'Danai Gurira','1978-02-14','P','Amerika Serikat'),(104,'Peter Dinklage','1969-06-11','L','Amerika Serikat'),(105,'Pom Klementieff','1986-05-03','P','Prancis'),(106,'Brie Larson','1989-10-01','P','Amerika Serikat'),(107,'Evangeline Lilly','1979-08-03','P','Kanada'),(108,'Rene Russo','1954-02-17','P','Amerika Serikat'),(109,'John Slattery','1962-08-13','L','Amerika Serikat'),(110,'Tilda Swinton','1960-11-05','P','Inggris');
/*!40000 ALTER TABLE `aktors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cinemas`
--

DROP TABLE IF EXISTS `cinemas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cinemas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama_cabang` varchar(45) NOT NULL,
  `alamat` varchar(75) NOT NULL,
  `tgl_dibuka` date NOT NULL,
  `kota` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cinemas`
--

LOCK TABLES `cinemas` WRITE;
/*!40000 ALTER TABLE `cinemas` DISABLE KEYS */;
INSERT INTO `cinemas` VALUES (1,'Tunjungan XXI','Jl. Basuki Rahmat No.8-12','2015-08-12','Surabaya'),(2,'Galaxy XXI','Galaxy Mall 1, Jl. Dr. Ir. H. Soekarno No.35-39','2019-09-30','Surabaya'),(3,'Delta XXI','Plaza Surabaya, Jl. Pemuda No.31-37 Lt. 5','2019-10-10','Surabaya'),(4,'Grand City XXI','Lantai 4 Grand City, Jl. Walikota Mustajab No.1','2013-05-12','Surabaya'),(5,'PTC XXI','Pakuwon Trade Center, Jl. Puncak Indah Lontar II No.2 lt.1','2015-08-12','Surabaya'),(6,'Cinema XXI - Ciputra World','Ciputra World, Jl. Mayjen Sungkono No.89 Lantai 4','2012-03-12','Surabaya'),(7,'XXI Premiere Lenmarc','LenMarc Lt. 4, Jl. Mayjend. Jonosewojo No.9','2012-08-25','Surabaya'),(8,'XXI - Tunjungan Plaza 5','Tunjungan Plaza 5, Jl. Embong Malang No.32-36','2017-07-02','Surabaya'),(9,'Pakuwon City XXI','Pakuwon City, Jl. Raya Laguna KJW Putih Tambak No.17','2018-08-15','Surabaya'),(10,'CGV Cinemas BG Junction','BG Junction Mall, Jl. Bubutan No.1 - 7','2017-08-22','Surabaya'),(11,'Transmart Ngagel XXI','Jl. Ngagel','2015-12-16','Surabaya'),(12,'Pakuwon Mall XXI','Pakuwon Mall, Jl. Puncak Indah Lontar No.2','2012-09-06','Surabaya'),(13,'Royal XXI','Royal Plaza, Jl. Achmad Yani No.16-18 Lt. 3','2014-06-17','Surabaya'),(14,'Cinepolis','Jl. Ahmad Yani No.288','2018-02-17','Surabaya'),(15,'CGV Cinemas Maspion','Jl. Ahmad Yani No.73','2015-08-14','Surabaya'),(16,'CGV Marvell City','Marvell City Mall, Jl. Ngagel No.123 Lt. 3','2012-08-13','Surabaya'),(17,'The Premiere - XXI Grand City Mall','Jl. Walikota Mustajab No.1','2013-11-12','Surabaya'),(18,'Transmart Rungkut XXI','Transmart Rungkut, Jl. Raya Kalirungkut No.23-25','2013-02-26','Surabaya'),(19,'Movimax Kaza','Kaza Mall, Jl. Kapas Krampung No.45 Lantai 3','2020-10-09','Surabaya'),(20,'Trans Icon Mall XXI','Jl. Ahmad Yani, Gayungan','2019-03-04','Surabaya');
/*!40000 ALTER TABLE `cinemas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `film_studio`
--

DROP TABLE IF EXISTS `film_studio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `film_studio` (
  `studios_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL,
  PRIMARY KEY (`studios_id`,`films_id`),
  KEY `fk_studios_has_films_films1_idx` (`films_id`),
  KEY `fk_studios_has_films_studios1_idx` (`studios_id`),
  CONSTRAINT `fk_studios_has_films_films1` FOREIGN KEY (`films_id`) REFERENCES `films` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_studios_has_films_studios1` FOREIGN KEY (`studios_id`) REFERENCES `studios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `film_studio`
--

LOCK TABLES `film_studio` WRITE;
/*!40000 ALTER TABLE `film_studio` DISABLE KEYS */;
INSERT INTO `film_studio` VALUES (1,1),(1,2),(1,3),(1,4),(1,7),(1,8),(1,9),(1,11),(1,15),(2,1),(2,2),(2,3),(2,4),(2,7),(2,8),(2,11),(2,12),(2,15),(3,1),(3,2),(3,3),(3,4),(3,7),(3,8),(3,12),(3,15),(4,1),(4,2),(4,3),(4,5),(4,7),(4,9),(4,11),(5,1),(5,2),(5,3),(5,5),(5,8),(5,9),(5,11),(5,12),(6,1),(6,2),(6,3),(6,5),(7,19),(7,20),(7,21),(7,22),(8,19),(8,20),(8,21),(8,22),(9,19),(9,20),(9,21),(9,22),(10,19),(10,20),(10,21),(10,22),(11,19),(11,20),(11,21),(11,22),(12,18),(12,19),(12,22),(13,18),(13,19),(13,22),(14,18),(14,19),(14,22);
/*!40000 ALTER TABLE `film_studio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `films`
--

DROP TABLE IF EXISTS `films`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `films` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `judul` varchar(45) NOT NULL,
  `sinopsis` text NOT NULL,
  `tahun` int(11) NOT NULL,
  `durasi` smallint(6) NOT NULL,
  `kelompoks_id` int(11) NOT NULL,
  `bahasa` enum('EN','ID','CHN','KOR','JPN','OTH') NOT NULL DEFAULT 'EN',
  `is_sub_indo` tinyint(4) NOT NULL DEFAULT 1,
  `cover_image` varchar(45) DEFAULT NULL,
  `diskon_nominal` double DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_films_kelompoks1_idx` (`kelompoks_id`),
  CONSTRAINT `fk_films_kelompoks1` FOREIGN KEY (`kelompoks_id`) REFERENCES `kelompoks` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `films`
--

LOCK TABLES `films` WRITE;
/*!40000 ALTER TABLE `films` DISABLE KEYS */;
INSERT INTO `films` VALUES (1,'Spider-Man','lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum ',2002,121,2,'EN',1,'Spider-Man.jpg',60),(2,'Spider-Man 2','',2004,127,2,'EN',1,'Spider-Man 2.jpg',45),(3,'Spider-Man 3','',2007,139,2,'EN',1,'Spider-Man 3.jpg',39),(4,'The Amazing Spider-Man','',2012,136,2,'EN',1,'The Amazing Spider-Man.jpg',28),(5,'The Amazing Spider-Man 2','',2014,142,2,'EN',1,'The Amazing Spider-Man 2.jpg',22),(6,'Spider-Man: Homecoming','',2017,133,2,'EN',1,'Spider-Man - Homecoming.jpg',30),(7,'Spider-Man: Far from Home','',2019,129,2,'EN',1,'Spider-Man - Far from Home.jpg',15),(8,'Spider-Man: No Way Home','',2021,148,2,'EN',1,'Spider-Man - No Way Home.jpg',10),(9,'Captain America: The First Avenger','',2011,124,2,'EN',1,'Captain America - The First Avenger.jpg',29),(10,'Captain America: The Winter Soldier','',2014,136,2,'EN',1,'Captain America - The Winter Soldier.jpg',11),(11,'Captain America: Civil War','',2016,147,2,'EN',1,'Captain America - Civil War.jpg',10),(12,'Iron Man','',2008,126,2,'EN',1,'Iron Man.jpg',12),(13,'Iron Man 2','',2010,124,2,'EN',1,'Iron Man 2.jpg',8),(14,'Iron Man 3','',2013,130,2,'EN',1,'Iron Man 3.jpg',14),(15,'Thor','',2011,115,2,'EN',1,'Thor.jpg',6),(16,'Thor: The Dark World','',2013,112,2,'EN',1,'Thor - The Dark World.jpg',10),(17,'Thor: Ragnarok','',2017,130,2,'EN',1,'Thor - Ragnarok.jpg',27),(18,'Thor: Love and Thunder','',2022,118,2,'EN',1,'Thor - Love and Thunder.jpg',42),(19,'The Avengers','',2012,143,2,'EN',1,'The Avengers.jpg',32),(20,'Avengers: Age of Ultron','',2015,141,2,'EN',1,'Avengers - Age of Ultron.jpg',13),(21,'Avengers: Infinity War','',2018,149,2,'EN',1,'Avengers - Infinity War.jpg',25),(22,'Avengers: Endgame','',2019,181,2,'EN',1,'Avengers - Endgame.jpg',30);
/*!40000 ALTER TABLE `films` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genre_film`
--

DROP TABLE IF EXISTS `genre_film`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `genre_film` (
  `films_id` int(11) NOT NULL,
  `genres_id` int(11) NOT NULL,
  PRIMARY KEY (`films_id`,`genres_id`),
  KEY `fk_films_has_genres_genres1_idx` (`genres_id`),
  KEY `fk_films_has_genres_films1_idx` (`films_id`),
  CONSTRAINT `fk_films_has_genres_films1` FOREIGN KEY (`films_id`) REFERENCES `films` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_films_has_genres_genres1` FOREIGN KEY (`genres_id`) REFERENCES `genres` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genre_film`
--

LOCK TABLES `genre_film` WRITE;
/*!40000 ALTER TABLE `genre_film` DISABLE KEYS */;
INSERT INTO `genre_film` VALUES (1,1),(1,2),(1,4),(1,5),(2,1),(2,2),(2,4),(2,8),(3,1),(3,2),(3,4),(3,8),(4,1),(4,2),(4,9),(5,1),(5,2),(5,9),(6,1),(6,2),(6,9),(7,1),(7,2),(7,9),(8,1),(8,2),(8,9),(9,1),(9,2),(9,9),(10,1),(10,2),(10,9),(11,1),(11,9),(12,1),(12,9),(13,1),(13,2),(13,9),(14,1),(14,5),(15,1),(15,2),(15,5),(16,1),(16,2),(16,5),(17,1),(17,2),(17,3),(17,5),(17,9),(18,1),(18,2),(18,3),(18,5),(18,8),(18,9),(19,1),(19,9),(20,1),(20,2),(20,9),(21,1),(21,2),(21,9),(22,1),(22,2),(22,4),(22,9);
/*!40000 ALTER TABLE `genre_film` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genres`
--

DROP TABLE IF EXISTS `genres`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `genres` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) NOT NULL,
  `deskripsi` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genres`
--

LOCK TABLES `genres` WRITE;
/*!40000 ALTER TABLE `genres` DISABLE KEYS */;
INSERT INTO `genres` VALUES (1,'Action','Film yang menekankan pada urutan adegan seru dan energik, sering kali melibatkan adegan kejar-kejaran, pertarungan, dan ledakan.'),(2,'Adventure','Film yang berfokus pada petualangan heroik, sering kali di latar belakang eksotis atau tempat-tempat yang jauh.'),(3,'Comedy','Genre yang tujuannya menghibur penonton dengan humor, sering melibatkan situasi konyol atau dialog lucu.'),(4,'Drama','Film yang berfokus pada pengembangan karakter dan interaksi emosional, sering menggambarkan situasi kehidupan yang realistis.'),(5,'Fantasy','Genre yang mencakup unsur-unsur supranatural dan magis, sering berlatar di dunia yang sepenuhnya imajinatif.'),(6,'Horror','Film yang bertujuan menimbulkan rasa takut, sering dengan unsur supernatural atau psikologis yang menegangkan.'),(7,'Mystery','Genre yang melibatkan penyelidikan suatu misteri, sering mengandung plot yang rumit dan berakhir dengan twist yang mengejutkan.'),(8,'Romance','Film yang berpusat pada hubungan cinta antara karakter, menekankan pada emosi dan hubungan romantis.'),(9,'Sci-Fi','Genre yang mengeksplorasi dampak ilmu pengetahuan dan teknologi, sering berlatar di masa depan atau di dunia alternatif.'),(10,'Thriller','Film yang membangun ketegangan dan suspense, sering melibatkan konflik yang harus diatasi oleh protagonis.'),(11,'Documentary','Film non-fiksi yang memberikan informasi tentang suatu subjek, orang, atau peristiwa, sering digunakan untuk mendidik atau membawa kesadaran.'),(12,'Biography','Film yang menceritakan kehidupan seseorang, sering berdasarkan tokoh nyata dan peristiwa bersejarah.'),(13,'Animation','Film yang dibuat dengan animasi, bisa dalam berbagai bentuk seperti kartun, CGI, atau stop motion, menargetkan semua usia.');
/*!40000 ALTER TABLE `genres` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoices`
--

DROP TABLE IF EXISTS `invoices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `invoices` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tanggal` datetime NOT NULL,
  `grand_total` double NOT NULL,
  `diskon_nominal` double DEFAULT NULL,
  `konsumens_id` int(11) NOT NULL,
  `kasir_id` int(11) DEFAULT NULL,
  `status` enum('PENDING','VALIDASI','TERBAYAR') NOT NULL DEFAULT 'PENDING',
  PRIMARY KEY (`id`),
  KEY `fk_invoices_konsumens1_idx` (`konsumens_id`),
  KEY `fk_invoices_pegawais1_idx` (`kasir_id`),
  CONSTRAINT `fk_invoices_konsumens1` FOREIGN KEY (`konsumens_id`) REFERENCES `konsumens` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_invoices_pegawais1` FOREIGN KEY (`kasir_id`) REFERENCES `pegawais` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoices`
--

LOCK TABLES `invoices` WRITE;
/*!40000 ALTER TABLE `invoices` DISABLE KEYS */;
INSERT INTO `invoices` VALUES (1,'2023-01-01 00:00:00',100000,0,1,3,'TERBAYAR'),(2,'2023-02-02 00:00:00',600000,0,5,6,'TERBAYAR'),(3,'2023-11-21 00:00:00',60000,0,3,6,'TERBAYAR'),(4,'2023-09-05 00:00:00',100000,0,1,3,'TERBAYAR'),(5,'2023-09-19 00:00:00',180000,0,2,6,'TERBAYAR'),(6,'2023-08-21 00:00:00',120000,0,7,3,'TERBAYAR');
/*!40000 ALTER TABLE `invoices` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jadwal_films`
--

DROP TABLE IF EXISTS `jadwal_films`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jadwal_films` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tanggal` date NOT NULL,
  `jam_pemutaran` enum('I','II','III','IV') NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jadwal_films`
--

LOCK TABLES `jadwal_films` WRITE;
/*!40000 ALTER TABLE `jadwal_films` DISABLE KEYS */;
INSERT INTO `jadwal_films` VALUES (1,'2023-09-28','I'),(2,'2023-09-28','II'),(3,'2023-12-07','I'),(4,'2023-12-19','I'),(5,'2023-12-19','II'),(6,'2023-12-20','I'),(7,'2023-12-20','II'),(8,'2023-07-02','I'),(9,'2023-07-08','I'),(10,'2023-07-05','I'),(11,'2023-07-02','II'),(12,'2023-07-08','II'),(13,'2023-07-05','II'),(14,'2023-07-02','III'),(15,'2023-07-08','III'),(16,'2023-07-05','III'),(17,'2023-08-13','I'),(18,'2023-08-13','II'),(19,'2023-08-14','I'),(20,'2023-08-14','II'),(21,'2023-08-15','I'),(22,'2023-08-15','II'),(23,'2023-08-16','I'),(24,'2023-08-16','II'),(25,'2023-08-17','I'),(26,'2023-08-17','II'),(27,'2023-08-18','I'),(28,'2023-08-18','II'),(29,'2024-01-19','I'),(30,'2024-01-19','II'),(31,'2024-01-19','III'),(32,'2024-01-20','I'),(33,'2024-01-20','II'),(34,'2024-01-20','III'),(35,'2024-01-21','I'),(36,'2024-01-21','II'),(37,'2024-01-21','III'),(38,'2024-01-22','I'),(39,'2024-01-22','II'),(40,'2024-01-22','III'),(41,'2024-01-23','I'),(42,'2024-01-23','II'),(43,'2024-01-23','III'),(44,'2024-01-24','I'),(45,'2024-01-24','II'),(46,'2024-01-24','III'),(47,'2024-01-25','I'),(48,'2024-01-25','II'),(49,'2024-01-25','III'),(50,'2024-01-26','I'),(51,'2024-01-26','II'),(52,'2024-01-26','III'),(53,'2024-01-27','I'),(54,'2024-01-27','II'),(55,'2024-01-27','III'),(56,'2024-01-28','I'),(57,'2024-01-28','II'),(58,'2024-01-28','III');
/*!40000 ALTER TABLE `jadwal_films` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jenis_studios`
--

DROP TABLE IF EXISTS `jenis_studios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jenis_studios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) NOT NULL,
  `deskripsi` varchar(355) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jenis_studios`
--

LOCK TABLES `jenis_studios` WRITE;
/*!40000 ALTER TABLE `jenis_studios` DISABLE KEYS */;
INSERT INTO `jenis_studios` VALUES (1,'Reguler / Deluxe','Menawarkan pengalaman menonton dengan teknologi digital dan kualitas audio bersertifikat THX, dilengkapi dengan sofa yang empuk untuk kenyamanan penonton​​​​.'),(2,'Dolby Atmos','Menyuguhkan pengalaman audio yang imersif dengan total 64 speaker yang terhubung ke Atmos enabled amplifier, memungkinkan suara yang realistis dan pengalaman menonton yang mendalam​​​​.'),(3,'IMAX','Khusus dengan teknologi kamera IMAX untuk film yang diproduksi secara spesifik, memberikan gambar maksimal dan pengalaman audiovisual yang sangat mendetail​​.'),(4,'The Premiere / Velvet Class','Menawarkan pengalaman menonton eksklusif dengan sofa kulit yang sangat empuk, dilengkapi dengan layanan pemesanan makanan di tempat, menciptakan suasana yang mewah dan elegan​​.'),(5,'3D','Memungkinkan penonton untuk menikmati film dengan efek visual tiga dimensi, memberikan sensasi yang lebih hidup dan memasukkan penonton ke dalam aksi film​​.'),(6,'Gold Class','Pengalaman menonton terbaik dengan layanan pelanggan maksimal, nuansa premium dan pribadi di bioskop.'),(7,'Velvet Class','Rasakan konsep Sofa Bed pertama di Bioskop Indonesia, pengalaman menonton film dengan kenyamanan dan kemudahan terbaik. Dengan pelayanan pelanggan maksimal, nuansa premium dan privasi di dalam bioskop.'),(8,'Satin Class','Kenyamanan kelas gold tanpa menguras dompet Anda. Pengalaman premium yang terjangkau.'),(9,'Sweetbox','Fitur baru yang dirancang khusus untuk dua orang dengan kursi yang nyaman dan luas kini hadir di CGV.'),(10,'4DX','Auditorium khusus untuk pengalaman lima indera, di mana dapat merasakan berbagai efek lingkungan yang sesuai dengan film. Lebih dari sekadar menonton film, penonton dapat merasakan seolah-olah mereka adalah karakter utama dalam film tersebut, dan efek 4DX yang memaksimalkan kehidupan setiap adegan memungkinkan penonton untuk lebih tenggelam dalam film.'),(11,'ScreenX','Auditorium proyeksi multi-layar pertama di dunia yang menyediakan imersi maksimum melampaui batas layar. Melampaui layar menjadi ruang!\r\n'),(12,'Starium','Layar dengan skala yang memukau semua indera, kualitas gambar yang sangat jernih, dan suara menggelegar dari 16 kanal.'),(13,'SphereX','Teknologi sinematik terbaik dalam Layar, Suara, dan Kursi. Nikmati layar lengkung yang memukau dalam kursi yang dapat direbahkan dan rasakan efek dari sistem suara yang memenuhi ruangan.');
/*!40000 ALTER TABLE `jenis_studios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kelompoks`
--

DROP TABLE IF EXISTS `kelompoks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kelompoks` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kelompoks`
--

LOCK TABLES `kelompoks` WRITE;
/*!40000 ALTER TABLE `kelompoks` DISABLE KEYS */;
INSERT INTO `kelompoks` VALUES (1,'Semua Umur (SU)'),(2,'13+'),(3,'17+'),(4,'21+');
/*!40000 ALTER TABLE `kelompoks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `konsumens`
--

DROP TABLE IF EXISTS `konsumens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `konsumens` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `no_hp` varchar(45) NOT NULL,
  `gender` enum('L','P') NOT NULL,
  `tgl_lahir` date NOT NULL,
  `saldo` double DEFAULT 0,
  `username` varchar(45) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `konsumens`
--

LOCK TABLES `konsumens` WRITE;
/*!40000 ALTER TABLE `konsumens` DISABLE KEYS */;
INSERT INTO `konsumens` VALUES (1,'hulk','hulk123@gmail.com','081234567890','L','2003-05-01',1000000,'hulk123','3c9909afec25354d551dae21590bb26e38d53f2173b8d3dc3eee4c047e7ab1c1eb8b85103e3be7ba613b31bb5c9c36214dc9f14a42fd7a2fdb84856bca5c44c2'),(2,'alice','alice123@gmail.com','081212345678','P','1990-04-12',1500000,'alice123','bc547750b92797f955b36112cc9bdd5cddf7d0862151d03a167ada8995aa24a9ad24610b36a68bc02da24141ee51670aea13ed6469099a4453f335cb239db5da'),(3,'bob','bob123@gmail.com','081223456789','L','1985-07-20',2000000,'bob123','92a891f888e79d1c2e8b82663c0f37cc6d61466c508ec62b8132588afe354712b20bb75429aa20aa3ab7cfcc58836c734306b43efd368080a2250831bf7f363f'),(4,'charlie','charlie123@gmail.com','081234567890','L','1992-10-15',1200000,'charlie123','2a64d6563d9729493f91bf5b143365c0a7bec4025e1fb0ae67e307a0c3bed1c28cfb259fc6be768ab0a962b1e2c9527c5f21a1090a9b9b2d956487eb97ad4209'),(5,'diana','diana123@gmail.com','081245678901','P','1988-12-30',1800000,'diana123','11961811bd4e11f23648afbd2d5c251d2784827147f1731be010adaf0ab38ae18e5567c6fd1bee50a4cd35fb544b3c594e7d677efa7ca01c2a2cb47f8fb12b17'),(6,'edward','edward123@gmail.com','081256789012','L','1993-03-22',1700000,'edward123','39c6f5329e959b2af0deb0f8dacbcdf5418204f46baed50388f62b047c9223c66ff470031ecd653a49f6eff6fa876811e46f0c269390a8bf61f4f983729e1083'),(7,'fiona','fiona123@gmail.com','081267890123','P','1995-06-04',1300000,'fiona123','011324228a766d0d06e56bd4c61fa8bffa4bc1dd01eb6892f906ef93cb9ba3f4a4243fe40f3e54314115bf0c0eac80bc630ed4dccf7ba6f22b12d9261cca7daa'),(8,'george','george123@gmail.com','081278901234','L','1991-09-17',2200000,'george123','a7d785790aecb79a4a3bcd5197301ae76897f83a2424a9b84160ed12a5def47f66d5a88ce5e6032be7e0e91b912d92e1b64f97b1d13a5096eec097470dee7764'),(9,'hannah','hannah123@gmail.com','081289012345','P','1994-11-28',1400000,'hannah123','219aab6b2cf738d9f370e197ce0151be42ae6095e0d72fa49592865c9d2dde5d2fa72e908ac374cba55426e6d0ed39324fd6de1d5da2641cc7f4491f5edd931f'),(10,'ian','ian123@gmail.com','081290123456','L','1987-02-10',1600000,'ian123','26e261e3003a175c800a2c48f96972793676e8ab464d0e73da50b1c8d359ed4bac5ee660bfe3ee9a9362ad42ca3c9aa793ab4f707b163dfea4d89b64fae0a0b9'),(11,'julia','julia123@gmail.com','081201234567','P','1986-05-23',2100000,'julia123','2ce5f635d25b791d37a92c99f0af6df02a68fa695b74f90685e7d93ed3f5a61a715168541954b4c2feec9fd39fcc4df74fef1b9211e12ca96dc03efba2e6a31e'),(12,'kevin','kevin123@gmail.com','081212345678','L','1989-08-16',2300000,'kevin123','f272bde3a05d1e2beacff0852af0935518c8e5977ac79413fa89d169c461f6b5d60eeefd6b128470c36c14e4f5a1cf192d01f93caa01dcb55ce6fedf8008173c'),(13,'laura','laura123@gmail.com','081223456789','P','1996-01-09',1500000,'laura123','552dc2e616c351e1a6ffaadb32dbacbaaeeb8359a9f6ec33668e9265997c8aa8fa8b501c6759b989742bf0b4e566ecf2079f9359d3224ecef116ce42c4ec07ad'),(14,'mike','mike123@gmail.com','081234567890','L','1984-04-03',1900000,'mike123','34ca329b0e0e8310bf012bc3cfd56e2ddf1ac6e734baab744a87fae59ada3e510306d9a701515e99770b20f42e5097a9b476be4835f8e599e3e38ddce521a4fb'),(15,'nina','nina123@gmail.com','081245678901','P','1997-07-27',1300000,'nina123','6c83e3c2b8a035bf55c774f4d9e150bfa292b61754883e188b0013a92ef3594e113f087854e3704d14f78079dbb37068c981159e2621f934018496cf730146dc'),(16,'oliver','oliver123@gmail.com','081256789012','L','1983-10-20',2100000,'oliver123','5644ed5463aeb778f5a41b5d25ad30dd4813300fec5e79ac82ae2777e59d596775958947a1607938d2162d3c011321fb876dc69c9345dcecce0df94b1cc601b7'),(17,'pamela','pamela123@gmail.com','081267890123','P','1998-12-14',1100000,'pamela123','33378b7b66c511efa8340d2f9101260739a0c512348bfe67b348876c874665d332c770d4ea528d9002496c1f574ed916ebdceb6870b5bea9366dc174bc0a7c5c'),(18,'quentin','quentin123@gmail.com','081278901234','L','1990-03-05',2000000,'quentin123','3bcb5691e05414034706c825ae61c62ef66d5db3647846e9570ee333c2cf31124b9c106c740d288be78eff4134251d748fbeef175d6ff587d38f8ecc3a3eb31d'),(19,'rachel','rachel123@gmail.com','081289012345','P','1991-06-19',1700000,'rachel123','62eb450f0c46e2fe24002cdcf6c8d3d45a4a7fb01737b7e2df2f9c535ca2e082c7dbd58a91ffd01ece48414862ab49d1e31272e036e34038b9fa69b3b0c92afb'),(20,'riki','riki123@gmail.com','081289012345','L','2000-03-20',2700000,'rikil123','3942229e706b3510f1151e84e49b027d76e06392ce9a7be977977d6b9b70a9e6cb2208dc13f4afeac8ecfd55babcd9af3dc1cc00c13f2a3b648df2ec52cd2488'),(21,'Nopal Udin','nopaludin50@gmail.com','081234163718','L','1945-08-17',1000000,'nopaludin','3106df54278dde8e7371bb9cbb39971ed0b74b638f0184bfb0d3bc4c616f2b6f05ebdd23009ccb23879e9c6ca381a2d1d845776a6773b09d6c664e6eb74ecfca'),(23,'Hmm','xk','0000000','P','2020-06-09',1000000,'bbb','5edc1c6a4390075a3ca27f4d4161c46b374b1c3b2d63f846db6fff0c513203c3ac3b14a24a6f09d8bf21407a4842113b5d9aa359d266299c3d6cf9e92db66dbe');
/*!40000 ALTER TABLE `konsumens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pegawais`
--

DROP TABLE IF EXISTS `pegawais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pegawais` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(255) NOT NULL,
  `roles` enum('ADMIN','KASIR','OPERATOR') NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pegawais`
--

LOCK TABLES `pegawais` WRITE;
/*!40000 ALTER TABLE `pegawais` DISABLE KEYS */;
INSERT INTO `pegawais` VALUES (1,'guin','guin123@gmail.com','guin123','3c9909afec25354d551dae21590bb26e38d53f2173b8d3dc3eee4c047e7ab1c1eb8b85103e3be7ba613b31bb5c9c36214dc9f14a42fd7a2fdb84856bca5c44c2','ADMIN'),(2,'yeyen','yeyen123@gmail.com','yeyen123','3c9909afec25354d551dae21590bb26e38d53f2173b8d3dc3eee4c047e7ab1c1eb8b85103e3be7ba613b31bb5c9c36214dc9f14a42fd7a2fdb84856bca5c44c2','OPERATOR'),(3,'bambang','bambang123@gmail.com','bambang123','3c9909afec25354d551dae21590bb26e38d53f2173b8d3dc3eee4c047e7ab1c1eb8b85103e3be7ba613b31bb5c9c36214dc9f14a42fd7a2fdb84856bca5c44c2','KASIR'),(4,'dewi astuti','dewiastuti123@gmail.com','dewiastuti','9f844e5d52173d75ad4f71ac4bbe0d9789caa19e91111335caa0f0a1fec648c5636ebd186e8cfe55f9e61d705be9f687ea7c984b56b19d9b70961b97fe94ce3e','ADMIN'),(5,'eko wahyudi','ekowahyudi123@gmail.com','ekowahyudi','cfd2c696248866dbacde6ca59d48932a0b465714cddd004f3e51bd5f8ee5358cb7d3b11adb3f5e9f4eb35a9f3dae29a7d418b76709d583f0de408aa86aafb229','OPERATOR'),(6,'fina suryani','finasuryani123@gmail.com','finasuryani','a8a50c62cc591d99560caffdced22b6c644794d6cadc92bf8644bae75fc1ce2bc2e58de99a18dfe653961f72882b8cacdedd5dfe0b68da01421f20f60f4ba5ec','KASIR'),(7,'gunawan setiawan','gunawansetiawan123@gmail.com','gunawansetiawan','aa47e32b4e222c66842d5dff045ec159022f0110524a032497eaa1a8a804d9213a5fd0a12279c0ac398643495e1fbbf6aa25bdf27d6c918cf049fdeaf9d81c6d','ADMIN'),(8,'hilda pratiwi','hildapratiwi123@gmail.com','hildapratiwi','8b1f34d5ff5663ea0032a4870780d9bce0c29b00355e937055de1ed66ae640a036fdf0648356d6b96882dea20509b7b9b03aae52b01e8f487b71c217a028a55e','OPERATOR'),(9,'irfan nugroho','irfannugroho123@gmail.com','irfannugroho','44d62c334558dc72b517bf7da2de1c78b44922c261da2be3b0d6f5fed0acd555a9bfc4e60be4404f64600c0b526979714a396ffb66ac5e08a00d190c0f3bfaa1','KASIR'),(10,'joko susanto','jokosusanto123@gmail.com','jokosusanto','56d33bc8b24b2d0f874767c97f0670f19154695a67a540c97a5985165fac9f0fa6cc5cf3b3769761082f6cea2fe4f5dd58552f5aa86ae6745439d7a7b6b5e203','ADMIN'),(11,'kiki rahmawati','kikirahmawati123@gmail.com','kikirahmawati','7688af25bc2d246cac08ddde1a15938b5de865f8b2a332d74b7080cf63153870944cfe9bb7f11270a4b5cec85bd31b3995e46c6eb59a3ea0213d47ff9bd5888b','OPERATOR'),(12,'linda yuliani','lindayuliani123@gmail.com','lindayuliani','31de0699377dd5462a750c0e412f537885d959b5bc684a81a59782588c580bf64fa0cdd94f99deca2b3b5540ce41526b280f1fcb679c5edf8db36532781c2134','KASIR'),(13,'maman suryaman','mamansuryaman123@gmail.com','mamansuryaman','b5ae3ff4a2548f654e2c0dfd0a0804d5818ecf1fd49d21cac27d772a2c0704cb026ebef0b77ea255c047483d2b3e6cf099b90e74a791ab5420e72530d63f1064','ADMIN'),(14,'nina kusumawati','ninakusumawati123@gmail.com','ninakusumawati','4f15df6c7373c0b1e701c424b19bfb169b8e38c2404a364c691594f96daf96fb6f882b6ec898b3d0fbd5a547bde6ee2c7d04976bbb4339345a4324f585c51dd1','OPERATOR'),(15,'opik ramadhan','opikramadhan123@gmail.com','opikramadhan','f4a0ed0878015a53ffb42612e34b82d717f5c8b9e69420f01cc76fd37782b313928fbef1a3edd6ea895238e43b8f85072b8305bd842e8f8cc95e884a62b47849','KASIR'),(16,'putri anggraini','putrianggraini123@gmail.com','putrianggraini','ea0e8e58c07a70c8cfdd8e2fcfeb15bc2df6564073e2dab61c2cec0028d2f663ab0323279f0a530caa44cb1bef91fb6ccd097ccb0a6b72a38da86975cad1c8a7','ADMIN'),(17,'rafi ahmad','rafiahmad123@gmail.com','rafiahmad','088bf5d78881ddee586593982fa27ca2f54e688ef7d814cf1440b3a130023d37d2dd8ace034e21d9c208dce88fba9ac9880483e42a98b3a3177735fed46103b9','OPERATOR'),(18,'siti fatimah','sitifatimah123@gmail.com','sitifatimah','7f966d74bd98f48754255145e637d11aa81d8668df96de312847912ddfcd8fdf8e0ad4085786928e569363a4d3e83a85f54b03492d86e69a0b69a60af300b080','KASIR'),(19,'tomy susilo','tomysusilo123@gmail.com','tomysusilo','070ba7107b8261d9f4c36124c25e0ddd80cbeb53b56b537850d43bde1485b469dcd103cf749a9890cd6a2737da3daac8bd7ac9b9946bf4de36b3d056001d982c','ADMIN'),(20,'umi kalsum','umikalsum123@gmail.com','umikalsum','aaf06d62a6794c1d41dec02fc86364a9c5a26610048dbf16ebcb035d7436b4b40b6bf57e0725e7e406bf8178aa0c7804dc726d92ef9fc87cbddf85f463c636c4','OPERATOR'),(22,'xxx','xxx','xxx','9057ff1aa9509b2a0af624d687461d2bbeb07e2f37d953b1ce4a9dc921a7f19c45dc35d7c5363b373792add57d0d7dc41596e1c585d6ef7844cdf8ae87af443f','ADMIN');
/*!40000 ALTER TABLE `pegawais` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sesi_films`
--

DROP TABLE IF EXISTS `sesi_films`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sesi_films` (
  `jadwal_film_id` int(11) NOT NULL,
  `studios_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL,
  PRIMARY KEY (`jadwal_film_id`,`studios_id`,`films_id`),
  KEY `fk_jadwal_film_has_film_studio_film_studio1_idx` (`studios_id`,`films_id`),
  KEY `fk_jadwal_film_has_film_studio_jadwal_film1_idx` (`jadwal_film_id`),
  CONSTRAINT `fk_jadwal_film_has_film_studio_film_studio1` FOREIGN KEY (`studios_id`, `films_id`) REFERENCES `film_studio` (`studios_id`, `films_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_jadwal_film_has_film_studio_jadwal_film1` FOREIGN KEY (`jadwal_film_id`) REFERENCES `jadwal_films` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sesi_films`
--

LOCK TABLES `sesi_films` WRITE;
/*!40000 ALTER TABLE `sesi_films` DISABLE KEYS */;
INSERT INTO `sesi_films` VALUES (1,1,1),(1,1,2),(1,1,3),(1,1,4),(1,1,7),(1,1,8),(1,1,9),(1,1,11),(1,1,15),(1,2,1),(1,2,2),(1,2,3),(1,2,4),(1,2,7),(1,2,8),(1,2,11),(1,2,12),(1,2,15),(1,3,1),(1,3,2),(1,3,3),(1,3,4),(1,3,7),(1,3,8),(1,3,12),(1,3,15),(1,4,1),(1,4,2),(1,4,3),(1,4,5),(1,4,7),(1,4,9),(1,4,11),(1,5,1),(1,5,2),(1,5,3),(1,5,5),(1,5,8),(1,5,9),(1,5,11),(1,5,12),(1,6,1),(1,6,2),(1,6,3),(1,6,5),(1,7,19),(1,7,20),(1,7,21),(1,7,22),(1,8,19),(1,8,20),(1,8,21),(1,8,22),(1,9,19),(1,9,20),(1,9,21),(1,9,22),(1,10,19),(1,10,20),(1,10,21),(1,10,22),(1,11,19),(1,11,20),(1,11,21),(1,11,22),(1,12,18),(1,12,19),(1,12,22),(1,13,18),(1,13,19),(1,13,22),(1,14,18),(1,14,19),(1,14,22),(29,1,1),(29,1,2),(29,1,3),(29,1,4),(29,1,7),(29,1,8),(29,1,9),(29,1,11),(29,1,15),(29,2,1),(29,2,2),(29,2,3),(29,2,4),(29,2,7),(29,2,8),(29,2,11),(29,2,12),(29,2,15),(29,3,1),(29,3,2),(29,3,3),(29,3,4),(29,3,7),(29,3,8),(29,3,12),(29,3,15),(29,4,1),(29,4,2),(29,4,3),(29,4,5),(29,4,7),(29,4,9),(29,4,11),(29,5,1),(29,5,2),(29,5,3),(29,5,5),(29,5,8),(29,5,9),(29,5,11),(29,5,12),(29,6,1),(29,6,2),(29,6,3),(29,6,5),(29,7,19),(29,7,20),(29,7,21),(29,7,22),(29,8,19),(29,8,20),(29,8,21),(29,8,22),(29,9,19),(29,9,20),(29,9,21),(29,9,22),(29,10,19),(29,10,20),(29,10,21),(29,10,22),(29,11,19),(29,11,20),(29,11,21),(29,11,22),(29,12,18),(29,12,19),(29,12,22),(29,13,18),(29,13,19),(29,13,22),(29,14,18),(29,14,19),(29,14,22),(30,1,1),(30,1,2),(30,1,3),(30,1,4),(30,1,7),(30,1,8),(30,1,9),(30,1,11),(30,1,15),(30,2,1),(30,2,2),(30,2,3),(30,2,4),(30,2,7),(30,2,8),(30,2,11),(30,2,12),(30,2,15),(30,3,1),(30,3,2),(30,3,3),(30,3,4),(30,3,7),(30,3,8),(30,3,12),(30,3,15),(30,4,1),(30,4,2),(30,4,3),(30,4,5),(30,4,7),(30,4,9),(30,4,11),(30,5,1),(30,5,2),(30,5,3),(30,5,5),(30,5,8),(30,5,9),(30,5,11),(30,5,12),(30,6,1),(30,6,2),(30,6,3),(30,6,5),(30,7,19),(30,7,20),(30,7,21),(30,7,22),(30,8,19),(30,8,20),(30,8,21),(30,8,22),(30,9,19),(30,9,20),(30,9,21),(30,9,22),(30,10,19),(30,10,20),(30,10,21),(30,10,22),(30,11,19),(30,11,20),(30,11,21),(30,11,22),(30,12,18),(30,12,19),(30,12,22),(30,13,18),(30,13,19),(30,13,22),(30,14,18),(30,14,19),(30,14,22),(31,1,1),(31,1,2),(31,1,3),(31,1,4),(31,1,7),(31,1,8),(31,1,9),(31,1,11),(31,1,15),(31,2,1),(31,2,2),(31,2,3),(31,2,4),(31,2,7),(31,2,8),(31,2,11),(31,2,12),(31,2,15),(31,3,1),(31,3,2),(31,3,3),(31,3,4),(31,3,7),(31,3,8),(31,3,12),(31,3,15),(31,4,1),(31,4,2),(31,4,3),(31,4,5),(31,4,7),(31,4,9),(31,4,11),(31,5,1),(31,5,2),(31,5,3),(31,5,5),(31,5,8),(31,5,9),(31,5,11),(31,5,12),(31,6,1),(31,6,2),(31,6,3),(31,6,5),(31,7,19),(31,7,20),(31,7,21),(31,7,22),(31,8,19),(31,8,20),(31,8,21),(31,8,22),(31,9,19),(31,9,20),(31,9,21),(31,9,22),(31,10,19),(31,10,20),(31,10,21),(31,10,22),(31,11,19),(31,11,20),(31,11,21),(31,11,22),(31,12,18),(31,12,19),(31,12,22),(31,13,18),(31,13,19),(31,13,22),(31,14,18),(31,14,19),(31,14,22),(32,1,1),(32,1,2),(32,1,3),(32,1,4),(32,1,7),(32,1,8),(32,1,9),(32,1,11),(32,1,15),(32,2,1),(32,2,2),(32,2,3),(32,2,4),(32,2,7),(32,2,8),(32,2,11),(32,2,12),(32,2,15),(32,3,1),(32,3,2),(32,3,3),(32,3,4),(32,3,7),(32,3,8),(32,3,12),(32,3,15),(32,4,1),(32,4,2),(32,4,3),(32,4,5),(32,4,7),(32,4,9),(32,4,11),(32,5,1),(32,5,2),(32,5,3),(32,5,5),(32,5,8),(32,5,9),(32,5,11),(32,5,12),(32,6,1),(32,6,2),(32,6,3),(32,6,5),(32,7,19),(32,7,20),(32,7,21),(32,7,22),(32,8,19),(32,8,20),(32,8,21),(32,8,22),(32,9,19),(32,9,20),(32,9,21),(32,9,22),(32,10,19),(32,10,20),(32,10,21),(32,10,22),(32,11,19),(32,11,20),(32,11,21),(32,11,22),(32,12,18),(32,12,19),(32,12,22),(32,13,18),(32,13,19),(32,13,22),(32,14,18),(32,14,19),(32,14,22),(33,1,1),(33,1,2),(33,1,3),(33,1,4),(33,1,7),(33,1,8),(33,1,9),(33,1,11),(33,1,15),(33,2,1),(33,2,2),(33,2,3),(33,2,4),(33,2,7),(33,2,8),(33,2,11),(33,2,12),(33,2,15),(33,3,1),(33,3,2),(33,3,3),(33,3,4),(33,3,7),(33,3,8),(33,3,12),(33,3,15),(33,4,1),(33,4,2),(33,4,3),(33,4,5),(33,4,7),(33,4,9),(33,4,11),(33,5,1),(33,5,2),(33,5,3),(33,5,5),(33,5,8),(33,5,9),(33,5,11),(33,5,12),(33,6,1),(33,6,2),(33,6,3),(33,6,5),(33,7,19),(33,7,20),(33,7,21),(33,7,22),(33,8,19),(33,8,20),(33,8,21),(33,8,22),(33,9,19),(33,9,20),(33,9,21),(33,9,22),(33,10,19),(33,10,20),(33,10,21),(33,10,22),(33,11,19),(33,11,20),(33,11,21),(33,11,22),(33,12,18),(33,12,19),(33,12,22),(33,13,18),(33,13,19),(33,13,22),(33,14,18),(33,14,19),(33,14,22),(34,1,1),(34,1,2),(34,1,3),(34,1,4),(34,1,7),(34,1,8),(34,1,9),(34,1,11),(34,1,15),(34,2,1),(34,2,2),(34,2,3),(34,2,4),(34,2,7),(34,2,8),(34,2,11),(34,2,12),(34,2,15),(34,3,1),(34,3,2),(34,3,3),(34,3,4),(34,3,7),(34,3,8),(34,3,12),(34,3,15),(34,4,1),(34,4,2),(34,4,3),(34,4,5),(34,4,7),(34,4,9),(34,4,11),(34,5,1),(34,5,2),(34,5,3),(34,5,5),(34,5,8),(34,5,9),(34,5,11),(34,5,12),(34,6,1),(34,6,2),(34,6,3),(34,6,5),(34,7,19),(34,7,20),(34,7,21),(34,7,22),(34,8,19),(34,8,20),(34,8,21),(34,8,22),(34,9,19),(34,9,20),(34,9,21),(34,9,22),(34,10,19),(34,10,20),(34,10,21),(34,10,22),(34,11,19),(34,11,20),(34,11,21),(34,11,22),(34,12,18),(34,12,19),(34,12,22),(34,13,18),(34,13,19),(34,13,22),(34,14,18),(34,14,19),(34,14,22),(35,1,1),(35,1,2),(35,1,3),(35,1,4),(35,1,7),(35,1,8),(35,1,9),(35,1,11),(35,1,15),(35,2,1),(35,2,2),(35,2,3),(35,2,4),(35,2,7),(35,2,8),(35,2,11),(35,2,12),(35,2,15),(35,3,1),(35,3,2),(35,3,3),(35,3,4),(35,3,7),(35,3,8),(35,3,12),(35,3,15),(35,4,1),(35,4,2),(35,4,3),(35,4,5),(35,4,7),(35,4,9),(35,4,11),(35,5,1),(35,5,2),(35,5,3),(35,5,5),(35,5,8),(35,5,9),(35,5,11),(35,5,12),(35,6,1),(35,6,2),(35,6,3),(35,6,5),(35,7,19),(35,7,20),(35,7,21),(35,7,22),(35,8,19),(35,8,20),(35,8,21),(35,8,22),(35,9,19),(35,9,20),(35,9,21),(35,9,22),(35,10,19),(35,10,20),(35,10,21),(35,10,22),(35,11,19),(35,11,20),(35,11,21),(35,11,22),(35,12,18),(35,12,19),(35,12,22),(35,13,18),(35,13,19),(35,13,22),(35,14,18),(35,14,19),(35,14,22),(36,1,1),(36,1,2),(36,1,3),(36,1,4),(36,1,7),(36,1,8),(36,1,9),(36,1,11),(36,1,15),(36,2,1),(36,2,2),(36,2,3),(36,2,4),(36,2,7),(36,2,8),(36,2,11),(36,2,12),(36,2,15),(36,3,1),(36,3,2),(36,3,3),(36,3,4),(36,3,7),(36,3,8),(36,3,12),(36,3,15),(36,4,1),(36,4,2),(36,4,3),(36,4,5),(36,4,7),(36,4,9),(36,4,11),(36,5,1),(36,5,2),(36,5,3),(36,5,5),(36,5,8),(36,5,9),(36,5,11),(36,5,12),(36,6,1),(36,6,2),(36,6,3),(36,6,5),(36,7,19),(36,7,20),(36,7,21),(36,7,22),(36,8,19),(36,8,20),(36,8,21),(36,8,22),(36,9,19),(36,9,20),(36,9,21),(36,9,22),(36,10,19),(36,10,20),(36,10,21),(36,10,22),(36,11,19),(36,11,20),(36,11,21),(36,11,22),(36,12,18),(36,12,19),(36,12,22),(36,13,18),(36,13,19),(36,13,22),(36,14,18),(36,14,19),(36,14,22);
/*!40000 ALTER TABLE `sesi_films` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studios`
--

DROP TABLE IF EXISTS `studios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `studios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) NOT NULL,
  `kapasitas` int(11) NOT NULL,
  `jenis_studios_id` int(11) NOT NULL,
  `cinemas_id` int(11) NOT NULL,
  `harga_weekday` int(11) NOT NULL,
  `harga_weekend` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_studios_jenis_studios_idx` (`jenis_studios_id`),
  KEY `fk_studios_cinemas1_idx` (`cinemas_id`),
  CONSTRAINT `fk_studios_cinemas1` FOREIGN KEY (`cinemas_id`) REFERENCES `cinemas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_studios_jenis_studios` FOREIGN KEY (`jenis_studios_id`) REFERENCES `jenis_studios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studios`
--

LOCK TABLES `studios` WRITE;
/*!40000 ALTER TABLE `studios` DISABLE KEYS */;
INSERT INTO `studios` VALUES (1,'1',64,2,4,45000,70000),(2,'2',24,1,6,40000,70000),(3,'3',24,1,6,40000,70000),(4,'4',64,2,9,50000,70000),(5,'5',24,1,9,40000,70000),(6,'6',64,2,9,50000,70000),(7,'A',84,2,7,30000,60000),(8,'B',64,1,7,40000,70000),(9,'C',64,1,7,40000,70000),(10,'D',48,2,7,30000,60000),(11,'E',48,2,7,35000,70000),(12,'I',48,2,12,60000,50000),(13,'II',48,3,12,70000,65000),(14,'III',48,5,12,80000,70000);
/*!40000 ALTER TABLE `studios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tikets`
--

DROP TABLE IF EXISTS `tikets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tikets` (
  `invoices_id` int(11) NOT NULL,
  `nomor_kursi` varchar(3) NOT NULL,
  `status_hadir` tinyint(4) DEFAULT NULL,
  `operator_id` int(11) NOT NULL,
  `harga` double NOT NULL,
  `jadwal_film_id` int(11) NOT NULL,
  `studios_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL,
  PRIMARY KEY (`invoices_id`,`nomor_kursi`),
  KEY `fk_film_studio_has_invoices_invoices1_idx` (`invoices_id`),
  KEY `fk_film_studio_has_invoices_pegawais1_idx` (`operator_id`),
  KEY `fk_tikets_sesi_films1_idx` (`jadwal_film_id`,`studios_id`,`films_id`),
  CONSTRAINT `fk_film_studio_has_invoices_invoices1` FOREIGN KEY (`invoices_id`) REFERENCES `invoices` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_film_studio_has_invoices_pegawais1` FOREIGN KEY (`operator_id`) REFERENCES `pegawais` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tikets_sesi_films1` FOREIGN KEY (`jadwal_film_id`, `studios_id`, `films_id`) REFERENCES `sesi_films` (`jadwal_film_id`, `studios_id`, `films_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tikets`
--

LOCK TABLES `tikets` WRITE;
/*!40000 ALTER TABLE `tikets` DISABLE KEYS */;
INSERT INTO `tikets` VALUES (1,'5',1,5,20000,1,1,1),(1,'6',1,5,20000,1,1,1),(1,'7',1,5,20000,1,1,1),(1,'8',1,5,20000,1,1,1),(2,'1',1,8,30000,1,1,15),(2,'10',1,8,30000,1,1,15),(2,'11',1,8,30000,1,1,15),(2,'12',1,8,30000,1,1,15),(2,'13',1,8,30000,1,1,15),(2,'14',1,8,30000,1,1,15),(2,'15',1,8,30000,1,1,15),(2,'16',1,8,30000,1,1,15),(2,'17',1,8,30000,1,1,15),(2,'18',1,8,30000,1,1,15),(2,'19',1,8,30000,1,1,15),(2,'2',1,8,30000,1,1,15),(2,'20',1,8,30000,1,1,15),(2,'3',1,8,30000,1,1,15),(2,'4',1,8,30000,1,1,15),(2,'5',1,8,30000,1,1,15),(2,'6',1,8,30000,1,1,15),(2,'7',1,8,30000,1,1,15),(2,'8',1,8,30000,1,1,15),(2,'9',1,8,30000,1,1,15);
/*!40000 ALTER TABLE `tikets` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-17  9:27:16
