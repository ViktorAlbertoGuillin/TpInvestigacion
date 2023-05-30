-- Crear la base de datos
CREATE DATABASE TpInvestigacion;
GO

-- Usar la base de datos
USE TpInvestigacion;
GO

-- Crear la tabla Bloque
CREATE TABLE Bloque (
    Id INT PRIMARY KEY,
    Datos VARCHAR(255),
    Hash VARCHAR(255),
    Hash_anterior VARCHAR(255),
    Tiempo DATETIME,
    Integro BIT
);

DROP DATABASE TpInvestigacion
use master