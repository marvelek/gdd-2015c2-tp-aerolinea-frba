USE [GD2C2015]
GO


-- INDICES PARA MIGRACION ---------------------------------------------------------

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

CREATE NONCLUSTERED INDEX [ix_maestra_pasaje_butacas]
ON [gd_esquema].[Maestra] ([Pasaje_Codigo])
INCLUDE ([Cli_Nombre],[Cli_Apellido],[Cli_Dni],[Cli_Fecha_Nac],[Pasaje_Precio],[Pasaje_FechaCompra],[Butaca_Nro],[Butaca_Tipo],[Butaca_Piso],[FechaSalida],[Fecha_LLegada_Estimada],[FechaLLegada],[Ruta_Codigo],[Ruta_Ciudad_Origen],[Ruta_Ciudad_Destino],[Aeronave_Matricula])

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
		pro_stock numeric(18,0) NOT NULL,
		pro_activo bit NOT NULL DEFAULT 1
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

/*Canjes*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Canjes' AND xtype='U')
	CREATE TABLE MILANESA.Canjes (
		can_id int identity(1,1) Primary Key,
		cliente_id int REFERENCES MILANESA.Clientes NOT NULL,
		producto_id int REFERENCES MILANESA.Productos,
		can_cantidad numeric(18,0) NOT NULL,
		can_fecha datetime
	)
GO

/*Millas*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Millas' AND xtype='U')
	CREATE TABLE MILANESA.Millas (
		mil_id int identity(1,1) Primary Key,
		cliente_id int REFERENCES MILANESA.Clientes NOT NULL,
		mil_cantidad numeric(18,0) NOT NULL,
		mil_fecha_acreditacion datetime,
		mil_canjeadas numeric(18,0) DEFAULT 0,
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
		tip_factor_precio numeric(18,2) DEFAULT 1,
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
		aer_fecha_alta datetime,
		aer_fecha_fuera_servicio datetime,
		aer_fecha_reinicio_servicio datetime,
		aer_fecha_baja_definitiva datetime,
		aer_activo bit NOT NULL DEFAULT 1
	)
GO

/*Estados_Arribos*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Estados_Arribos' AND xtype='U')
	CREATE TABLE MILANESA.Estados_Arribos (
		ear_id int identity(1,1) Primary Key,
		ear_descripcion nvarchar(255) NOT NULL,
	)
GO

INSERT INTO MILANESA.Estados_Arribos (ear_descripcion) VALUES ('OK')
GO
INSERT INTO MILANESA.Estados_Arribos (ear_descripcion) VALUES ('ERROR: Debería haber llegado a otro aeropuerto')
GO
INSERT INTO MILANESA.Estados_Arribos (ear_descripcion) VALUES ('ERROR: No se encontró vuelo cargado')
GO

/*Arribos*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Arribos' AND xtype='U')
	CREATE TABLE MILANESA.Arribos (
		arr_id int identity(1,1) Primary Key,
		aeronave_id int REFERENCES MILANESA.Aeronaves NOT NULL,
		ciudad_origen_id int REFERENCES MILANESA.Ciudades NOT NULL,
		ciudad_destino_id int REFERENCES MILANESA.Ciudades NOT NULL,
		arr_destino_correcto int REFERENCES MILANESA.Estados_Arribos NOT NULL,
		arr_fecha datetime NOT NULL
	)
GO

/*Vuelos*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Vuelos' AND xtype='U')
	CREATE TABLE MILANESA.Vuelos (
		vue_id int identity(1,1) Primary Key,
		ruta_id int REFERENCES MILANESA.Rutas NOT NULL,
		aeronave_id int REFERENCES MILANESA.Aeronaves NOT NULL,
		arribo_id int REFERENCES MILANESA.Arribos,
		vue_fecha_salida datetime NOT NULL,
		vue_fecha_llegada_estimada datetime NOT NULL,
		vue_fecha_llegada datetime,
		vue_activo bit NOT NULL DEFAULT 1
	)
GO

/*Tarjetas_Credito*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Tarjetas_Credito' AND xtype='U')
	CREATE TABLE MILANESA.Tarjetas_Credito (
		tac_id int identity(1,1) Primary Key,
		tac_descripcion nvarchar(255) NOT NULL,
		tac_admite_cuotas BIT DEFAULT 1,
		tac_activo BIT DEFAULT 1
	)
GO

INSERT INTO MILANESA.Tarjetas_Credito (tac_descripcion) VALUES ('Visa')
GO
INSERT INTO MILANESA.Tarjetas_Credito (tac_descripcion, tac_admite_cuotas) VALUES ('Master Card', 0)
GO
INSERT INTO MILANESA.Tarjetas_Credito (tac_descripcion) VALUES ('American Express')
GO

/*Pagos_Tarjeta*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Pagos_Tarjeta' AND xtype='U')
	CREATE TABLE MILANESA.Pagos_Tarjeta (
		pat_id int identity(1,1) Primary Key,
		pat_numero_tarjeta numeric(12,0),
		tarjeta_credito_id int REFERENCES MILANESA.Tarjetas_Credito
	)
GO

/*Ventas*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Ventas' AND xtype='U')
	CREATE TABLE MILANESA.Ventas (
		ven_id int identity(1,1) Primary Key,
		comprador_id int REFERENCES MILANESA.Clientes NOT NULL,
		vuelo_id int REFERENCES MILANESA.Vuelos NOT NULL,
		pago_tarjeta_id int REFERENCES MILANESA.Pagos_Tarjeta,
		ven_fecha datetime NOT NULL,
		ven_activo bit NOT NULL DEFAULT 1
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
		pas_precio numeric(18,2) NOT NULL,
		pas_activo bit NOT NULL DEFAULT 1
	)
GO

/*Paquetes*/
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name='Paquetes' AND xtype='U')
	CREATE TABLE MILANESA.Paquetes (
		paq_id int identity(1,1) Primary Key,
		devolucion_id int REFERENCES MILANESA.Devoluciones,
		venta_id int REFERENCES MILANESA.Ventas NOT NULL,
		cliente_id int REFERENCES MILANESA.Clientes NOT NULL,
		paq_codigo numeric(18,0) NOT NULL,
		paq_precio numeric(18,2) NOT NULL,
		paq_kg numeric(18,0) NOT NULL,
		paq_activo bit NOT NULL DEFAULT 1
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
	SELECT DISTINCT LTRIM(RTRIM(Ruta_Ciudad_Destino))
	FROM gd_esquema.Maestra
	UNION
	SELECT DISTINCT LTRIM(RTRIM(Ruta_Ciudad_Origen))
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

	INSERT INTO MILANESA.Tipos_Servicio (tip_descripcion)
	SELECT DISTINCT m.Tipo_Servicio
	FROM gd_esquema.Maestra m

	UPDATE MILANESA.Tipos_Servicio SET tip_factor_precio=1.5 WHERE tip_descripcion='Ejecutivo'
	UPDATE MILANESA.Tipos_Servicio SET tip_factor_precio=2.0 WHERE tip_descripcion='Primera Clase'

END
GO

CREATE PROCEDURE MILANESA.sp_migracion_aeronaves AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Aeronaves(aer_matricula, aer_modelo, aer_kg_disponibles, aer_fabricante, tipo_servicio_id, aer_fecha_alta)
	SELECT DISTINCT 
		Aeronave_Matricula, 
		Aeronave_Modelo, 
		Aeronave_KG_Disponibles, 
		Aeronave_Fabricante,
		(SELECT tip_id
		 FROM MILANESA.Tipos_Servicio
		 WHERE tip_descripcion = M.Tipo_Servicio),
		 GETDATE()
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
	WHERE M.Butaca_Piso = 1
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

	INSERT INTO Pasajes(pas_codigo, pas_precio, pasajero_id, venta_id, butaca_id)
	SELECT DISTINCT 
			M.Pasaje_Codigo, 
			M.Pasaje_Precio,
			C.cli_id,
			Ven.ven_id,
			B.but_id
		FROM
			gd_esquema.Maestra M, MILANESA.Clientes C, MILANESA.Vuelos V, MILANESA.Ventas Ven, MILANESA.Butacas B, MILANESA.Aeronaves A
		WHERE
			M.Butaca_Nro = B.but_numero AND
			M.Butaca_Piso = B.but_piso AND
			M.Butaca_Tipo = B.but_tipo AND
			A.aer_id = V.aeronave_id AND
			A.aer_id = B.aeronave_id AND
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

	INSERT INTO Paquetes(paq_codigo, paq_precio, cliente_id, paq_kg, venta_id)
	SELECT DISTINCT 
		M.Paquete_Codigo, 
		M.Paquete_Precio,
		C.cli_id,
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
		Ven.comprador_id = C.cli_id AND
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


INSERT INTO [MILANESA].[Roles] ([rol_descripcion],[rol_activo]) VALUES ('Administrador General', 1)
GO

INSERT INTO [MILANESA].[Funciones] ([fun_descripcion], [fun_activo]) VALUES ('Administrar', 1)
GO

INSERT INTO [MILANESA].[Funciones] ([fun_descripcion], [fun_activo]) VALUES ('Vender', 1)
GO

INSERT INTO [MILANESA].[Funciones_Roles] ([funcion_id], [rol_id]) VALUES (1,1)
GO

INSERT INTO [MILANESA].[Usuarios] ([usu_nombre], [usu_password], [rol_id], [usu_intentos_logueo_fallidos], [usu_activo])
     VALUES ('admin', HASHBYTES('SHA2_256', 'w23e'), 1, 0, 1)
GO

INSERT INTO [MILANESA].[Productos] ([pro_descripcion], [pro_cantidad_millas], [pro_stock], [pro_activo])
	 VALUES ('Bicicleta', 400, 10, 1)
GO

INSERT INTO [MILANESA].[Productos] ([pro_descripcion], [pro_cantidad_millas], [pro_stock], [pro_activo])
	 VALUES ('Celular', 1000, 200, 1)
GO

INSERT INTO [MILANESA].[Productos] ([pro_descripcion], [pro_cantidad_millas], [pro_stock], [pro_activo])
	 VALUES ('TV LED', 2000, 50, 1)
GO

-- INDICES PARA LA APP -----------------------------------------------------------------


USE [GD2C2015]
GO
CREATE NONCLUSTERED INDEX ix_pasajes_venta
ON [MILANESA].[Pasajes] ([venta_id])

GO


USE [GD2C2015]
GO
CREATE NONCLUSTERED INDEX ix_paquetes_venta_kg
ON [MILANESA].[Paquetes] ([venta_id])
INCLUDE ([paq_kg])
GO

USE [GD2C2015]
GO
CREATE NONCLUSTERED INDEX ix_ventas_vuelo
ON [MILANESA].[Ventas] ([vuelo_id])
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

----------------------------- PROCEDURES DE RUTAS -----------------

CREATE PROCEDURE [MILANESA].[devolucionInsertar]
(
	@dev_motivo nvarchar(255),
	@dev_fecha datetime
)
AS
	SET NOCOUNT OFF;
	DECLARE @dev_id int
INSERT INTO MILANESA.Devoluciones
                         (dev_motivo, dev_fecha)
VALUES        (@dev_motivo, @dev_fecha);
	 
	 
SET @dev_id = (SELECT dev_id FROM MILANESA.Devoluciones WHERE (dev_id = SCOPE_IDENTITY()))
return @dev_id
GO


CREATE PROCEDURE [MILANESA].[paqueteBajaPorVenta]
(
	@venta_id int,
	@devolucion_id int
)
AS
UPDATE       MILANESA.Paquetes
SET                paq_activo = 'false', devolucion_id = @devolucion_id
WHERE        (venta_id = @venta_id) and paq_activo = 1
GO

CREATE PROCEDURE [MILANESA].[pasajeBajaPorVenta]
(
	@venta_id int,
	@devolucion_id int
)
AS
UPDATE       MILANESA.Pasajes
SET                pas_activo = 'false', devolucion_id = @devolucion_id
WHERE        (venta_id = @venta_id) and pas_activo = 1
GO

CREATE PROCEDURE [MILANESA].[ventaBajaPorVuelo]
(
	@vuelo_id int,
	@devolucion_id int
)
AS
	SET NOCOUNT OFF;	
	DECLARE @venta int
	SET NOCOUNT OFF;
	DECLARE ventas CURSOR 
	FOR SELECT ven_id from  MILANESA.Ventas where (vuelo_id = @vuelo_id) and ven_activo = 1
	OPEN ventas
	FETCH ventas INTO @venta 

		WHILE (@@FETCH_STATUS = 0)

		BEGIN	
			EXEC MILANESA.pasajeBajaPorVenta @venta,@devolucion_id;
			EXEC MILANESA.paqueteBajaPorVenta @venta,@devolucion_id;
			FETCH ventas INTO @venta 
		END -- Fin del bucle WHILE	
	CLOSE ventas
	DEALLOCATE ventas
UPDATE       MILANESA.Ventas
SET                ven_activo = 'false'
WHERE        (vuelo_id = @vuelo_id) and ven_activo = 1
GO

CREATE PROCEDURE [MILANESA].[vueloBajaPorRuta]
(
	@ruta_id int
)
AS	
	DECLARE @vuelo int, @devolucion int, @motivo nvarchar(255), @fecha datetime
	SET @motivo = 'BAJA DE RUTA'
	SET @fecha = SYSDATETIME()
	EXEC @devolucion = MILANESA.devolucionInsertar @motivo,@fecha
	SET NOCOUNT OFF;
	DECLARE vuelos CURSOR 
	FOR SELECT vue_id from  MILANESA.Vuelos where (ruta_id = @ruta_id) and vue_fecha_salida > SYSDATETIME() and vue_activo = 1
	OPEN vuelos
	FETCH vuelos INTO @vuelo 

		WHILE (@@FETCH_STATUS = 0)

		BEGIN	
			EXEC MILANESA.ventaBajaPorVuelo @vuelo,@devolucion;
			FETCH vuelos INTO @vuelo 
		END -- Fin del bucle WHILE	
	CLOSE vuelos
	DEALLOCATE vuelos			
UPDATE       MILANESA.Vuelos
SET                vue_activo = 'false'
WHERE        (ruta_id = @ruta_id) and  vue_fecha_salida > SYSDATETIME() and vue_activo = 1
GO


CREATE PROCEDURE [MILANESA].[rutaBajaLogica]
(
	@rut_id int
)
AS
	SET NOCOUNT OFF;
EXEC MILANESA.vueloBajaPorRuta @rut_id;
UPDATE       MILANESA.Rutas
SET                rut_activo = 'false'
WHERE        (rut_id = @rut_id)
GO

CREATE PROCEDURE [MILANESA].[rutaBuscar]
(
	@codigo nvarchar(255),
	@activo Varchar(10),
	@ciudadOrigen nvarchar(255),
	@ciudadDestino nvarchar(255),
	@precioKgDesde numeric(18,2),
	@precioKgHasta numeric(18,2),
	@precioBaseDesde numeric(18,2),
	@precioBaseHasta numeric(18,2)
)
AS
	SET NOCOUNT ON;
SELECT        rut_id, rut_codigo, ciudad_origen_id, co.ciu_descripcion AS ciudad_origen_desc, ciudad_destino_id, cd.ciu_descripcion AS ciudad_destino_desc, rut_precio_base_kg, rut_precio_base_pasaje, rut_activo
FROM            MILANESA.Rutas
JOIN [MILANESA].[Ciudades] co on co.ciu_id = ciudad_origen_id
JOIN [MILANESA].[Ciudades] cd on cd.ciu_id = ciudad_destino_id
WHERE        (CAST(rut_codigo as varchar(18)) LIKE '%' + @codigo + '%') AND ((@activo = 'TODOS') or (@activo = 'ACTIVO' AND rut_activo = 1) or (@activo = 'INACTIVO' and rut_activo = 0)) AND ( co.ciu_descripcion LIKE '%' + @ciudadOrigen + '%') AND ( cd.ciu_descripcion LIKE '%' + @ciudadDestino + '%') AND ((@precioKgDesde = 0 OR rut_precio_base_kg >= @precioKgDesde ) AND ( @precioKgHasta = 0 OR rut_precio_base_kg <= @precioKgHasta )  AND ( (@precioBaseDesde = 0 or rut_precio_base_pasaje >= @precioBaseDesde) AND ( @precioBaseHasta = 0 OR rut_precio_base_pasaje <= @precioBaseHasta)))
GO

CREATE PROCEDURE [MILANESA].[rutaInsertar]
(
	@ciudad_origen_id int,
	@ciudad_destino_id int,
	@rut_codigo numeric(18, 0),
	@rut_precio_base_kg numeric(18, 2),
	@rut_precio_base_pasaje numeric(18, 2)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [MILANESA].[Rutas] (ciudad_origen_id, ciudad_destino_id, rut_codigo, rut_precio_base_kg, rut_precio_base_pasaje, rut_activo) 
VALUES (@ciudad_origen_id, @ciudad_destino_id, @rut_codigo, @rut_precio_base_kg, @rut_precio_base_pasaje, 'true')

SELECT rut_id FROM MILANESA.Rutas WHERE (rut_id = SCOPE_IDENTITY())
GO

CREATE PROCEDURE [MILANESA].[rutaModificar]
(
	@ciudad_destino_id int,
	@ciudad_origen_id int,	
	@rut_codigo numeric(18, 0),
	@rut_precio_base_kg numeric(18, 2),
	@rut_precio_base_pasaje numeric(18, 2),
	@rut_activo bit,
	@Original_rut_id int
)
AS
	SET NOCOUNT OFF;
UPDATE [MILANESA].[Rutas] SET [ciudad_origen_id] = @ciudad_origen_id, [ciudad_destino_id] = @ciudad_destino_id, [rut_codigo] = @rut_codigo, [rut_precio_base_kg] = @rut_precio_base_kg, [rut_precio_base_pasaje] = @rut_precio_base_pasaje, [rut_activo] = @rut_activo WHERE (([rut_id] = @Original_rut_id))
GO

CREATE PROCEDURE [MILANESA].[tipo_Servicio_RutaInsertar]
(
	@tipo_servicio_id int,
	@rut_id int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [MILANESA].[Tipos_Servicio_Rutas] ([tipo_servicio_id], [rut_id]) VALUES (@tipo_servicio_id, @rut_id)
GO

CREATE PROCEDURE [MILANESA].[tipos_Servicio_RutasBorrar]
(
	@rut_id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM MILANESA.Tipos_Servicio_Rutas
WHERE        (rut_id = @rut_id)
GO


-- PROCEDURES DE VUELOS --
CREATE PROCEDURE [MILANESA].[vuelos_disponibles]
(
	@fecha_salida datetime,
	@ciudad_origen_id int,
	@ciudad_destino_id int
)
AS
	SET NOCOUNT OFF;

	select * from (
	SELECT v.vue_id,
	t.tip_descripcion,
	(select aer_kg_disponibles -
	(select sum(p.paq_kg) from MILANESA.Ventas v1 
	join MILANESA.Paquetes p ON p.venta_id = v1.ven_id
	where v1.vuelo_id = v.vue_id
	and v1.ven_activo = 1
	and p.paq_activo = 1
	and p.devolucion_id is null) 
	  from milanesa.aeronaves where aer_id = v.aeronave_id) as kg_disponibles,
		(select count(1)-(select count(1) from MILANESA.Ventas v1 
	join MILANESA.Pasajes pas ON v1.ven_id = pas.venta_id
	where v1.vuelo_id = v.vue_id
	and v1.ven_activo = 1
	and pas.pas_activo = 1
	and pas.devolucion_id is null) from milanesa.butacas b where
	  b.aeronave_id = v.aeronave_id) as butacas_disponibles
	 from MILANESA.Vuelos v 
	join MILANESA.Rutas r ON v.ruta_id = r.rut_id
	join MILANESA.Aeronaves a ON v.aeronave_id = a.aer_id
	join MILANESA.Tipos_Servicio t ON a.tipo_servicio_id = t.tip_id
	where v.vue_activo = 1
	and r.ciudad_origen_id = @ciudad_origen_id
	and r.ciudad_destino_id = @ciudad_destino_id
	and convert(date, v.vue_fecha_salida,121) = convert(date, @fecha_salida, 121)
	) as query 
	where query.kg_disponibles > 0
	and query.butacas_disponibles > 0
	order by vue_id
GO

-- PROCEDURES DE ARRIBOS --
CREATE PROCEDURE MILANESA.arribosInsertar
(
	@aeronave_id int,
	@ciudad_origen_id int,
	@ciudad_destino_id int,
	@fecha_llegada datetime,
	@destino_correcto_id int
)
AS
	SET NOCOUNT OFF;
INSERT INTO MILANESA.Arribos (aeronave_id, ciudad_origen_id, ciudad_destino_id, arr_fecha, arr_destino_correcto)
VALUES        (@aeronave_id,@ciudad_origen_id,@ciudad_destino_id,@fecha_llegada,@destino_correcto_id);
	 
	 
SELECT arr_id FROM MILANESA.Arribos WHERE (arr_id = SCOPE_IDENTITY())
GO

-- PROCEDURES PARA MILLAS --

CREATE PROCEDURE MILANESA.acreditarMillasCliente 
(
	@cliente_id int,
	@pesos_gastados int
)

AS
	SET NOCOUNT OFF;

	DECLARE @cantidad_acreditar int

	SELECT @cantidad_acreditar = @pesos_gastados / 10 

	INSERT INTO MILANESA.Millas(cliente_id, mil_cantidad, mil_fecha_acreditacion) VALUES (@cliente_id, @cantidad_acreditar, SYSDATETIME())

GO

CREATE PROCEDURE MILANESA.acreditarMillas
(
	@vuelo_id int
)
AS
	SET NOCOUNT OFF;

	DECLARE @cliente_id int, @pesos_gastados int

	DECLARE cr_cliente_gastado CURSOR
	FOR
		SELECT QUERY.cli_id, SUM(QUERY.pesos_gastados) 
		FROM
			(SELECT
				C.cli_id,
				SUM(P.pas_precio) as pesos_gastados
			FROM
				MILANESA.Ventas VE,
				MILANESA.Vuelos VU,
				MILANESA.Pasajes P,
				MILANESA.Clientes C
			WHERE
				VE.ven_id = P.venta_id AND
				VE.vuelo_id = VU.vue_id AND
				C.cli_id = P.pasajero_id AND
				VU.vue_id = @vuelo_id AND
				P.pas_activo = 1 AND
				P.devolucion_id IS NULL
			GROUP BY C.cli_id
			UNION
			SELECT
				C.cli_id,
				SUM(P.paq_precio) as pesos_gastados
			FROM
				MILANESA.Ventas VE,
				MILANESA.Vuelos VU,
				MILANESA.Paquetes P,
				MILANESA.Clientes C
			WHERE
				VE.ven_id = P.venta_id AND
				VE.vuelo_id = VU.vue_id AND
				C.cli_id = P.cliente_id AND
				VU.vue_id = @vuelo_id AND
				P.paq_activo = 1 AND
				P.devolucion_id IS NULL
			GROUP BY C.cli_id ) QUERY
		GROUP BY QUERY.cli_id;

	OPEN cr_cliente_gastado

	FETCH cr_cliente_gastado INTO @cliente_id, @pesos_gastados

	WHILE(@@FETCH_STATUS = 0)

	BEGIN
		EXEC MILANESA.acreditarMillasCliente @cliente_id, @pesos_gastados

		FETCH NEXT FROM cr_cliente_gastado INTO @cliente_id, @pesos_gastados

	END

	CLOSE cr_cliente_gastado

	DEALLOCATE cr_cliente_gastado
GO

CREATE PROCEDURE [MILANESA].historialMillas
(
	@cliente_id int
)
AS
	SET NOCOUNT OFF;

SELECT query.movimiento, query.concepto, query.fecha 
FROM
	(select
		m.mil_cantidad as movimiento, 
		'Vuelo' as concepto,
		mil_fecha_acreditacion as fecha
	from MILANESA.Millas m
	where 
		m.cliente_id = @cliente_id
	UNION
	select
		(can_cantidad * p.pro_cantidad_millas) * -1 as movimiento,
		'Canje por: ' + p.pro_descripcion as concepto,
		c.can_fecha
	 from MILANESA.Canjes c, MILANESA.Productos p
	 where
		p.pro_id = c.producto_id and
		c.cliente_id = @cliente_id) query
GROUP BY 
	query.movimiento, query.concepto, query.fecha
ORDER BY query.fecha desc

GO
-------------------------------------------------ESTADISTICAS --------------------------------------------

CREATE PROCEDURE [MILANESA].[estadisticaDestinosPasajes]
(
	@año int,
	@mes1 int,
	@mes2 int
)
AS
	SET NOCOUNT ON;
	SELECT TOP 5
		cd.ciu_id,
		cd.ciu_descripcion,
		count(pa.pas_Id) as CANTIDAD_PASAJE
	FROM MILANESA.Rutas ru
	JOIN MILANESA.Ciudades cd on cd.ciu_id = ru.ciudad_destino_id
	JOIN MILANESA.Vuelos vu on vu.ruta_id = ru.rut_id
	JOIN MILANESA.Ventas ve on ve.vuelo_id = vu.vue_id
	JOIN MILANESA.Pasajes pa on venta_id = ve.ven_id and devolucion_id is null
	where YEAR(ve.ven_fecha) = @año and MONTH(ve.ven_fecha) between @mes1 and @mes2
	group by 
		cd.ciu_id,
		cd.ciu_descripcion
	order by CANTIDAD_PASAJE DESC
GO

CREATE PROCEDURE [MILANESA].[estadisticaDestinosButacas]
(
	@año int,
	@mes1 int,
	@mes2 int
)
AS
	SET NOCOUNT ON;
	SELECT TOP 5
		cd.ciu_id,
		cd.ciu_descripcion,
		(count(bu.but_id) - count(pa.pas_Id)) as BUTACAS_DISPONIBLES
	FROM MILANESA.Rutas ru
	JOIN MILANESA.Ciudades cd on cd.ciu_id = ru.ciudad_destino_id
	JOIN MILANESA.Vuelos vu on vu.ruta_id = ru.rut_id
	JOIN MILANESA.Ventas ve on ve.vuelo_id = vu.vue_id
	JOIN MILANESA.Pasajes pa on venta_id = ve.ven_id and devolucion_id is null
	JOIN MILANESA.Aeronaves ae on ae.aer_id = vu.aeronave_id
	JOIN MILANESA.Butacas bu on bu.aeronave_id = ae.aer_id
	where YEAR(ve.ven_fecha) = @año and MONTH(ve.ven_fecha) between @mes1 and @mes2
	group by 
		cd.ciu_id,
		cd.ciu_descripcion
	order by BUTACAS_DISPONIBLES DESC
GO	



CREATE PROCEDURE [MILANESA].[estadisticaDestinosCancelados]
(
	@año int,
	@mes1 int,
	@mes2 int
)
AS
	SET NOCOUNT ON;
	SELECT TOP 5
		cd.ciu_id,
		cd.ciu_descripcion,
		count(pa.pas_Id) as CANTIDAD_PASAJE
	FROM MILANESA.Rutas ru
	JOIN MILANESA.Ciudades cd on cd.ciu_id = ru.ciudad_destino_id
	JOIN MILANESA.Vuelos vu on vu.ruta_id = ru.rut_id
	JOIN MILANESA.Ventas ve on ve.vuelo_id = vu.vue_id
	JOIN MILANESA.Pasajes pa on venta_id = ve.ven_id and devolucion_id is not null
	where YEAR(ve.ven_fecha) = @año and MONTH(ve.ven_fecha) between @mes1 and @mes2
	group by 
		cd.ciu_id,
		cd.ciu_descripcion
	order by CANTIDAD_PASAJE DESC
GO



CREATE PROCEDURE [MILANESA].[estadisticaAeronavesFueraDeServicio]
(
	@año int,
	@mes1 int,
	@mes2 int
)
AS
	SET NOCOUNT ON;
	SELECT TOP 5
		aer_id,
		aer_matricula,
		aer_modelo,
		aer_kg_disponibles,
		aer_fabricante,	
		aer_fecha_fuera_servicio,
		aer_fecha_reinicio_servicio,
		DATEDIFF(MINUTE, aer_fecha_fuera_servicio, aer_fecha_reinicio_servicio) as días
	FROM [MILANESA].[Aeronaves]
	where YEAR(aer_fecha_fuera_servicio) = @año and MONTH(aer_fecha_fuera_servicio) between @mes1 and @mes2
	group by 
		aer_id,
		aer_matricula,
		aer_modelo,
		aer_kg_disponibles,
		aer_fabricante,	
		aer_fecha_fuera_servicio,
		aer_fecha_reinicio_servicio
	order by días desc
GO

CREATE PROCEDURE [MILANESA].[estadisticaClientesMillas]
AS
	SET NOCOUNT ON;
	SELECT TOP 5
		cl.cli_id,
		cl.cli_nombre,
		cl.cli_apellido,
		cl.cli_dni,
		cl.cli_direccion,
		cl.cli_telefono,
		cl.cli_mail,
		sum(mi.mil_cantidad-mi.mil_canjeadas) as Puntos
	FROM MILANESA.Clientes cl
	JOIN MILANESA.Millas mi on  mi.cliente_id = cl.cli_id
	group by 
		cl.cli_id,
		cl.cli_nombre,
		cl.cli_apellido,
		cl.cli_dni,
		cl.cli_direccion,
		cl.cli_telefono,
		cl.cli_mail
	order by Puntos desc 
GO

CREATE PROCEDURE [MILANESA].[AeronavesBuscar]
(
	@matricula nvarchar(255)
)
AS
	SET NOCOUNT ON;
SELECT aer_id, tipo_servicio_id, aer_matricula, aer_modelo, aer_kg_disponibles, aer_fabricante, aer_fecha_fuera_servicio, aer_fecha_reinicio_servicio, aer_fecha_baja_definitiva, aer_activo FROM MILANESA.Aeronaves
WHERE (CAST(aer_matricula as varchar(18)) LIKE '%' + @matricula + '%')
GO

 CREATE PROCEDURE [MILANESA].[AeronavesInsert]
(
	@tipo_servicio_id int,
	@aer_matricula nvarchar(255),
	@aer_modelo nvarchar(255),
	@aer_kg_disponibles numeric(18, 0),
	@aer_fabricante nvarchar(255)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [MILANESA].[Aeronaves] ([tipo_servicio_id], [aer_matricula],[aer_fecha_alta], [aer_modelo], [aer_kg_disponibles], [aer_fabricante], [aer_activo]) VALUES (@tipo_servicio_id, @aer_matricula,GETDATE(), @aer_modelo, @aer_kg_disponibles, @aer_fabricante, 1)
GO

CREATE PROCEDURE [MILANESA].[ButacasInsert]
(
	@aeronave_id int,
	@but_numero numeric(18, 0),
	@but_tipo nvarchar(255)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [MILANESA].[Butacas] ([aeronave_id], [but_numero], [but_tipo], [but_piso], [but_activo]) VALUES (@aeronave_id, @but_numero, @but_tipo, 1, 1)
GO

CREATE PROCEDURE MILANESA.millasDisponibles
(
	@clienteId int
)
AS
	SET NOCOUNT OFF;
	DECLARE
		@return int
SELECT
	@return = ISNULL(SUM(m.mil_cantidad - m.mil_canjeadas), 0)
FROM
	MILANESA.Millas m
WHERE
	m.cliente_id = @clienteId AND
	DATEDIFF(day, SYSDATETIME(), m.mil_fecha_acreditacion) < 365

	RETURN(@return)
GO

CREATE PROCEDURE MILANESA.debitoMillas
(
	@costoEnMillas int,
	@clienteId int
)
AS
	SET NOCOUNT OFF;

DECLARE @idMillaActual int, @totales int, @canjeadas int, @diferencia int, @costoEnMillasRestante int, @costoEnMillasRestanteActual int
	
	SET @costoEnMillasRestante = @costoEnMillas

	DECLARE cr_millas_disponibles CURSOR
	FOR
		SELECT
			m.mil_id as id,
 			m.mil_cantidad as totales,
			m.mil_canjeadas as canjeadas
		FROM MILANESA.Millas m
		WHERE 
			m.cliente_id = @clienteId AND
			DATEDIFF(day, SYSDATETIME(), m.mil_fecha_acreditacion) < 365
		ORDER BY m.mil_fecha_acreditacion asc

	OPEN cr_millas_disponibles

	FETCH cr_millas_disponibles INTO @idMillaActual, @totales, @canjeadas

	WHILE(@@FETCH_STATUS = 0 AND @costoEnMillasRestante > 0)

	BEGIN

		SET @costoEnMillasRestanteActual = @costoEnMillasRestante - @totales + @canjeadas

		IF @costoEnMillasRestanteActual > 0
			UPDATE MILANESA.Millas SET mil_canjeadas = @costoEnMillasRestante - @costoEnMillasRestanteActual + @canjeadas WHERE mil_id = @idMillaActual	
		ELSE
			UPDATE MILANESA.Millas SET mil_canjeadas = @costoEnMillasRestante + @canjeadas WHERE mil_id = @idMillaActual	

		SET @costoEnMillasRestante = @costoEnMillasRestanteActual
		FETCH NEXT FROM cr_millas_disponibles INTO @idMillaActual, @totales, @canjeadas

	END

	CLOSE cr_millas_disponibles

	DEALLOCATE cr_millas_disponibles

GO

CREATE PROCEDURE MILANESA.canjearProducto
(
	@clienteId int,
	@productoId int,
	@cantidad int
)
AS
	SET NOCOUNT OFF;

	DECLARE @millasDisponibles int, @costoEnMillas int, @stockDisponible int

	EXEC @millasDisponibles = MILANESA.millasDisponibles @clienteId

	SELECT 
		@costoEnMillas = p.pro_cantidad_millas * @cantidad,
		@stockDisponible = p.pro_stock
	 FROM MILANESA.Productos p 
	 WHERE p.pro_id = @productoId

	if @costoEnMillas > @millasDisponibles
		THROW 60601,'Las millas acumuladas no son suficientes para el canje', 1;
	else if @cantidad > @stockDisponible
		THROW 60602,'No alcanza el stock para la cantidad seleccionada', 1;

	EXEC MILANESA.debitoMillas @costoEnMillas, @clienteId

	INSERT INTO MILANESA.Canjes (cliente_id, producto_id, can_cantidad, can_fecha) VALUES (@clienteId, @productoId, @cantidad, SYSDATETIME())

	UPDATE MILANESA.Productos SET pro_stock = @stockDisponible - @cantidad WHERE pro_id = @productoId

GO

-- PROCEDURES COMPRA --

CREATE PROCEDURE MILANESA.precioPasaje
(
	@vueloId int
)
AS
	SET NOCOUNT OFF;

	SELECT 
		r.rut_precio_base_pasaje * ts.tip_factor_precio
	FROM
		MILANESA.Vuelos v
		JOIN MILANESA.Rutas r 
			ON r.rut_id = v.ruta_id
		JOIN MILANESA.Aeronaves a
			ON a.aer_id = v.aeronave_id
		JOIN MILANESA.Tipos_Servicio ts
			ON ts.tip_id = a.tipo_servicio_id
	WHERE
		v.vue_id = @vueloId
GO

CREATE PROCEDURE MILANESA.precioPaquete
(
	@vueloId int,
	@peso int
)
AS
	SET NOCOUNT OFF;

	SELECT 
		r.rut_precio_base_kg * @peso
	FROM
		MILANESA.Vuelos v
		JOIN MILANESA.Rutas r 
			ON r.rut_id = v.ruta_id
	WHERE
		v.vue_id = @vueloId
GO

CREATE PROCEDURE MILANESA.generarVenta
(
	@vueloId int,
	@clienteId int,
	@pagoTarjetaId int
)
AS
	SET NOCOUNT OFF;

	INSERT INTO MILANESA.Ventas (comprador_id, vuelo_id, pago_tarjeta_id, ven_fecha, ven_activo)
		VALUES(@clienteId, @vueloId, @pagoTarjetaId, SYSDATETIME(), 1)

	SELECT SCOPE_IDENTITY()
GO

CREATE PROCEDURE MILANESA.generarPasaje
(
	@ventaId int,
	@clienteId int,
	@butacaId int,
	@precio decimal(18,2)
)
AS
	SET NOCOUNT OFF;
	DECLARE @codigoPasaje numeric(18,0)

	SELECT @codigoPasaje = max(paq_codigo) + 1 FROM MILANESA.Paquetes

	INSERT INTO MILANESA.Pasajes (pasajero_id, venta_id, butaca_id, pas_precio, pas_codigo, pas_activo)
		VALUES(@clienteId, @ventaId, @butacaId, @precio, @codigoPasaje, 1)
	
	SELECT @codigoPasaje
GO

CREATE PROCEDURE MILANESA.generarPaquete
(
	@ventaId int,
	@clienteId int,
	@peso int,
	@precio decimal(18,2)
)
AS
	SET NOCOUNT OFF;
	DECLARE @codigoPaquete numeric(18,0)

	SELECT @codigoPaquete = max(paq_codigo) + 1 FROM MILANESA.Paquetes

	INSERT INTO MILANESA.Paquetes(venta_id, cliente_id, paq_kg, paq_precio, paq_codigo, paq_activo)
		VALUES(@ventaId, @clienteId, @peso, @precio, @codigoPaquete, 1)

	SELECT @codigoPaquete
GO

CREATE PROCEDURE MILANESA.pagoTarjeta
(
	@numeroTarjeta numeric(18,0),
	@tarjetaId int,
	@codigoSeguridad int,
	@añoVencimiento int,
	@mesVencimiento int,
	@cantidadCuotas int
)
AS
	SET NOCOUNT OFF;

	--Acá el sistema debe encargarse de realizar la compra con tarjeta usando

	INSERT INTO MILANESA.Pagos_Tarjeta(pat_numero_tarjeta, tarjeta_credito_id)
		VALUES(@numeroTarjeta, @tarjetaId)

	SELECT SCOPE_IDENTITY();
GO