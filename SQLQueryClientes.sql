
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'BETA')
    CREATE DATABASE BETA;
GO
USE BETA;
GO
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'users')
    CREATE TABLE Users
    (
        UserID INT IDENTITY(1, 1) PRIMARY KEY,
        LoginName NVARCHAR(100)
            UNIQUE NOT NULL,
        Password NVARCHAR(100) NOT NULL,
        FirstName NVARCHAR(100) NOT NULL,
        LastName NVARCHAR(100) NOT NULL,
        Position NVARCHAR(100) NULL,
        Email NVARCHAR(150) NOT NULL,
        DateoOfBirth DATE NULL,
        GENDER VARCHAR(1) NULL,
    );
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Clientes')
    CREATE TABLE Clientes
    (
        ID INT IDENTITY(1, 1) PRIMARY KEY,
        Nombre VARCHAR(100),
        Apellido VARCHAR(100),
        Direccion VARCHAR(100),
        Telefono FLOAT,
        Localidad VARCHAR(100),
    );
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Productos')
    CREATE TABLE Productos
    (
        Id INT IDENTITY(1, 1) PRIMARY KEY,
        Producto NVARCHAR(100),
        Descripcion NVARCHAR(100),
        Marca NVARCHAR(100),
        Costo FLOAT,
        Precio FLOAT,
        Stock INT
    );
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ventas')
    CREATE TABLE [dbo].[ventas]
    (
        [ID] [INT] IDENTITY(1, 1) NOT NULL,
        [IDCliente] [INT] NOT NULL,
        [Fecha] [DATETIME] NULL,
        [Total] [FLOAT] NULL,
        PRIMARY KEY CLUSTERED ([ID] ASC)
        WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
              ALLOW_PAGE_LOCKS = ON
             ) ON [PRIMARY]
    ) ON [PRIMARY];
GO
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ventasitems')
    CREATE TABLE [dbo].[ventasitems]
    (
        [ID] [INT] IDENTITY(1, 1) NOT NULL,
        [IDVenta] [INT] NOT NULL,
        [IDProducto] [INT] NOT NULL,
        [PrecioUnitario] [FLOAT] NULL,
        [Cantidad] [FLOAT] NULL,
        [PrecioTotal] [FLOAT] NULL,
        PRIMARY KEY CLUSTERED ([ID] ASC)
        WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
              ALLOW_PAGE_LOCKS = ON
             ) ON [PRIMARY]
    ) ON [PRIMARY];
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Compras')
    CREATE TABLE [dbo].[Compras]
    (
        [ID] [INT] IDENTITY(1, 1) NOT NULL,
        [IDProveedor] [INT] NOT NULL,
        [Fecha] [DATETIME] NULL,
        [Total] [FLOAT] NULL,
        PRIMARY KEY CLUSTERED ([ID] ASC)
        WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
              ALLOW_PAGE_LOCKS = ON
             ) ON [PRIMARY]
    ) ON [PRIMARY];
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'comprasitems')
    CREATE TABLE [dbo].[comprasitems]
    (
        [ID] [INT] IDENTITY(1, 1) NOT NULL,
        [IDCompra] [INT] NOT NULL,
        [IDProducto] [INT] NOT NULL,
        [PrecioCompra] [FLOAT] NULL,
        [PrecioVenta] [FLOAT] NULL,
        [Cantidad] [FLOAT] NULL,
        [SubTotal] [FLOAT] NULL,
        PRIMARY KEY CLUSTERED ([ID] ASC)
        WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
              ALLOW_PAGE_LOCKS = ON
             ) ON [PRIMARY]
    ) ON [PRIMARY];
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Proveedor')
    CREATE TABLE Proveedor
    (
        Id INT IDENTITY(1, 1) PRIMARY KEY,
        Nombre NVARCHAR(100),
        Razon_Social NVARCHAR(100),
        Direccion NVARCHAR(100),
        Telefono INT,
        Referencia NVARCHAR(100),
        Email NVARCHAR(100)
    );
GO
---PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR
CREATE OR ALTER PROCEDURE MostrarProveedor
AS
BEGIN
    SELECT *
    FROM Proveedor;
END;
GO

CREATE OR ALTER PROCEDURE MostrarClientes
AS
BEGIN
    SELECT *
    FROM Clientes;
END;
GO

CREATE OR ALTER PROCEDURE MostrarProductos
AS
BEGIN
    SELECT *
    FROM Productos;
END;
GO
--------------------------INSERTAR 
CREATE OR ALTER PROCEDURE InsetarProductos
    @nombre NVARCHAR(100),
    @descrip NVARCHAR(100),
    @marca NVARCHAR(100),
    @costo FLOAT,
    @precio FLOAT,
    @stock INT
AS
BEGIN
    INSERT INTO Productos
    VALUES
    (@nombre, @descrip, @marca, @costo, @precio, @stock);
END;
GO

CREATE OR ALTER PROCEDURE InsertaCompra
    @idpro INT,
    @fecha DATE,
    @total FLOAT
AS
BEGIN
    INSERT INTO Compras
    VALUES
    (@idpro, @fecha, @total);
    SELECT SCOPE_IDENTITY();
END;
GO

------------------------ELIMINAR
CREATE OR ALTER PROCEDURE EliminarProducto @idpro INT
AS
BEGIN
    DELETE FROM Productos
    WHERE Id = @idpro;
END;
GO
------------------EDITAR
CREATE OR ALTER PROCEDURE EditarProductos
    @nombre NVARCHAR(100),
    @descrip NVARCHAR(100),
    @marca NVARCHAR(100),
    @costo FLOAT,
    @precio FLOAT,
    @stock INT,
    @id INT
AS
BEGIN
    UPDATE Productos
    SET Producto = @nombre,
        Descripcion = @descrip,
        Marca = @marca,
        Costo = @costo,
        Precio = @precio,
        Stock = @stock
    WHERE Id = @id;
END;
GO

CREATE OR ALTER PROCEDURE RestarStock
    @stock INT,
    @id INT
AS
BEGIN
    UPDATE Productos
    SET Stock = Stock - @stock
    WHERE Id = @id;
END;
GO

----------------VISTAS
CREATE OR ALTER VIEW [dbo].[MostrarDetalleDeVenta]
AS
SELECT IDVenta,
       Producto,
       Marca,
       Descripcion,
       PrecioUnitario,
       Cantidad,
       PrecioTotal
FROM ventasitems
    JOIN Productos
        ON IDProducto = Productos.Id;
GO
-------------TRIGGERS
CREATE OR ALTER TRIGGER [dbo].[UsersPosicion]
ON [dbo].[Users]
AFTER INSERT
AS
UPDATE Users
SET Position = 'Usuario'
WHERE UserID IN
      (
          SELECT UserID FROM inserted WHERE Position = NULL
      );
GO


