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

