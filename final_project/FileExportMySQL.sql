-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Oct 24, 2021 at 06:21 PM
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
-- Database: `db_bank_new1`
--

-- --------------------------------------------------------

--
-- Table structure for table `AspNetRoleClaims`
--

CREATE TABLE `AspNetRoleClaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(85) NOT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetRoles`
--

CREATE TABLE `AspNetRoles` (
  `Id` varchar(85) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(85) DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserClaims`
--

CREATE TABLE `AspNetUserClaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(85) NOT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserLogins`
--

CREATE TABLE `AspNetUserLogins` (
  `LoginProvider` varchar(85) NOT NULL,
  `ProviderKey` varchar(85) NOT NULL,
  `ProviderDisplayName` text DEFAULT NULL,
  `UserId` varchar(85) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserRoles`
--

CREATE TABLE `AspNetUserRoles` (
  `UserId` varchar(85) NOT NULL,
  `RoleId` varchar(85) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUsers`
--

CREATE TABLE `AspNetUsers` (
  `Id` varchar(85) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(85) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(85) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` text DEFAULT NULL,
  `SecurityStamp` text DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL,
  `PhoneNumber` text DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `AspNetUsers`
--

INSERT INTO `AspNetUsers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('303b38a2-14e2-4a83-935b-b928512a5bf1', 'new_user', 'NEW_USER', 'new_user@example.com', 'NEW_USER@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAELw/A0FR3ch95+d3dFcRPdkYVV/FKipGa8oI5mAQkDgwFcUqgy8HXEkIz3eKqOMkOA==', 'IG45CDAIR7UR2EZYYGF7JWTABF2KJX6E', 'cb608e77-8366-43bc-98ae-2d463a5e5f01', NULL, 0, 0, NULL, 1, 0),
('68279b8c-06a4-4240-9703-da666ccec921', 'roy', 'ROY', 'roy@mail.com', 'ROY@MAIL.COM', 0, 'AQAAAAEAACcQAAAAEKKnB2A6xNf4Ki/Pqzu4d2/RuLXuRqCUiVOVY01UxmWKM5oK9irF310rZUmKUZ+0DA==', '3CBDUDBUHZ7SXXHVJPGSSPXOUZFWTLU2', 'abc843a7-317e-4d0b-bd6e-c99093c83273', NULL, 0, 0, NULL, 1, 0),
('95ce46fc-712d-4a0f-b595-e9659767b13b', 'newuser', 'NEWUSER', 'newuser@example.com', 'NEWUSER@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAEMwtPbOTBGfOLmqi7x9zwkk+oJGUBEjskV4HFXFrV6v55Z4mtt7NzpZdhMyvgepD8Q==', 'PZ42RRARZ25YYWBPKQMDAJP2IM7FYSWA', '8654f80f-8c7e-4ea0-8076-14934f50bec2', NULL, 0, 0, NULL, 1, 0),
('ec48605d-0181-4525-bd23-73efcdc8cff3', 'roychan', 'ROYCHAN', 'roy@example.com', 'ROY@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAEKMJ3LO5vCJn9FJ+2pX0JNPm3zIDl/Sa63gIQT6rixV1EIsmpBazfge/2fR9rTUaqg==', '7I6SHVLFHQYDWIJQ67F5G274JMHPVWJH', '56ad689a-4e7d-4e1d-ba06-b86d7ef58993', NULL, 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserTokens`
--

CREATE TABLE `AspNetUserTokens` (
  `UserId` varchar(85) NOT NULL,
  `LoginProvider` varchar(85) NOT NULL,
  `Name` varchar(85) NOT NULL,
  `Value` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `Payments`
--

CREATE TABLE `Payments` (
  `paymentDetailId` int(11) NOT NULL,
  `cardOwnerName` text DEFAULT NULL,
  `cardNumber` text DEFAULT NULL,
  `expirationDate` text DEFAULT NULL,
  `securityCode` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `Payments`
--

INSERT INTO `Payments` (`paymentDetailId`, `cardOwnerName`, `cardNumber`, `expirationDate`, `securityCode`) VALUES
(2, 'string', 'string', 'string', 'string'),
(3, 'string', 'string', 'string', 'string'),
(4, 'Roychan', '090909', '10/20/2026', '411');

-- --------------------------------------------------------

--
-- Table structure for table `RefreshTokens`
--

CREATE TABLE `RefreshTokens` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(85) DEFAULT NULL,
  `Token` text DEFAULT NULL,
  `JwtId` text DEFAULT NULL,
  `IsUsed` tinyint(1) NOT NULL,
  `AddedDate` datetime NOT NULL,
  `ExpiryDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `RefreshTokens`
--

INSERT INTO `RefreshTokens` (`Id`, `UserId`, `Token`, `JwtId`, `IsUsed`, `AddedDate`, `ExpiryDate`) VALUES
(1, '68279b8c-06a4-4240-9703-da666ccec921', 'L1S1JILQSLRSGD3OZLIOPKFOJMYFAIY0ETR28bd38a1-469f-4df3-930a-7271a7d39e10', '677339c4-5f20-4f0a-9ce5-26d2035159db', 0, '2021-10-22 03:04:26', '2022-04-22 03:04:26'),
(2, '68279b8c-06a4-4240-9703-da666ccec921', 'UCR69WRI31L7G33TGXRXDZSF3X64J34IM9K5400ca43-1025-4b3d-8f89-16f24d71f965', '8871b47c-3a1a-4738-ba48-1a84187cee52', 0, '2021-10-22 03:04:46', '2022-04-22 03:04:46'),
(3, '68279b8c-06a4-4240-9703-da666ccec921', 'KGQ2IKTL1MFKCH54A4I1HG3E8PUUDD1KORHb2b7e8ed-a474-4b76-9cbe-994f6f4b2864', 'a1bc8da2-5076-4e19-b363-041210656560', 0, '2021-10-22 03:13:43', '2022-04-22 03:13:43'),
(4, '68279b8c-06a4-4240-9703-da666ccec921', 'BLQKN9U5T16TN5U5JCDJ1A8MJXTURM3X3UO1c82dd2a-8024-450f-9f4e-2f8d71e22165', 'a156a8c4-3aeb-4357-9b0b-8d4461a4bded', 0, '2021-10-22 03:21:36', '2022-04-22 03:21:36'),
(5, '68279b8c-06a4-4240-9703-da666ccec921', 'D6036QBXP9C5ENDDGUHRVLDTJ3QPOB3033G0e7e47c3-94bb-4304-906e-8b01c69e3709', 'f0d1513f-4666-423d-a478-08f5f20f3cef', 0, '2021-10-22 03:25:57', '2022-04-22 03:25:57'),
(6, '68279b8c-06a4-4240-9703-da666ccec921', '8R6M8ONUUVUOSD6OWI9QIT5PNBQ3GCH0YBVc4331d68-6a20-47c2-b294-ab5e11547bbe', '1e59799b-56bf-4172-a19a-82c7e8aa6060', 0, '2021-10-22 06:20:24', '2022-04-22 06:20:24'),
(7, 'ec48605d-0181-4525-bd23-73efcdc8cff3', 'C8YEM990A1EBZG8RQPF4DTGIW4W6LCEOLLM98ddceaf-dd0a-47b1-be9a-0b799e7b69e5', '11aa165b-d071-4244-903b-27ab3cf96b55', 0, '2021-10-22 06:30:07', '2022-04-22 06:30:07'),
(8, 'ec48605d-0181-4525-bd23-73efcdc8cff3', '0YKO7FTLY3JB6GJ9UMHI154DUDPYBBW0P00c3ed6f35-10fe-4333-a783-42deba16198b', '3a9125c6-c8b4-47ed-a4a6-ced766131c72', 0, '2021-10-22 06:30:30', '2022-04-22 06:30:30'),
(9, '95ce46fc-712d-4a0f-b595-e9659767b13b', 'T8XM522O19NOXRWH4V5FZ1AA6NSQT8661U631b133f6-6ee6-4e6a-ab14-a6f08dfb35d5', 'aa7ebb43-d28a-4aee-a415-5bda49a0556a', 0, '2021-10-24 15:05:27', '2022-04-24 15:05:27'),
(10, '303b38a2-14e2-4a83-935b-b928512a5bf1', '7K7K50VQXX1DXB4PTPPDO5Q4YBI3MAS0TWNf82fba55-8d42-43d1-8c1c-f8180b7b6bed', '4ee6d476-d2d5-45e0-b65e-fbbfe9c509cf', 0, '2021-10-24 15:17:34', '2022-04-24 15:17:34'),
(11, '303b38a2-14e2-4a83-935b-b928512a5bf1', 'OFGYBYUL1JH732NNS8S9F6JNE8NFLFAPL2N08b609f4-2c70-4c75-b1e9-0683fb15b370', 'd22ddbf1-540c-4d60-8a15-ad3825c3bd60', 0, '2021-10-24 15:21:54', '2022-04-24 15:21:54'),
(12, '303b38a2-14e2-4a83-935b-b928512a5bf1', 'DD0YX5JOC38MUGTV30SFPEYJYQQPG1OHCW7baae8c81-427f-4c24-88a3-b8a49d86ca4a', 'b3218a54-c688-4496-8946-6a8266c1c681', 0, '2021-10-24 15:56:32', '2022-04-24 15:56:32');

-- --------------------------------------------------------

--
-- Table structure for table `__EFMigrationsHistory`
--

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__EFMigrationsHistory`
--

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`) VALUES
('20211021084212_initial migrate', '5.0.11'),
('20211021084337_add refresh Token table', '5.0.11'),
('20211021091515_Added refresh tokens table', '5.0.11'),
('20211021092936_Added refresh tokens', '5.0.11');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indexes for table `AspNetRoles`
--
ALTER TABLE `AspNetRoles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indexes for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indexes for table `AspNetUserLogins`
--
ALTER TABLE `AspNetUserLogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indexes for table `AspNetUserRoles`
--
ALTER TABLE `AspNetUserRoles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indexes for table `AspNetUsers`
--
ALTER TABLE `AspNetUsers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indexes for table `AspNetUserTokens`
--
ALTER TABLE `AspNetUserTokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indexes for table `Payments`
--
ALTER TABLE `Payments`
  ADD PRIMARY KEY (`paymentDetailId`);

--
-- Indexes for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_RefreshTokens_UserId` (`UserId`);

--
-- Indexes for table `__EFMigrationsHistory`
--
ALTER TABLE `__EFMigrationsHistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `Payments`
--
ALTER TABLE `Payments`
  MODIFY `paymentDetailId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserLogins`
--
ALTER TABLE `AspNetUserLogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserRoles`
--
ALTER TABLE `AspNetUserRoles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserTokens`
--
ALTER TABLE `AspNetUserTokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  ADD CONSTRAINT `FK_RefreshTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
