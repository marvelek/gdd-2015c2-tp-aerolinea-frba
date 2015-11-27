USE [GD2C2015]
GO


-- INDICES ---------------------------------------------------------


CREATE NONCLUSTERED INDEX [ix_maestra_ruta]
ON [gd_esquema].[Maestra] ([Ruta_Precio_BasePasaje])
INCLUDE ([Ruta_Codigo],[Ruta_Ciudad_Origen],[Ruta_Ciudad_Destino],[Tipo_Servicio])
GO

CREATE NONCLUSTERED INDEX [ix_maestra_venta]
ON [gd_esquema].[Maestra] ([Paquete_Codigo])
INCLUDE ([Cli_Nombre],[Cli_Apellido],[Cli_Dni],[Cli_Fecha_Nac],[Paquete_FechaCompra],[FechaSalida],[Fecha_LLegada_Estimada],[FechaLLegada],[Ruta_Codigo],[Ruta_Ciudad_Origen],[Ruta_Ciudad_Destino],[Aeronave_Matricula],[Tipo_Servicio])
GO

CREATE NONCLUSTERED INDEX [ix_maestra_pasaje_codigo]
ON [gd_esquema].[Maestra] ([Pasaje_Codigo])
INCLUDE ([Cli_Nombre],[Cli_Apellido],[Cli_Dni],[Cli_Fecha_Nac],[Pasaje_Precio],[Pasaje_FechaCompra],[FechaSalida],[Fecha_LLegada_Estimada],[FechaLLegada],[Ruta_Codigo],[Ruta_Ciudad_Origen],[Ruta_Ciudad_Destino],[Aeronave_Matricula],[Tipo_Servicio])
GO

CREATE NONCLUSTERED INDEX [ix_maestra_pasaje_fecha]
ON [gd_esquema].[Maestra] ([FechaSalida],[Fecha_LLegada_Estimada],[FechaLLegada])
INCLUDE ([Cli_Nombre],[Cli_Apellido],[Cli_Dni],[Cli_Fecha_Nac],[Pasaje_Codigo],[Pasaje_Precio],[Pasaje_FechaCompra],[Ruta_Codigo],[Ruta_Ciudad_Origen],[Ruta_Ciudad_Destino],[Aeronave_Matricula],[Tipo_Servicio])
GO

CREATE NONCLUSTERED INDEX [ix_maestra_paquete]
ON [gd_esquema].[Maestra] ([Paquete_Codigo])
INCLUDE ([Cli_Nombre],[Cli_Apellido],[Cli_Dni],[Cli_Fecha_Nac],[Paquete_Precio],[Paquete_KG],[Paquete_FechaCompra],[FechaSalida],[Fecha_LLegada_Estimada],[FechaLLegada],[Ruta_Codigo],[Ruta_Ciudad_Origen],[Ruta_Ciudad_Destino],[Aeronave_Matricula],[Tipo_Servicio])
GO

GO
CREATE NONCLUSTERED INDEX [ix_maestra_paquete_fecha]
ON [gd_esquema].[Maestra] ([FechaSalida],[Fecha_LLegada_Estimada],[FechaLLegada])
INCLUDE ([Cli_Nombre],[Cli_Apellido],[Cli_Dni],[Cli_Fecha_Nac],[Paquete_Codigo],[Paquete_Precio],[Paquete_KG],[Paquete_FechaCompra],[Ruta_Codigo],[Ruta_Ciudad_Origen],[Ruta_Ciudad_Destino],[Aeronave_Matricula],[Tipo_Servicio])
GO


-- CREACION INICIAL -----------------------------------------------------


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
		usu_password varbinary(1024) NOT NULL,
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
		--tipo_servicio_id int REFERENCES MILANESA.Tipos_Servicio NOT NULL,
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
		rut_id int REFERENCES MILANESA.Rutas,
		Primary Key (tipo_servicio_id, rut_id)
	)
GO


-- PROCEDURES DE MIGRACION -------------------------------------------------------


