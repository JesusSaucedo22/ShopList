USE Libros;

-- Creamos la tabla Autores
CREATE TABLE Autores (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(64) NOT NULL,
	Apellido VARCHAR(64) NOT NULL
); 

-- Creamos la tabla Titulos
CREATE TABLE Titulos(
	Isbn VARCHAR(20) NOT NULL PRIMARY KEY,
	Titulo VARCHAR(120) NOT NULL,
	NumeroDeEdicion INT,
	AnioDePublicacion CHAR(4)
);

-- Creamos la tabla relacional TituloAutor
create table TituloAutor(
	Isbn VARCHAR (20) NOT NULL,
	IdAutor INT NOT NULL, 
	PRIMARY KEY (Isbn, IdAutor),
	FOREIGN KEY (Isbn) REFERENCES Titulos(Isbn),
	FOREIGN KEY (IdAutor) REFERENCES Autores(id)
);

-- Insertamos datos en tabla Autores
INSERT INTO Autores (Nombre, Apellido)
VALUES ('Roger', 'Pressmann');
INSERT INTO Autores (Nombre, Apellido)
VALUES ('Summerville', 'Ian');
INSERT INTO Autores (Nombre, Apellido)
VALUES ('Robert', 'Martin');
INSERT INTO Autores (Nombre, Apellido)
VALUES ('Harvey', 'Deitel'), ('Paul', 'Deitel'), ('Andrew','Goldberg'); 

--Insesrtamos datos en tabla Titulos
INSERT INTO Titulos (Isbn, Titulo, NumeroDeEdicion, AnioDePublicacion)
VALUES 
('013183452703', 'Ingeneria de Software', '10', '2017'),
('013145771287', 'C# Cpmo Programar', '4', '2014'),
('013145771976', 'Visual Basic como progarmar', '2', '2011'),
('013155761784', 'Ingeneria del software', '11', '2018');


INSERT INTO TituloAutor(Isbn, IdAutor)
VALUES
('013183452703','1'),
('013145771287','4'), ('013145771287','5'),
('013145771976','4'),('013145771976','5'),('013145771976','6'),
('013155761784','2');

--El comando SELECT
SELECT * FROM TituloAutor;
SELECT Id, Nombre, Apellido FROM Autores;
SELECT * FROM Autores WHERE Apellido = 'Deitel';
SELECT * FROM Titulos WHERE NumeroDeEdicion = 11 or AnioDePublicacion = '2014';
SELECT * FROM Titulos WHERE NumeroDeEdicion < 11;
SELECT * FROM TituloAutor INNER JOIN Autores ON TituloAutor.IdAutor = Autores.id
						  INNER JOIN Titulos ON TituloAutor.Isbn = Titulos.Isbn
WHERE Apellido = 'Martin';