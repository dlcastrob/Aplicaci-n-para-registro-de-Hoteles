CREATE TRIGGER tr_CrearHabitaciones
ON TiposHabitacion
AFTER INSERT
AS
BEGIN
    -- Obtener el TipoHabitacionID del tipo de habitación insertado
    DECLARE @TipoHabitacionID VARCHAR(255)
    SELECT @TipoHabitacionID = TipoHabitacionID FROM inserted

    -- Insertar 50 registros en la tabla Habitacion para el TipoHabitacionID especificado
    DECLARE @Contador INT = 1
    WHILE @Contador <= 50
    BEGIN
        INSERT INTO Habitacion (TipoHabitacionID, Estado, HotelID)
        VALUES (@TipoHabitacionID, 0, NULL) -- 0 representa el estado inicial y NULL el HotelID (puede ajustarse según tus necesidades)
        
        SET @Contador = @Contador + 1
    END
END
