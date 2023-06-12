
use MAD
CREATE PROCEDURE sp_BuscarHotelesPorCiudad
    @Ciudad VARCHAR(255)
AS
BEGIN
    SELECT NombreHotel FROM Hotel
     WHERE Ciudad = @Ciudad;
END