CREATE PROCEDURE dbo.Tarea_Update
    @Id UNIQUEIDENTIFIER,
    @Nombre VARCHAR(50),
    @Descripcion VARCHAR(50),
    @FechaInicio DATE,
    @FechaFinal DATE,
    @Asignado UNIQUEIDENTIFIER,
    @Estado UNIQUEIDENTIFIER,
    @Creador UNIQUEIDENTIFIER
AS
BEGIN
    UPDATE dbo.Tarea
    SET Nombre = @Nombre, Descripcion = @Descripcion, FechaInicio = @FechaInicio,
        FechaFinal = @FechaFinal, Asignado = @Asignado, Estado = @Estado, Creador = @Creador
    WHERE Id = @Id
END