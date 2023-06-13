USE MAD;
GO

IF OBJECT_ID('spGestionarCliente') IS NOT NULL
BEGIN
    DROP PROCEDURE spGestionarCliente;
END;
GO

CREATE PROCEDURE spGestionarCliente
(
    @idCliente INT,
    @apellidos VARCHAR(100),
    @nombre VARCHAR(100),
    @domicilioCompleto VARCHAR(200),
    @rfc VARCHAR(13),
    @correoElectronico VARCHAR(100),
    @telefonoCasa VARCHAR(20),
    @telefonoCelular VARCHAR(20),
    @referenciaHotel VARCHAR(200),
    @fechaNacimiento DATE,
    @estadoCivil VARCHAR(20),
    @fecha DATE,
    @hora TIME,
    @UsuarioID INT,
    @estado VARCHAR(50)

    
)
AS
BEGIN
  IF @Accion = 'C'
    IF @Accion = 'C'
   IF NOT EXISTS (SELECT 1 FROM Cliente WHERE idCliente = @idCliente)
    BEGIN
        -- Insertar el nuevo cliente
        INSERT INTO Cliente (idCliente, apellidos, nombre, domicilioCompleto, rfc, correoElectronico, telefonoCasa, telefonoCelular, referenciaHotel, fechaNacimiento, estadoCivil, fecha, hora, UsuarioID, estado)
        VALUES (@idCliente, @apellidos, @nombre, @domicilioCompleto, @rfc, @correoElectronico, @telefonoCasa, @telefonoCelular, @referenciaHotel, @fechaNacimiento, @estadoCivil, @fecha, @hora, @UsuarioID, @estado);

        SELECT 'Cliente creado exitosamente.' AS Mensaje;
    END
    ELSE
    BEGIN
        SELECT 'El cliente ya existe.' AS Mensaje;
    END
    END;
    IF @Accion = 'C'
    BEGIN
   
   
    END;
END;
