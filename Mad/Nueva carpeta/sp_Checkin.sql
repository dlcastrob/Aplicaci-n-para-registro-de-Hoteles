CREATE PROCEDURE sp_Checkin
    @ReservaId INT
AS
BEGIN
    -- Actualizar el estado de la reserva a "Activa" en la tabla de reservas
    UPDATE Reservas
    SET Estado = 'Activa'
    WHERE Id = @ReservaId;
END
