--CREANDO LA BASE DE DATOS
CREATE DATABASE bd_aranda

GO

USE bd_aranda

GO

--CREACION DE TABLAS


--INSERTAMOS REGISTROS MANUALES DE PRUEBA EN LAS DOS TABLAS
INSERT INTO dbo.categorias
(
    cat_nombre,
    cat_descripcion
)
VALUES
(   'Pantalones', -- cat_nombre - varchar(50)
    'lorem ipsum dolor sit amet lorem ipsum dolor sit amet' -- cat_descripcion - nvarchar(250)
    )

GO
INSERT INTO dbo.productos
(
    pro_nombre,
    pro_descripcion,
    pro_cat_id,
    pro_imagen
)
VALUES
(   'Pantalon de temporada',  -- pro_nombre - varchar(50)
    'lorem ipsum dolor sit amet lorem ipsum dolor sit amet', -- pro_descripcion - nvarchar(250)
    1,   -- pro_cat_id - int
    ''   -- pro_imagen - varchar(250)
    )

SELECT * FROM dbo.categorias,dbo.productos