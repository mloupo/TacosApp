USE [TacosAppDeliveryDb]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Martin Lopez>
-- Create date: <Create Date>
-- Description:	<ListarPedidosPorCliente>
-- =============================================
CREATE PROCEDURE [dbo].[ListarPedidosPorCliente]
       @IdCliente int
AS
BEGIN
    SELECT P.idPedido, P.Fecha_Hora, P.Importe, P.Entregado, C.Nombre AS Cliente, ME.Nombre AS Medio_Envio
    FROM [dbo].[Pedidos] P
    INNER JOIN [dbo].Clientes C ON P.idCliente = C.idCliente
    INNER JOIN [dbo].MediosEnvio ME ON P.idMedioEnvio = ME.idMedioEnvio
    WHERE C.idCliente =@IdCliente;
END
GO
