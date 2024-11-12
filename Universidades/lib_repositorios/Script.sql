CREATE DATABASE db_universidades;
GO
USE db_universidades
GO

CREATE TABLE Universidades (
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Codigo] NVARCHAR(50) NOT NULL,
	[Nombre] NVARCHAR(150) NOT NULL,
	[Direccion] NVARCHAR(100) NOT NULL,
	[Telefono] NVARCHAR(10) NOT NULL,
	[Fecha] SMALLDATETIME NOT NULL,
	[Cant_carreres] INT NOT NULL,
	[Activa] BIT NOT NULL,
	[Descripcion] NVARCHAR(180) NOT NULL,
);