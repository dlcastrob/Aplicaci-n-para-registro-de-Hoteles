CREATE PROCEDURE calcular_porcentaje_ocupacion()
AS
RETURNS porcentaje_ocupacion DECIMAL(5, 2);
BEGIN
    DECLARE total_ocupadas INT;
    DECLARE total_disponibles INT;
    DECLARE porcentaje_ocupacion DECIMAL(5, 2);
    
    -- Obtener el total de habitaciones ocupadas
    SELECT COUNT(habitacion_id) INTO total_ocupadas
    FROM habitaciones
    WHERE ocupada = true;
    
    -- Obtener el total de habitaciones disponibles
    SELECT COUNT(habitacion_id) INTO total_disponibles
    FROM habitaciones
    WHERE ocupada = false;
    
    -- Calcular el porcentaje de ocupación
    SET porcentaje_ocupacion = (total_ocupadas / (total_ocupadas + total_disponibles)) * 100;
    
    -- Mostrar el resultado
    SELECT porcentaje_ocupacion AS 'Porcentaje de ocupación';
    RETURN porcentaje_ocupacion; 
END;


CREATE PROCEDURE ObtenerReporteOcupacion
    @Pais VARCHAR(255),
    @Anio INT,
    @Ciudad VARCHAR(255),
    @NombreHotel VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        Ciudad,
        NombreHotel,
        CONVERT(varchar(7), R.FechaEntrada, 126) AS [Anio-Mes],
        TH.TipoHabitacionID AS [Tipo de habitacion],

        COUNT AS [Cantidad de habitaciones],
      Porcentaje de ocupacion= Cantidad de habitaciones
        SUM(R.CantidadPersonasHabitacion) AS [Cantidad de personas hospedadas]
    FROM
        Hotel H
        JOIN Habitacion HA ON H.HotelID = HA.HotelID
        JOIN TiposHabitacion TH ON HA.TipoHabitacionID = TH.TipoHabitacionID
        JOIN Reservacion R ON HA.NumeroHabitacion = R.HabitacionID
    WHERE
        H.Pais = @Pais
        AND YEAR(R.FechaEntrada) = @Anio
        AND H.Ciudad = @Ciudad
        AND (H.NombreHotel = @NombreHotel OR @NombreHotel = 'Todos')
    GROUP BY
        Ciudad,
        NombreHotel,
        CONVERT(varchar(7), R.FechaEntrada, 126),
        TH.TipoHabitacionID
    WITH ROLLUP
END