CREATE PROCEDURE MILANESA.sp_migracion_clientes AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Clientes (cli_nombre, cli_apellido, cli_dni, cli_direccion, cli_telefono, cli_mail, cli_fecha_nacimiento)
	SELECT DISTINCT Cli_Nombre, Cli_Apellido, Cli_Dni, Cli_Dir, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac
	FROM gd_esquema.Maestra

END
GO

CREATE PROCEDURE MILANESA.sp_migracion_ciudades AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Ciudades (ciu_descripcion)
	SELECT DISTINCT Ruta_Ciudad_Destino
	FROM gd_esquema.Maestra
	UNION
	SELECT DISTINCT Ruta_Ciudad_Origen
	FROM gd_esquema.Maestra

END
GO

CREATE PROCEDURE MILANESA.sp_migracion_rutas AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Rutas (rut_codigo, rut_precio_base_pasaje, rut_precio_base_kg, ciudad_origen_id, ciudad_destino_id )
	SELECT DISTINCT 
		Ruta_Codigo, 
		Ruta_Precio_BasePasaje,
		0,
		(SELECT ciu_id
		 FROM MILANESA.Ciudades
		 WHERE Ruta_Ciudad_Origen = ciu_descripcion),
		(SELECT ciu_id
		 FROM MILANESA.Ciudades
		 WHERE Ruta_Ciudad_Destino = ciu_descripcion)
	FROM gd_esquema.Maestra M
	WHERE Ruta_Precio_BasePasaje > 0

	INSERT INTO MILANESA.Tipos_Servicio_Rutas(tipo_servicio_id, rut_id )
	SELECT DISTINCT 
		(SELECT tip_id
		 FROM MILANESA.Tipos_Servicio
		 WHERE tip_descripcion = M.Tipo_Servicio),
		 (SELECT rut_id
		 FROM MILANESA.Rutas R
		 WHERE R.rut_codigo = M.Ruta_Codigo AND
			M.Ruta_Ciudad_Origen = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = R.ciudad_origen_id) AND
			M.Ruta_Ciudad_Destino = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = R.ciudad_destino_id))
	FROM gd_esquema.Maestra M
	WHERE Ruta_Precio_BasePasaje > 0

	UPDATE Rutas 
	SET
		rut_precio_base_kg = M.Ruta_Precio_BaseKG
	FROM
		Rutas R, gd_esquema.Maestra M
	WHERE
		r.rut_precio_base_kg = 0 AND
		m.Ruta_Precio_BaseKG > 0 AND
		m.Ruta_Codigo = r.rut_codigo AND
		m.Ruta_Ciudad_Origen = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = r.ciudad_origen_id) AND
		m.Ruta_Ciudad_Destino = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = r.ciudad_destino_id)-- AND
		--m.Tipo_Servicio = (SELECT tip_descripcion FROM MILANESA.Tipos_Servicio WHERE tip_id = r.tipo_servicio_id)

END
GO

CREATE PROCEDURE MILANESA.sp_migracion_tipos_servicio AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Tipos_Servicio (tip_descripcion)
	SELECT DISTINCT Tipo_Servicio
	FROM gd_esquema.Maestra
END
GO

CREATE PROCEDURE MILANESA.sp_migracion_aeronaves AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Aeronaves(aer_matricula, aer_modelo, aer_kg_disponibles, aer_fabricante, tipo_servicio_id)
	SELECT DISTINCT 
		Aeronave_Matricula, 
		Aeronave_Modelo, 
		Aeronave_KG_Disponibles, 
		Aeronave_Fabricante,
		(SELECT tip_id
		 FROM MILANESA.Tipos_Servicio
		 WHERE tip_descripcion = M.Tipo_Servicio)
	FROM gd_esquema.Maestra M
END
GO

CREATE PROCEDURE MILANESA.sp_migracion_butacas AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Butacas(but_numero, but_piso, but_tipo, aeronave_id)
	SELECT DISTINCT 
		Butaca_Nro, 
		Butaca_Piso, 
		Butaca_Tipo, 
		(SELECT aer_id
		 FROM MILANESA.Aeronaves
		 WHERE aer_matricula = M.Aeronave_Matricula)
	FROM gd_esquema.Maestra M
