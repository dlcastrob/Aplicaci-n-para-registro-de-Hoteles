CREATE PROCEDURE SP_CrudUsuario
(
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
    @estado VARCHAR(50) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- CREATE (Crear usuario)
        IF @idUs IS NULL
        BEGIN
            -- Insertar nuevo usuario
            INSERT INTO Usuario (tipoUs, correoElectronico, contrasena, nombreCompleto, numeroNomina, fechaNacimiento, domicilio, telefonoCasa, telefonoCelular, estado)
            VALUES (@tipoUs, @correoElectronico, @contrasena, @nombreCompleto, @numeroNomina, @fechaNacimiento, @domicilio, @telefonoCasa, @telefonoCelular, @estado);
        END
        -- UPDATE (Actualizar usuario)
        ELSE
        BEGIN
            -- Actualizar información del usuario
            UPDATE Usuario
            SET tipoUs = COALESCE(@tipoUs, tipoUs),
                correoElectronico = COALESCE(@correoElectronico, correoElectronico),
                contrasena = COALESCE(@contrasena, contrasena),
                nombreCompleto = COALESCE(@nombreCompleto, nombreCompleto),
                numeroNomina = COALESCE(@numeroNomina, numeroNomina),
                fechaNacimiento = COALESCE(@fechaNacimiento, fechaNacimiento),
                domicilio = COALESCE(@domicilio, domicilio),
                telefonoCasa = COALESCE(@telefonoCasa, telefonoCasa),
                telefonoCelular = COALESCE(@telefonoCelular, telefonoCelular),
                estado = COALESCE(@estado, estado)
            WHERE idUs = @idUs;
        END

        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK;
            -- Puedes agregar aquí el código para capturar y manejar los errores
        END
    END CATCH;
END;

BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;

        -- Capturar el mensaje de error
        DECLARE @ErrorMessage NVARCHAR(MAX) = ERROR_MESSAGE();

        -- Registrar el error en una tabla de registro de errores
        INSERT INTO ErrorLog (Fecha, Mensaje)
        VALUES (GETDATE(), @ErrorMessage);

        -- Notificar al administrador del sistema por correo electrónico
        EXEC sp_send_dbmail
            @profile_name = 'DatabaseMailProfile',
            @recipients = 'admin@example.com',
            @subject = 'Error en el stored procedure SP_CrudUsuario',
            @body = @ErrorMessage;

        -- Enviar una respuesta de error al usuario
        RAISERROR('Se produjo un error en el procedimiento almacenado. Por favor, inténtelo de nuevo más tarde.', 16, 1);
    END
END CATCH;
