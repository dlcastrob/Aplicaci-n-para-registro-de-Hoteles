DROP DATABASE MAD
CREATE DATABASE MAD;
USE MAD;

CREATE TABLE Usuario (
  UsuarioID INT IDENTITY(1,1) PRIMARY KEY,
  tipoUs VARCHAR(255),
  CorreoElectronico VARCHAR(255) NOT NULL,
  Contrasena VARCHAR(255),
  NombreCompleto VARCHAR(255),
  NumeroNomina VARCHAR(255),
  FechaNacimiento VARCHAR(255),
  Domicilio VARCHAR(255),
  TelefonoCasa VARCHAR(20),
  TelefonoCelular VARCHAR(20),
  Estado bit 
);

CREATE TABLE Cliente (
    idCliente INT PRIMARY KEY,
    apellidos VARCHAR(100),
    nombre VARCHAR(100),
    domicilioCompleto VARCHAR(200),
    rfc VARCHAR(13),
    correoElectronico VARCHAR(100),
    telefonoCasa VARCHAR(20),
    telefonoCelular VARCHAR(20),
    referenciaHotel VARCHAR(200),
    fechaNacimiento DATE,
    estadoCivil VARCHAR(20),
    fecha DATE,
    hora TIME,
    UsuarioID int,
    estado bit,
	FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID),
);
INSERT INTO Usuario (tipoUs, CorreoElectronico, Contrasena, NombreCompleto, NumeroNomina, FechaNacimiento, Domicilio, TelefonoCasa, TelefonoCelular, Estado)
VALUES
    ('ADMINISTRADOR', 'admin@example.com', 'admin123', 'Administrador','12345', '1990-01-01', 'Calle 123, Ciudad', '555-1234', '555-5678', 1),
    ('EMPLEADO', 'empleado@example.com', 'empleado123', 'Empleado', '12345', '1990-01-01', 'Calle 123, Ciudad', '555-1234', '555-5678', 1);
select * from Usuario

INSERT INTO Cliente (idCliente, apellidos, nombre, domicilioCompleto, rfc, correoElectronico, telefonoCasa, telefonoCelular, referenciaHotel, fechaNacimiento, estadoCivil, fecha, hora, UsuarioID, estado)
VALUES
    (1, 'López', 'Juan', 'Calle 123, Ciudad', 'LOPJ890712', 'juan@example.com', '555-1234', '555-5678', 'Hotel A', '1989-07-12', 'Soltero', GETDATE(), GETDATE(), 1, 1),
    (2, 'Gómez', 'María', 'Avenida XYZ, Ciudad', 'GOMM890301', 'maria@example.com', '555-9876', '555-4321', 'Hotel B', '1989-03-01', 'Casado', GETDATE(), GETDATE(), 2, 1),
    (3, 'Pérez', 'Pedro', 'Calle 456, Ciudad', 'PEPP900520', 'pedro@example.com', '555-2468', '555-1357', 'Hotel C', '1990-05-20', 'Soltero', GETDATE(), GETDATE(), 1, 1),
    (4, 'Rodríguez', 'Ana', 'Avenida ABC, Ciudad', 'RODA871209', 'ana@example.com', '555-3691', '555-1478', 'Hotel D', '1987-12-09', 'Casado', GETDATE(), GETDATE(), 1,1),
    (5, 'Hernández', 'Carlos', 'Calle 789, Ciudad', 'HERC880712', 'carlos@example.com', '555-8524', '555-9631', 'Hotel E', '1988-07-12', 'Soltero', GETDATE(), GETDATE(), 1, 1);

	select * from Cliente

CREATE TABLE Hotel (
  HotelID INT IDENTITY(1,1) PRIMARY KEY,
  NombreHotel VARCHAR(255) ,
  Ciudad VARCHAR(255),
  Estado VARCHAR(255),
  Pais VARCHAR(255),
  Domicilio VARCHAR(255),
  NumeroPisos INT ,
  CantidadHabitaciones INT,

  FechaRegistroHotel DATE,
  FechaInicioOperaciones DATE,
  HoraRegistroHotel TIME,
  EstadoHotel bit,
  UsuarioOperativo int,
  FOREIGN KEY (UsuarioOperativo) REFERENCES Usuario(UsuarioID)
);
ALTER TABLE hotel DROP CONSTRAINT UsuarioOperativo;


