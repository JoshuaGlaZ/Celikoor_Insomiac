-- MariaDB dump 10.19  Distrib 10.6.12-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: insomiac
-- ------------------------------------------------------
-- Server version	10.6.12-MariaDB-0ubuntu0.22.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aktors`
--

LOCK TABLES `aktors` WRITE;
/*!40000 ALTER TABLE `aktors` DISABLE KEYS */;
INSERT INTO `aktors` VALUES (1,'Andi Setiawan','1980-01-05','L','Indonesia'),(2,'Budi Raharjo','1975-02-10','L','Indonesia'),(3,'Citra Kirana','1988-03-15','P','Indonesia'),(4,'Dian Sastrowardoyo','1990-04-20','P','Indonesia'),(5,'Eko Yuli','1985-05-25','L','Indonesia'),(6,'Fitri Tropica','1983-06-30','P','Indonesia'),(7,'Galih Ginanjar','1978-07-05','L','Indonesia'),(8,'Hilda Vitria','1987-08-10','P','Indonesia'),(9,'Irfan Hakim','1979-09-15','L','Indonesia'),(10,'Jessica Iskandar','1982-10-20','P','Indonesia'),(11,'Kiki Fatmala','1981-11-25','P','Indonesia'),(12,'Luna Maya','1986-12-30','P','Indonesia'),(13,'Mario Lawalata','1984-01-04','L','Indonesia'),(14,'Nia Ramadhani','1989-02-09','P','Indonesia'),(15,'Olla Ramlan','1977-03-15','P','Indonesia'),(16,'Pevita Pearce','1992-04-19','P','Indonesia'),(17,'Raffi Ahmad','1983-05-24','L','Indonesia'),(18,'Syahrini','1985-06-29','P','Indonesia'),(19,'Titi Kamal','1979-07-04','P','Indonesia'),(20,'Ussy Sulistiawaty','1981-08-09','P','Indonesia');
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
  `alamat` varchar(45) NOT NULL,
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
INSERT INTO `cinemas` VALUES (1,'Cinema Central','Jl. Merdeka No. 1','2010-06-15','Jakarta'),(2,'Starlight Theater','Jl. Raya Surya Kencana No. 23','2012-03-20','Bandung'),(3,'Galaxy Cinema','Jl. Ahmad Yani No. 45','2015-11-02','Surabaya'),(4,'Dreamland Cinema','Jl. Diponegoro No. 17','2013-07-18','Yogyakarta'),(5,'Mega Screen Cinemas','Jl. Sudirman No. 56','2014-09-10','Semarang'),(6,'Premiere Cinema Complex','Jl. Pahlawan No. 71','2016-12-05','Malang'),(7,'Fantasy Theater','Jl. Majapahit No. 88','2011-08-24','Denpasar'),(8,'Royal Cinema Palace','Jl. Pattimura No. 32','2017-05-30','Makassar'),(9,'Eclipse Movie House','Jl. Gatot Subroto No. 21','2019-01-15','Medan'),(10,'Silver Screen Cinemax','Jl. Hasanuddin No. 18','2018-04-08','Palembang'),(11,'Harmony Cinema','Jl. Sisingamangaraja No. 47','2020-07-22','Pekanbaru'),(12,'Sunshine Theater','Jl. Jendral Sudirman No. 99','2019-10-14','Balikpapan'),(13,'Cineplex 21','Jl. A. Yani No. 12','2021-02-11','Samarinda'),(14,'Grand Theater','Jl. Khatulistiwa No. 34','2017-06-19','Pontianak'),(15,'Metro Cinema','Jl. Merapi No. 22','2016-09-27','Manado'),(16,'Paradise Cinema','Jl. Palapa No. 63','2018-12-31','Jayapura'),(17,'Cinema One','Jl. Letjen S. Parman No. 11','2014-02-15','Bekasi'),(18,'Luxe Movie Theater','Jl. Imam Bonjol No. 78','2015-08-03','Tangerang'),(19,'Aurora Cinemas','Jl. Kalimantan No. 5','2020-03-29','Banjarmasin'),(20,'Horizon Cinema','Jl. Sumatra No. 14','2019-05-20','Batam');
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `films`
--

LOCK TABLES `films` WRITE;
/*!40000 ALTER TABLE `films` DISABLE KEYS */;
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
  `deskripsi` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genres`
