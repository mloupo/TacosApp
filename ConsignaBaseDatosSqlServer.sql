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

-- Trigger para mantener una tabla "BackUp" con los datos de los pedidos realizados
CREATE TRIGGER Backup_Pedidos
ON Pedidos
AFTER INSERT
AS
BEGIN
    INSERT INTO BackUp_Pedidos (idPedido, Fecha_Hora, Importe, Entregado, idCliente, idMedioEnvio)
    SELECT idPedido, Fecha_Hora, Importe, Entregado, idCliente, idMedioEnvio FROM inserted;
END;


-- Procedimiento almacenado para listar los pedidos de un cliente:
CREATE PROCEDURE ListarPedidosPorCliente
    @cliente_nombre NVARCHAR(100)
AS
BEGIN
    SELECT P.idPedido, P.Fecha_Hora, P.Importe, P.Entregado, C.Nombre AS Cliente, ME.Nombre AS Medio_Envio
    FROM Pedidos P
    INNER JOIN Clientes C ON P.idCliente = C.idCliente
    INNER JOIN MediosEnvio ME ON P.idMedioEnvio = ME.idMedioEnvio
    WHERE C.Nombre = @cliente_nombre;
END;

-- Procedimiento almacenado para obtener el promedio recaudado por delivery en un rango de fechas:
CREATE PROCEDURE PromedioRecaudadoPorDelivery
    @fecha_desde DATETIME,
    @fecha_hasta DATETIME
AS
BEGIN
    SELECT AVG(Importe) AS Promedio_Recaudado
    FROM Pedidos
    WHERE Entregado = 1 AND Fecha_Hora BETWEEN @fecha_desde AND @fecha_hasta;
END;

-- Insertar datos en la tabla Clientes
INSERT INTO Clientes (Nombre, Celular) VALUES
    ('Juan Perez', '1234567890'),
    ('Maria Gomez', '9876543210'),
    ('Pedro Rodriguez', '5555555555'),
    ('Laura Martinez', '7777777777'),
    ('Carlos Sanchez', '1111111111');

-- Insertar datos en la tabla MediosEnvio
INSERT INTO MediosEnvio (Patente, Nombre, Celular) VALUES
    ('ABC123', 'Moto Express', '3333333333'),
    ('XYZ987', 'Auto Delivery', '4444444444'),
    ('LMN456', 'Bici Envíos', '6666666666'),
    ('DEF789', 'Camión de Carga', '2222222222'),
    ('GHI321', 'A Pie', '9999999999');

-- Insertar datos en la tabla Tacos
INSERT INTO Tacos (Descripcion, Precio) VALUES
    ('Taco de Pollo', 3.5),
    ('Taco de Res', 4.0),
    ('Taco de Pescado', 5.0),
    ('Taco Vegetariano', 3.0),
    ('Taco de Camarón', 6.0);

-- Insertar datos en la tabla Pedidos
INSERT INTO Pedidos (Fecha_Hora, Importe, Entregado, idCliente, idMedioEnvio) VALUES
    ('2023-07-25 10:00:00', 15.5, 1, 1, 1),
    ('2023-07-26 14:30:00', 12.0, 1, 2, 2),
    ('2023-07-26 18:15:00', 6.0, 0, 3, 3),
    ('2023-07-27 12:45:00', 9.5, 1, 4, 4),
    ('2023-07-27 20:00:00', 6.0, 1, 5, 5);

-- Ejecutar el procedimiento almacenado para listar los pedidos de un cliente:
EXEC ListarPedidosPorCliente 'Juan Perez';

-- Ejecutar el procedimiento almacenado para obtener el promedio recaudado por delivery en un rango de fechas:
EXEC PromedioRecaudadoPorDelivery '2023-07-25 00:00:00', '2023-07-27 23:59:59';