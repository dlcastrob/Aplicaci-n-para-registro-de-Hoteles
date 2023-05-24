CREATE PROCEDURE dbo.GestionarUsuario
@idUs INT = NULL,
@tipoUs VARCHAR(50) = NULL,
@correoElectronico VARCHAR(100) = NULL,
@contrasena VARCHAR(50) = NULL,
@nombreCompleto VARCHAR(100) = NULL,
@numeroNomina VARCHAR(20) = NULL,
@fechaNacimiento DATE = NULL,
@domicilio VARCHAR(200) = NULL,
@telefonoCasa VARCHAR(20) = NULL,
@telefonoCelular VARCHAR(20) = NULL,
@estado VARCHAR(50) = NULL,
@accion VARCHAR(10)
AS
BEGIN
SET NOCOUNT ON;

```
IF @accion = 'Insertar'
BEGIN
    INSERT INTO Usuario (idUs, tipoUs, correoElectronico, contrasena, nombreCompleto, numeroNomina, fechaNacimiento, domicilio, telefonoCasa, telefonoCelular, estado)
    VALUES (@idUs, @tipoUs, @correoElectronico, @contrasena, @nombreCompleto, @numeroNomina, @fechaNacimiento, @domicilio, @telefonoCasa, @telefonoCelular, @estado);
END
ELSE IF @accion = 'Actualizar'
BEGIN
    UPDATE Usuario
    SET tipoUs = @tipoUs,
        correoElectronico = @correoElectronico,
        contrasena = @contrasena,
        nombreCompleto = @nombreCompleto,
        numeroNomina = @numeroNomina,
        fechaNacimiento = @fechaNacimiento,
        domicilio = @domicilio,
        telefonoCasa = @telefonoCasa,
        telefonoCelular = @telefonoCelular,
        estado = @estado
    WHERE idUs = @idUs;
END
ELSE IF @accion = 'Eliminar'
BEGIN
    DELETE FROM Usuario
    WHERE idUs = @idUs;
END
ELSE IF @accion = 'ObtenerPorId'
BEGIN
    SELECT *
    FROM Usuario
    WHERE idUs = @idUs;
END
ELSE IF @accion = 'ObtenerTodos'
BEGIN
    SELECT *
    FROM Usuario;
END

```

END