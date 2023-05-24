CREATE FUNCTION dbo.CalcularPorcentajeOcupacion()
RETURNS DECIMAL(10, 2)
AS
BEGIN
DECLARE @HabitacionesOcupadas INT;
DECLARE @HabitacionesDisponibles INT;
DECLARE @PorcentajeOcupacion DECIMAL(10, 2);

```
-- Obtener el total de habitaciones ocupadas
SELECT @HabitacionesOcupadas = COUNT(*) FROM Habitaciones WHERE Estado = 'Ocupada';

-- Obtener el total de habitaciones disponibles
SELECT @HabitacionesDisponibles = COUNT(*) FROM Habitaciones WHERE Estado = 'Disponible';

-- Calcular el porcentaje de ocupación
IF (@HabitacionesDisponibles > 0)
    SET @PorcentajeOcupacion = (@HabitacionesOcupadas * 100.0) / @HabitacionesDisponibles;
ELSE
    SET @PorcentajeOcupacion = 0;

RETURN @PorcentajeOcupacion;

```

END

CREATE FUNCTION CalcularPorcentaje
(
@montoTotal decimal(18,2),
@porcentaje decimal(5,2)
)
RETURNS decimal(18,2)
AS
BEGIN
DECLARE @resultado decimal(18,2);

```
SET @resultado = (@montoTotal * @porcentaje) / 100;

RETURN @resultado;

```

END