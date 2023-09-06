-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 2023-09-06 07:34:37
-- 伺服器版本： 10.4.19-MariaDB
-- PHP 版本： 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `unityacess`
--
CREATE DATABASE IF NOT EXISTS `unityacess` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `unityacess`;

-- --------------------------------------------------------

--
-- 資料表結構 `players`
--

CREATE TABLE `players` (
  `id` int(25) NOT NULL,
  `username` varchar(20) NOT NULL,
  `hash` varchar(100) NOT NULL,
  `salt` varchar(50) NOT NULL,
  `sex` varchar(5) NOT NULL,
  `time` datetime(6) NOT NULL DEFAULT current_timestamp(6)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `players`
--

INSERT INTO `players` (`id`, `username`, `hash`, `salt`, `sex`, `time`) VALUES
(2, '09091738', '$5$rounds=5000$steamedhams09091$vfIf7kiDAsE7d/oG2zG27Y7qgOp32iBhufnQC6pdFS8', '$5$rounds=5000$steamedhams09091738$', 'M', '2023-09-03 17:38:52.008495'),
(3, 'root0203', '$5$rounds=5000$steamedhamsroot0$v85SaWF.6xG.wZ7e9FWvcXLchAaOf3QZn17ab6GY4i1', '$5$rounds=5000$steamedhamsroot0203$', 'M', '2023-09-03 20:27:51.184989');

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `players`
--
ALTER TABLE `players`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- 在傾印的資料表使用自動遞增(AUTO_INCREMENT)
--

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `players`
--
ALTER TABLE `players`
  MODIFY `id` int(25) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
