-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 23-Set-2020 às 18:51
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cadastropizzaria`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `idcadastropizzaria`
--

CREATE TABLE `idcadastropizzaria` (
  `idCliente` int(5) NOT NULL,
  `nomeCliente` varchar(50) NOT NULL,
  `CPF` varchar(20) NOT NULL,
  `Telefone` varchar(20) NOT NULL,
  `Endereco` varchar(100) NOT NULL,
  `CEP` varchar(12) NOT NULL,
  `Email` varchar(40) NOT NULL,
  `Senha` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `idcadastropizzaria`
--

INSERT INTO `idcadastropizzaria` (`idCliente`, `nomeCliente`, `CPF`, `Telefone`, `Endereco`, `CEP`, `Email`, `Senha`) VALUES
(1, 'guilherme felipe darossi', '214.748.000-00', '(88) 8888-8888', 'rua cacho111', '11.888-888', 'guilherme@.com', 'senha123'),
(2, 'guilherme', '23454', '34545', 'rua da rua', '55556', 'email@.com', 'senha'),
(3, 'eu não sei', '5556667', '9999999', 'rua do ze', '678900', 'ze@.com', 'senha'),
(5, 'biel', '456678', '74747474', 'palhoça', '55556', 'palhoça@.com', 'senha12'),
(6, 'guilherme felipe darossi', '666', '0', 'rua da praia', '66', 'guilherme@.com.br', 'senhasenha'),
(11, 'guilherme darosdss', '214748', '0', 'rua', '11', 'guilherme@.commmm', 'nsei'),
(12, 'nao sei', '111111', '0', '111111', '11', 'guilherme', '12'),
(13, 'jessica piovezani', '123456', '0', 'minha rua', '11', 'jessica@gmail.com', 'jessica'),
(14, 'oioioi', '111222', '0', 'qqqqq', '11', 'oi@gmail.com', 'oi'),
(15, 'oioi', '111.122.233-33', '(11) 2223-3333', 'rrtttttt', '11.222-333', 'oi', 'oi');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `idcadastropizzaria`
--
ALTER TABLE `idcadastropizzaria`
  ADD PRIMARY KEY (`idCliente`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `idcadastropizzaria`
--
ALTER TABLE `idcadastropizzaria`
  MODIFY `idCliente` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
