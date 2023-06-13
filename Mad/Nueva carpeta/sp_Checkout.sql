CREATE PROCEDURE sp_Checkout
    @ReservaId INT
AS
BEGIN
    -- Actualizar el estado de la reserva a "Activa" en la tabla de reservas
    UPDATE Reservas
    SET Estado = 'Terminada'
    WHERE Id = @ReservaId;
END
