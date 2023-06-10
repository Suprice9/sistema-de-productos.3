-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 20, 2023 at 07:13 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `farmaprog`
--

-- --------------------------------------------------------

--
-- Table structure for table `cliente`
--

CREATE TABLE `cliente` (
  `codcliente` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `compra`
--

CREATE TABLE `compra` (
  `Id` int(11) NOT NULL,
  `id_suplidor` int(250) NOT NULL,
  `idproducto` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `producto`
--

CREATE TABLE `producto` (
  `codigo` int(11) NOT NULL,
  `idproveedor` int(250) NOT NULL,
  `nombreproduc` varchar(50) NOT NULL,
  `preciovent` decimal(10,0) NOT NULL,
  `preciocomp` decimal(10,0) NOT NULL,
  `fechavencimiento` date NOT NULL,
  `stock` int(11) NOT NULL,
  `descripcion` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `producto`
--

INSERT INTO `producto` (`codigo`, `idproveedor`, `nombreproduc`, `preciovent`, `preciocomp`, `fechavencimiento`, `stock`, `descripcion`) VALUES
(3, 0, 'acetomenofen', '80', '50', '2025-07-17', 4, 'dolor de cabeza'),
(6, 7, 'Diclo K', '600', '50', '2023-03-15', 5, 'Firbere'),
(9, 10, 'pastillas', '100', '50', '2023-03-15', 4, 'dolor'),
(11, 8, 'Diclo KK', '100', '50', '2023-03-22', 4, 'Dolor de cabeza'),
(12, 7, 'diclo k', '100', '50', '2023-08-04', 5, 'una'),
(15, 7, 'Acetomenofen', '70', '50', '2023-03-08', 4, 'dolor de cabeza'),
(16, 10, '15', '70', '50', '2023-03-08', 5, 'dolor de cabeza'),
(17, 9, '6', '600', '50', '2023-03-15', 4, 'Firbere'),
(18, 8, '9', '100', '50', '2023-03-15', 6, 'dolor'),
(20, 9, '6', '600', '50', '2023-03-15', 4, 'Firbere'),
(21, 8, '20', '600', '50', '2023-03-15', 4, 'Firbere'),
(22, 11, '6', '600', '50', '2023-03-15', 12, 'Firbere'),
(23, 9, 'Diclo K', '600', '50', '2025-07-17', 1, 'Firbere'),
(24, 16, 'Diclo K', '0', '50', '0000-00-00', 2147483647, '1'),
(27, 14, 'Diclo K', '0', '50', '0000-00-00', 2147483647, '4'),
(28, 12, 'Diclo K', '0', '50', '0000-00-00', 2147483647, '4'),
(29, 13, 'Diclo K', '0', '50', '0000-00-00', 2147483647, '4'),
(30, 13, 'Diclo K', '0', '50', '0000-00-00', 2147483647, '4'),
(31, 14, 'Diclo K', '0', '50', '0000-00-00', 2147483647, '4'),
(32, 11, 'Acetomenofen', '0', '50', '0000-00-00', 2147483647, '4'),
(33, 17, 'acetomenofen', '0', '50', '0000-00-00', 2147483647, '1'),
(34, 17, 'acetomenofen', '0', '50', '0000-00-00', 2147483647, '1'),
(35, 10, 'Diclo K', '0', '50', '0000-00-00', 2147483647, '4'),
(36, 10, 'acetomenofen', '0', '50', '0000-00-00', 2147483647, '3'),
(37, 10, 'Diclo K', '50', '600', '2023-03-15', 3, 'Firbere'),
(38, 13, 'Acetomenofen', '70', '50', '2023-03-08', 1, 'dolor de cabeza'),
(39, 13, 'Diclo KK', '100', '50', '2023-03-22', 4, 'Dolor de cabeza'),
(40, 13, 'Diclo KK', '100', '50', '2023-03-22', 4, 'Dolor de cabeza'),
(41, 14, 'diclo k', '100', '50', '2023-08-04', 4, 'una'),
(42, 11, 'diclo k', '100', '50', '2023-08-04', 1, 'una'),
(43, 11, 'diclo k', '100', '50', '2023-08-04', 1, 'una'),
(44, 8, 'Diclo K', '50', '600', '2023-03-15', 3, 'Firbere'),
(45, 8, 'Diclo K', '50', '600', '2023-03-15', 3, 'Firbere'),
(46, 10, '15', '70', '50', '2023-03-08', 1, 'dolor de cabeza'),
(47, 10, '15', '70', '50', '2023-03-08', 1, 'dolor de cabeza'),
(48, 10, 'Diclo KK', '100', '50', '2023-03-22', 4, 'Dolor de cabeza'),
(49, 12, '15', '70', '50', '2023-03-08', 4, 'dolor de cabeza'),
(50, 15, 'Diclo KK', '100', '50', '2023-03-22', 5, 'Dolor de cabeza'),
(51, 13, 'Diclo K', '600', '50', '2025-07-17', 4, 'Firbere'),
(52, 5, 'Diclo KK', '100', '50', '2023-03-22', 3, 'Dolor de cabeza'),
(53, 0, 'Acetomenofen', '70', '50', '2023-03-08', 4, 'dolor de cabeza'),
(54, 13, 'diclo k', '100', '50', '2023-08-04', 1, 'una'),
(55, 13, 'diclo k', '100', '50', '2023-08-04', 1, 'una'),
(56, 13, 'diclo k', '100', '50', '2023-08-04', 1, 'una'),
(57, 11, 'Acetomenofen', '70', '50', '2023-03-08', 4, 'dolor de cabeza'),
(58, 11, 'Diclo KK', '100', '50', '2023-03-22', 4, 'Dolor de cabeza'),
(59, 12, 'Diclo KK', '100', '50', '2023-03-22', 1, 'Dolor de cabeza'),
(60, 10, 'Acetomenofen', '70', '50', '2023-03-08', 3, 'dolor de cabeza'),
(61, 11, 'Acetomenofen', '70', '50', '2023-03-08', 5, 'dolor de cabeza'),
(62, 11, 'diclo k', '100', '50', '2023-08-04', 4, 'una'),
(63, 10, 'Diclo KK', '100', '50', '2023-03-22', 4, 'Dolor de cabeza'),
(64, 10, 'acetomenofen', '80', '50', '2025-07-17', 1, 'dolor de cabeza'),
(65, 10, 'diclo k', '100', '50', '2023-08-04', 4, 'una'),
(66, 10, 'Acetomenofen', '70', '50', '2023-03-08', 4, 'dolor de cabeza'),
(67, 11, 'acetomenofen', '80', '50', '2025-07-17', 5, 'dolor de cabeza'),
(68, 10, 'diclo k', '100', '50', '2023-08-04', 3, 'una'),
(69, 11, 'diclo k', '100', '50', '2023-08-04', 4, 'una'),
(70, 12, 'diclo k', '100', '50', '2023-08-04', 5, 'una');

-- --------------------------------------------------------

--
-- Table structure for table `proveedores`
--

CREATE TABLE `proveedores` (
  `codprov` int(11) NOT NULL,
  `laboratorio` varchar(50) NOT NULL,
  `codigo` int(11) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `correo_electronico` varchar(50) NOT NULL,
  `telefono` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `proveedores`
--

INSERT INTO `proveedores` (`codprov`, `laboratorio`, `codigo`, `direccion`, `correo_electronico`, `telefono`) VALUES
(5, 'Tu solucion', 65165, 'El portal', 'TuSolucion@gmail.com', '8092459092'),
(6, 'dsfsdf', 65156, 'dfdsf', 'fdsfs', '6561'),
(7, 'adsa', 65165, 'asfas', 'afadfd', '515'),
(8, 'fdsf', 65165, 'dffdsf', 'fsfsdf', '65165'),
(9, 'ewr', 1655, 'fewfewf', 'fwf', '65165'),
(10, 'ytyt', 656465, 'yudytu', 'yuytu', '615'),
(11, 'gfdgd', 651651, 'gfdfg', 'fgdfg', '6515'),
(12, 'Laboratorio', 651651, 'asdakjdbn', 'lkandjlknas', '656651'),
(13, 'elpreio', 12345, 'Elportal', 'Wilmer@gmai.com', '8092459092'),
(14, 'elpreio', 12345, 'Elportal', 'Wilmer@gmai.com', '8092459092'),
(15, 'El salmon', 651651, 'El portal', 'Wilmiradael@gmail.com', '8092459092'),
(16, 'elcasique', 65165161, 'El portal', 'Elcasique@gmail.com', '8092459092'),
(17, 'juan', 65165, 'Elcacao', 'Samuel@gmial.com', '8092459092'),
(21, 'laboratorio', 95195, 'El portal', 'laboratorio@gmial.com', '8092459092'),
(22, 'dasd', 4245, 'dasd@gmail.com', 'el portal', '8092459092');

-- --------------------------------------------------------

--
-- Table structure for table `sucursal2`
--

CREATE TABLE `sucursal2` (
  `Id` int(11) NOT NULL,
  `codigo` int(11) NOT NULL,
  `nombreproduct` varchar(50) NOT NULL,
  `preciovent` decimal(10,0) NOT NULL,
  `preciocomp` decimal(10,0) NOT NULL,
  `fechavencimiento` date NOT NULL,
  `stocks` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sucursal2`
--

INSERT INTO `sucursal2` (`Id`, `codigo`, `nombreproduct`, `preciovent`, `preciocomp`, `fechavencimiento`, `stocks`) VALUES
(1, 18497, 'Nifedipina', '20', '10', '2027-12-06', 0),
(2, 14805, 'Metildopa', '15', '5', '2024-02-15', 0),
(1, 18497, 'Nifedipina', '20', '10', '2027-12-06', 0),
(2, 14805, 'Metildopa', '15', '5', '2024-02-15', 0),
(1, 18497, 'Nifeldipina', '20', '10', '2027-03-24', 800),
(0, 0, '[value-3]', '0', '0', '0000-00-00', 0),
(2, 14805, 'Metildopa', '15', '5', '2026-05-01', 350),
(2, 14805, 'Metildopa', '15', '5', '2026-05-01', 350),
(20, 15782, 'Heparina', '75', '40', '2027-12-20', 246),
(20, 15782, 'Heparina', '75', '40', '2027-12-20', 246);

-- --------------------------------------------------------

--
-- Table structure for table `sucursal3`
--

CREATE TABLE `sucursal3` (
  `Id` int(11) NOT NULL,
  `codigo` int(11) NOT NULL,
  `nombreproduct` varchar(50) NOT NULL,
  `preciovent` decimal(10,0) NOT NULL,
  `preciocomp` decimal(10,0) NOT NULL,
  `fechavencimiento` date NOT NULL,
  `stocks` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sucursal3`
--

INSERT INTO `sucursal3` (`Id`, `codigo`, `nombreproduct`, `preciovent`, `preciocomp`, `fechavencimiento`, `stocks`) VALUES
(13, 10254, 'Alendronato', '20', '10', '2027-12-06', 800),
(13, 10254, 'Alendronato', '20', '10', '2027-12-06', 800),
(17, 10588, 'Azitromicina', '110', '80', '2025-09-06', 0),
(17, 10588, 'Azitromicina', '110', '80', '2025-09-06', 0),
(17, 10588, 'Azitromicina', '110', '80', '2025-04-23', 750),
(17, 10588, 'Azitromicina', '110', '80', '2025-04-23', 750);

-- --------------------------------------------------------

--
-- Table structure for table `sucursal4`
--

CREATE TABLE `sucursal4` (
  `Id` int(11) NOT NULL,
  `codigo` int(11) NOT NULL,
  `nombreproduct` varchar(50) NOT NULL,
  `preciovent` decimal(10,0) NOT NULL,
  `preciocomp` decimal(10,0) NOT NULL,
  `fechavencimiento` date NOT NULL,
  `stocks` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sucursal4`
--

INSERT INTO `sucursal4` (`Id`, `codigo`, `nombreproduct`, `preciovent`, `preciocomp`, `fechavencimiento`, `stocks`) VALUES
(42, 18506, 'Docixilina', '40', '20', '2026-01-05', 470),
(42, 18506, 'Docixilina', '40', '20', '2026-01-05', 470),
(44, 10583, 'Metropolol', '115', '100', '2027-05-15', 340),
(44, 10583, 'Metropolol', '115', '100', '2027-05-15', 340);

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `idusuario` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `contrasena` varchar(50) NOT NULL,
  `sexo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`idusuario`, `nombre`, `apellido`, `contrasena`, `sexo`) VALUES
(1, 'Wilmer', 'Villar', '12345', 'masculino'),
(2, 'Samuel', '123456', '123456', 'Masculino'),
(3, 'Lucas', '12345', '12345', 'Femenino'),
(4, 'Wilma', '12345', '12345', 'Femenino'),
(5, 'Wilma', '1234578', '1234578', 'Femenino'),
(7, 'Wilmer', '32145', '32145', 'Femenino'),
(8, 'Wilmer', '32145', '32145', 'Femenino'),
(9, 'Samuel', '69894165', '69894165', 'Masculino'),
(10, 'Samuel', 'Lopez', '2564', 'Masculino'),
(11, 'daury', 'villar', 'villar1234', 'Masculino'),
(12, 'daury', 'villar', 'villar123', ''),
(13, 'samuel', 'lopez', '12345', 'Femenino'),
(15, 'manuel', 'sena', '1212', 'masculino'),
(16, 'wilmer', 'Villar', '123456', 'Femenino'),
(17, 'samuel', 'Lopez', '12345', 'Femenino'),
(18, 'Juan', 'Lopez', '12345', 'Masculino');

-- --------------------------------------------------------

--
-- Table structure for table `venta`
--

CREATE TABLE `venta` (
  `codigo` int(11) NOT NULL,
  `nombrecliente` varchar(50) NOT NULL,
  `nombreproduct` varchar(255) NOT NULL,
  `preciovent` float NOT NULL,
  `Cantidad` varchar(255) NOT NULL,
  `Total` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `venta`
--

INSERT INTO `venta` (`codigo`, `nombrecliente`, `nombreproduct`, `preciovent`, `Cantidad`, `Total`) VALUES
(124, '', 'metronidazol', 20, '50', ''),
(1010, '', 'acetaminofen', 10, '150', ''),
(1111, '', 'diclo k', 5, '', ''),
(3025, '', 'ibuprofen', 35, '50', ''),
(3026, '15', 'Acetomenofen', 70, '4', '280'),
(3027, 'Carlos', 'Acetomenofen', 70, '4', '280'),
(3028, 'Samuel', 'Acetomenofen', 70, '4', '960'),
(3029, 'Samuel', 'diclo k', 100, '4', '960'),
(3030, 'Samuel', '15', 70, '4', '280'),
(3031, 'Carlos', 'Acetomenofen', 70, '3', '210'),
(3032, 'Carlos', 'diclo k', 100, '3', '300'),
(3033, 'Saul', '15', 70, '3', '490'),
(3034, 'Saul', 'Acetomenofen', 70, '4', '490'),
(3035, 'Samuel', 'Diclo KK', 100, '4', '400'),
(3036, '', 'acetomenofen', 80, '5', '400'),
(3037, 'Samuel', 'Acetomenofen', 70, '3', '210'),
(3038, 'Carlos', 'pastillas', 100, '4', '800'),
(3039, 'Carlos', 'diclo k', 100, '4', '800'),
(3040, '', 'Acetomenofen', 70, '1', '70'),
(3041, 'Carlos', 'acetomenofen', 80, '1', '80');

-- --------------------------------------------------------

--
-- Table structure for table `ventas`
--

CREATE TABLE `ventas` (
  `numventa` int(11) NOT NULL,
  `codcliente` int(11) NOT NULL,
  `codempleado` int(11) NOT NULL,
  `codproducto` int(11) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`codcliente`);

--
-- Indexes for table `compra`
--
ALTER TABLE `compra`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `id_suplidor` (`id_suplidor`),
  ADD KEY `idproducto` (`idproducto`);

--
-- Indexes for table `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `idproveedor` (`idproveedor`);

--
-- Indexes for table `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`codprov`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idusuario`);

--
-- Indexes for table `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`codigo`);

--
-- Indexes for table `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`numventa`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `producto`
--
ALTER TABLE `producto`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=71;

--
-- AUTO_INCREMENT for table `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `codprov` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `idusuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `venta`
--
ALTER TABLE `venta`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3042;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
