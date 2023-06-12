USE MAD;
GO

IF OBJECT_ID('spBuscarCliente') IS NOT NULL
BEGIN
    DROP PROCEDURE spBuscarCliente;
END;
GO

CREATE PROCEDURE spBuscarCliente
(
    @Busqueda VARCHAR(255),
    @OpcionBusqueda INT
)
AS
BEGIN
    SET @Busqueda = '%' + @Busqueda + '%';

    IF @OpcionBusqueda = 1
    BEGIN
        -- Buscar por apellidos (sin tener en cuenta los acentos)
        SELECT apellidos, nombre, correoElectronico, rfc
        FROM Cliente
        WHERE apellidos COLLATE Latin1_General_CI_AI LIKE @Busqueda COLLATE Latin1_General_CI_AI
        ORDER BY apellidos;
    END;
    ELSE IF @OpcionBusqueda = 2
    BEGIN
        -- Buscar por correo electrónico (sin tener en cuenta los acentos)
        SELECT apellidos, nombre, correoElectronico, rfc
        FROM Cliente
        WHERE correoElectronico COLLATE Latin1_General_CI_AI LIKE @Busqueda COLLATE Latin1_General_CI_AI
        ORDER BY correoElectronico;
    END;
    ELSE IF @OpcionBusqueda = 3
    BEGIN
        -- Buscar por RFC (sin tener en cuenta los acentos)
        SELECT apellidos, nombre, correoElectronico, rfc
        FROM Cliente
        WHERE rfc COLLATE Latin1_General_CI_AI LIKE @Busqueda COLLATE Latin1_General_CI_AI
        ORDER BY rfc;
    END;
    ELSE
    BEGIN
        -- Opción de búsqueda inválida
        SELECT 'Opción de búsqueda inválida' AS Mensaje;
    END;
END;

EXEC spBuscarCliente 'o', 1;
