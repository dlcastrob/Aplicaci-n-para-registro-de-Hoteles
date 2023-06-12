CREATE PROCEDURE ObtenerReporteOcupacion
    @Pais VARCHAR(255),
    @A�o INT,
    @Ciudad VARCHAR(255),
    @NombreHotel VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        Ciudad,
        NombreHotel,
        CONVERT(varchar(7), R.FechaEntrada, 126) AS [A�o-Mes],
        TH.TipoHabitacionID AS [Tipo de habitaci�n],
        COUNT(*) AS [Cantidad de habitaciones],
        AVG(CAST(R.CantidadPersonasHabitacion AS decimal)) AS [Porcentaje de ocupaci�n],
        SUM(R.CantidadPersonasHabitacion) AS [Cantidad de personas hospedadas]
    FROM
        Hotel H
        JOIN Habitacion HA ON H.HotelID = HA.HotelID
        JOIN TiposHabitacion TH ON HA.TipoHabitacionID = TH.TipoHabitacionID
        JOIN Reservacion R ON HA.NumeroHabitacion = R.HabitacionID
    WHERE
        H.Pais = @Pais
        AND YEAR(R.FechaEntrada) = @A�o
        AND H.Ciudad = @Ciudad
        AND (H.NombreHotel = @NombreHotel OR @NombreHotel = 'Todos')
    GROUP BY
        Ciudad,
        NombreHotel,
        CONVERT(varchar(7), R.FechaEntrada, 126),
        TH.TipoHabitacionID
    WITH ROLLUP
END
