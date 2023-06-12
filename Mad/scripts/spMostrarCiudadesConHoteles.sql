USE MAD;

-- Crear la vista
CREATE VIEW VistaCiudadesConHoteles
AS
SELECT DISTINCT Ciudad
FROM Hotel;

-- Crear el procedimiento almacenado
IF OBJECT_ID('spMostrarCiudadesConHoteles') IS NOT NULL
BEGIN
    DROP PROCEDURE spMostrarCiudadesConHoteles;
END;
GO

CREATE PROCEDURE spMostrarCiudadesConHoteles
AS
BEGIN
    SELECT Ciudad
    FROM VistaCiudadesConHoteles;
END;
GO

-- Ejecutar el procedimiento almacenado
EXEC spMostrarCiudadesConHoteles;



CREATE PROCEDURE spBuscarHotelesPorCiudad
(
    @Ciudad VARCHAR(255)
)
AS
BEGIN
    SELECT NombreHotel, Ciudad, Estado, Pais, Domicilio
    FROM Hotel
    WHERE Ciudad = @Ciudad;
END;

USE ProyectoMAD;
Go

IF OBJECT_ID('spReservacion')IS NOT NULL
BEGIN
DROP PROCEDURE spReservacion;
END;
Go

CREATE PROCEDURE spReservacion
    @FechaEntrada DATE,
    @FechaSalida DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT H.NumeroHabitacion, H.TipoHabitacionID, H.Estado
    FROM Habitacion H
    WHERE H.NumeroHabitacion NOT IN (
        SELECT R.HabitacionID
        FROM Reservacion R
        WHERE (
            @FechaEntrada BETWEEN R.FechaEntrada AND R.FechaSalida
            OR @FechaSalida BETWEEN R.FechaEntrada AND R.FechaSalida
            OR R.FechaEntrada BETWEEN @FechaEntrada AND @FechaSalida
            OR R.FechaSalida BETWEEN @FechaEntrada AND @FechaSalida
        )
    );
END
EXEC spReservacion;
