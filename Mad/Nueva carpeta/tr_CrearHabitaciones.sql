CREATE TRIGGER tr_CrearHabitaciones
ON TiposHabitacion
AFTER INSERT
AS
BEGIN
    -- Obtener el TipoHabitacionID del tipo de habitación insertado
    DECLARE @TipoHabitacionID VARCHAR(255)
    SELECT @TipoHabitacionID = TipoHabitacionID FROM inserted

    -- Insertar 50 registros en la tabla Habitacion para el TipoHabitacionID especificado
   SELECT h.NumeroHabitacion, th.TipoHabitacionID
FROM Habitacion h
LEFT JOIN Reservacion r ON h.NumeroHabitacion = r.HabitacionID
RIGHT JOIN TiposHabitacion th ON h.TipoHabitacionID = th.TipoHabitacionID
WHERE r.ReservacionID IS NULL;
    END
END
