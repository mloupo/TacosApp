-- Modelo Físico en MySQL:
DROP DATABASE IF EXISTS TacosAppDb;
CREATE DATABASE TacosAppDb;
USE TacosAppDb;

-- Tabla Clientes
DROP TABLE IF EXISTS Clientes;
CREATE TABLE Clientes (
    idCliente INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Pass VARCHAR(15) NOT NULL,
    NroContacto VARCHAR(15) NOT NULL
);

-- Tabla Medios de envío
DROP TABLE IF EXISTS MediosEnvio;
CREATE TABLE MediosEnvio (
    idMedioEnvio INT AUTO_INCREMENT PRIMARY KEY,
    Patente VARCHAR(20) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    NroContacto VARCHAR(15) NOT NULL
);

-- Tabla Tacos (Para almacenar los tipos de tacos disponibles)
DROP TABLE IF EXISTS Tacos;
CREATE TABLE Tacos (
    idTaco INT AUTO_INCREMENT PRIMARY KEY,
    Precio DECIMAL(8, 2) NOT NULL
);

-- Tabla Pedidos
DROP TABLE IF EXISTS Pedidos;
CREATE TABLE Pedidos (
    idPedido INT AUTO_INCREMENT PRIMARY KEY,
    Fecha_Hora DATETIME NOT NULL,
    Importe DECIMAL(8, 2) NOT NULL,
    Entregado ENUM('Si', 'No') NOT NULL,
    idCliente INT NOT NULL,
    idMedioEnvio INT NOT NULL,
    FOREIGN KEY (idCliente) REFERENCES Clientes(idCliente),
    FOREIGN KEY (idMedioEnvio) REFERENCES MediosEnvio(idMedioEnvio)
);

-- Tabla intermedia para la relación M:N entre Pedidos y Tacos
DROP TABLE IF EXISTS Pedidos_Tacos;
CREATE TABLE Pedidos_Tacos (
    idPedido INT NOT NULL,
    idTaco INT NOT NULL,
    PRIMARY KEY (idPedido, idTaco),
    FOREIGN KEY (idPedido) REFERENCES Pedidos(idPedido),
    FOREIGN KEY (idTaco) REFERENCES Tacos(idTaco)
);

-- Tabla "BackUp" para mantener los datos de los pedidos realizados
DROP TABLE IF EXISTS BackUp_Pedidos;
CREATE TABLE BackUp_Pedidos (
    idPedido INT NOT NULL,
    Fecha_Hora DATETIME NOT NULL,
    Importe DECIMAL(8, 2) NOT NULL,
    Entregado ENUM('Si', 'No') NOT NULL,
    idCliente INT NOT NULL,
    idMedioEnvio INT NOT NULL
);

-- Trigger para mantener una tabla "BackUp" con los datos de los pedidos realizados
USE TacosAppDb;
DELIMITER //
CREATE TRIGGER Backup_Pedidos
AFTER INSERT ON Pedidos
FOR EACH ROW
BEGIN
    INSERT INTO BackUp_Pedidos (idPedido, Fecha_Hora, Importe, Entregado, idCliente, idMedioEnvio)
    VALUES (NEW.idPedido, NEW.Fecha_Hora, NEW.Importe, NEW.Entregado, NEW.idCliente, NEW.idMedioEnvio);
END//
DELIMITER ;

-- Procedimiento almacenado para listar los pedidos de un cliente:
DELIMITER //
USE TacosAppDb;
DROP PROCEDURE IF EXISTS ListarPedidosPorCliente;
CREATE PROCEDURE ListarPedidosPorCliente (IN cliente_nombre VARCHAR(100))
BEGIN
    SELECT P.idPedido, P.Fecha_Hora, P.Importe, P.Entregado, C.Nombre AS Cliente, ME.Nombre AS Medio_Envio
    FROM Pedidos P
    INNER JOIN Clientes C ON P.idCliente = C.idCliente
    INNER JOIN MediosEnvio ME ON P.idMedioEnvio = ME.idMedioEnvio
    WHERE C.Nombre = cliente_nombre;
END //

DELIMITER ;


