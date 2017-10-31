-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: adv_sys
-- ------------------------------------------------------
-- Server version	5.7.12-log

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
-- Dumping data for table `tbl_advogado`
--

LOCK TABLES `tbl_advogado` WRITE;
/*!40000 ALTER TABLE `tbl_advogado` DISABLE KEYS */;
INSERT INTO `tbl_advogado` VALUES (9,'Italo DUque','12,345,678-9','123,456,789-12','Masculino','italo@italo.com','Rua 52','','','','','239','(12)3456-7891','(12)34567-8910','Civil','123456789','11/22/3333','Ativo'),(10,'Gustavo soares','88.888.888-8','999.999.999-99','Masculino','exemplo2000@hotmail.com','rua dalva','Vila Verde','Acre','14.578-463','Tatubaté','210','(44)4444-4444','(55)55555-5555','civel','410','20/12/2014','Ativo');
/*!40000 ALTER TABLE `tbl_advogado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_agenda`
--

LOCK TABLES `tbl_agenda` WRITE;
/*!40000 ALTER TABLE `tbl_agenda` DISABLE KEYS */;
INSERT INTO `tbl_agenda` VALUES (10,'Denis','11/22/3333','11:22','urgente','Acusação','(12)3456-7891','(12)34567-8910');
/*!40000 ALTER TABLE `tbl_agenda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_caso`
--

LOCK TABLES `tbl_caso` WRITE;
/*!40000 ALTER TABLE `tbl_caso` DISABLE KEYS */;
INSERT INTO `tbl_caso` VALUES (8,'Bateu no amigo','123','exemplo de cartorio','123','333','Convenio','0','Convenio ','Gustavo Soares','acusado','Italo DUque','Matheus Pinho','Rua 85','22','(12)3456-7891','(12)34567-8910','11/22/3333','caso encerrado','22/11/5555'),(9,'Discussão','Infancia e juventude','Taubaté','524','745','Particular','800','Dinheiro','Gustavo','réu','Italo DUque','Elias','Rua aurora','87','(12)3333-5444','(12)33333-9999','12/08/2013','analise','12/09/2013');
/*!40000 ALTER TABLE `tbl_caso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_cliente`
--

LOCK TABLES `tbl_cliente` WRITE;
/*!40000 ALTER TABLE `tbl_cliente` DISABLE KEYS */;
INSERT INTO `tbl_cliente` VALUES (5,'Gustavo Soares','Masculino','gustavo@gustavo.com','12.345.678-9','123.456.789-12','11/22/3333','taubaté','bela vista','12.121-212','São Paulo','rua 32','321','(12)3456-7891','(12)34567-8940');
/*!40000 ALTER TABLE `tbl_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_secretaria`
--

LOCK TABLES `tbl_secretaria` WRITE;
/*!40000 ALTER TABLE `tbl_secretaria` DISABLE KEYS */;
INSERT INTO `tbl_secretaria` VALUES (5,'Maria','12,345,678-9','123,456,798-12','Feminino','rua 85','','','','','96','(12)3464-6874','(23)66971-3131'),(6,'Fernanda','22.333.222-8','412-548-874-54','Feminino','Rua reilo','12.415.687','Jureminda','São Paulo','Nha','100','(65)7487-9842','(45)32147-9874');
/*!40000 ALTER TABLE `tbl_secretaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_usuario`
--

LOCK TABLES `tbl_usuario` WRITE;
/*!40000 ALTER TABLE `tbl_usuario` DISABLE KEYS */;
INSERT INTO `tbl_usuario` VALUES (5,'denis','Advogado','denis','denis'),(6,'Gustavo Soares','Advogado','gustavo','gustavo'),(7,'secretaria','Secretário','usu','usu'),(8,'Italo DUque','Advogado','italo','italo'),(9,'Sheila','Secretária','secretaria','secretaria'),(10,'gustavo soares','Advogado','gustavo','gustavo'),(11,'afasdf',' Advogado','nha','nham'),(12,'sadfgasdfas','Advogado','Kkk','kkK'),(13,'CLAUDIOCABE?UDO','Advogado','loku','lokau'),(14,'lukio','Advogado','KUXY','kuxy'),(15,'olhaodenis','Advogado','DEEENISSSSS','COEMALUCO'),(16,'coeveivaiagr?','Advogado','KLARAO','DENOIS'),(17,'DESNAAAAAUCOSPIAAAUM','Advogado','denis','copieeei'),(18,'TESTE2','Advogado','denis','copieiii'),(19,'22222222222222','Advogado','teste','teste'),(20,'CLAUDIA',' Secretaria(o)','claudikla','CRAUUUDIA'),(21,'guigui','Advogado','gui','gui');
/*!40000 ALTER TABLE `tbl_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'adv_sys'
--

--
-- Dumping routines for database 'adv_sys'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-10-30 21:34:02
