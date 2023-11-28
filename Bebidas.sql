USE [TacosAppDb]
GO

CREATE TABLE [dbo].[Gaseosa] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Nombre] NVARCHAR (50) NOT NULL,
    [Precio] FLOAT (53)    NOT NULL
	CONSTRAINT [PK_Gaseosa] PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [dbo].[Gaseosa]
           ([Nombre]
           ,[Precio])
     VALUES
           ('Coca Cola', 2000),
		   ('Sprite', 2200),
		   ('Fanta', 2200)
		   

GO


