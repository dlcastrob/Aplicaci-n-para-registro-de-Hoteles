CREATE VIEW Factura AS
SELECT R.ReservacionID AS 'Número de factura',
       H.NombreHotel AS 'Nombre del hotel',
       H.Ciudad + ', ' + H.Estado + ', ' + H.Pais AS 'Datos del hotel',
       CONCAT(C.nombre, ' ', C.apellidos) AS 'Datos del cliente',
       R.ReservacionID AS 'Código de reservación',
       R.FechaEntrada AS 'Fecha de inicio',
       R.FechaSalida AS 'Fecha de salida'
FROM Reservacion R
INNER JOIN Hotel H ON R.HotelID = H.HotelID
INNER JOIN Cliente C ON R.ClienteID = C.idCliente;
