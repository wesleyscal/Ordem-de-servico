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
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordem_servico`
--

LOCK TABLES `ordem_servico` WRITE;
/*!40000 ALTER TABLE `ordem_servico` DISABLE KEYS */;
INSERT INTO `ordem_servico` VALUES (1,1,'Wesley Gury','Alta','2020-09-08 14:43:15','09/09 as 8:00, Robo Fabrica','Levar cabo de Rede e senha do AP01, la no robo da fabrica','Finalizado'),(2,2,'Wesley Gury','Media','2020-09-08 15:32:23','Instalar Swtch PCP','Instalar Swtch PCP, Cabo Ja esta Passado so falta o Swtch','Finalizado'),(3,3,'Wesley Gury','Baixa','2020-09-09 09:47:30','Cotar PC','Fazer um orçamento de um PC para o lucas, o do Lucas vai para o Luan, o do Luan vai para o Matheus e a maquina nova para o Lucas','Finalizado'),(4,3,'Wesley Gury','Alta','2020-09-09 09:51:58','Comprar Fuzivel','Comprar Fuzivel: 250v 10A','Finalizado'),(5,3,'Wesley Gury','Alta','2020-09-09 09:55:40','Trocar Filtro de Linha T.I','Trocar Filtro de Linha T.I, Depois do Horario tirar Filto de linha e colocar o novo','Finalizado'),(6,3,'Wesley Gury','Alta','2020-09-11 16:14:02','Pedir Sr pedro passar na infocat','Pedir Sr pedro passar na infocat, pegar o nobreak, baterias e o Computador.','Finalizado'),(7,4,'Wesley Gury','Media','2020-09-15 10:06:22','Maquina Nova','Montar e entregar maquina','Finalizado'),(8,5,'Wesley Gury','Baixa','2020-09-15 10:08:36','Trocar Windows','trocar o windows 8.1 pelo windows 10','Finalizado'),(9,6,'Wesley Gury','Media','2020-09-18 10:10:04','Comprar Camera','Comprar camera para portaria','Andamento'),(10,3,'Wesley Gury','Media','2020-09-22 10:10:04','Nobreak','Mandar nobreak para arrumar','Finalizado'),(11,9,'Wesley Gury','Media','2020-09-28 13:17:58','Tranformador Impressora','Colocar as Impressora:\r\nFogão,\r\nAlemão,\r\nComprar,\r\n\r\nNo tranformador para aliviar os nobreak','Andamento'),(12,3,'Lucas','Alta','2020-10-01 17:54:48','Liçença windows 10','Comprar licenças','Finalizado'),(13,5,'Wesley Gury','Media','2020-10-02 07:37:51','Impressora PCP','Precissa formar, Pois esta muito lenta','Finalizado'),(14,5,'Wesley Gury','Media','2020-10-06 07:50:11','Nobreak PCP','Colocar nobreak no PCP, Anterior queimou, Eles esta ligado direto no 110v','Finalizado'),(15,3,'Wesley Gury','Media','2020-10-13 13:37:03','Computador Mauricio','Montar maquina para o Mauricio','Finalizado'),(16,8,'Wesley Gury','Media','2020-10-14 14:01:11','Ativar Windows 10','Ativar o windows do Andersom','Finalizado'),(17,10,'Lucas','Baixa','2020-11-19 08:11:11','Email e Conta no sistema','Criar e-mail para o Heraldo, e criar um login no sistema para parte da frente do almoxarifado ( fernando )','Finalizado'),(18,10,'Wesley Gury','Media','2020-11-19 17:22:58','Mudar Spark','Mudar Spark Heraldo Para almoxarife01','Finalizado'),(19,9,'Wesley Gury','Alta','2020-11-24 07:34:38','Nobreak Manutenção','Mandar nobreak da manutençao para conserto, dependendo do preço pegar novo','Finalizado'),(20,11,'Wesley Gury','Media','2020-12-15 09:21:43','Passar W8 para W10','Mudar o windows da marquina do marquino.','Finalizado'),(21,3,'Lucas','Media','2021-01-04 13:23:37','Camera Cell Fatima','Descobrir se a fatima tem o sistema de cameras na celular','Aberto'),(22,3,'Wesley Gury','Alta','2021-01-06 08:39:49','Ghost Hd Engenharia Campath','Fazer ghost para garantir que não perca o software instalado nela','Aberto'),(23,9,'Wesley Gury','Alta','2021-01-20 13:20:03','Nobreak ArtMarket','Mandar dois nobreak da artmarket para o conserto','Andamento'),(24,12,'Wesley Gury','Media','2021-02-10 16:23:02','SPF dominio de email','Criar arquivo txt com de SPF e colocar no servidor do dominio de email','Finalizado');
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

-- Dump completed on 2021-02-24  9:08:36
