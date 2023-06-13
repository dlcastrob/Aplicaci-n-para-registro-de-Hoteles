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