drop table hotel
-- Registra los hoteles
INSERT INTO Hotel (NombreHotel, Ciudad, Estado, Pais, Domicilio, NumeroPisos, CantidadHabitaciones, FechaRegistroHotel, FechaInicioOperaciones, HoraRegistroHotel, EstadoHotel,UsuarioOperativo)
VALUES
    ('Hotel A', 'Ciudad A', 'Estado A', 'Pais A', 'Domicilio A', 5, 100,  '2023-06-01', '2023-06-10', '12:00:00', 1, 1),
    ('Hotel B', 'Ciudad A', 'Estado A', 'Pais A', 'Domicilio B', 7, 150,  '2023-06-02', '2023-06-11', '14:00:00', 1, 1),
    ('Hotel C', 'Ciudad B', 'Estado B', 'Pais B', 'Domicilio C', 4, 80,  '2023-06-03', '2023-06-12', '11:00:00', 1, 1),
    ('Hotel D', 'Ciudad B', 'Estado B', 'Pais B', 'Domicilio D', 6, 120,  '2023-06-04', '2023-06-13', '13:30:00', 1, 1),
    ('Hotel E', 'Ciudad C', 'Estado C', 'Pais C', 'Domicilio E', 3, 60,  '2023-06-05', '2023-06-14', '10:00:00', 1, 1),
    ('Hotel F', 'Ciudad C', 'Estado C', 'Pais C', 'Domicilio F', 5, 100,  '2023-06-06', '2023-06-15', '12:30:00', 1, 1);


CREATE TABLE ServiciosAdicionales (
  ServicioID INT IDENTITY(1,1) PRIMARY KEY,
  HotelID int,
  NombreServicio VARCHAR(255),
  PrecioServicio DECIMAL(10, 2),
    FOREIGN KEY (HotelID) REFERENCES Hotel(HotelID)

);

-- Registra los servicios adicionales para cada hote
select * from hotel
INSERT INTO ServiciosAdicionales (HotelID, NombreServicio, PrecioServicio)
VALUES
    -- Servicios para Hotel A
    (7, 'Servicio A1', 50.00),
    (7, 'Servicio A2', 30.00),
    (7, 'Servicio A3', 20.00),

    -- Servicios para Hotel B
    (8, 'Servicio B1', 40.00),
    (8, 'Servicio B2', 25.00),
    (8, 'Servicio B3', 15.00),

    -- Servicios para Hotel C
    (3, 'Servicio C1', 60.00),
    (3, 'Servicio C2', 35.00),
    (3, 'Servicio C3', 18.00),

    -- Servicios para Hotel D
    (4, 'Servicio D1', 45.00),
    (4, 'Servicio D2', 28.00),
    (4, 'Servicio D3', 17.50),

    -- Servicios para Hotel E
    (5, 'Servicio E1', 55.00),
    (5, 'Servicio E2', 32.00),
    (5, 'Servicio E3', 22.50),

    -- Servicios para Hotel F
    (6, 'Servicio F1', 48.00),
    (6, 'Servicio F2', 26.00),
    (6, 'Servicio F3', 19.00);

	select * from ServiciosAdicionales

truncate table hotel;


CREATE TABLE TiposHabitacion ( 
  TipoHabitacionID VARCHAR(255) PRIMARY KEY,
  HotelID int,
  PrecioNochePersona DECIMAL(10, 2),
  CapacidadMaxima INT,
  NumeroCamas INT,
  TiposCama VARCHAR(255),
  NivelHabitacion INT,
  UsuarioOperativo INT,
  Fecha DATE,
  Hora TIME,
  EstadoTiposHabitacion bit,
  CantidadHabitaciones INT,
    FOREIGN KEY (HotelID) REFERENCES Hotel(HotelID),

  FOREIGN KEY (UsuarioOperativo) REFERENCES Usuario(UsuarioID)

);
INSERT INTO TiposHabitacion (TipoHabitacionID, HotelID, PrecioNochePersona, CapacidadMaxima, NumeroCamas, TiposCama, NivelHabitacion, UsuarioOperativo, Fecha, Hora, EstadoTiposHabitacion, CantidadHabitaciones)
VALUES
    ('Tipo1_Hotel4', 4, 150.00, 2, 1, 'Cama King', 1, 1, '2023-06-08', '09:00:00', 1, 10),
    ('Tipo2_Hotel5', 5, 200.00, 4, 2, 'Camas Dobles', 2, 1, '2023-06-08', '10:00:00', 1, 20),
    ('Tipo3_Hotel6', 6, 180.00, 3, 1, 'Cama Queen', 1, 1, '2023-06-08', '11:00:00', 1, 15),
    ('Tipo4_Hotel7', 7, 220.00, 2, 1, 'Cama King', 1, 1, '2023-06-08', '12:00:00', 1, 12),
    ('Tipo5_Hotel8', 8, 190.00, 4, 2, 'Camas Dobles', 2, 1, '2023-06-08', '13:00:00', 1, 18);
		
		
		select * from TiposHabitacion



