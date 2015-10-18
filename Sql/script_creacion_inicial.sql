USE [GD2C2015]
GO

IF NOT EXISTS (SELECT 1 FROM information_schema.schemata WHERE schema_name = 'MILANESA') 
BEGIN
	EXEC ('CREATE SCHEMA MILANESA')
END

/*Roles*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Roles' AND xtype='U')
	CREATE TABLE MILANESA.Roles (
		rol_id int identity(1,1) Primary Key,
		rol_descripcion nvarchar(255)	NOT NULL
	)
GO

/*Funciones*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Funciones' AND xtype='U')
	CREATE TABLE MILANESA.Funciones (
		fun_id int identity(1,1) Primary Key,
		fun_descripcion nvarchar(255)	NOT NULL
	)
GO

/*Funciones_Roles*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Funciones_Roles' AND xtype='U')
	CREATE TABLE MILANESA.Funciones_Roles (
		funcion_id int REFERENCES MILANESA.Funciones,
		rol_id int REFERENCES MILANESA.Roles,
		Primary Key (funcion_id, rol_id)
	)
GO

/*Usuario*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Usuarios' AND xtype='U')
	CREATE TABLE MILANESA.Usuarios (
		usu_id int identity(1,1) Primary Key,
		usu_nombre nvarchar(255) NOT NULL,
		usu_password nvarchar(4000) NOT NULL,
		rol_id int REFERENCES MILANESA.Roles,	
		usu_intentos_logueo_fallidos int NOT NULL DEFAULT 0		
	)
GO

/*Canjes*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Canjes' AND xtype='U')
	CREATE TABLE MILANESA.Canjes (
		can_id int identity(1,1) Primary Key,
		can_cantidad numeric(18,0) NOT NULL,
		can_fecha datetime
	)
GO

/*Productos*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Productos' AND xtype='U')
	CREATE TABLE MILANESA.Productos (
		pro_id int identity(1,1) Primary Key,
		canje_id int REFERENCES MILANESA.Canjes,
		pro_descripcion nvarchar(255) NOT NULL,
		pro_cantidad_millas numeric(18,0) NOT NULL
	)
GO

/*Clientes*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Clientes' AND xtype='U')
	CREATE TABLE MILANESA.Clientes (
		cli_id int identity(1,1) Primary Key,
		cli_nombre nvarchar(255) NOT NULL,
		cli_apellido nvarchar(255) NOT NULL,
		cli_dni int NOT NULL,
		cli_direccion nvarchar(255) NOT NULL,
		cli_telefono int,
		cli_mail nvarchar(255) NOT NULL,
		cli_fecha_nacimiento datetime
	)
GO

/*Millas*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Millas' AND xtype='U')
	CREATE TABLE MILANESA.Millas (
		mil_id int identity(1,1) Primary Key,
		cliente_id int REFERENCES MILANESA.Clientes NOT NULL,
		canje_id int REFERENCES MILANESA.Canjes,
		mil_cantidad numeric(18,0) NOT NULL,
	)
GO
	
/*Devoluciones*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Devoluciones' AND xtype='U')
	CREATE TABLE MILANESA.Devoluciones (
		dev_id int identity(1,1) Primary Key,
		dev_motivo nvarchar(255),
		dev_fecha datetime
	)
GO

/*Ciudades*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Ciudades' AND xtype='U')
	CREATE TABLE MILANESA.Ciudades (
		ciu_id int identity(1,1) Primary Key,
		ciu_descripcion nvarchar(255)
	)
GO

/*Tipos_Servicio*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Tipos_Servicio' AND xtype='U')
	CREATE TABLE MILANESA.Tipos_Servicio (
		tip_id int identity(1,1) Primary Key,
		tip_descripcion nvarchar(255)
	)
GO

/*Rutas*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Rutas' AND xtype='U')
	CREATE TABLE MILANESA.Rutas (
		rut_id int identity(1,1) Primary Key,
		ciudad_origen_id int REFERENCES MILANESA.Ciudades,
		ciudad_destino_id int REFERENCES MILANESA.Ciudades,
		tipo_servicio_id int REFERENCES MILANESA.Tipos_Servicio,
		rut_codigo numeric(18,0),
		rut_precio_base_kg numeric(18,2),
		rut_precio_base_pasaje numeric(18,2)
	)
GO

/*Aeronaves*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Aeronaves' AND xtype='U')
	CREATE TABLE MILANESA.Aeronaves (
		aer_id int identity(1,1) Primary Key,
		tipo_servicio_id int REFERENCES MILANESA.Tipos_Servicio,
		aer_matricula nvarchar(255),
		aer_modelo nvarchar(255),
		aer_kg_disponibles numeric(18,0),
		aer_fabricante nvarchar(255),
		aer_fecha_fuera_servicio datetime,
		aer_fecha_reinicio_servicio datetime,
		aer_fecha_baja_definitiva datetime
	)
GO

/*Vuelos*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Vuelos' AND xtype='U')
	CREATE TABLE MILANESA.Vuelos (
		vue_id int identity(1,1) Primary Key,
		ruta_id int REFERENCES MILANESA.Rutas,
		aeronave_id int REFERENCES MILANESA.Aeronaves,
		vue_fecha_salida datetime,
		vue_fecha_llegada_estimada datetime,
		vue_fecha_llegada datetime,
	)
GO

/*Pasajes*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Pasajes' AND xtype='U')
	CREATE TABLE MILANESA.Pasajes (
		pas_id int identity(1,1) Primary Key,
		cliente_id int REFERENCES MILANESA.Clientes NOT NULL,
		devolucion_id int REFERENCES MILANESA.Devoluciones,
		vuelo_id int REFERENCES MILANESA.Vuelos,
		pas_codigo numeric(18,0) NOT NULL,
		pas_precio numeric(18,2),
		pas_fecha_compra datetime
	)
GO

/*Paquetes*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Paquetes' AND xtype='U')
	CREATE TABLE MILANESA.Paquetes (
		paq_id int identity(1,1) Primary Key,
		cliente_id int REFERENCES MILANESA.Clientes NOT NULL,
		devolucion_id int REFERENCES MILANESA.Devoluciones,
		vuelo_id int REFERENCES MILANESA.Vuelos,
		paq_codigo numeric(18,0) NOT NULL,
		paq_precio numeric(18,2),
		paq_kg numeric(18,0),
		paq_fecha_compra datetime,
	)
GO
	
/*Periodos_Fuera_Servicio*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Periodos_Fuera_Servicio' AND xtype='U')
	CREATE TABLE MILANESA.Periodos_Fuera_Servicio (
		pfs_id int identity(1,1) Primary Key,
		aeronave_id int REFERENCES MILANESA.Aeronaves,
		pfs_motivo nvarchar(255),
		pfs_fecha_inicio datetime,
		pfs_fecha_fin datetime
	)
GO

/*Butacas*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Butacas' AND xtype='U')
	CREATE TABLE MILANESA.Butacas (
		but_id int identity(1,1) Primary Key,
		aeronave_id int REFERENCES MILANESA.Aeronaves,
		but_numero numeric(18,0),
		but_tipo nvarchar(255),
		but_piso numeric(18,0)
	)
GO

/*Arribos*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Arribos' AND xtype='U')
	CREATE TABLE MILANESA.Arribos (
		arr_id int identity(1,1) Primary Key,
		aeronave_id int REFERENCES MILANESA.Aeronaves,
		ciudad_origen_id int REFERENCES MILANESA.Ciudades,
		ciudad_destino_id int REFERENCES MILANESA.Ciudades,
		arr_fecha datetime
	)
GO

/*Tipos_Servicio_Rutas*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Tipos_Servicio_Rutas' AND xtype='U')
	CREATE TABLE MILANESA.Tipos_Servicio_Rutas (
		tipo_servicio_id int REFERENCES MILANESA.Tipos_Servicio,
		ciudad_id int REFERENCES MILANESA.Ciudades,
		Primary Key (tipo_servicio_id, ciudad_id)
	)
GO