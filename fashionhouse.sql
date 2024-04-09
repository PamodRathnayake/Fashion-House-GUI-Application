-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 20, 2023 at 09:10 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fashionhouse`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_details`
--

CREATE TABLE `admin_details` (
  `ID` int(11) NOT NULL,
  `AdminName` varchar(100) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Telephone` int(10) NOT NULL,
  `Admin_code` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin_details`
--

INSERT INTO `admin_details` (`ID`, `AdminName`, `Password`, `Email`, `Address`, `Telephone`, `Admin_code`) VALUES
(1, 'Pethum123', 'Peth123#', 'pethum56@gmail.com', 'Dikwela,Kanaththewewa', 784523648, '1234'),
(2, 'Praveena890', 'peav567&', 'pravee1@gmail.com', 'Bamunakotuwa,Wariyapola', 563487289, '2314'),
(3, 'ss', '99', 's@gmail.com', 'no.90/89,kgala', 778897655, '1234');

-- --------------------------------------------------------

--
-- Table structure for table `customer_deatails`
--

CREATE TABLE `customer_deatails` (
  `ID` int(11) NOT NULL,
  `UserName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `PhoneNumber` int(10) NOT NULL,
  `Address` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer_deatails`
--

INSERT INTO `customer_deatails` (`ID`, `UserName`, `Email`, `Password`, `PhoneNumber`, `Address`) VALUES
(1, 'Saveen', 'savee456@gmail.com', 'Savi345#', 772346578, 'Karawanella,Warakapola'),
(2, 'Chathuni45', 'chathu23@gmail.com', 'chathu$78', 754731358, 'Thulhiriya,Warakapola'),
(3, 'Dinushi98', 'dinu34@gmail.com', 'dinu#68', 754731359, 'Dampelessa,Narammala.');

-- --------------------------------------------------------

--
-- Table structure for table `ladies_costumes`
--

CREATE TABLE `ladies_costumes` (
  `L_id` int(11) NOT NULL,
  `Ldress_code` varchar(20) NOT NULL,
  `type` varchar(20) NOT NULL,
  `colour` varchar(20) NOT NULL,
  `size` varchar(20) NOT NULL,
  `price` double(10,2) NOT NULL,
  `stock` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ladies_costumes`
--

INSERT INTO `ladies_costumes` (`L_id`, `Ldress_code`, `type`, `colour`, `size`, `price`, `stock`) VALUES
(1, 'L_T_BK001', 'trouser', 'black', '32', 2350.00, 100),
(2, 'L_T_BL002', 'trouser', 'blue', '36', 3200.50, 300),
(3, 'L_B_BL001', 'blouse', 'black', 'M', 1500.00, 100),
(4, 'L_F_G001', 'frock', 'white', 'XL', 3500.00, 200),
(5, 'L_SR_PR001', 'saree', 'purple', '', 4300.00, 265),
(6, 'L_F_G002', 'frock', 'yellow', 'L', 4000.00, 300);

-- --------------------------------------------------------

--
-- Table structure for table `male_costumes`
--

CREATE TABLE `male_costumes` (
  `ID` int(11) NOT NULL,
  `Mdress_code` varchar(20) NOT NULL,
  `type` varchar(20) NOT NULL,
  `colour` varchar(20) NOT NULL,
  `size` varchar(20) NOT NULL,
  `price` double(10,2) NOT NULL,
  `stock` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `male_costumes`
--

INSERT INTO `male_costumes` (`ID`, `Mdress_code`, `type`, `colour`, `size`, `price`, `stock`) VALUES
(1, 'M_TR_BL001', 'trousers', 'blue', '32', 2400.00, 150),
(2, 'M_TS_BL001', 't shirt', 'blue', '16', 3200.50, 135),
(3, 'M_S_BK001', 'shirt', 'black', '15', 2400.00, 180),
(4, 'M_SH_GR001', 'shorts', 'grey', '33', 1750.00, 190),
(5, 'M_S_PK002', 'shirt', 'pink', '15 1/2', 1950.00, 255),
(6, 'M_T_R002', 't shirt', 'red', '14', 1500.00, 400);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin_details`
--
ALTER TABLE `admin_details`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `customer_deatails`
--
ALTER TABLE `customer_deatails`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `ladies_costumes`
--
ALTER TABLE `ladies_costumes`
  ADD PRIMARY KEY (`L_id`);

--
-- Indexes for table `male_costumes`
--
ALTER TABLE `male_costumes`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin_details`
--
ALTER TABLE `admin_details`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `customer_deatails`
--
ALTER TABLE `customer_deatails`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `ladies_costumes`
--
ALTER TABLE `ladies_costumes`
  MODIFY `L_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `male_costumes`
--
ALTER TABLE `male_costumes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
