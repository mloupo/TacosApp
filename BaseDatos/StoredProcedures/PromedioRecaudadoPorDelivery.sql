USE [TacosAppDeliveryDb]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Martin Lopez>
-- Create date: <Create Date>
-- Description:	<PromedioRecaudadoPorDelivery>
-- =============================================
CREATE PROCEDURE [dbo].[PromedioRecaudadoPorDelivery]
    @fecha_desde DATETIME,
    @fecha_hasta DATETIME
AS
BEGIN
	SELECT AVG(Importe) AS Promedio_Recaudado
    FROM [dbo].[Pedidos]
    WHERE Entregado = 1 AND Fecha_Hora BETWEEN @fecha_desde AND @fecha_hasta;
END
GO
