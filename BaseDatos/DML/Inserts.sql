
-- Insertar datos en la tabla Clientes
INSERT INTO Clientes (Nombre, NroContacto) VALUES
    ('John Malkovich', '1234567890'),
    ('John Wick', '9876543210'),
    ('Matt Damon', '5555555555'),
    ('Laura Martinez', '7777777777'),
    ('Carlos Sanchez', '1111111111');

-- Insertar datos en la tabla MediosEnvio
INSERT INTO MediosEnvio (Patente, Nombre, NroContacto) VALUES
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