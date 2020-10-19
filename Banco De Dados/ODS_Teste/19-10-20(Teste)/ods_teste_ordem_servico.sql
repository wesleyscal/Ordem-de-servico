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
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordem_servico`
--

LOCK TABLES `ordem_servico` WRITE;
/*!40000 ALTER TABLE `ordem_servico` DISABLE KEYS */;
INSERT INTO `ordem_servico` VALUES (9,2,'Lucas','Media','2020-09-04 10:41:29','Limpar Careca','Ajudar o Gury a limpar a careca do carecone','CuEba'),(10,3,'Wesley Gury','Urgente','2020-09-07 10:27:15','Fazer teste na ordem de serviço','Testar a ordem de serviço ate ficar 100%','Andamento'),(11,2,'Lucas','Urgente','2020-08-07 10:27:15','Add estado','Adicionar estado a ordem de serviço','Andamento'),(12,2,'Lucas','Urgente','2019-12-01 10:27:15','Add estado 02','Adicionar estado a ordem de serviço 02','Aberto'),(13,4,'Lucas','Alta','2020-09-08 08:58:56','vender empada','Ajudar o maquinha com a venda de empada','Andamento'),(14,2,'Wesley Gury','Media','2020-09-28 13:24:34','teste horario','aaaaaaaaaaaa','Aberto'),(15,3,'Lucas','Baixa','2020-09-28 13:39:05','ar','arwwww','Aberto'),(16,2,'Lucas','Media','2020-09-28 13:43:12','tg','t','Aberto'),(17,2,'Lucas','Media','2020-09-28 13:44:35','j','j','Aberto'),(18,2,'Lucas','Baixa','2020-09-28 13:46:17','hkhk','ikik','Aberto'),(19,3,'Lucas','Alta','2020-10-19 16:58:48','teste DBC','DVB','Andamento'),(20,3,'Wesley Gury','Baixa','2020-10-19 17:00:04','edfgsef','efsaefs','Aberto');
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

-- Dump completed on 2020-10-19 17:02:41