END
GO

CREATE PROCEDURE MILANESA.sp_migracion_vuelos AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Vuelos(vue_fecha_salida, vue_fecha_llegada_estimada, vue_fecha_llegada, ruta_id, aeronave_id)
	SELECT DISTINCT 
		FechaSalida, 
		Fecha_LLegada_Estimada, 
		FechaLLegada, 
		(SELECT rut_id
		 FROM MILANESA.Rutas R
		 WHERE 
			rut_codigo = M.Ruta_Codigo AND
			M.Ruta_Ciudad_Origen = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = R.ciudad_origen_id) AND
			M.Ruta_Ciudad_Destino = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = R.ciudad_destino_id)), --AND
			--M.Tipo_Servicio = (SELECT tip_descripcion FROM MILANESA.Tipos_Servicio WHERE tip_id = R.tipo_servicio_id)),
		(SELECT aer_id
		 FROM MILANESA.Aeronaves 
		 WHERE aer_matricula = M.Aeronave_Matricula)
	FROM gd_esquema.Maestra M
END
GO

CREATE PROCEDURE MILANESA.sp_migracion_ventas AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Ventas(ven_fecha, comprador_id, vuelo_id)
	SELECT DISTINCT
			M.Pasaje_FechaCompra, 
			C.cli_id,
			V.vue_id
		FROM
			gd_esquema.Maestra M, MILANESA.Clientes C, MILANESA.Vuelos V
		WHERE
			M.Pasaje_Codigo != 0 AND
			C.cli_nombre = M.Cli_Nombre AND
			C.cli_apellido = M.Cli_Apellido AND
			C.cli_dni = M.Cli_Dni AND 
			C.cli_fecha_nacimiento = M.Cli_Fecha_Nac AND
			V.ruta_id = (SELECT R.rut_id 
								FROM MILANESA.Rutas R
								WHERE
								R.rut_codigo = M.Ruta_Codigo AND
								M.Ruta_Ciudad_Origen = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = R.ciudad_origen_id) AND
								M.Ruta_Ciudad_Destino = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = R.ciudad_destino_id)) --AND
								--M.Tipo_Servicio = (SELECT tip_descripcion FROM MILANESA.Tipos_Servicio WHERE tip_id = R.tipo_servicio_id))
			AND V.aeronave_id = (SELECT aer_id
									 FROM MILANESA.Aeronaves A
									 WHERE M.Aeronave_Matricula = A.aer_matricula)
			AND V.vue_fecha_salida = M.FechaSalida
			AND V.vue_fecha_llegada_estimada = M.Fecha_LLegada_Estimada
			AND V.vue_fecha_llegada = M.FechaLLegada
	UNION
	SELECT DISTINCT
			M.Paquete_FechaCompra, 
			C.cli_id,
			V.vue_id
		FROM
			gd_esquema.Maestra M, MILANESA.Clientes C, MILANESA.Vuelos V
		WHERE
			M.Paquete_Codigo != 0 AND
			C.cli_nombre = M.Cli_Nombre AND
			C.cli_apellido = M.Cli_Apellido AND
			C.cli_dni = M.Cli_Dni AND 
			C.cli_fecha_nacimiento = M.Cli_Fecha_Nac AND
			V.ruta_id = (SELECT R.rut_id 
								FROM MILANESA.Rutas R
								WHERE
								R.rut_codigo = M.Ruta_Codigo AND
								M.Ruta_Ciudad_Origen = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = R.ciudad_origen_id) AND
								M.Ruta_Ciudad_Destino = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = R.ciudad_destino_id)) --AND
								--M.Tipo_Servicio = (SELECT tip_descripcion FROM MILANESA.Tipos_Servicio WHERE tip_id = R.tipo_servicio_id))
			AND V.aeronave_id = (SELECT aer_id
									 FROM MILANESA.Aeronaves A
									 WHERE M.Aeronave_Matricula = A.aer_matricula)
			AND V.vue_fecha_salida = M.FechaSalida
			AND V.vue_fecha_llegada_estimada = M.Fecha_LLegada_Estimada
			AND V.vue_fecha_llegada = M.FechaLLegada

