-- Ejecutar el procedimiento almacenado para listar los pedidos de un cliente:
EXEC ListarPedidosPorCliente 'John Wick';

-- Ejecutar el procedimiento almacenado para obtener el promedio recaudado por delivery en un rango de fechas:
EXEC PromedioRecaudadoPorDelivery '2023-07-25 00:00:00', '2023-07-27 23:59:59';