--

LOCK TABLES `genres` WRITE;
/*!40000 ALTER TABLE `genres` DISABLE KEYS */;
INSERT INTO `genres` VALUES (1,'Misteri','Film yang penuh teka-teki dan investigasi.'),(2,'Komedi','Film humor yang menghibur penonton.'),(3,'Drama','Film berfokus pengembangan karakter.'),(4,'Fantasi','Film yang mengandung elemen fantastis.'),(5,'Horor','Film yang bertujuan menimbulkan ketakutan.'),(6,'Romantis','Film yang berkisah tentang cinta.'),(7,'Sci-Fi','Film yang berbasis pada ilmu pengetahuan.'),(8,'Thriller','Film dengan ketegangan tinggi.'),(9,'Dokumenter','Film yang menggambarkan peristiwa nyata.'),(10,'Musikal','Film yang mengandung unsur musik.'),(11,'Kriminal','Film yang berkisah tentang kejahatan.'),(12,'War','Film yang menceritakan tentang perang.'),(13,'Sejarah','Film yang berbasis pada peristiwa nyata.'),(14,'Misteri','Film yang penuh teka-teki dan investigasi.'),(15,'Biografi','Film yang menceritakan kisah nyata.');
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoices`
--

LOCK TABLES `invoices` WRITE;
/*!40000 ALTER TABLE `invoices` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jadwal_films`
--

LOCK TABLES `jadwal_films` WRITE;
/*!40000 ALTER TABLE `jadwal_films` DISABLE KEYS */;
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
  `deskripsi` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jenis_studios`
--

LOCK TABLES `jenis_studios` WRITE;
/*!40000 ALTER TABLE `jenis_studios` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kelompoks`
--