END
GO

CREATE PROCEDURE MILANESA.sp_migracion_pasajes AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Pasajes(pas_codigo, pas_precio, pasajero_id, venta_id)
	SELECT DISTINCT 
			M.Pasaje_Codigo, 
			M.Pasaje_Precio,
			C.cli_id,
			Ven.ven_id
		FROM
			gd_esquema.Maestra M, MILANESA.Clientes C, MILANESA.Vuelos V, MILANESA.Ventas Ven
		WHERE
			M.Pasaje_Codigo != 0 AND
			C.cli_nombre = M.Cli_Nombre AND
			C.cli_apellido = M.Cli_Apellido AND
			C.cli_dni = M.Cli_Dni AND 
			C.cli_fecha_nacimiento = M.Cli_Fecha_Nac AND
			Ven.ven_fecha = M.Pasaje_FechaCompra AND
			Ven.comprador_id = C.cli_id AND
			Ven.vuelo_id = V.vue_id AND
			V.ruta_id = (SELECT R.rut_id 
								FROM MILANESA.Rutas R
								WHERE
								R.rut_codigo = M.Ruta_Codigo AND
								M.Ruta_Ciudad_Origen = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = R.ciudad_origen_id) AND
								M.Ruta_Ciudad_Destino = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = R.ciudad_destino_id))-- AND
								--M.Tipo_Servicio = (SELECT tip_descripcion FROM MILANESA.Tipos_Servicio WHERE tip_id = R.tipo_servicio_id))
			AND V.aeronave_id = (SELECT aer_id
									 FROM MILANESA.Aeronaves A
									 WHERE M.Aeronave_Matricula = A.aer_matricula)
			AND V.vue_fecha_salida = M.FechaSalida
			AND V.vue_fecha_llegada_estimada = M.Fecha_LLegada_Estimada
			AND V.vue_fecha_llegada = M.FechaLLegada
END
GO

CREATE PROCEDURE MILANESA.sp_migracion_paquetes AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Paquetes(paq_codigo, paq_precio, paq_kg, venta_id)
	SELECT DISTINCT 
		M.Paquete_Codigo, 
		M.Paquete_Precio,
		M.Paquete_Kg,
		Ven.ven_id
	FROM
		gd_esquema.Maestra M, MILANESA.Vuelos V, MILANESA.Clientes C, MILANESA.Ventas Ven
	WHERE
		M.Paquete_Codigo != 0 AND
		Ven.vuelo_id = V.vue_id AND
		C.cli_nombre = M.Cli_Nombre AND
		C.cli_apellido = M.Cli_Apellido AND
		C.cli_dni = M.Cli_Dni AND 
		C.cli_fecha_nacimiento = M.Cli_Fecha_Nac AND
		Ven.ven_fecha = M.Paquete_FechaCompra AND
		Ven.comprador_id = C.cli_id AND
		V.ruta_id = (SELECT R.rut_id 
							FROM MILANESA.Rutas R
							WHERE
							R.rut_codigo = M.Ruta_Codigo AND
							M.Ruta_Ciudad_Origen = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = R.ciudad_origen_id) AND
							M.Ruta_Ciudad_Destino = (SELECT ciu_descripcion FROM MILANESA.Ciudades WHERE ciu_id = R.ciudad_destino_id))-- AND
							--M.Tipo_Servicio = (SELECT tip_descripcion FROM MILANESA.Tipos_Servicio WHERE tip_id = R.tipo_servicio_id))
		AND V.aeronave_id = (SELECT aer_id
								 FROM MILANESA.Aeronaves A
								 WHERE M.Aeronave_Matricula = A.aer_matricula)
		AND V.vue_fecha_salida = M.FechaSalida
		AND V.vue_fecha_llegada_estimada = M.Fecha_LLegada_Estimada
		AND V.vue_fecha_llegada = M.FechaLLegada
