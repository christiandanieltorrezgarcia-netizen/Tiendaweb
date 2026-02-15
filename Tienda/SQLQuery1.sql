CREATE DATABASE ProductosDB;
GO

USE ProductosDB;
GO

CREATE TABLE Productos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Marca NVARCHAR(100) NOT NULL,
    Precio DECIMAL(18,2) NOT NULL,
    Stock INT NOT NULL,
    Descripcion NVARCHAR(500) NULL
);
GO
