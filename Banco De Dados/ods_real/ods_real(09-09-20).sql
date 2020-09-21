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
-- Table structure for table `ordem_cliente`
--

DROP TABLE IF EXISTS `ordem_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordem_cliente` (
  `id` int NOT NULL AUTO_INCREMENT,
  `cliente` varchar(200) NOT NULL,
  `setor` varchar(200) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordem_cliente`
--

LOCK TABLES `ordem_cliente` WRITE;
/*!40000 ALTER TABLE `ordem_cliente` DISABLE KEYS */;
INSERT INTO `ordem_cliente` VALUES (1,'Negão','Manutenção'),(2,'Bias','PCP'),(3,'lucas','TI');
/*!40000 ALTER TABLE `ordem_cliente` ENABLE KEYS */;
UNLOCK TABLES;

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
  `observacao` varchar(5000) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordem_servico`
--

LOCK TABLES `ordem_servico` WRITE;
/*!40000 ALTER TABLE `ordem_servico` DISABLE KEYS */;
INSERT INTO `ordem_servico` VALUES (1,1,'Wesley Gury','Alta','2020-09-08 14:43:15','09/09 as 8:00, Robo Fabrica','Levar cabo de Rede e senha do AP01, la no robo da fabrica','Finalizado',''),(2,2,'Wesley Gury','Media','2020-09-08 15:32:23','Instalar Swtch PCP','Instalar Swtch PCP, Cabo Ja esta Passado so falta o Swtch','Andamento','Falta Fechar a porta do Swtch.'),(3,3,'Wesley Gury','Baixa','2020-09-09 09:47:30','Cotar PC','Fazer um orçamento de um PC para o lucas, o do Lucas vai para o Luan, o do Luan vai para o Matheus e a maquina nova para o Lucas','Finalizado','Planilha esta no Desktop com o nome \"Lucão\",\r\n\r\nTa ok'),(4,3,'Wesley Gury','Alta','2020-09-09 09:51:58','Comprar Fuzivel','Comprar Fuzivel: 250v 10A','Finalizado','ok Entregue'),(5,3,'Wesley Gury','Alta','2020-09-09 09:55:40','Trocar Filtro de Linha T.I','Trocar Filtro de Linha T.I, Depois do Horario tirar Filto de linha e colocar o novo','Aberto','');
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

-- Dump completed on 2020-09-10  7:56:17
