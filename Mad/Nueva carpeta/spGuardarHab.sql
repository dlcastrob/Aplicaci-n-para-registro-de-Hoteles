
DECLARE @PrecioTotal DECIMAL(10, 2);

EXEC spCalcularPrecioTotal
    @CantidadPersonas = 3,
    @TipoHabitacionID = 'Tipo1',
    @PrecioTotal = @PrecioTotal OUTPUT;

SELECT @PrecioTotal;
USE ProyectoMAD;
GO

IF OBJECT_ID('spCalcularPrecioTotal') IS NOT NULL
BEGIN
    DROP PROCEDURE spCalcularPrecioTotal;
END;
GO

CREATE PROCEDURE spCalcularPrecioTotal
    @CantidadPersonas INT,
    @TipoHabitacionID VARCHAR(255),
    @PrecioTotal DECIMAL(10, 2) OUTPUT
AS
BEGIN

    -- Llamar a la función para obtener el precio total
    SET @PrecioTotal = dbo.udfCalcularPrecioHabitacion(@CantidadPersonas, @TipoHabitacionID);
END
