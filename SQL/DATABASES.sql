CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(255) NOT NULL,
    Apellido NVARCHAR(255) NOT NULL,
    NombreUsuario NVARCHAR(255) NOT NULL,
    Contrasenia NVARCHAR(255) NOT NULL,
    Mail NVARCHAR(255) NOT NULL
);


-- Insertar usuario 1
INSERT INTO Usuarios (Nombre, Apellido, NombreUsuario, Contrasenia, Mail)
VALUES ('John', 'Doe', 'john.doe', 'contrasenia1', 'john.doe@example.com');

-- Insertar usuario 2
INSERT INTO Usuarios (Nombre, Apellido, NombreUsuario, Contrasenia, Mail)
VALUES ('Jane', 'Smith', 'jane.smith', 'contrasenia2', 'jane.smith@example.com');

-- Insertar usuario 3
INSERT INTO Usuarios (Nombre, Apellido, NombreUsuario, Contrasenia, Mail)
VALUES ('Michael', 'Johnson', 'michael.johnson', 'contrasenia3', 'michael.johnson@example.com');

-- Insertar usuario 4
INSERT INTO Usuarios (Nombre, Apellido, NombreUsuario, Contrasenia, Mail)
VALUES ('Emily', 'Williams', 'emily.williams', 'contrasenia4', 'emily.williams@example.com');

-- Insertar usuario 5
INSERT INTO Usuarios (Nombre, Apellido, NombreUsuario, Contrasenia, Mail)
VALUES ('William', 'Brown', 'william.brown', 'contrasenia5', 'william.brown@example.com');

SELECT * FROM Usuarios;




CREATE TABLE Productos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Descripcion NVARCHAR(255) NOT NULL,
    Costo DECIMAL(18, 2) NOT NULL,
    PrecioVenta DECIMAL(18, 2) NOT NULL,
    Stock INT NOT NULL,
    IdUsuario INT NOT NULL
);


INSERT INTO Productos (Descripcion, Costo, PrecioVenta, Stock, IdUsuario)
VALUES
    ('Producto 1', 10.50, 20.00, 100, 1),
    ('Producto 2', 8.75, 18.00, 75, 2),
    ('Producto 3', 15.25, 30.00, 50, 1),
    ('Producto 4', 12.00, 25.50, 90, 3),
    ('Producto 5', 9.99, 22.75, 120, 2);


	SELECT * FROM Productos;



	CREATE TABLE Ventas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Comentarios NVARCHAR(255) NOT NULL,
    IdUsuario INT NOT NULL
);

INSERT INTO Ventas (Comentarios, IdUsuario)
VALUES
    ('Venta 1', 1),
    ('Venta 2', 2),
    ('Venta 3', 1),
    ('Venta 4', 3),
    ('Venta 5', 2);

	SELECT * FROM Ventas;





	CREATE TABLE ProductosVendidos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    IdProducto INT NOT NULL,
    Stock INT NOT NULL,
    IdVenta INT NOT NULL
);

INSERT INTO ProductosVendidos (IdProducto, Stock, IdVenta)
VALUES
    (1, 5, 1),
    (2, 3, 2),
    (3, 2, 3),
    (4, 4, 4),
    (5, 6, 5);


	SELECT * FROM ProductosVendidos;