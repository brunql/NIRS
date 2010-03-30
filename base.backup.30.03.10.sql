-- MySQL dump 10.10
--
-- Host: localhost    Database: nirs
-- ------------------------------------------------------
-- Server version	5.0.24a-community

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
-- Table structure for table `division`
--

DROP TABLE IF EXISTS `division`;
CREATE TABLE `division` (
  `id` int(11) NOT NULL auto_increment,
  `fac_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `fullname` varchar(100) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `division`
--


/*!40000 ALTER TABLE `division` DISABLE KEYS */;
LOCK TABLES `division` WRITE;
INSERT INTO `division` VALUES (24,43,'ВТиАСУ','Кафедра вычислительной техники и автоматизированных систем управления'),(29,43,'АПП','Кафедра автоматизации производственных процессов'),(30,43,'Информатика','Кафедра информатики'),(31,43,'Общей математики','Кафедра общей математики'),(32,43,'Физика','Кафедра физики'),(33,38,'Прикладной математики','Кафедра прикладной математики'),(34,43,'Прикладной математики','Кафедра прикладной математики'),(35,38,'КТиИБ','Кафедра компьютерных технологий и информационной безопасности'),(36,38,'Делового английского языка','Кафедра делового английского языка');
UNLOCK TABLES;
/*!40000 ALTER TABLE `division` ENABLE KEYS */;

--
-- Table structure for table `faculty`
--

DROP TABLE IF EXISTS `faculty`;
CREATE TABLE `faculty` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(50) NOT NULL,
  `fullname` varchar(100) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=118 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `faculty`
--


/*!40000 ALTER TABLE `faculty` DISABLE KEYS */;
LOCK TABLES `faculty` WRITE;
INSERT INTO `faculty` VALUES (38,'ИИТиБ','Институт информационных технологий и безопасности'),(39,'ИНГЭиБ','Институт нефти, газа, энергетики и безопасности'),(40,'СГФ','Социально-гуманитарный факультет'),(41,'ФАДКС','Факультет автомобильно-дорожных и кадастровых систем'),(42,'ФИЭК','Факультет инженерии, экспертизы и компьютерного моделирования высоких технологий'),(43,'ФКТАС','Факультет компьютерных технологий, автоматизированных систем и защиты информации'),(44,'ФМА','Факультет машиностроения и автосервиса'),(45,'ФПБРБ','Факультет пищевой биотехнологии и ресторанного бизнеса'),(47,'ФСУН','Факультет строительства и управления недвижимостью'),(48,'ФЭУБ','Факультет экономики, управления и бизнеса'),(49,'Факультет заочного и дистанционного обучения','Факультет заочного и дистанционного обучения'),(50,'Центр социальной адаптации молодежи','Центр социальной адаптации молодежи'),(51,'Подготовительный факультет для иностранных граждан','Подготовительный факультет для иностранных граждан');
UNLOCK TABLES;
/*!40000 ALTER TABLE `faculty` ENABLE KEYS */;

--
-- Table structure for table `group`
--

DROP TABLE IF EXISTS `group`;
CREATE TABLE `group` (
  `id` int(11) NOT NULL auto_increment,
  `spec_id` int(11) NOT NULL,
  `code` varchar(30) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `group`
--


/*!40000 ALTER TABLE `group` DISABLE KEYS */;
LOCK TABLES `group` WRITE;
INSERT INTO `group` VALUES (8,1,'08-К-ПО1'),(6,11,'08-К-ПИ1'),(9,1,'08-К-ПО2'),(10,1,'09-К-ПО2'),(11,12,'07-К-ЗИ1'),(12,9,'08-К-УИ1'),(13,9,'06-К-УИ1'),(14,14,'07-К-ИБ1');
UNLOCK TABLES;
/*!40000 ALTER TABLE `group` ENABLE KEYS */;

--
-- Table structure for table `mentor`
--

DROP TABLE IF EXISTS `mentor`;
CREATE TABLE `mentor` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(40) NOT NULL,
  `surname` varchar(40) NOT NULL,
  `fathername` varchar(40) NOT NULL,
  `work` varchar(150) NOT NULL,
  `acrank` varchar(150) NOT NULL,
  `degree` varchar(150) NOT NULL,
  `div_id` int(11) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `mentor`
--


/*!40000 ALTER TABLE `mentor` DISABLE KEYS */;
LOCK TABLES `mentor` WRITE;
INSERT INTO `mentor` VALUES (1,'Николай','Бубликов','Иванович','Уборщик','Ниже среднего','-2',24),(3,'Леонид','Терещенко','Иванович','Зав. кафедрой КТиИБ','Профессор','93',35),(2,'Василий','Абрикосов','Николаевич','Президент РФ','к.т.н по боксу','9999',29);
UNLOCK TABLES;
/*!40000 ALTER TABLE `mentor` ENABLE KEYS */;

--
-- Table structure for table `spec`
--

DROP TABLE IF EXISTS `spec`;
CREATE TABLE `spec` (
  `id` int(11) NOT NULL auto_increment,
  `div_id` int(11) NOT NULL,
  `code` varchar(10) NOT NULL,
  `name` varchar(200) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `spec`
--


/*!40000 ALTER TABLE `spec` DISABLE KEYS */;
LOCK TABLES `spec` WRITE;
INSERT INTO `spec` VALUES (1,24,'230105','Программное обеспечение вычислительной техники и автоматизированных систем управления'),(12,35,'090103 ','Организация и технология защиты информации '),(13,35,'090104 ','Комплексная защита объектов информатизации '),(9,29,'220201','Управление и информатика в технических системах '),(10,30,'230101','Вычислительные машины, комплексы, системы и сети '),(11,24,'080801','Прикладная информатика в экономике '),(14,35,'090105 ','Комплексное обеспечение информационной безопасности автоматизированных систем ');
UNLOCK TABLES;
/*!40000 ALTER TABLE `spec` ENABLE KEYS */;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
CREATE TABLE `student` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(20) NOT NULL,
  `surname` varchar(20) NOT NULL,
  `fathername` varchar(20) NOT NULL,
  `group_id` int(11) NOT NULL,
  `born` date NOT NULL,
  `study` varchar(45) NOT NULL,
  `grant` varchar(45) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student`
--


/*!40000 ALTER TABLE `student` DISABLE KEYS */;
LOCK TABLES `student` WRITE;
INSERT INTO `student` VALUES (1,'Василий','Иванов','Петрович',8,'1990-11-12','Бюджет','Стипендия Dr.Web'),(2,'Евгений','Смертин','Николаевич',8,'1990-03-11','СКЦ','нет'),(7,'Николай','Безбедов','Владимирович',13,'1991-01-01','Бюджет','Стипендия Microsoft'),(8,'Юлия','Молчанова','Петровна',10,'2003-03-02','Бюджет','Нет'),(9,'Генадий','Сидоров','Викторович',14,'1993-02-02','СКЦ','Нет');
UNLOCK TABLES;
/*!40000 ALTER TABLE `student` ENABLE KEYS */;

--
-- Table structure for table `works`
--

DROP TABLE IF EXISTS `works`;
CREATE TABLE `works` (
  `id` int(11) NOT NULL auto_increment,
  `student_id` int(11) NOT NULL,
  `name` varchar(150) NOT NULL,
  `desc` text NOT NULL,
  `mentor_id` int(11) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `works`
--


/*!40000 ALTER TABLE `works` DISABLE KEYS */;
LOCK TABLES `works` WRITE;
INSERT INTO `works` VALUES (2,1,'test theme','test science work',1);
UNLOCK TABLES;
/*!40000 ALTER TABLE `works` ENABLE KEYS */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

