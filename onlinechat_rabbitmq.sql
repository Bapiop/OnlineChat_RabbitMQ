-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Фев 14 2022 г., 04:08
-- Версия сервера: 10.4.22-MariaDB
-- Версия PHP: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `onlinechat_rabbitmq`
--

-- --------------------------------------------------------

--
-- Структура таблицы `chat_log`
--

CREATE TABLE `chat_log` (
  `id` int(11) NOT NULL,
  `channel` varchar(255) NOT NULL,
  `message` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `chat_log`
--

INSERT INTO `chat_log` (`id`, `channel`, `message`) VALUES
(53, 'admin1_Oleksandr', '{\"Author\":\"admin1\",\"Text\":\"MTIz\"}'),
(54, 'admin1_Oleksandr', '{\"Author\":\"admin1\",\"Text\":\"Mw==\"}'),
(55, 'admin1_Oleksandr', '{\"Author\":\"admin1\",\"Text\":\"NTU1\"}'),
(56, 'admin1_Oleksandr', '{\"Author\":\"admin1\",\"Text\":\"aGVsbG8=\"}');

-- --------------------------------------------------------

--
-- Структура таблицы `chat_table`
--

CREATE TABLE `chat_table` (
  `id` int(11) NOT NULL,
  `roomName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `chat_table`
--

INSERT INTO `chat_table` (`id`, `roomName`) VALUES
(12, 'admin1_Oleksandr');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(1, 'admin1', 'admin1'),
(2, 'Oleksandr', '1111');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `chat_log`
--
ALTER TABLE `chat_log`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `chat_table`
--
ALTER TABLE `chat_table`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `chat_log`
--
ALTER TABLE `chat_log`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT для таблицы `chat_table`
--
ALTER TABLE `chat_table`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