CREATE TABLE Habitacion (
  NumeroHabitacion INT IDENTITY(1,1) PRIMARY KEY,
  TipoHabitacionID VARCHAR(255),
  Estado bit,
  HotelID INT,
  FOREIGN KEY (TipoHabitacionID) REFERENCES TiposHabitacion(TipoHabitacionID),
  FOREIGN KEY (HotelID) REFERENCES Hotel(HotelID)
);

CREATE TABLE Reservacion (
  ReservacionID VARCHAR(255) PRIMARY KEY,
  ServicioID INT,
  ClienteID INT,
  HotelID INT,
  HabitacionID INT,
  FechaEntrada DATE,
  FechaSalida DATE,
  Anticipo DECIMAL(10, 2),
  UsuarioOperativo INT,
  Fecha DATE,
  Hora TIME,
  CantidadHabitaciones INT,
  CantidadPersonasHabitacion INT,
  Estado VARCHAR(255),
  FechaReservacion DATE,
  HoraReservacion TIME,
  DuracionExtendida DATE NULL,
  CheckIn BIT,
  CheckOut BIT, 
    FOREIGN KEY (ServicioID) REFERENCES ServiciosAdicionales(ServicioID),
  FOREIGN KEY (ClienteID) REFERENCES cliente(idCliente),
  FOREIGN KEY (HotelID) REFERENCES Hotel(HotelID),
  FOREIGN KEY (HabitacionID) REFERENCES Habitacion(NumeroHabitacion),
  FOREIGN KEY (UsuarioOperativo) REFERENCES Usuario(UsuarioID)
);

-- Reservación 1
INSERT INTO Reservacion (ReservacionID, ServicioID, ClienteID, HotelID, HabitacionID, FechaEntrada, FechaSalida, Anticipo, UsuarioOperativo, Fecha, Hora, CantidadHabitaciones, CantidadPersonasHabitacion, Estado, FechaReservacion, HoraReservacion, CheckIn, CheckOut)
VALUES ('RES001', 1, 1, 1, 1, '2023-06-10', '2023-06-15', 100.00, 1, GETDATE(), GETDATE(), 1, 2, 'Activa', GETDATE(), GETDATE(), 0, 0);

-- Reservación 2
INSERT INTO Reservacion (ReservacionID, ServicioID, ClienteID, HotelID, HabitacionID, FechaEntrada, FechaSalida, Anticipo, UsuarioOperativo, Fecha, Hora, CantidadHabitaciones, CantidadPersonasHabitacion, Estado, FechaReservacion, HoraReservacion, CheckIn, CheckOut)
VALUES ('RES002', 4, 2, 2, 2, '2023-06-12', '2023-06-14', 150.00, 1, GETDATE(), GETDATE(), 1, 2, 'Activa', GETDATE(), GETDATE(), 0, 0);

-- Reservación 3
INSERT INTO Reservacion (ReservacionID, ServicioID, ClienteID, HotelID, HabitacionID, FechaEntrada, FechaSalida, Anticipo, UsuarioOperativo, Fecha, Hora, CantidadHabitaciones, CantidadPersonasHabitacion, Estado, FechaReservacion, HoraReservacion, CheckIn, CheckOut)
VALUES ('RES003', 9, 3, 3, 3, '2023-06-14', '2023-06-16', 120.00, 1, GETDATE(), GETDATE(), 1, 1, 'Activa', GETDATE(), GETDATE(), 0, 0);


CREATE TABLE Cancelaciones (
  CancelacionID INT IDENTITY(1,1) PRIMARY KEY,
  ReservacionID VARCHAR(255),
  FechaCancelacion DATE,
  HoraCancelacion TIME,
  UsuarioOperativo INT,
  FOREIGN KEY (ReservacionID) REFERENCES Reservacion(ReservacionID),
  FOREIGN KEY (UsuarioOperativo) REFERENCES Usuario(UsuarioID)
);

CREATE TABLE Pago (
  idPago INT PRIMARY KEY,
  ReservacionID VARCHAR(255),
  idCliente INT,
  tipoPago VARCHAR(255),
  Concepto VARCHAR(255),
  monto DECIMAL(10, 2),
  fecha DATE,
  FOREIGN KEY (ReservacionID) REFERENCES Reservacion(ReservacionID),
  FOREIGN KEY (idCliente) REFERENCES Cliente(idCliente)

);
