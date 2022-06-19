USE HOSTEL;
GO


CREATE TABLE ROL (
    RolId  int not null IDENTITY(1,1) PRIMARY KEY,
    NombreRol varchar(255) 
);
go

CREATE TABLE Users (
    UserId  int not null IDENTITY(1,1) PRIMARY KEY,
    UserName varchar(255),
    Password varchar(255),
	PasswordConfirm varchar(255),
	Email varchar(255),
	RolId int not null,
	FOREIGN KEY(RolId) REFERENCES Rol(RolId)
);
 
CREATE TABLE Modulo (
    ModuloId  int not null IDENTITY(1,1) PRIMARY KEY,
    ModuloNombre varchar(255) 
);