USE TacosAppDb;
DROP TABLE [dbo].[Contactos];

CREATE TABLE [dbo].[Contactos] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]            NVARCHAR (50) NOT NULL,
    [Apellido]          NVARCHAR (50) NOT NULL,
    [NroContacto]       NVARCHAR (50) NOT NULL,
    [CorreoElectronico] NVARCHAR (50) NOT NULL,
	[DireccionEnvio]         NVARCHAR (50) NOT NULL,
    [Contraseña]        NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Contactos] PRIMARY KEY CLUSTERED ([Id] ASC)
);

