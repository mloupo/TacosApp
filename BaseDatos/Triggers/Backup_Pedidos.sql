USE [TacosAppDeliveryDb]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Martin Lopez>
-- Create date: <Create Date>
-- Description:	<TriggerBackup_Pedidos>
-- =============================================
CREATE TRIGGER [dbo].[TriggerBackup_Pedidos] 
ON [dbo].[Pedidos]
AFTER INSERT
AS
BEGIN
	INSERT INTO [dbo].BackUp_Pedidos (idPedido, Fecha_Hora, Importe, Entregado, idCliente, idMedioEnvio)
    SELECT idPedido, Fecha_Hora, Importe, Entregado, idCliente, idMedioEnvio FROM inserted;
END
GO
;