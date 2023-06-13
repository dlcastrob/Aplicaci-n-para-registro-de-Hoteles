USE MAD;
GO

IF OBJECT_ID('spGestionarUsuario') IS NOT NULL
BEGIN
    DROP PROCEDURE spGestionarUsuario;
END;
GO

CREATE PROCEDURE spGestionarUsuario
(
    @Accion CHAR(1),
    @UsuarioID INT = NULL,
    @CorreoElectronico VARCHAR(255) = NULL,
    @Contrasena VARCHAR(255) = NULL,
    @NombreCompleto VARCHAR(255) = NULL,
    @NumeroNomina VARCHAR(255) = NULL,
    @FechaNacimiento VARCHAR(255) = NULL,
    @Domicilio VARCHAR(255) = NULL,
    @TelefonoCasa VARCHAR(20) = NULL,
    @TelefonoCelular VARCHAR(20) = NULL,
    @Estado BIT = NULL
)
AS
BEGIN
    IF @Accion = 'C'
    BEGIN
       IF NOT EXISTS (SELECT 1 FROM Usuario WHERE CorreoElectronico = @CorreoElectronico)
    BEGIN
        -- Insertar el nuevo usuario
        INSERT INTO Usuario (CorreoElectronico, Contrasena, NombreCompleto, NumeroNomina, FechaNacimiento, Domicilio, TelefonoCasa, TelefonoCelular, Estado)
        VALUES (@CorreoElectronico, @Contrasena, @NombreCompleto, @NumeroNomina, @FechaNacimiento, @Domicilio, @TelefonoCasa, @TelefonoCelular, 1);

        SELECT 'Usuario creado exitosamente.' AS Mensaje;
    END
    ELSE
    BEGIN
        SELECT 'El usuario ya existe.' AS Mensaje;
    END
    END;


    IF @Accion = 'U'
    BEGIN
        -- Actualizar usuario
        IF EXISTS (SELECT 1 FROM Usuario WHERE NombreUsuario = @NombreUsuario AND CorreoElectronico = @CorreoElectronico)
    BEGIN
        -- Obtener el nombre del usuario
        DECLARE @NombreCompleto VARCHAR(255);

        SELECT @NombreCompleto = NombreCompleto
        FROM Usuario
        WHERE NombreUsuario = @NombreUsuario AND CorreoElectronico = @CorreoElectronico;

        SELECT @NombreCompleto AS NombreUsuario;
    END
    ELSE
    BEGIN
        SELECT 'Usuario no encontrado' AS Mensaje;
    END
    END;

   
END;
GO
