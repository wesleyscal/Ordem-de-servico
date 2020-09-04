-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: ods_teste
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
-- Table structure for table `ordem_servico`
--

DROP TABLE IF EXISTS `ordem_servico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordem_servico` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_cliente` int NOT NULL,
  `usuario` varchar(200) NOT NULL,
  `prioridade` varchar(200) NOT NULL,
  `data_hora` datetime NOT NULL,
  `titulo` varchar(200) NOT NULL,
  `descricao` varchar(5000) NOT NULL,
  `estado` varchar(200) NOT NULL,
  `observacao` varchar(5000),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordem_servico`
--

LOCK TABLES `ordem_servico` WRITE;
/*!40000 ALTER TABLE `ordem_servico` DISABLE KEYS */;
INSERT INTO `ordem_servico` VALUES (1,2,'Wesley Gury','Urgente','2020-08-12 16:42:15','urgente','treta','Aberto'),(2,12,'Lucas','Media','2020-08-12 17:32:19','lipar a careca','lipar a careca do carecone','Aberto'),(3,12,'Wesley Gury','Alta','2020-08-12 17:33:19','Come cu de curioso','descriçao de como come cu de curioso','Aberto'),(4,2,'Lucas','Baixa','2020-08-04 17:34:07','tata','010203040506070809\r\n','Aberto'),(5,13,'Lucas','Baixa','2020-08-21 10:09:22','Ave maria, Coração chego a bate','Olha o caminha do leite','Aberto'),(6,16,'Wesley Gury','Alta','2020-09-01 17:24:40','Teste pesquisa 01','A Pesquisa Foi Comcluida Com Sucesso','Aberto'),(7,16,'Wesley Gury','Media','2020-09-01 17:26:00','yoga yoga yoga','o lucão da o toba','Aberto'),(8,12,'Lucas','Urgente','2020-09-01 17:28:10','Limpar a Careca Dinovo','Teste 01','Aberto');
/*!40000 ALTER TABLE `ordem_servico` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-09-01 17:43:33