END
GO

CREATE PROCEDURE MILANESA.sp_migracion_datos AS
BEGIN
	SET NOCOUNT ON;

	EXEC MILANESA.sp_migracion_clientes
	EXEC MILANESA.sp_migracion_ciudades
	EXEC MILANESA.sp_migracion_tipos_servicio
	EXEC MILANESA.sp_migracion_aeronaves
	EXEC MILANESA.sp_migracion_butacas
	EXEC MILANESA.sp_migracion_rutas
	EXEC MILANESA.sp_migracion_vuelos
	EXEC MILANESA.sp_migracion_ventas
	EXEC MILANESA.sp_migracion_pasajes
	EXEC MILANESA.sp_migracion_paquetes

END
GO


-- EJECUCION PROCEDURES MIGRACION -------------------------------------------------------


EXEC MILANESA.sp_migracion_datos
GO


-- CREACION ADMIN ----------------------------------------------------------------------


INSERT INTO [MILANESA].[Roles]
           ([rol_descripcion]
           ,[rol_activo])
     VALUES
           ('Administrador General'
           ,1)
GO

INSERT INTO [MILANESA].[Funciones]
           ([fun_descripcion]
           ,[fun_activo])
     VALUES
           ('Administrar'
           ,1)
GO

INSERT INTO [MILANESA].[Funciones]
           ([fun_descripcion]
           ,[fun_activo])
     VALUES
           ('Vender'
           ,1)
GO

INSERT INTO [MILANESA].[Funciones_Roles]
           ([funcion_id]
           ,[rol_id])
     VALUES
           (1
           ,1)
GO

INSERT INTO [MILANESA].[Usuarios]
           ([usu_nombre]
           ,[usu_password]
           ,[rol_id]
           ,[usu_intentos_logueo_fallidos]
           ,[usu_activo])
     VALUES
           ('admin'
           ,HASHBYTES('SHA2_256', 'w23e')
           ,1
           ,0
           ,1)
GO


-- PROCEDURES NECESARIOS PARA LA APP ---------------------------------------------------


CREATE PROCEDURE MILANESA.rolBajaLogica
(
	@rol_id int
)
AS
	SET NOCOUNT OFF;
UPDATE       MILANESA.Roles
SET                rol_activo = 'false'
WHERE        (rol_id = @rol_id)
GO

CREATE PROCEDURE MILANESA.funcionesRolesBorrar
(
	@rol_id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM MILANESA.Funciones_Roles
WHERE        (rol_id = @rol_id)
GO

CREATE PROCEDURE MILANESA.rolBuscar
(
	@param1 nvarchar(255)
)
AS
	SET NOCOUNT ON;
SELECT        rol_id, rol_descripcion, rol_activo
FROM            MILANESA.Roles
WHERE        (rol_descripcion LIKE '%' + @param1 + '%')
GO

CREATE PROCEDURE MILANESA.rolInsertar
(
	@rol_descripcion nvarchar(255)
)
AS
	SET NOCOUNT OFF;
INSERT INTO MILANESA.Roles
                         (rol_descripcion, rol_activo)
VALUES        (@rol_descripcion, 'true');
	 
	 
SELECT rol_id FROM MILANESA.Roles WHERE (rol_id = SCOPE_IDENTITY())
GO

CREATE PROCEDURE MILANESA.funcionesRolesInsertar
(
	@funcion_id int,
	@rol_id int
)
AS
	SET NOCOUNT OFF;
INSERT INTO MILANESA.Funciones_Roles
                         (funcion_id, rol_id)
VALUES        (@funcion_id,@rol_id)
GO

CREATE PROCEDURE MILANESA.rolModificar
(
	@rol_descripcion nvarchar(255),
	@rol_activo bit,
	@rol_id int
)
AS
	SET NOCOUNT OFF;
UPDATE       MILANESA.Roles
SET                rol_descripcion = @rol_descripcion, rol_activo = @rol_activo
WHERE        (rol_id = @rol_id)
GO

