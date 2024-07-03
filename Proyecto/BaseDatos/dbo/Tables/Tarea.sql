CREATE TABLE [dbo].[Tarea]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Nombre] VARCHAR(50) NULL,
    [Descripcion] VARCHAR(50) NULL, 
    [FechaInicio] DATE NULL, 
    [FechaFinal] DATE NULL, 
    [Asignado] UNIQUEIDENTIFIER NULL, 
    [Estado] UNIQUEIDENTIFIER NULL, 
    [Creador] UNIQUEIDENTIFIER NULL
)
