DECLARE @FechaInicio DATE = '2024-10-01';  -- Reemplaza con tu valor o pon NULL si no se usa
DECLARE @FechaFinal DATE = '2024-11-01';   -- Reemplaza con tu valor o pon NULL si no se usa
DECLARE @Criticidad INT = NULL;            -- Reemplaza con tu valor o pon NULL si no se usa
DECLARE @Modulo VARCHAR(50) = NULL;        -- Reemplaza con tu valor o pon NULL si no se usa
DECLARE @Usuario INT = NULL;       -- Reemplaza con tu valor o pon NULL si no se usa
DECLARE @Operacion VARCHAR(50) = NULL;     -- Reemplaza con tu valor o pon NULL si no se usa

SELECT * 
FROM [dbo].[Bitacora]
WHERE
    (Fecha >= @FechaInicio OR @FechaInicio IS NULL)
    AND (Fecha <= @FechaFinal OR @FechaFinal IS NULL)
    AND (Criticidad = @Criticidad OR @Criticidad IS NULL)
    AND (Modulo = @Modulo OR @Modulo IS NULL)
    AND (UsuarioID = @Usuario OR @Usuario IS NULL)
    AND (Operacion = @Operacion OR @Operacion IS NULL);
