CREATE DATABASE  IF NOT EXISTS `ods_real` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `ods_real`;
-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: ods_real
-- ------------------------------------------------------
-- Server version	8.0.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ordem_servico_observacao`
--

DROP TABLE IF EXISTS `ordem_servico_observacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordem_servico_observacao` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_servico` int NOT NULL,
  `observacao` varchar(2500) NOT NULL,
  `data` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordem_servico_observacao`
--

LOCK TABLES `ordem_servico_observacao` WRITE;
/*!40000 ALTER TABLE `ordem_servico_observacao` DISABLE KEYS */;
INSERT INTO `ordem_servico_observacao` VALUES (1,2,'Falta Fechar a porta do Swtch.','2020-09-08'),(2,3,'Planilha esta no Desktop com o nome \"Lucão\",','2020-09-09'),(3,4,'ok Entregue','2020-09-09'),(4,5,'Um deles parou.','2020-09-09'),(5,7,'Obeservar se esta com lentidão, Troquei a fonte e parece que parou de travar.','2020-09-15'),(6,10,'Dia 26/09/20 testar o nobreak que chegou,\r\n\r\nSem nada ligado ele fica a 81v,\r\nCom 1 pc ligado ele vai para 85v,','2020-09-24'),(7,10,'Não foi possivel dia 26/09, remarcar outra data','2020-09-28'),(8,11,'Tranformador Comprado, falta instalação','2020-10-05');
/*!40000 ALTER TABLE `ordem_servico_observacao` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-06  9:41:11
