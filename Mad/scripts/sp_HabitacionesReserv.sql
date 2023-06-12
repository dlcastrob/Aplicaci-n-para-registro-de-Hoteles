
CREATE PROCEDURE sp_HabitacionesReserv
    @ReservaId INT
AS
BEGIN
    -- Actualizar el estado de la reserva a "Activa" en la tabla de reservas
SELECT H.NumeroHabitacion
FROM Reservacion R
JOIN Habitacion H ON R.HabitacionID = H.NumeroHabitacion
WHERE R.ReservacionID =   @ReservaId;
 
     
END
