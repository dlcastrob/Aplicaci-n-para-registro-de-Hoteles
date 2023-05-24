CREATE PROCEDURE CrearCliente
    @nombreCompleto VARCHAR(100),
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
    @usuarioOperativo VARCHAR(100),
    @estado VARCHAR(50)


AS
BEGIN
    INSERT INTO Cliente (nombreCompleto, domicilioCompleto, rfc, correoElectronico, telefonoCasa, telefonoCelular, referenciaHotel, fechaNacimiento, estadoCivil, fecha, hora, usuarioOperativo, estado)
    VALUES (@nombreCompleto, @domicilioCompleto, @rfc, @correoElectronico, @telefonoCasa, @telefonoCelular, @referenciaHotel, @fechaNacimiento, @estadoCivil, @fecha, @hora, @usuarioOperativo, @estado);
END
CREATE PROCEDURE LeerCliente
    @idCliente INT
AS
BEGIN
    SELECT *
    FROM Cliente
    WHERE idCliente = @idCliente;
END
CREATE PROCEDURE ActualizarCliente
    @idCliente INT,
    @nombreCompleto VARCHAR(100),
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
    @usuarioOperativo VARCHAR(100),
    @estado VARCHAR(50)
AS
BEGIN
    UPDATE Cliente
    SET nombreCompleto = @nombreCompleto,
        domicilioCompleto = @domicilioCompleto,
        rfc = @rfc,
        correoElectronico = @correoElectronico,
        telefonoCasa = @telefonoCasa,
        telefonoCelular = @telefonoCelular,
        referenciaHotel = @referenciaHotel,
        fechaNacimiento = @fechaNacimiento,
        estadoCivil = @estadoCivil,
        fecha = @fecha,
        hora = @hora,
        usuarioOperativo = @usuarioOperativo,
        estado = @estado
    WHERE idCliente = @idCliente;
END
CREATE PROCEDURE ActualizarCliente
    @idCliente INT,
    @nombreCompleto VARCHAR(100),
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
    @usuarioOperativo VARCHAR(100),
    @estado VARCHAR(50)
AS
BEGIN
    UPDATE Cliente
    SET nombreCompleto = @nombreCompleto,
        domicilioCompleto = @domicilioCompleto,
        rfc = @rfc,
        correoElectronico = @correoElectronico,
        telefonoCasa = @telefonoCasa,
        telefonoCelular = @telefonoCelular,
        referenciaHotel = @referenciaHotel,
        fechaNacimiento = @fechaNacimiento,
        estadoCivil = @estadoCivil,
        fecha = @fecha,
        hora = @hora,
        usuarioOperativo = @usuarioOperativo,
        estado = @estado
    WHERE idCliente = @idCliente;
END
CREATE PROCEDURE EliminarCliente
    @idCliente INT
AS
BEGIN
    DELETE FROM Cliente
    WHERE idCliente = @idCliente;
END

