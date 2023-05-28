-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: shopisa
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.25-MariaDB

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
-- Table structure for table `tbarang`
--

DROP TABLE IF EXISTS `tbarang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbarang` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `product_name` varchar(45) NOT NULL,
  `price` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbarang`
--

LOCK TABLES `tbarang` WRITE;
/*!40000 ALTER TABLE `tbarang` DISABLE KEYS */;
INSERT INTO `tbarang` VALUES (1,'Archaic Petra','15000'),(2,'Crimson Witch of Flames','20000'),(3,'Deepwood Memories','35000'),(4,'Blizzard Strayer','15000'),(5,'Emblem of Severed Fate','100000');
/*!40000 ALTER TABLE `tbarang` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tjabatan`
--

DROP TABLE IF EXISTS `tjabatan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tjabatan` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `role_name` enum('Penjual','Pembeli','Administrator') NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tjabatan`
--

LOCK TABLES `tjabatan` WRITE;
/*!40000 ALTER TABLE `tjabatan` DISABLE KEYS */;
INSERT INTO `tjabatan` VALUES (1,'Administrator'),(2,'Pembeli'),(3,'Penjual');
/*!40000 ALTER TABLE `tjabatan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tnotabeli`
--

DROP TABLE IF EXISTS `tnotabeli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tnotabeli` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tanggal` date DEFAULT NULL,
  `tUser_id` int(11) NOT NULL,
  `tBarang_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_tNotaBeli_tUser1_idx` (`tUser_id`),
  KEY `fk_tNotaBeli_tBarang1_idx` (`tBarang_id`),
  CONSTRAINT `fk_tNotaBeli_tBarang1` FOREIGN KEY (`tBarang_id`) REFERENCES `tbarang` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tNotaBeli_tUser1` FOREIGN KEY (`tUser_id`) REFERENCES `tuser` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tnotabeli`
--

LOCK TABLES `tnotabeli` WRITE;
/*!40000 ALTER TABLE `tnotabeli` DISABLE KEYS */;
/*!40000 ALTER TABLE `tnotabeli` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tuser`
--

DROP TABLE IF EXISTS `tuser`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tuser` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `tRole_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_tUser_tRole_idx` (`tRole_id`),
  CONSTRAINT `fk_tUser_tRole` FOREIGN KEY (`tRole_id`) REFERENCES `tjabatan` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tuser`
--

LOCK TABLES `tuser` WRITE;
/*!40000 ALTER TABLE `tuser` DISABLE KEYS */;
INSERT INTO `tuser` VALUES (1,'5kMlCAAYK54=','5kMlCAAYK54=',1),(2,'WKPx1iyPZkM=','WKPx1iyPZkM=',1),(3,'C0vutNnet0c=','C0vutNnet0c=',1);
/*!40000 ALTER TABLE `tuser` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-30 14:54:55
