-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Oct 17, 2021 at 11:06 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_movies`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_movie`
--

CREATE TABLE `tb_movie` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `genre` varchar(45) NOT NULL,
  `duration` varchar(16) NOT NULL,
  `releasedate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_movie`
--

INSERT INTO `tb_movie` (`id`, `name`, `genre`, `duration`, `releasedate`) VALUES
(1, 'Avengers: Endgame', 'Action/Sci-Fi', '3h 1m', '2019-04-24 00:00:00'),
(2, 'Avengers: Infinity War\r\n', 'Action/Sci-Fi', '2h 29m', '2018-04-25 00:00:00'),
(3, 'Slumdog Millionaire\r\n', 'Romance/Drama', '2h 0m', '2008-02-11 00:00:00'),
(4, '500 Days of Summer', 'Romance/Drama', '1h 35m', '2009-07-17 00:00:00'),
(5, 'Gone Girl', 'Thriller/Mystery', '2h 29m', '2014-10-03 00:00:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_movie`
--
ALTER TABLE `tb_movie`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_movie`
--
ALTER TABLE `tb_movie`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
