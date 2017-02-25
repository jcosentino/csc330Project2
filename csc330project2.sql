CREATE DATABASE  IF NOT EXISTS `csc330project2` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `csc330project2`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: csc330project2
-- ------------------------------------------------------
-- Server version	5.6.28-log

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
-- Table structure for table `carriers`
--

DROP TABLE IF EXISTS `carriers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `carriers` (
  `idcarriers` int(11) NOT NULL,
  `dayDeliver` varchar(45) DEFAULT NULL,
  `idhouseholds` int(11) DEFAULT NULL,
  `idpublications` int(11) DEFAULT NULL,
  `price` double DEFAULT NULL,
  PRIMARY KEY (`idcarriers`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carriers`
--

LOCK TABLES `carriers` WRITE;
/*!40000 ALTER TABLE `carriers` DISABLE KEYS */;
INSERT INTO `carriers` VALUES (107148,'Friday',166141,862971,3.25),(108054,'Sunday',137675,204099,1.5),(108740,'Friday',166141,862971,3.25),(149988,'Friday',200332,511313,2),(176814,'Friday',200332,511313,2),(183989,'Friday',166141,862971,3.25),(203322,'Monday',149163,127544,2.75),(438980,'Saturday',945249,181955,4.2),(785696,'Saturday',945249,181955,4.2),(885579,'Friday',200332,511313,2),(910126,'Saturday',945249,181955,4.2);
/*!40000 ALTER TABLE `carriers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `households`
--

DROP TABLE IF EXISTS `households`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `households` (
  `idhouseholds` int(11) NOT NULL,
  `firstName` varchar(45) DEFAULT NULL,
  `lastName` varchar(45) DEFAULT NULL,
  `pNumber` varchar(11) DEFAULT '0',
  `streetName` varchar(45) DEFAULT NULL,
  `houseNumber` varchar(45) DEFAULT NULL,
  `aptNum` varchar(45) DEFAULT NULL,
  `postal` varchar(45) DEFAULT NULL,
  `subStatus` bit(1) DEFAULT b'1',
  PRIMARY KEY (`idhouseholds`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `households`
--

LOCK TABLES `households` WRITE;
/*!40000 ALTER TABLE `households` DISABLE KEYS */;
INSERT INTO `households` VALUES (137069,'Nick','Raynin','0000001111','Midland','12',NULL,'10033',''),(137675,'Sarah','Pei-Zhu','7181637493','Place St','124',NULL,'10300',''),(149163,'Person','FDS','3211111111','Nowhere','2',NULL,'10000',''),(165472,'Natacha','G','7181231234','Victory Blvd','100',NULL,'10131',''),(166141,'Jeff','Dietrich','1005551000','Kingsley','39',NULL,'10300',''),(200332,'John','Cosentino','3477217803','Forest Avenue','859',NULL,'10310',''),(945249,'Michelle','Kushnir','8880000000','Lamoka','1',NULL,'10314','');
/*!40000 ALTER TABLE `households` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `logins`
--

DROP TABLE IF EXISTS `logins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `logins` (
  `username` varchar(45) NOT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logins`
--

LOCK TABLES `logins` WRITE;
/*!40000 ALTER TABLE `logins` DISABLE KEYS */;
INSERT INTO `logins` VALUES ('john','admin1'),('justin','1'),('maria','maria'),('Michelle','1'),('new person','pass'),('nick','nick'),('rad','1'),('radoslaw','1'),('vlad','vlad');
/*!40000 ALTER TABLE `logins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publications`
--

DROP TABLE IF EXISTS `publications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `publications` (
  `idpublications` int(11) NOT NULL,
  `title` varchar(45) DEFAULT NULL,
  `newsType` varchar(45) DEFAULT NULL,
  `edition` varchar(45) DEFAULT NULL,
  `price` double DEFAULT NULL,
  PRIMARY KEY (`idpublications`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publications`
--

LOCK TABLES `publications` WRITE;
/*!40000 ALTER TABLE `publications` DISABLE KEYS */;
INSERT INTO `publications` VALUES (100186,'SI Advance','Newspaper','Daily',2.25),(127544,'NY Times','Newspaper','Daily',2.75),(170041,'National Review','Magazine','Daily',2.5),(181955,'The Atlantic','Newspaper','Daily',3.75),(204099,'Vox','Magazine','Daily',4.5),(511313,'Washington Post','Newspaper','Daily',3.25),(517365,'RT','Magazine','Daily',1.75),(862971,'SI Advance','Newspaper','Weekly',3);
/*!40000 ALTER TABLE `publications` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-18 13:45:13
