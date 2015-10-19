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
		rol_descripcion nvarchar(255)	NOT NULL,
		rol_activo bit NOT NULL DEFAULT 1
	)
GO

/*Funciones*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Funciones' AND xtype='U')
	CREATE TABLE MILANESA.Funciones (
		fun_id int identity(1,1) Primary Key,
		fun_descripcion nvarchar(255)	NOT NULL,
		fun_activo bit NOT NULL DEFAULT 1
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

/*Usuarios*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Usuarios' AND xtype='U')
	CREATE TABLE MILANESA.Usuarios (
		usu_id int identity(1,1) Primary Key,
		usu_nombre nvarchar(255) NOT NULL,
		usu_password nvarchar(4000) NOT NULL,
		rol_id int REFERENCES MILANESA.Roles,	
		usu_intentos_logueo_fallidos int NOT NULL DEFAULT 0,
		usu_activo bit NOT NULL DEFAULT 1
	)
GO

/*Productos*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Productos' AND xtype='U')
	CREATE TABLE MILANESA.Productos (
		pro_id int identity(1,1) Primary Key,
		pro_descripcion nvarchar(255) NOT NULL,
		pro_cantidad_millas numeric(18,0) NOT NULL,
		pro_activo bit NOT NULL DEFAULT 1
	)
GO

/*Canjes*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Canjes' AND xtype='U')
	CREATE TABLE MILANESA.Canjes (
		can_id int identity(1,1) Primary Key,
		producto_id int REFERENCES MILANESA.Productos,
		can_cantidad numeric(18,0) NOT NULL,
		can_fecha datetime
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
		cli_telefono int NOT NULL,
		cli_mail nvarchar(255),
		cli_fecha_nacimiento datetime NOT NULL,
		cli_activo bit NOT NULL DEFAULT 1
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
		dev_motivo nvarchar(255) NOT NULL,
		dev_fecha datetime NOT NULL
	)
GO

/*Ciudades*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Ciudades' AND xtype='U')
	CREATE TABLE MILANESA.Ciudades (
		ciu_id int identity(1,1) Primary Key,
		ciu_descripcion nvarchar(255) NOT NULL,
		ciu_activo bit NOT NULL DEFAULT 1
	)
GO

/*Tipos_Servicio*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Tipos_Servicio' AND xtype='U')
	CREATE TABLE MILANESA.Tipos_Servicio (
		tip_id int identity(1,1) Primary Key,
		tip_descripcion nvarchar(255) NOT NULL,
		tip_activo bit NOT NULL DEFAULT 1
	)
GO

/*Rutas*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Rutas' AND xtype='U')
	CREATE TABLE MILANESA.Rutas (
		rut_id int identity(1,1) Primary Key,
		ciudad_origen_id int REFERENCES MILANESA.Ciudades NOT NULL,
		ciudad_destino_id int REFERENCES MILANESA.Ciudades NOT NULL,
		tipo_servicio_id int REFERENCES MILANESA.Tipos_Servicio NOT NULL,
		rut_codigo numeric(18,0) NOT NULL,
		rut_precio_base_kg numeric(18,2) NOT NULL,
		rut_precio_base_pasaje numeric(18,2) NOT NULL,
		rut_activo bit NOT NULL DEFAULT 1
	)
GO

/*Aeronaves*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Aeronaves' AND xtype='U')
	CREATE TABLE MILANESA.Aeronaves (
		aer_id int identity(1,1) Primary Key,
		tipo_servicio_id int REFERENCES MILANESA.Tipos_Servicio NOT NULL,
		aer_matricula nvarchar(255) NOT NULL,
		aer_modelo nvarchar(255) NOT NULL,
		aer_kg_disponibles numeric(18,0) NOT NULL,
		aer_fabricante nvarchar(255) NOT NULL,
		aer_fecha_fuera_servicio datetime,
		aer_fecha_reinicio_servicio datetime,
		aer_fecha_baja_definitiva datetime,
		aer_activo bit NOT NULL DEFAULT 1
	)
GO

/*Vuelos*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Vuelos' AND xtype='U')
	CREATE TABLE MILANESA.Vuelos (
		vue_id int identity(1,1) Primary Key,
		ruta_id int REFERENCES MILANESA.Rutas NOT NULL,
		aeronave_id int REFERENCES MILANESA.Aeronaves NOT NULL,
		vue_fecha_salida datetime NOT NULL,
		vue_fecha_llegada_estimada datetime NOT NULL,
		vue_fecha_llegada datetime
	)
GO

/*Ventas*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Ventas' AND xtype='U')
	CREATE TABLE MILANESA.Ventas (
		ven_id int identity(1,1) Primary Key,
		comprador_id int REFERENCES MILANESA.Clientes NOT NULL,
		vuelo_id int REFERENCES MILANESA.Vuelos NOT NULL,
		vendedor_id int REFERENCES MILANESA.Usuarios,
		ven_fecha datetime NOT NULL,
	)
GO

/*Butacas*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Butacas' AND xtype='U')
	CREATE TABLE MILANESA.Butacas (
		but_id int identity(1,1) Primary Key,
		aeronave_id int REFERENCES MILANESA.Aeronaves NOT NULL,
		but_numero numeric(18,0) NOT NULL,
		but_tipo nvarchar(255) NOT NULL,
		but_piso numeric(18,0) NOT NULL,
		but_activo bit NOT NULL DEFAULT 1
	)
GO

/*Pasajes*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Pasajes' AND xtype='U')
	CREATE TABLE MILANESA.Pasajes (
		pas_id int identity(1,1) Primary Key,
		pasajero_id int REFERENCES MILANESA.Clientes NOT NULL,
		devolucion_id int REFERENCES MILANESA.Devoluciones,
		venta_id int REFERENCES MILANESA.Ventas NOT NULL,
		butaca_id int REFERENCES MILANESA.Butacas,
		pas_codigo numeric(18,0) NOT NULL,
		pas_precio numeric(18,2) NOT NULL
	)
GO

/*Paquetes*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Paquetes' AND xtype='U')
	CREATE TABLE MILANESA.Paquetes (
		paq_id int identity(1,1) Primary Key,
		devolucion_id int REFERENCES MILANESA.Devoluciones,
		venta_id int REFERENCES MILANESA.Ventas NOT NULL,
		paq_codigo numeric(18,0) NOT NULL,
		paq_precio numeric(18,2) NOT NULL,
		paq_kg numeric(18,0) NOT NULL
	)
GO
	
/*Periodos_Fuera_Servicio*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Periodos_Fuera_Servicio' AND xtype='U')
	CREATE TABLE MILANESA.Periodos_Fuera_Servicio (
		pfs_id int identity(1,1) Primary Key,
		aeronave_id int REFERENCES MILANESA.Aeronaves NOT NULL,
		pfs_motivo nvarchar(255) NOT NULL,
		pfs_fecha_inicio datetime NOT NULL,
		pfs_fecha_fin datetime
	)
GO

/*Arribos*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Arribos' AND xtype='U')
	CREATE TABLE MILANESA.Arribos (
		arr_id int identity(1,1) Primary Key,
		aeronave_id int REFERENCES MILANESA.Aeronaves NOT NULL,
		ciudad_origen_id int REFERENCES MILANESA.Ciudades NOT NULL,
		ciudad_destino_id int REFERENCES MILANESA.Ciudades NOT NULL,
		arr_fecha datetime NOT NULL
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