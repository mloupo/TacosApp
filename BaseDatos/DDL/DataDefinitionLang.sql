-- Modelo Físico en SQL Server:
DROP DATABASE IF EXISTS TacosAppDeliveryDb;
CREATE DATABASE TacosAppDeliveryDb;
USE TacosAppDeliveryDb;

-- Tabla Clientes
DROP TABLE IF EXISTS Clientes;
CREATE TABLE Clientes (
    idCliente INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Pass NVARCHAR(15) NOT NULL,
    NroContacto NVARCHAR(15) NOT NULL
);

-- Tabla Medios de envío
DROP TABLE IF EXISTS MediosEnvio;
CREATE TABLE MediosEnvio (
    idMedioEnvio INT PRIMARY KEY IDENTITY(1,1),
    Patente NVARCHAR(20) NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    NroContacto NVARCHAR(15) NOT NULL
);

-- Tabla Tacos (Para almacenar los tipos de tacos disponibles)
DROP TABLE IF EXISTS Tacos;
CREATE TABLE Tacos (
    idTaco INT PRIMARY KEY IDENTITY(1,1),
    Precio DECIMAL(8, 2) NOT NULL
);

-- Tabla Pedidos
CREATE TABLE Pedidos (
    idPedido INT PRIMARY KEY IDENTITY(1,1),
    Fecha_Hora DATETIME NOT NULL,
    Importe DECIMAL(8, 2) NOT NULL,
    Entregado BIT NOT NULL,
    idCliente INT NOT NULL,
    idMedioEnvio INT NOT NULL,
    FOREIGN KEY (idCliente) REFERENCES Clientes(idCliente),
    FOREIGN KEY (idMedioEnvio) REFERENCES MediosEnvio(idMedioEnvio)
);

-- Tabla intermedia para la relación M:N entre Pedidos y Tacos
CREATE TABLE Pedidos_Tacos (
    idPedido INT NOT NULL,
    idTaco INT NOT NULL,
    PRIMARY KEY (idPedido, idTaco),
    FOREIGN KEY (idPedido) REFERENCES Pedidos(idPedido),
    FOREIGN KEY (idTaco) REFERENCES Tacos(idTaco)
);

-- Tabla "BackUp" para mantener los datos de los pedidos realizados
CREATE TABLE BackUp_Pedidos (
    idPedido INT NOT NULL,
    Fecha_Hora DATETIME NOT NULL,
    Importe DECIMAL(8, 2) NOT NULL,
    Entregado BIT NOT NULL,
    idCliente INT NOT NULL,
    idMedioEnvio INT NOT NULL
);