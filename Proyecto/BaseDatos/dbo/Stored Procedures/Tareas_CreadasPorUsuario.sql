CREATE PROCEDURE dbo.Tareas_CreadasPorUsuario
    @Creador UNIQUEIDENTIFIER
AS
BEGIN
    SELECT
        Nombre,
        Descripcion,
        FechaInicio,
        FechaFinal,
        Asignado,
        Estado
    FROM dbo.Tarea
    WHERE Creador = @Creador
END