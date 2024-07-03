CREATE PROCEDURE dbo.Tarea_Insert
    @Nombre VARCHAR(50),
    @Descripcion VARCHAR(50),
    @FechaInicio DATE,
    @FechaFinal DATE,
    @Asignado UNIQUEIDENTIFIER,
    @Estado UNIQUEIDENTIFIER,
    @Creador UNIQUEIDENTIFIER
AS
BEGIN
    INSERT INTO dbo.Tarea (Nombre, Descripcion, FechaInicio, FechaFinal, Asignado, Estado, Creador)
    VALUES (@Nombre, @Descripcion, @FechaInicio, @FechaFinal, @Asignado, @Estado, @Creador)
END