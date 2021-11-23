- --------------------------
# LDD Database examenfinal
-- --------------------------
-- DROP DATABASE examenfinal;
CREATE DATABASE examenfinal;
USE examenfinal;

-- ------------------------------------------------------------------------------------------------------------
-- 	TABLAS GENERALES
-- ------------------------------------------------------------------------------------------------------------
create table empresa(
	idEmpresa varchar(15) primary key not null,
	nit varchar(13) not null,
    nombre varchar(35) not null,
    direccion text not null,
    telefono int(10) not null,
    estatus char(1) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table sucursal(
	idSucursal varchar(15) primary key not null,
	idEmpresa varchar(15) not null,
    nombre varchar(35) not null,
    direccion text not null,
    telefono int(10) not null,
    codigoPostal int not null,
    estatus char(1) not null,
    
    foreign key (idEmpresa) references empresa (idEmpresa)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE puesto (
  pkIdPuesto VARCHAR(11) PRIMARY KEY,
  nombre VARCHAR(45) NULL DEFAULT NULL,
  añosDeExperiencia INT NULL DEFAULT NULL,
  fkIdPuestoSuperior VARCHAR(11) NOT NULL,
  estatus char(1) not null
 -- FOREIGN KEY (fkIdPuestoSuperior) REFERENCES puesto (pkIdPuesto))
)ENGINE=InnoDB DEFAULT CHARSET=latin1;
 

-- ------------------------------------------------------------------------------------------------------------
-- 	COMPONENTE SEGURIDAD
-- ------------------------------------------------------------------------------------------------------------
CREATE TABLE empleado (
	pkIdEmpleado VARCHAR(15) PRIMARY KEY,
	nombre VARCHAR(45) NULL DEFAULT NULL,
	apellido VARCHAR(45) NULL DEFAULT NULL,
	fechaDeNacimiento VARCHAR(45) NULL DEFAULT NULL,
	sueldo FLOAT NULL DEFAULT NULL,
	correo VARCHAR(45) NULL DEFAULT NULL,
	direccion VARCHAR(45) NULL DEFAULT NULL,
	contratado VARCHAR(45) NULL DEFAULT NULL,
	añosDeExperiencia INT NULL DEFAULT NULL,
	telefono VARCHAR(10) NULL DEFAULT NULL,
    fechaContratacion DATE NULL,
	finDeContrato DATE NULL,
	fkIdPuesto VARCHAR(15) NOT NULL,
	fkIdEmpresa VARCHAR(15) NOT NULL,
    estatus char(1) not null,
  
	FOREIGN KEY (fkIdPuesto) REFERENCES puesto (pkIdPuesto),
	FOREIGN KEY (fkIdEmpresa) REFERENCES empresa (IdEmpresa)
  )ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE usuario(
	pkId VARCHAR(15) PRIMARY KEY,
	fkIdEmpleado varchar(15) NOT NULL, 
	nombre VARCHAR(30) NOT NULL,
	contraseña VARCHAR(100) NOT NULL,
	estado VARCHAR(1) NOT NULL,
	intento INT NULL,

	FOREIGN KEY (fkIdEmpleado) REFERENCES empleado(pkIdEmpleado)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE modulo(
	pkId VARCHAR(15) PRIMARY KEY,
	nombre VARCHAR(30) NOT NULL,
	descripcion VARCHAR(200) NOT NULL,
	estado VARCHAR(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
	
CREATE TABLE aplicacion(
	pkId VARCHAR(15) PRIMARY KEY,
	fkIdModulo VARCHAR(15) NOT NULL,
	nombre VARCHAR(45) NULL,
	estado INT NOT NULL,
	rutaChm varchar(180) not null,
	rutaHtml varchar(180) not null,
	FOREIGN KEY (fkIdModulo) REFERENCES modulo(pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE bitacoraUsuario(
	pkId INT AUTO_INCREMENT PRIMARY KEY,
	fkIdUsuario VARCHAR(15) NOT NULL,
	`host` VARCHAR(45) NULL DEFAULT NULL,
	ip VARCHAR(20) NULL,
	fkIdModulo VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,
	accion VARCHAR(200) NOT NULL,
	conexionFecha DATE NULL,
	conexionHora TIME NULL,
  
	FOREIGN KEY (fkIdUsuario) REFERENCES usuario (pkId),
	FOREIGN KEY (fkIdModulo) REFERENCES modulo (pkId),
	FOREIGN KEY (fkIdAplicacion) REFERENCES aplicacion(pkID)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE perfil(
	pkId VARCHAR(15) PRIMARY KEY,
	nombre VARCHAR(45) NULL,
	estado VARCHAR(45) NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE usuarioPerfil(
	fkIdUsuario VARCHAR(15) NOT NULL,
	fkIdPerfil VARCHAR(15) NOT NULL,

	FOREIGN KEY (fkIdPerfil) REFERENCES Perfil (pkId),
	FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE usuarioAplicacion(
	fkIdUsuario VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,
	permisoEscritura int,
	permisoLectura int,
	permisoModificar int,
	permisoEliminar int,
	permisoImprimir int,

	FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
	FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
   
CREATE TABLE aplicacionPerfil (
	fkIdPerfil VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,
	permisoEscritura int,
	permisoLectura int,
	permisoModificar int,
	permisoEliminar int,
	permisoImprimir int,

	FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
	FOREIGN KEY (fkIdPerfil) REFERENCES Perfil (pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Vista #1
CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `examenfinal`.`vwpermisosperfil` AS
    SELECT 
        `a`.`permisoEscritura` AS `permisoEscritura`,
        `a`.`permisoLectura` AS `permisoLectura`,
        `a`.`permisoModificar` AS `permisoModificar`,
        `a`.`permisoEliminar` AS `permisoEliminar`,
        `a`.`permisoImprimir` AS `permisoImprimir`,
        `b`.`pkId` AS `pkIdPerfil`,
        `b`.`nombre` AS `Perfil`,
        `c`.`pkId` AS `pkIdAplicacion`,
        `c`.`nombre` AS `Aplicacion`
    FROM
        ((`examenfinal`.`aplicacionperfil` `a`
        JOIN `examenfinal`.`perfil` `b` ON ((`b`.`pkId` = `a`.`fkIdPerfil`)))
        JOIN `examenfinal`.`aplicacion` `c` ON ((`c`.`pkId` = `a`.`fkIdAplicacion`)))
    ORDER BY `a`.`fkIdPerfil`;

-- Vista #2
CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `examenfinal`.`vwpermisosusuario` AS
    SELECT 
        `a`.`permisoEscritura` AS `permisoEscritura`,
        `a`.`permisoLectura` AS `permisoLectura`,
        `a`.`permisoModificar` AS `permisoModificar`,
        `a`.`permisoEliminar` AS `permisoEliminar`,
        `a`.`permisoImprimir` AS `permisoImprimir`,
        `b`.`pkId` AS `pkIdUsuario`,
        `b`.`nombre` AS `Usuario`,
        `c`.`pkId` AS `pkIdAplicacion`,
        `c`.`nombre` AS `Aplicacion`
    FROM
        ((`examenfinal`.`usuarioaplicacion` `a`
        JOIN `examenfinal`.`usuario` `b` ON ((`b`.`pkId` = `a`.`fkIdUsuario`)))
        JOIN `examenfinal`.`aplicacion` `c` ON ((`c`.`pkId` = `a`.`fkIdAplicacion`)))
    ORDER BY `a`.`fkIdUsuario`;
    

CREATE TABLE usuarioAplicacionAsignados(
	fkIdUsuario VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,

	FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
	FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ------------------------------------------------------------------------------------------------------------
-- REPORTEADOR
-- ------------------------------------------------------------------------------------------------------------
create table reporte (
	idReporte varchar(15) NOT NULL primary key,
	nombre varchar(20) NOT NULL,
	ruta varchar(100) NOT NULL,
    idAplicacion VARCHAR(15) not null,
	estado varchar(1) NOT NULL,
    foreign key (idAplicacion) references aplicacion(pkId)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

-- ------------------------------------------------------------------------------------------------------------
-- CONSULTAS INTELIGENTES
-- ------------------------------------------------------------------------------------------------------------
CREATE TABLE registro_consultas (
   id_registro int primary key auto_increment NOT NULL,
   nombre varchar(200) DEFAULT NULL,
   consulta varchar(500) DEFAULT NULL,
   Estatus varchar(1)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- ------------------------------------------------------------------------------------------------------------
-- 	TABLAS GENERALES
-- ------------------------------------------------------------------------------------------------------------
create table tipoCliente(                      /*Huésped, Invitado(consumidor)*/
	idTipo varchar(15) primary key not null,
    nombre varchar(35) not null,
    estatus char(1) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


create table cliente(
	Pkid varchar(15) primary key,
	nombre varchar(30) not null,
	idTipo varchar(15) not null,
	apellido varchar(30) not null,
	nit varchar(15) not null,
	telefono varchar(15) not null,
	direccion varchar(50) not null,
	correo varchar(50) not null,
	estatus varchar(1),

foreign key (idTipo) references tipoCliente(idTipo)
)engine=InnoDB DEFAULT CHARSET=latin1;


create table tipoInventario(
	Pkid varchar(15) primary key,
	nombre varchar(30) not null,
	estatus varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

-- el impuesto y su %, lo calcula cada módulo según los que le apliquen


create table tipoBodega(
	pkid varchar(15) primary key,
	nombre varchar(30) not null,
	estatus varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

create table bodega(
	pkid varchar(15) primary key,
	fkidTipobodega varchar(15) not null,
	nombre varchar(30) not null,
	direccion varchar(65) not null,
	estatus varchar(1) not null,
	
    foreign key (fkidTipobodega) references Tipobodega(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table proveedor(
	idProveedor varchar(15),
	nombre varchar(100) not NULL,
	direccion varchar(500) not NULL,
	telefono int not NULL,
	email varchar(200) not NULL,
	idEmpresa varchar(15),
	stsproveedor varchar(1),
    Estatus varchar(1),
	primary key (idProveedor),
    
	foreign key (idEmpresa) references empresa (idEmpresa)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE marca (
	idMarca varchar(15),
	nombre varchar(100) not NULL,
	descripcion varchar(500) not NULL,
    Estatus varchar(1),
	primary key (idMarca)
 )ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE linea (
	idLinea varchar(15),
	nombre varchar(100) not NULL,
	descripcion varchar(500) not NULL,
	idMarca varchar(15) not null,
    Estatus varchar(1),
	primary key (idLinea),
	foreign key (idMarca) references marca (idMarca)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table Inventario(
	Pkid varchar(15) primary key,
    nombre varchar(100) not NULL,
	fkidsucursal varchar(15) not null,
	Fktipoinventario varchar(15) not null,
	fkidbodega varchar(15) NOT NULL,
	Estatus varchar(1),
	foreign key (Fktipoinventario) references TipoInventario (Pkid),
	foreign key (Fkidsucursal) references sucursal (idsucursal),
	foreign key (Fkidbodega) references bodega (pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table producto (
	pkid varchar(15) primary key,
	fkinventario varchar(15) not null,
	Nombre varchar(30) not null,
	Fkidlinea varchar(15) not null,
	Stock int not null,
    StockMaximo int not null,
    StockMinimo int not null,
	Costo float not null,
	Precio float not null,
	Estatus varchar(1),

	foreign key (Fkidlinea) references linea (idLinea),
	foreign key (fkinventario) references inventario (Pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

-- ------------------------------------------------------------------------------------------------------------
-- 							MÓDULO VENTAS Y CUENTAS POR COBRAR
-- ------------------------------------------------------------------------------------------------------------
create table clienteEmpresa(
	fkidcliente varchar(15) not null,
	fkidempresa varchar(15) not null,

	foreign key (fkidcliente) references cliente(pkid),
	foreign key (fkidempresa) references empresa(idempresa)
)engine=InnoDB DEFAULT CHARSET=latin1;


create table TrasladoProductoEncabezado(
	pkid varchar(15) primary key,
	fkidSucursal varchar(15),
	fkidBodega varchar(15) not null,
	fechapedido datetime not null,
	fechamaxentrega datetime not null,
	estatus varchar(1) not null,
	foreign key (fkidBodega) references Bodega(pkid),
	foreign key (fkidSucursal) references Sucursal(idSucursal)
)engine=InnoDB DEFAULT CHARSET=latin1;


create table TrasladoProductoDetalle(
	pkid varchar(15) primary key,
	fkidpedido varchar(15) not null,
	cantidad int not null,
	fkidproducto varchar(15) not null,
	foreign key (fkidpedido) references TrasladoProductoEncabezado(pkid),
	foreign key (fkidproducto) references Producto(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

-- Insert con relacion al empleado
insert into puesto values("1","Gerente", "10", "1","1");
insert into empresa values("1", "65464-k","hotel san carlos","zona 6 de mixco", "65467654","1" );
insert into empleado values("1","María","Hernandez","1999-09-25","4000.00","cmaria@gmail.com", "zona 11","4", "5", "789654123", "2016-10-25", "2021-12-25","1","1","1");

#usuario: admin
#contraseña: 12345
INSERT INTO usuario(pkId,fkIdEmpleado, nombre, contraseña,estado,intento) VALUES ("1", "1", "admin","LKAekHU9EtweB49HAaTRfg==","1","0");

-- Inserts con relacion a seguridad
insert into perfil values("1","Administrador","1");
insert into perfil values("2","Vendedor","1");

INSERT INTO modulo VALUES ('1','Seguridad','Módulo de Seguridad',1);

INSERT INTO aplicacion VALUES ("0001","1","Login Seguridad HSC",1,0001,0);
INSERT INTO aplicacion VALUES ("0002","1","Registrar Usuario",1,0002,0);
INSERT INTO aplicacion VALUES ("0003","1","Mantenimiento Aplicación",1,0003,0);
INSERT INTO aplicacion VALUES ("0004","1","Mantenimiento Perfil",1,0004,0);
INSERT INTO aplicacion VALUES ("0005","1","Asignación de Aplicación a Perfiles",1,0005,0);
INSERT INTO aplicacion VALUES ("0006","1","Asignación de Aplicación a Usuarios",1,0006,0);
INSERT INTO aplicacion VALUES ("0007","1","Asignación de Perfiles a Usuarios",1,0007,0);
INSERT INTO aplicacion VALUES ("0008","1","Asignación Permisos",1,0008,0);
INSERT INTO aplicacion VALUES ("0009","1","Recuperar Contraseña",1,0009,0);
INSERT INTO aplicacion VALUES ("0010","1","Cambiar Contraseña",1,0010,0);
INSERT INTO aplicacion VALUES ("0011","1","Consulta Bitácora",1,0011,0);
INSERT INTO aplicacion VALUES ("0012","1","Mantenimiento Módulo",1,0012,0);

/*Alter con ajuste de tamaño para el campo de ip en bitácora*/ 
ALTER TABLE bitacorausuario 
CHANGE COLUMN ip ip VARCHAR(100) NULL DEFAULT NULL ;
insert into modulo values("3001","Ventas","Modulo dedicado al área de Ventas","A");

