CREATE TABLE [dbo].[Cerveza] (
    [Id]            INT       IDENTITY (1, 1) NOT NULL,
    [Nombre]        NVARCHAR (50) NOT NULL,
    [Precio]        FLOAT (53)    NOT NULL,
    [Marca]         NVARCHAR (50) NULL,
    [Cerveceria]    NVARCHAR (50) NULL,
    [Pais]          NVARCHAR (50) NULL,
    [Alcohol]       NVARCHAR (50) NULL,
    [Clasificacion] INT           NULL
	CONSTRAINT [PK_Cerveza] PRIMARY KEY CLUSTERED ([Id] ASC)
);

