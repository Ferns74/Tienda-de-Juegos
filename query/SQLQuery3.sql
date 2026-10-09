CREATE DATABASE Productos

USE Productos

CREATE TABLE Consolas (
    ID INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Fabricante VARCHAR(100),
    Lanzamiento VARCHAR(100), 
	Precio int 
)

INSERT INTO Consolas VALUES ('01','PlayStation 5', 'Sony', '2020-11-12', '500')
INSERT INTO Consolas VALUES ('02','Xbox Series X', 'Microsoft', '2020-11-10', '500')
INSERT INTO Consolas VALUES('03','Nintendo Switch', 'Nintendo', '2017-03-03', '320')