LOCK TABLES `kelompoks` WRITE;
/*!40000 ALTER TABLE `kelompoks` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `konsumens`
--

LOCK TABLES `konsumens` WRITE;
/*!40000 ALTER TABLE `konsumens` DISABLE KEYS */;
INSERT INTO `konsumens` VALUES (1,'hulk','hulk123@gmail.com','081234567890','L','2003-05-01',1000000,'hulk123','3c9909afec25354d551dae21590bb26e38d53f2173b8d3dc3eee4c047e7ab1c1eb8b85103e3be7ba613b31bb5c9c36214dc9f14a42fd7a2fdb84856bca5c44c2'),(2,'alice','alice123@gmail.com','081212345678','P','1990-04-12',1500000,'alice123','bc547750b92797f955b36112cc9bdd5cddf7d0862151d03a167ada8995aa24a9ad24610b36a68bc02da24141ee51670aea13ed6469099a4453f335cb239db5da'),(3,'bob','bob123@gmail.com','081223456789','L','1985-07-20',2000000,'bob123','92a891f888e79d1c2e8b82663c0f37cc6d61466c508ec62b8132588afe354712b20bb75429aa20aa3ab7cfcc58836c734306b43efd368080a2250831bf7f363f'),(4,'charlie','charlie123@gmail.com','081234567890','L','1992-10-15',1200000,'charlie123','2a64d6563d9729493f91bf5b143365c0a7bec4025e1fb0ae67e307a0c3bed1c28cfb259fc6be768ab0a962b1e2c9527c5f21a1090a9b9b2d956487eb97ad4209'),(5,'diana','diana123@gmail.com','081245678901','P','1988-12-30',1800000,'diana123','11961811bd4e11f23648afbd2d5c251d2784827147f1731be010adaf0ab38ae18e5567c6fd1bee50a4cd35fb544b3c594e7d677efa7ca01c2a2cb47f8fb12b17'),(6,'edward','edward123@gmail.com','081256789012','L','1993-03-22',1700000,'edward123','39c6f5329e959b2af0deb0f8dacbcdf5418204f46baed50388f62b047c9223c66ff470031ecd653a49f6eff6fa876811e46f0c269390a8bf61f4f983729e1083'),(7,'fiona','fiona123@gmail.com','081267890123','P','1995-06-04',1300000,'fiona123','011324228a766d0d06e56bd4c61fa8bffa4bc1dd01eb6892f906ef93cb9ba3f4a4243fe40f3e54314115bf0c0eac80bc630ed4dccf7ba6f22b12d9261cca7daa'),(8,'george','george123@gmail.com','081278901234','L','1991-09-17',2200000,'george123','a7d785790aecb79a4a3bcd5197301ae76897f83a2424a9b84160ed12a5def47f66d5a88ce5e6032be7e0e91b912d92e1b64f97b1d13a5096eec097470dee7764'),(9,'hannah','hannah123@gmail.com','081289012345','P','1994-11-28',1400000,'hannah123','219aab6b2cf738d9f370e197ce0151be42ae6095e0d72fa49592865c9d2dde5d2fa72e908ac374cba55426e6d0ed39324fd6de1d5da2641cc7f4491f5edd931f'),(10,'ian','ian123@gmail.com','081290123456','L','1987-02-10',1600000,'ian123','26e261e3003a175c800a2c48f96972793676e8ab464d0e73da50b1c8d359ed4bac5ee660bfe3ee9a9362ad42ca3c9aa793ab4f707b163dfea4d89b64fae0a0b9'),(11,'julia','julia123@gmail.com','081201234567','P','1986-05-23',2100000,'julia123','2ce5f635d25b791d37a92c99f0af6df02a68fa695b74f90685e7d93ed3f5a61a715168541954b4c2feec9fd39fcc4df74fef1b9211e12ca96dc03efba2e6a31e'),(12,'kevin','kevin123@gmail.com','081212345678','L','1989-08-16',2300000,'kevin123','f272bde3a05d1e2beacff0852af0935518c8e5977ac79413fa89d169c461f6b5d60eeefd6b128470c36c14e4f5a1cf192d01f93caa01dcb55ce6fedf8008173c'),(13,'laura','laura123@gmail.com','081223456789','P','1996-01-09',1500000,'laura123','552dc2e616c351e1a6ffaadb32dbacbaaeeb8359a9f6ec33668e9265997c8aa8fa8b501c6759b989742bf0b4e566ecf2079f9359d3224ecef116ce42c4ec07ad'),(14,'mike','mike123@gmail.com','081234567890','L','1984-04-03',1900000,'mike123','34ca329b0e0e8310bf012bc3cfd56e2ddf1ac6e734baab744a87fae59ada3e510306d9a701515e99770b20f42e5097a9b476be4835f8e599e3e38ddce521a4fb'),(15,'nina','nina123@gmail.com','081245678901','P','1997-07-27',1300000,'nina123','6c83e3c2b8a035bf55c774f4d9e150bfa292b61754883e188b0013a92ef3594e113f087854e3704d14f78079dbb37068c981159e2621f934018496cf730146dc'),(16,'oliver','oliver123@gmail.com','081256789012','L','1983-10-20',2100000,'oliver123','5644ed5463aeb778f5a41b5d25ad30dd4813300fec5e79ac82ae2777e59d596775958947a1607938d2162d3c011321fb876dc69c9345dcecce0df94b1cc601b7'),(17,'pamela','pamela123@gmail.com','081267890123','P','1998-12-14',1100000,'pamela123','33378b7b66c511efa8340d2f9101260739a0c512348bfe67b348876c874665d332c770d4ea528d9002496c1f574ed916ebdceb6870b5bea9366dc174bc0a7c5c'),(18,'quentin','quentin123@gmail.com','081278901234','L','1990-03-05',2000000,'quentin123','3bcb5691e05414034706c825ae61c62ef66d5db3647846e9570ee333c2cf31124b9c106c740d288be78eff4134251d748fbeef175d6ff587d38f8ecc3a3eb31d'),(19,'rachel','rachel123@gmail.com','081289012345','P','1991-06-19',1700000,'rachel123','62eb450f0c46e2fe24002cdcf6c8d3d45a4a7fb01737b7e2df2f9c535ca2e082c7dbd58a91ffd01ece48414862ab49d1e31272e036e34038b9fa69b3b0c92afb'),(20,'riki','riki123@gmail.com','081289012345','L','2000-03-20',2700000,'rikil123','3942229e706b3510f1151e84e49b027d76e06392ce9a7be977977d6b9b70a9e6cb2208dc13f4afeac8ecfd55babcd9af3dc1cc00c13f2a3b648df2ec52cd2488');
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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pegawais`
--

LOCK TABLES `pegawais` WRITE;
/*!40000 ALTER TABLE `pegawais` DISABLE KEYS */;
INSERT INTO `pegawais` VALUES (1,'guin','guin123@gmail.com','guin123','3c9909afec25354d551dae21590bb26e38d53f2173b8d3dc3eee4c047e7ab1c1eb8b85103e3be7ba613b31bb5c9c36214dc9f14a42fd7a2fdb84856bca5c44c2','ADMIN'),(2,'yeyen','yeyen123@gmail.com','yeyen123','3c9909afec25354d551dae21590bb26e38d53f2173b8d3dc3eee4c047e7ab1c1eb8b85103e3be7ba613b31bb5c9c36214dc9f14a42fd7a2fdb84856bca5c44c2','OPERATOR'),(3,'bambang','bambang123@gmail.com','bambang123','3c9909afec25354d551dae21590bb26e38d53f2173b8d3dc3eee4c047e7ab1c1eb8b85103e3be7ba613b31bb5c9c36214dc9f14a42fd7a2fdb84856bca5c44c2','KASIR'),(4,'dewi astuti','dewiastuti123@gmail.com','dewiastuti','9f844e5d52173d75ad4f71ac4bbe0d9789caa19e91111335caa0f0a1fec648c5636ebd186e8cfe55f9e61d705be9f687ea7c984b56b19d9b70961b97fe94ce3e','ADMIN'),(5,'eko wahyudi','ekowahyudi123@gmail.com','ekowahyudi','cfd2c696248866dbacde6ca59d48932a0b465714cddd004f3e51bd5f8ee5358cb7d3b11adb3f5e9f4eb35a9f3dae29a7d418b76709d583f0de408aa86aafb229','OPERATOR'),(6,'fina suryani','finasuryani123@gmail.com','finasuryani','a8a50c62cc591d99560caffdced22b6c644794d6cadc92bf8644bae75fc1ce2bc2e58de99a18dfe653961f72882b8cacdedd5dfe0b68da01421f20f60f4ba5ec','KASIR'),(7,'gunawan setiawan','gunawansetiawan123@gmail.com','gunawansetiawan','aa47e32b4e222c66842d5dff045ec159022f0110524a032497eaa1a8a804d9213a5fd0a12279c0ac398643495e1fbbf6aa25bdf27d6c918cf049fdeaf9d81c6d','ADMIN'),(8,'hilda pratiwi','hildapratiwi123@gmail.com','hildapratiwi','8b1f34d5ff5663ea0032a4870780d9bce0c29b00355e937055de1ed66ae640a036fdf0648356d6b96882dea20509b7b9b03aae52b01e8f487b71c217a028a55e','OPERATOR'),(9,'irfan nugroho','irfannugroho123@gmail.com','irfannugroho','44d62c334558dc72b517bf7da2de1c78b44922c261da2be3b0d6f5fed0acd555a9bfc4e60be4404f64600c0b526979714a396ffb66ac5e08a00d190c0f3bfaa1','KASIR'),(10,'joko susanto','jokosusanto123@gmail.com','jokosusanto','56d33bc8b24b2d0f874767c97f0670f19154695a67a540c97a5985165fac9f0fa6cc5cf3b3769761082f6cea2fe4f5dd58552f5aa86ae6745439d7a7b6b5e203','ADMIN'),(11,'kiki rahmawati','kikirahmawati123@gmail.com','kikirahmawati','7688af25bc2d246cac08ddde1a15938b5de865f8b2a332d74b7080cf63153870944cfe9bb7f11270a4b5cec85bd31b3995e46c6eb59a3ea0213d47ff9bd5888b','OPERATOR'),(12,'linda yuliani','lindayuliani123@gmail.com','lindayuliani','31de0699377dd5462a750c0e412f537885d959b5bc684a81a59782588c580bf64fa0cdd94f99deca2b3b5540ce41526b280f1fcb679c5edf8db36532781c2134','KASIR'),(13,'maman suryaman','mamansuryaman123@gmail.com','mamansuryaman','b5ae3ff4a2548f654e2c0dfd0a0804d5818ecf1fd49d21cac27d772a2c0704cb026ebef0b77ea255c047483d2b3e6cf099b90e74a791ab5420e72530d63f1064','ADMIN'),(14,'nina kusumawati','ninakusumawati123@gmail.com','ninakusumawati','4f15df6c7373c0b1e701c424b19bfb169b8e38c2404a364c691594f96daf96fb6f882b6ec898b3d0fbd5a547bde6ee2c7d04976bbb4339345a4324f585c51dd1','OPERATOR'),(15,'opik ramadhan','opikramadhan123@gmail.com','opikramadhan','f4a0ed0878015a53ffb42612e34b82d717f5c8b9e69420f01cc76fd37782b313928fbef1a3edd6ea895238e43b8f85072b8305bd842e8f8cc95e884a62b47849','KASIR'),(16,'putri anggraini','putrianggraini123@gmail.com','putrianggraini','ea0e8e58c07a70c8cfdd8e2fcfeb15bc2df6564073e2dab61c2cec0028d2f663ab0323279f0a530caa44cb1bef91fb6ccd097ccb0a6b72a38da86975cad1c8a7','ADMIN'),(17,'rafi ahmad','rafiahmad123@gmail.com','rafiahmad','088bf5d78881ddee586593982fa27ca2f54e688ef7d814cf1440b3a130023d37d2dd8ace034e21d9c208dce88fba9ac9880483e42a98b3a3177735fed46103b9','OPERATOR'),(18,'siti fatimah','sitifatimah123@gmail.com','sitifatimah','7f966d74bd98f48754255145e637d11aa81d8668df96de312847912ddfcd8fdf8e0ad4085786928e569363a4d3e83a85f54b03492d86e69a0b69a60af300b080','KASIR'),(19,'tomy susilo','tomysusilo123@gmail.com','tomysusilo','070ba7107b8261d9f4c36124c25e0ddd80cbeb53b56b537850d43bde1485b469dcd103cf749a9890cd6a2737da3daac8bd7ac9b9946bf4de36b3d056001d982c','ADMIN'),(20,'umi kalsum','umikalsum123@gmail.com','umikalsum','aaf06d62a6794c1d41dec02fc86364a9c5a26610048dbf16ebcb035d7436b4b40b6bf57e0725e7e406bf8178aa0c7804dc726d92ef9fc87cbddf85f463c636c4','OPERATOR');
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studios`
--

LOCK TABLES `studios` WRITE;
/*!40000 ALTER TABLE `studios` DISABLE KEYS */;
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

-- Dump completed on 2023-11-24 19:54:57
