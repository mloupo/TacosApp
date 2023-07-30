USE TacosAppDeliveryDb;
-- Insertar datos en la tabla Clientes
INSERT INTO Clientes (Nombre, Email, Pass, NroContacto) VALUES
    ('John Malkovich', 'JohnMalkovich@gmail.com', 'Lorem1234', '2291486425'),
    ('John Wick', 'JonhWick@gamil.com', 'Lorem2345', '2291369417'),
    ('Matt Damon', 'MattDamon@gmail.com', 'Lorem3456', '2291682536'),
    ('Laura Martinez', 'LauraMartinez@gmail.com', 'Lorem4567', '2291410054'),    
    ('Carlos Sanchez', 'CarlosSanchez@gmail.com', 'Lorem5678', '2291520065');

-- Insertar datos en la tabla MediosEnvio
INSERT INTO MediosEnvio (Patente, Nombre, NroContacto) VALUES
    ('ABC123', 'Alberto Cortez', '3333333333'),
    ('XYZ987', 'Jorge Porcel', '4444444444'),
    ('LMN456', 'Jonh Travolta', '6666666666'),
    ('DEF789', 'Conor MacGregor', '2222222222'),
    ('GHI321', 'Sanderlei Silva', '9999999999');

-- Insertar datos en la tabla Tacos
INSERT INTO Tacos (Precio) VALUES
    (3.5),
    (4.0),
    (5.0),
    (3.0),
    (6.0);

-- Insertar datos en la tabla Pedidos
INSERT INTO Pedidos (Fecha_Hora, Importe, Entregado, idCliente, idMedioEnvio) VALUES
    ('2023-07-25 10:00:00', 15.5, 1, 3, 1),
    ('2023-07-26 14:30:00', 12.0, 1, 2, 2),
    ('2023-07-26 18:15:00', 6.0, 0, 3, 3),
    ('2023-07-27 12:45:00', 9.5, 1, 4, 4),
    ('2023-07-27 20:00:00', 6.0, 1, 5, 5)