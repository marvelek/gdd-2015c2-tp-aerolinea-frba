USE [GD2C2015]
GO

/* Drop Indices de Maestra */
IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_ruta')
	DROP INDEX ix_maestra_ruta ON gd_esquema.Maestra
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_venta')
	DROP INDEX ix_maestra_venta ON gd_esquema.Maestra
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_pasaje_codigo')
	DROP INDEX ix_maestra_pasaje_codigo ON gd_esquema.Maestra
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_pasaje_fecha')
	DROP INDEX ix_maestra_pasaje_fecha ON gd_esquema.Maestra
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_pasaje_butacas')
	DROP INDEX ix_maestra_pasaje_butacas ON gd_esquema.Maestra
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_paquete')
	DROP INDEX ix_maestra_paquete ON gd_esquema.Maestra
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_paquete_fecha')
	DROP INDEX ix_maestra_paquete_fecha ON gd_esquema.Maestra
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

CREATE NONCLUSTERED INDEX [ix_maestra_paquete_fecha]
ON [gd_esquema].[Maestra] ([FechaSalida],[Fecha_LLegada_Estimada],[FechaLLegada])
INCLUDE ([Cli_Nombre],[Cli_Apellido],[Cli_Dni],[Cli_Fecha_Nac],[Paquete_Codigo],[Paquete_Precio],[Paquete_KG],[Paquete_FechaCompra],[Ruta_Codigo],[Ruta_Ciudad_Origen],[Ruta_Ciudad_Destino],[Aeronave_Matricula],[Tipo_Servicio])
GO


-- CREACION SCHEMA -----------------------------------------------------

IF NOT EXISTS (
    SELECT schema_name 
    FROM information_schema.schemata 
    WHERE schema_name = 'MILANESA' 
    )

BEGIN
    EXEC ('CREATE SCHEMA MILANESA');
END

/*Drop Tables*/
IF OBJECT_ID('MILANESA.Funciones_Roles') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Funciones_Roles
END;

IF OBJECT_ID('MILANESA.Funciones') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Funciones
END;

IF OBJECT_ID('MILANESA.Millas') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Millas
END;

IF OBJECT_ID('MILANESA.Paquetes') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Paquetes
END;

IF OBJECT_ID('MILANESA.Pasajes') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Pasajes
END;

IF OBJECT_ID('MILANESA.Ventas') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Ventas
END;

IF OBJECT_ID('MILANESA.Pagos_Tarjeta') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Pagos_Tarjeta
END;

IF OBJECT_ID('MILANESA.Tarjetas_Credito') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Tarjetas_Credito
END;

IF OBJECT_ID('MILANESA.Canjes') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Canjes
END;

IF OBJECT_ID('MILANESA.Productos') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Productos
END;

IF OBJECT_ID('MILANESA.Usuarios') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Usuarios
END;

IF OBJECT_ID('MILANESA.Roles') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Roles
END;

IF OBJECT_ID('MILANESA.Devoluciones') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Devoluciones
END;

IF OBJECT_ID('MILANESA.Clientes') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Clientes
END;

IF OBJECT_ID('MILANESA.Tipos_Servicio_Rutas') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Tipos_Servicio_Rutas
END;

IF OBJECT_ID('MILANESA.Vuelos') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Vuelos
END;

IF OBJECT_ID('MILANESA.Rutas') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Rutas
END;

IF OBJECT_ID('MILANESA.Arribos') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Arribos
END;

IF OBJECT_ID('MILANESA.Ciudades') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Ciudades
END;

IF OBJECT_ID('MILANESA.Periodos_Fuera_Servicio') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Periodos_Fuera_Servicio
END;

IF OBJECT_ID('MILANESA.Butacas') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Butacas
END;

IF OBJECT_ID('MILANESA.Aeronaves') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Aeronaves
END;

IF OBJECT_ID('MILANESA.Tipos_Servicio') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Tipos_Servicio
END;

IF OBJECT_ID('MILANESA.Estados_Arribos') IS NOT NULL
BEGIN
	DROP TABLE MILANESA.Estados_Arribos
END;

/*Drop Stored Procedures*/
IF OBJECT_ID('MILANESA.sp_migracion_datos') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.sp_migracion_datos
END;

IF OBJECT_ID('MILANESA.sp_migracion_clientes') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.sp_migracion_clientes
END;

IF OBJECT_ID('MILANESA.sp_migracion_ciudades') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.sp_migracion_ciudades
END;

IF OBJECT_ID('MILANESA.sp_migracion_tipos_servicio') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.sp_migracion_tipos_servicio
END;

IF OBJECT_ID('MILANESA.sp_migracion_aeronaves') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.sp_migracion_aeronaves
END;

IF OBJECT_ID('MILANESA.sp_migracion_butacas') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.sp_migracion_butacas
END;

IF OBJECT_ID('MILANESA.sp_migracion_rutas') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.sp_migracion_rutas
END;

IF OBJECT_ID('MILANESA.sp_migracion_vuelos') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.sp_migracion_vuelos
END;

IF OBJECT_ID('MILANESA.sp_migracion_ventas') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.sp_migracion_ventas
END;

IF OBJECT_ID('MILANESA.sp_migracion_pasajes') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.sp_migracion_pasajes
END;

IF OBJECT_ID('MILANESA.sp_migracion_paquetes') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.sp_migracion_paquetes
END;

IF OBJECT_ID('MILANESA.rolBajaLogica') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.rolBajaLogica
END;

IF OBJECT_ID('MILANESA.funcionesRolesBorrar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.funcionesRolesBorrar
END;

IF OBJECT_ID('MILANESA.rolBuscar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.rolBuscar
END;

IF OBJECT_ID('MILANESA.rolInsertar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.rolInsertar
END;

IF OBJECT_ID('MILANESA.funcionesRolesInsertar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.funcionesRolesInsertar
END;

IF OBJECT_ID('MILANESA.rolModificar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.rolModificar
END;

IF OBJECT_ID('MILANESA.paqueteBajaPorVenta') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.paqueteBajaPorVenta
END;

IF OBJECT_ID('MILANESA.pasajeBajaPorVenta') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.pasajeBajaPorVenta
END;

IF OBJECT_ID('MILANESA.ventaBajaPorVuelo') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.ventaBajaPorVuelo
END;

IF OBJECT_ID('MILANESA.vueloBajaPorRuta') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.vueloBajaPorRuta
END;

IF OBJECT_ID('MILANESA.rutaBajaLogica') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.rutaBajaLogica
END;

IF OBJECT_ID('MILANESA.rutaBuscar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.rutaBuscar
END;

IF OBJECT_ID('MILANESA.rutaInsertar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.rutaInsertar
END;

IF OBJECT_ID('MILANESA.rutaModificar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.rutaModificar
END;

IF OBJECT_ID('MILANESA.tipo_Servicio_RutaInsertar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.tipo_Servicio_RutaInsertar
END;

IF OBJECT_ID('MILANESA.tipos_Servicio_RutasBorrar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.tipos_Servicio_RutasBorrar
END;

IF OBJECT_ID('MILANESA.vuelos_disponibles') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.vuelos_disponibles
END;

IF OBJECT_ID('MILANESA.arribosInsertar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.arribosInsertar
END;

IF OBJECT_ID('MILANESA.acreditarMillas') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.acreditarMillas
END;

IF OBJECT_ID('MILANESA.acreditarMillasCliente') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.acreditarMillasCliente
END;

IF OBJECT_ID('MILANESA.historialMillas') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.historialMillas
END;

IF OBJECT_ID('MILANESA.devolucionInsertar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.devolucionInsertar
END;

IF OBJECT_ID('MILANESA.millasDisponibles') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.millasDisponibles
END;

IF OBJECT_ID('MILANESA.debitoMillas') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.debitoMillas
END;

IF OBJECT_ID('MILANESA.canjearProducto') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.canjearProducto
END;

IF OBJECT_ID('MILANESA.estadisticaDestinosPasajes') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.estadisticaDestinosPasajes
END;

IF OBJECT_ID('MILANESA.estadisticaDestinosButacas') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.estadisticaDestinosButacas
END;

IF OBJECT_ID('MILANESA.estadisticaDestinosCancelados') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.estadisticaDestinosCancelados
END;

IF OBJECT_ID('MILANESA.estadisticaAeronavesFueraDeServicio') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.estadisticaAeronavesFueraDeServicio
END;

IF OBJECT_ID('MILANESA.estadisticaClientesMillas') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.estadisticaClientesMillas
END;

IF OBJECT_ID('MILANESA.ButacasInsert') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.ButacasInsert
END;

IF OBJECT_ID('MILANESA.AeronavesBuscar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.AeronavesBuscar
END;

IF OBJECT_ID('MILANESA.AeronavesInsert') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.AeronavesInsert
END;

IF OBJECT_ID('MILANESA.precioPasaje') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.precioPasaje
END;

IF OBJECT_ID('MILANESA.precioPaquete') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.precioPaquete
END;

IF OBJECT_ID('MILANESA.generarVenta ') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.generarVenta 
END;

IF OBJECT_ID('MILANESA.generarPasaje') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.generarPasaje
END;

IF OBJECT_ID('MILANESA.generarPaquete') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.generarPaquete
END;

IF OBJECT_ID('MILANESA.pagoTarjeta') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.pagoTarjeta
END;

IF OBJECT_ID('MILANESA.AeronavesBajaDefinitiva') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.AeronavesBajaDefinitiva
END;

IF OBJECT_ID('MILANESA.AeronavesIniciarFueraDeServicio') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.AeronavesIniciarFueraDeServicio
END;

IF OBJECT_ID('MILANESA.AeronavesFueraServicioActualmente') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.AeronavesFueraServicioActualmente
END;

IF OBJECT_ID('MILANESA.VuelossFuturosByAer') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.VuelossFuturosByAer
END;

IF OBJECT_ID('MILANESA.VuelossFuturosByAerFS') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.VuelossFuturosByAerFS
END;

IF OBJECT_ID('MILANESA.AeronavesBuscarMany') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.AeronavesBuscarMany
END;

IF OBJECT_ID('MILANESA.AeronavesCancelacionBajaFS') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.AeronavesCancelacionBajaFS
END;

IF OBJECT_ID('MILANESA.AeronavesCancelacionBajaDef') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.AeronavesCancelacionBajaDef
END;

IF OBJECT_ID('MILANESA.AeronavesReemplazo') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.AeronavesReemplazo
END;

IF OBJECT_ID('MILANESA.AeronavesReemplazoDef') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.AeronavesReemplazoDef
END;

IF OBJECT_ID('MILANESA.AeronavesReemplazoFS') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.AeronavesReemplazoFS
END;

IF OBJECT_ID('MILANESA.AeronavesReemplazoVueloYButacas') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.AeronavesReemplazoVueloYButacas
END;

IF OBJECT_ID('MILANESA.pasajesReemplazoButaca') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.pasajesReemplazoButaca
END;

IF OBJECT_ID('MILANESA.pasajeBuscar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.pasajeBuscar
END;

IF OBJECT_ID('MILANESA.paqueteBuscar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.paqueteBuscar
END;

IF OBJECT_ID('MILANESA.VentaBuscar') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.VentaBuscar
END;

IF OBJECT_ID('MILANESA.devolucionEfectivo') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.devolucionEfectivo
END;

IF OBJECT_ID('MILANESA.devolucionTarjeta') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.devolucionTarjeta
END;

IF OBJECT_ID('MILANESA.devolucionPorVenta') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.devolucionPorVenta
END;

IF OBJECT_ID('MILANESA.ventaCancelacion') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.ventaCancelacion
END;

IF OBJECT_ID('MILANESA.devolucionBusca') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.devolucionBusca
END;

IF OBJECT_ID('MILANESA.paqueteCancelacion') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.paqueteCancelacion
END;

IF OBJECT_ID('MILANESA.pasajeCancelacion') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.pasajeCancelacion
END;

IF OBJECT_ID('MILANESA.aeronavesDisponiblesEnFechas') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.aeronavesDisponiblesEnFechas
END;

IF OBJECT_ID('MILANESA.clienteDisponibleParaVuelo') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.clienteDisponibleParaVuelo
END;

IF OBJECT_ID('MILANESA.rutasRepetidas') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.rutasRepetidas
END;

IF OBJECT_ID('MILANESA.rutasRepetidasUpdate') IS NOT NULL
BEGIN
	DROP PROCEDURE MILANESA.rutasRepetidasUpdate
END;

/*Roles*/
CREATE TABLE MILANESA.Roles (
	rol_id int identity(1,1) Primary Key,
	rol_descripcion nvarchar(255)	NOT NULL,
	rol_activo bit NOT NULL DEFAULT 1
)
GO

/*Funciones*/
CREATE TABLE MILANESA.Funciones (
	fun_id int identity(1,1) Primary Key,
	fun_descripcion nvarchar(255)	NOT NULL,
	fun_activo bit NOT NULL DEFAULT 1
)
GO

/*Funciones_Roles*/
CREATE TABLE MILANESA.Funciones_Roles (
	funcion_id int REFERENCES MILANESA.Funciones,
	rol_id int REFERENCES MILANESA.Roles,
	Primary Key (funcion_id, rol_id)
)
GO

/*Usuarios*/
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
CREATE TABLE MILANESA.Productos (
	pro_id int identity(1,1) Primary Key,
	pro_descripcion nvarchar(255) NOT NULL,
	pro_cantidad_millas numeric(18,0) NOT NULL,
	pro_stock numeric(18,0) NOT NULL,
	pro_activo bit NOT NULL DEFAULT 1
)
GO

/*Clientes*/
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
CREATE TABLE MILANESA.Canjes (
	can_id int identity(1,1) Primary Key,
	cliente_id int REFERENCES MILANESA.Clientes NOT NULL,
	producto_id int REFERENCES MILANESA.Productos,
	can_cantidad numeric(18,0) NOT NULL,
	can_fecha datetime
)
GO

/*Millas*/
CREATE TABLE MILANESA.Millas (
	mil_id int identity(1,1) Primary Key,
	cliente_id int REFERENCES MILANESA.Clientes NOT NULL,
	mil_cantidad numeric(18,0) NOT NULL,
	mil_fecha_acreditacion datetime NOT NULL,
	mil_canjeadas numeric(18,0) NOT NULL DEFAULT 0,
)
GO
	
/*Devoluciones*/
CREATE TABLE MILANESA.Devoluciones (
	dev_id int identity(1,1) Primary Key,
	dev_motivo nvarchar(255) NOT NULL,
	dev_fecha datetime NOT NULL
)
GO

/*Ciudades*/
CREATE TABLE MILANESA.Ciudades (
	ciu_id int identity(1,1) Primary Key,
	ciu_descripcion nvarchar(255) NOT NULL,
	ciu_activo bit NOT NULL DEFAULT 1
)
GO

/*Tipos_Servicio*/
CREATE TABLE MILANESA.Tipos_Servicio (
	tip_id int identity(1,1) Primary Key,
	tip_descripcion nvarchar(255) NOT NULL,
	tip_factor_precio numeric(18,2) DEFAULT 1,
	tip_activo bit NOT NULL DEFAULT 1
)
GO

/*Rutas*/
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
CREATE TABLE MILANESA.Pagos_Tarjeta (
	pat_id int identity(1,1) Primary Key,
	pat_numero_tarjeta numeric(12,0),
	tarjeta_credito_id int REFERENCES MILANESA.Tarjetas_Credito
)
GO

/*Ventas*/
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
CREATE TABLE MILANESA.Periodos_Fuera_Servicio (
	pfs_id int identity(1,1) Primary Key,
	aeronave_id int REFERENCES MILANESA.Aeronaves NOT NULL,
	pfs_motivo nvarchar(255) NOT NULL,
	pfs_fecha_inicio datetime NOT NULL,
	pfs_fecha_fin datetime
)
GO

/*Tipos_Servicio_Rutas*/
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


--Vuelos -> ruta
USE [GD2C2015]
GO
CREATE NONCLUSTERED INDEX ix_vuelos_ruta
ON [MILANESA].[Vuelos] ([ruta_id])

GO

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
	 
	 
SELECT SCOPE_IDENTITY()
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
	 
	 
SET @dev_id = SCOPE_IDENTITY()
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

CREATE PROCEDURE [MILANESA].[devolucionEfectivo]
(
	@devolucion int,
	@mailCliente nvarchar(255)
)
AS
	SET NOCOUNT OFF;

	/* Acá se devolverá al cliente el dinero en efectivo y se le avisará por mail*/
GO

CREATE PROCEDURE [MILANESA].[devolucionTarjeta]
(
	@devolucion int,
	@pago_tarjeta_id int
)
AS
	SET NOCOUNT OFF;

	/* Acá se devolverá al cliente el importe realizado con la tarjeta*/

GO

CREATE PROCEDURE [MILANESA].[devolucionPorVenta]
(
	@venta_id int,
	@devolucion int
)
AS	
	SET NOCOUNT OFF;
	DECLARE @pago_tarjeta_id int, @mailCliente nvarchar(255)	

	SELECT @pago_tarjeta_id	= ve.pago_tarjeta_id, @mailCliente = cl.cli_mail
	FROM  MILANESA.Ventas ve
	JOIN MILANESA.Clientes cl on cl.cli_id = comprador_id
	WHERE (ven_id = @venta_id);

	IF @pago_tarjeta_id is null
	BEGIN
		EXEC MILANESA.devolucionEfectivo @devolucion, @mailCliente;
	END
	ELSE
	BEGIN
		EXEC MILANESA.devolucionTarjeta @devolucion, @pago_tarjeta_id;
	END
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
			EXEC MILANESA.devolucionPorVenta @venta, @devolucion_id;

			UPDATE       MILANESA.Ventas
			SET          ven_activo = 'false'
			WHERE        ven_id = @venta;

			FETCH ventas INTO @venta 
		END -- Fin del bucle WHILE	
	CLOSE ventas
	DEALLOCATE ventas

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
	@rut_precio_base_kg numeric(18, 2),
	@rut_precio_base_pasaje numeric(18, 2)
)
AS
	SET NOCOUNT OFF;

DECLARE 	@rut_codigo numeric(18, 0)

SELECT @rut_codigo = max(rut_codigo) + 1 FROM MILANESA.Rutas

INSERT INTO [MILANESA].[Rutas] (ciudad_origen_id, ciudad_destino_id, rut_codigo, rut_precio_base_kg, rut_precio_base_pasaje, rut_activo) 
VALUES (@ciudad_origen_id, @ciudad_destino_id, @rut_codigo, @rut_precio_base_kg, @rut_precio_base_pasaje, 'true')

SELECT @@IDENTITY
GO

CREATE PROCEDURE [MILANESA].[rutaModificar]
(
	@ciudad_destino_id int,
	@ciudad_origen_id int,	
	@rut_precio_base_kg numeric(18, 2),
	@rut_precio_base_pasaje numeric(18, 2),
	@rut_activo bit,
	@Original_rut_id int
)
AS
	SET NOCOUNT OFF;
UPDATE [MILANESA].[Rutas] SET [ciudad_origen_id] = @ciudad_origen_id, [ciudad_destino_id] = @ciudad_destino_id, [rut_precio_base_kg] = @rut_precio_base_kg, [rut_precio_base_pasaje] = @rut_precio_base_pasaje, [rut_activo] = @rut_activo WHERE (([rut_id] = @Original_rut_id))
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

CREATE PROCEDURE [MILANESA].[clienteDisponibleParaVuelo]
(
	@clienteId int,
	@vueloId int
)
AS
	SET NOCOUNT OFF;

SELECT
	c.cli_id
FROM
	MILANESA.Clientes c
WHERE
	c.cli_activo = 1 AND
	c.cli_id = @clienteId AND
	NOT EXISTS (
				SELECT 1 
				FROM 
					MILANESA.Pasajes p
					join MILANESA.Ventas v on p.venta_id = v.ven_id AND v.ven_activo = 1
					join MILANESA.Vuelos vu on v.vuelo_id = vu.vue_id AND vu.vue_activo = 1,
					MILANESA.Vuelos vu2
				WHERE p.pasajero_id = c.cli_id AND
				(vu2.vue_fecha_salida BETWEEN vu.vue_fecha_salida and vu.vue_fecha_llegada_estimada OR
				vu2.vue_fecha_llegada_estimada BETWEEN vu.vue_fecha_salida and vu.vue_fecha_llegada_estimada) AND
				vu2.vue_activo = 1 AND
				vu2.vue_id = @vueloId)

GO

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
	(select isnull(sum(p.paq_kg),0) from MILANESA.Ventas v1 
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
	 
	 
SELECT SCOPE_IDENTITY()
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
		SELECT QUERY.cli_id, ISNULL(SUM(QUERY.pesos_gastados),0)
		FROM
			(SELECT
				C.cli_id,
				ISNULL(SUM(P.pas_precio),0) as pesos_gastados
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
				ISNULL(SUM(P.paq_precio), 0) as pesos_gastados
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
		ciu_id,
		ciu_descripcion,
		sum(cantidad_butacas - butacas_ocupadas ) as BUTACAS_DISPONIBLES
	FROM
		(SELECT 
			cd.ciu_id,
			cd.ciu_descripcion,
			vu.aeronave_id,
			vu.vue_id,
			(select count(but.but_id) 
			from Milanesa.Aeronaves a
			join MILANESA.Butacas but ON but.aeronave_id = a.aer_id
			 where a.aer_id = vu.aeronave_id) as cantidad_butacas,
			 (select count(1) 
			 from  MILANESA.Ventas ve2 
			 JOIN MILANESA.Pasajes pa on venta_id = ve2.ven_id and devolucion_id is null
			where ve2.vuelo_id = vu.vue_id ) as butacas_ocupadas			
		FROM MILANESA.Rutas ru
		JOIN MILANESA.Ciudades cd on cd.ciu_id = ru.ciudad_destino_id
		JOIN MILANESA.Vuelos vu on vu.ruta_id = ru.rut_id		
		where YEAR(vu.vue_fecha_llegada) = 2016 and MONTH(vu.vue_fecha_llegada) between 1 and 6) as tablaAux
		group by 
			ciu_id,
			ciu_descripcion
		order by BUTACAS_DISPONIBLES DESC;
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
		SUM(DATEDIFF(MINUTE, fs.pfs_fecha_inicio, fs.pfs_fecha_fin)) as días
	FROM [MILANESA].[Aeronaves]
	JOIN [MILANESA].[Periodos_Fuera_Servicio] fs on fs.aeronave_id = aer_id and YEAR(fs.pfs_fecha_inicio) = @año and MONTH(fs.pfs_fecha_inicio) between @mes1 and @mes2
	--where YEAR(aer_fecha_fuera_servicio) = @año and MONTH(aer_fecha_fuera_servicio) between @mes1 and @mes2
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
(
	@año int,
	@mes1 int,
	@mes2 int
)
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
		isnull(sum(mi.mil_cantidad-mi.mil_canjeadas),0) as Puntos
	FROM MILANESA.Clientes cl
	JOIN MILANESA.Millas mi on  mi.cliente_id = cl.cli_id
	WHERE YEAR(mi.mil_fecha_acreditacion) = @año and MONTH(mi.mil_fecha_acreditacion) between @mes1 and @mes2 AND
	DATEDIFF(day, SYSDATETIME(), mi.mil_fecha_acreditacion) < 365
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


-- AERONAVES --LUCAS

CREATE PROCEDURE [MILANESA].[AeronavesDisponiblesEnFechas]
(
	@fechaSalida datetime,
	@fechaLlegada datetime,
	@aeronaveId int
)
AS
	SET NOCOUNT OFF;
SELECT
	a.aer_matricula
FROM
	MILANESA.Aeronaves a
WHERE
	a.aer_activo = 1 AND
	a.aer_id = @aeronaveId AND
	(a.aer_fecha_fuera_servicio IS NULL OR a.aer_fecha_reinicio_servicio < @fechaSalida)  AND
	NOT EXISTS (SELECT 1 FROM MILANESA.Vuelos v 
				WHERE a.aer_id = v.aeronave_id AND
				(@fechaSalida BETWEEN v.vue_fecha_salida and v.vue_fecha_llegada_estimada OR
				@fechaLlegada BETWEEN v.vue_fecha_salida and v.vue_fecha_llegada_estimada) AND
				v.vue_activo = 1)
GROUP by a.aer_matricula

GO

CREATE PROCEDURE [MILANESA].[AeronavesBajaDefinitiva]
(
	@aer_id int
)
AS
	SET NOCOUNT ON;
update MILANESA.Aeronaves
set aer_activo = 0, aer_fecha_baja_definitiva = SYSDATETIME()
WHERE aer_id = @aer_id
GO


CREATE PROCEDURE [MILANESA].[AeronavesReemplazo](
@aer_id int,
@fechaHasta datetime
)
AS
SET NOCOUNT ON;

--devuelve las aeronaves que..
select a1.* from MILANESA.aeronaves A
--tengan el mismo tipo de servicio y fabricante
JOIN MILANESA.AERONAVES A1 ON A1.tipo_servicio_id = A.tipo_servicio_id AND a1.aer_fabricante = a.aer_fabricante 
-- ID distinto a la Nave a reemplazar y este activa. 
and a1.aer_id != a.aer_id
and a1.aer_activo = 1
--Tenga igual o + KG, butacas ventana y pasillo
and a.aer_kg_disponibles <= a1.aer_kg_disponibles
and (SELECT count(1) FROM MILANESA.Butacas WHERE aeronave_id = a.aer_id AND BUT_TIPO = 'Ventanilla') <= (SELECT count(1) FROM MILANESA.Butacas WHERE aeronave_id = a1.aer_id AND BUT_TIPO = 'Ventanilla')
and (SELECT count(1) FROM MILANESA.Butacas WHERE aeronave_id = a.aer_id AND BUT_TIPO = 'Pasillo') <= (SELECT count(1) FROM MILANESA.Butacas WHERE aeronave_id = a1.aer_id AND BUT_TIPO = 'Pasillo')
--Que no este fuera de servicio desde la fecha del primer vuelo activo con ventas de la aeronave a reemplazar
and 
(   (a1.aer_fecha_reinicio_servicio is null) or 
	(a1.aer_fecha_reinicio_servicio < 
			(select MIN(vue.vue_fecha_salida) from MILANESA.Vuelos vue 
			where vue.aeronave_id = a.aer_id and vue.vue_fecha_salida > SYSDATETIME() 
				and vue.vue_activo = 1
				and exists (
				select 1 from MILANESA.Ventas t where t.ven_activo = 1 and t.vuelo_id = vue.vue_id)
				)
	)
)
-- que no exista un solapamiento de fechas entre los vuelos de la aeronave a reemplazar con ventas activas y la reemplazante
and not exists (
	select 1 from MILANESA.VUELOS v where v.VUE_ACTIVO = 1 AND v.vue_fecha_salida >= GETDATE() AND (@fechaHasta = null OR v.vue_fecha_salida <= @fechaHasta)
	AND v.AERONAVE_id = a1.aer_id
	and exists (
		select 1 from MILANESA.Vuelos v1 
		where ((v.vue_fecha_salida between v1.vue_fecha_salida and v1.vue_fecha_llegada_estimada) OR (
		v.vue_fecha_llegada between v1.vue_fecha_salida and v1.vue_fecha_llegada_estimada))
		AND (@fechaHasta = null OR v1.vue_fecha_salida <= @fechaHasta)
		and v1.aeronave_id = a.aer_id
		and v1.VUE_ACTIVO = 1 AND v1.vue_fecha_salida >= GETDATE()
		and exists (
			select 1 from MILANESA.Ventas where ven_activo = 1 and vuelo_id = v1.vue_id
		)
	)
)
where a.AER_ID = @aer_id;
GO

CREATE PROCEDURE [MILANESA].[AeronavesIniciarFueraDeServicio]
(
	@aer_id int,
	@motivo nvarchar(255),
	@fechaHasta datetime

)
AS
SET NOCOUNT ON;
update MILANESA.Aeronaves
set aer_fecha_fuera_servicio = SYSDATETIME(),
aer_fecha_reinicio_servicio = @fechaHasta
WHERE aer_id = @aer_id;
Insert into MILANESA.Periodos_Fuera_Servicio (aeronave_id, pfs_motivo, pfs_fecha_inicio, pfs_fecha_fin) values (
@aer_id, @motivo, SYSDATETIME(), @fechaHasta)
GO


CREATE PROCEDURE [MILANESA].[AeronavesCancelacionBajaFS]
(
	@aer_id int,
	@motivo nvarchar(255),
	@fechaHasta dateTime
)
AS	
	DECLARE @vuelo int, @devolucion int, @fecha datetime
	SET @fecha = SYSDATETIME()
	EXEC @devolucion = MILANESA.devolucionInsertar @motivo,@fecha
	SET NOCOUNT OFF;
	DECLARE vuelos CURSOR 
	FOR 
--FUTUROS VUELOS ENTRE FECHAS DE FS CON VENTAS
select v.vue_id from MILANESA.VUELOS v where VUE_ACTIVO = 1 AND vue_fecha_salida BETWEEN GETDATE() AND @fechaHasta
AND v.AERONAVE_id = @aer_id;
	OPEN vuelos
	FETCH vuelos INTO @vuelo 

		WHILE (@@FETCH_STATUS = 0)

		BEGIN	
			EXEC MILANESA.ventaBajaPorVuelo @vuelo,@devolucion;
			UPDATE MILANESA.Vuelos SET  vue_activo = 'false'
				WHERE vue_id = @vuelo;
			FETCH vuelos INTO @vuelo 
		END -- Fin del bucle WHILE	
	CLOSE vuelos
	DEALLOCATE vuelos
	EXEC MILANESA.AeronavesIniciarFueraDeServicio @aer_id,@motivo,@fechaHasta;	
GO

CREATE PROCEDURE [MILANESA].[AeronavesCancelacionBajaDef]
(
	@aer_id int
)
AS	
	DECLARE @vuelo int, @devolucion int, @motivo nvarchar(255), @fecha datetime
	SET @motivo = 'BAJA DE AERONAVE DEFINITIVA'
	SET @fecha = SYSDATETIME()
	EXEC @devolucion = MILANESA.devolucionInsertar @motivo,@fecha
	SET NOCOUNT OFF;
	DECLARE vuelos CURSOR 
	FOR 
	--FUTUROS VUELOS DE UNA AERONAVE CON VENTAS
	select v.vue_id from MILANESA.VUELOS v where v.VUE_ACTIVO = 1 AND v.vue_fecha_salida >= GETDATE()
	AND v.AERONAVE_id = @aer_id;
	OPEN vuelos
	FETCH vuelos INTO @vuelo 

		WHILE (@@FETCH_STATUS = 0)

		BEGIN	
			EXEC MILANESA.ventaBajaPorVuelo @vuelo,@devolucion;
			UPDATE MILANESA.Vuelos SET  vue_activo = 'false'
				WHERE vue_id = @vuelo;
			FETCH vuelos INTO @vuelo 
		END -- Fin del bucle WHILE	
	CLOSE vuelos
	DEALLOCATE vuelos
	EXEC MILANESA.AeronavesBajaDefinitiva @aer_id;		
GO

 CREATE PROCEDURE [MILANESA].[pasajesReemplazoButaca]
(
	@vuelo int,
	@aer_id_reemplazo int
)
AS	
	DECLARE @pasaje int, @count int
	SET @count = 0;
	SET NOCOUNT OFF;
	DECLARE pasajes CURSOR 
	FOR 
 select p.pas_id from MILANESA.Pasajes p 
 join MILANESA.Ventas v ON v.ven_id = p.venta_id
 where p.pas_activo = 1 and v.vuelo_id = @vuelo;
	OPEN pasajes
	FETCH pasajes INTO @pasaje 

		WHILE (@@FETCH_STATUS = 0)
		BEGIN	
			
			UPDATE MILANESA.Pasajes set butaca_id = (SELECT but_id from MILANESA.Butacas b 
			                                         where b.aeronave_id = @aer_id_reemplazo 
													 and b.but_numero = @count) 
						             where pas_id = @pasaje;
            SET @count = @count+1;
			FETCH pasajes INTO @pasaje 
		END -- Fin del bucle WHILE	
	CLOSE pasajes
	DEALLOCATE pasajes
GO


 CREATE PROCEDURE [MILANESA].[AeronavesReemplazoVueloYButacas]
(
	@aer_id int,
	@aer_id_reemplazo int,
	@fechaHasta dateTime
)
AS	
	DECLARE @vuelo int, @fecha datetime
	SET @fecha = SYSDATETIME();
	SET NOCOUNT OFF;
	DECLARE vuelos CURSOR 
	FOR 
select vue_id from MILANESA.vuelos v where aeronave_id = @aer_id 
 and vue_fecha_salida between SYSDATETIME() and @fechaHasta and vue_activo = 1  
and exists (
select 1 from MILANESA.Ventas t where t.ven_activo = 1 and t.vuelo_id = v.vue_id
); 
	OPEN vuelos
	FETCH vuelos INTO @vuelo 

		WHILE (@@FETCH_STATUS = 0)
		BEGIN	
			EXEC MILANESA.pasajesReemplazoButaca @vuelo,@aer_id_reemplazo;
			UPDATE MILANESA.Vuelos SET  aeronave_id = @aer_id_reemplazo
				WHERE vue_id = @vuelo;
			FETCH vuelos INTO @vuelo 
		END -- Fin del bucle WHILE	
	CLOSE vuelos
	DEALLOCATE vuelos
GO

CREATE PROCEDURE [MILANESA].[AeronavesReemplazoDef]
(
	@aer_id int,
	@aer_id_reemplazo int,
	@fechaHasta dateTime
)
AS	
	DECLARE @vuelo int, @fecha datetime
	SET @fecha = SYSDATETIME();
	SET NOCOUNT OFF;
	EXEC MILANESA.AeronavesReemplazoVueloYButacas @aer_id,@aer_id_reemplazo,@fechaHasta;
	EXEC MILANESA.AeronavesBajaDefinitiva @aer_id;	
GO

 CREATE PROCEDURE [MILANESA].[AeronavesReemplazoFS]
(
	@aer_id int,
	@aer_id_reemplazo int,
	@motivo nvarchar(255),
	@fechaHasta dateTime
)
AS	
	DECLARE @vuelo int, @fecha datetime
	SET @fecha = SYSDATETIME();
	SET NOCOUNT OFF;
	EXEC MILANESA.AeronavesReemplazoVueloYButacas @aer_id,@aer_id_reemplazo,@fechaHasta;
	EXEC MILANESA.AeronavesIniciarFueraDeServicio @aer_id,@motivo,@fechaHasta;	
GO


CREATE PROCEDURE [MILANESA].[AeronavesBuscarMany]
(
@tipoServicioId nvarchar(255),
@modelo nvarchar(255),
@matricula nvarchar(255),
@fabricante nvarchar(255),
@precioKgDesde numeric(18,2),
@precioKgHasta numeric(18,2),
@activo Varchar(10)
)
AS
SET NOCOUNT ON;
select * from MILANESA.Aeronaves
WHERE 
((@tipoServicioId = '0') or (CAST(tipo_servicio_id as varchar(2)) LIKE '%' + @tipoServicioId + '%'))
AND (CAST(aer_matricula as varchar(255)) LIKE '%' + @matricula + '%')
AND (CAST(aer_modelo as varchar(255)) LIKE '%' + @modelo + '%')
AND (aer_fabricante LIKE '%' + @fabricante + '%')
AND (@precioKgDesde = 0 OR aer_kg_disponibles >= @precioKgDesde ) 
AND (@precioKgHasta = 0 OR aer_kg_disponibles <= @precioKgHasta )
AND ((@activo = 'TODOS') or (@activo = 'ACTIVO' AND aer_activo = 1) or (@activo = 'INACTIVO' and aer_activo = 0))    
GO



CREATE PROCEDURE [MILANESA].[VuelossFuturosByAer] (
 @aer_id int
)
AS
SET NOCOUNT ON;
--FUTUROS VUELOS DE UNA AERONAVE CON VENTAS
select * from MILANESA.VUELOS v where v.VUE_ACTIVO = 1 AND v.vue_fecha_salida >= GETDATE()
AND v.AERONAVE_id = @aer_id

GO

CREATE PROCEDURE [MILANESA].[VuelossFuturosByAerFS] (
 @aer_id int,
 @fechaHasta datetime
)
AS
SET NOCOUNT ON;
--FUTUROS VUELOS ENTRE FECHAS DE FS CON VENTAS
select * from MILANESA.VUELOS v where VUE_ACTIVO = 1 AND vue_fecha_salida BETWEEN GETDATE() AND @fechaHasta
AND v.AERONAVE_id = @aer_id
GO




CREATE PROCEDURE [MILANESA].[AeronavesFueraServicioActualmente] (
	 @aer_id int
)
AS
SET NOCOUNT ON;
	select * from MILANESA.Aeronaves 
	where aer_id = @aer_id 
	and aer_fecha_reinicio_servicio is not null 
	and aer_fecha_reinicio_servicio > SYSDATETIME()
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
	
	SELECT
		ISNULL(SUM(m.mil_cantidad - m.mil_canjeadas), 0)
	FROM
		MILANESA.Millas m
	WHERE
		m.cliente_id = @clienteId AND
		DATEDIFF(day, SYSDATETIME(), m.mil_fecha_acreditacion) < 365

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
	DECLARE @ResultSet table (retorno int)

	EXEC @millasDisponibles = MILANESA.millasDisponibles @clienteId
	INSERT INTO @ResultSet (retorno)
		EXEC MILANESA.millasDisponibles @clienteId
	SELECT @millasDisponibles = retorno FROM @ResultSet 
		
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

	SELECT @codigoPasaje = max(pas_codigo) + 1 FROM MILANESA.Pasajes

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

-- CONSTRAINTS --

-- Aeronaves
ALTER TABLE MILANESA.Aeronaves ADD CONSTRAINT uc_aeronaves_matricula UNIQUE (aer_matricula)

-- Butacas
ALTER TABLE MILANESA.Butacas ADD CONSTRAINT uc_butacas_aeronave_numero UNIQUE (aeronave_id, but_numero)

-- Ciudades
ALTER TABLE MILANESA.Ciudades ADD CONSTRAINT uc_ciudades_descripcion UNIQUE (ciu_descripcion)

-- Clientes
--ALTER TABLE MILANESA.Clientes ADD CONSTRAINT uc_clientes_nombre_apellido_dni UNIQUE (cli_nombre, cli_apellido, cli_dni)
--Se lo reemplaza por Trigger io_update e io_insert

-- Estados Arribos
ALTER TABLE MILANESA.Estados_Arribos ADD CONSTRAINT uc_estados_arribos_descripcion UNIQUE (ear_descripcion)

-- Funciones 
ALTER TABLE MILANESA.Funciones ADD CONSTRAINT uc_funciones_descripcion UNIQUE (fun_descripcion)

-- Paquetes
ALTER TABLE MILANESA.Paquetes ADD CONSTRAINT uc_paquetes_codigo UNIQUE (paq_codigo)

-- Pasajes
ALTER TABLE MILANESA.Pasajes ADD CONSTRAINT uc_pasajes_codigo UNIQUE (pas_codigo)

-- Productos
ALTER TABLE MILANESA.Productos ADD CONSTRAINT uc_productos_descripcion UNIQUE (pro_descripcion)

-- Roles
ALTER TABLE MILANESA.Roles ADD CONSTRAINT uc_roles_descripcion UNIQUE (rol_descripcion)

-- Rutas
--ALTER TABLE MILANESA.Rutas ADD CONSTRAINT uc_rutas_codigo UNIQUE (rut_codigo)
--Se lo reemplaza por Trigger io_update e io_insert
ALTER TABLE MILANESA.Rutas ADD CONSTRAINT uc_rutas_origen_destino UNIQUE (ciudad_origen_id, ciudad_destino_id)

-- Tarjetas Credito
ALTER TABLE MILANESA.Tarjetas_Credito ADD CONSTRAINT uc_tarjetas_credito_descripcion UNIQUE (tac_descripcion)

-- Tipos Servicio
ALTER TABLE MILANESA.Tipos_Servicio ADD CONSTRAINT uc_tipos_servicio_descripcion UNIQUE (tip_descripcion)

-- Usuarios
ALTER TABLE MILANESA.Usuarios ADD CONSTRAINT uc_usuarios_nombre UNIQUE (usu_nombre)
GO
--Triggers para validación de unique--

CREATE TRIGGER tr_clientes_io_insert ON MILANESA.Clientes
INSTEAD OF INSERT
AS
BEGIN
SET NOCOUNT ON
IF (NOT EXISTS (SELECT 1
      FROM MILANESA.Clientes C, inserted I
      WHERE c.cli_dni = i.cli_dni AND
			c.cli_nombre = i.cli_nombre AND
			c.cli_apellido = i.cli_apellido))
   INSERT INTO MILANESA.Clientes
      SELECT cli_nombre, cli_apellido, cli_dni, cli_direccion, cli_telefono, cli_mail, cli_fecha_nacimiento, cli_activo
      FROM inserted
ELSE
	THROW 60500,'El cliente ya existe', 1;
END

GO

CREATE TRIGGER tr_clientes_io_update ON MILANESA.Clientes
INSTEAD OF UPDATE
AS
BEGIN
SET NOCOUNT ON
IF (NOT EXISTS (SELECT 1
      FROM MILANESA.Clientes C, inserted I
      WHERE c.cli_dni = i.cli_dni AND
			c.cli_nombre = i.cli_nombre AND
			c.cli_apellido = i.cli_apellido AND
			c.cli_id <> i.cli_id))
	UPDATE MILANESA.Clientes 
	SET
		cli_nombre = i.cli_nombre,
		cli_apellido = i.cli_apellido,
		cli_dni = i.cli_dni,
		cli_direccion = i.cli_direccion,
		cli_telefono = i.cli_telefono,
		cli_mail = i.cli_mail,
		cli_fecha_nacimiento = i.cli_fecha_nacimiento,
		cli_activo = i.cli_activo
	FROM
		inserted I
	WHERE
		MILANESA.Clientes.cli_id = i.cli_id
ELSE
	THROW 60500,'El cliente ya existe', 1;
END

GO

CREATE TRIGGER tr_rutas_io_insert ON MILANESA.Rutas
INSTEAD OF INSERT
AS
BEGIN

DECLARE @rutaId int

SET NOCOUNT ON
IF (NOT EXISTS (SELECT 1
      FROM MILANESA.Rutas R, inserted I
      WHERE r.rut_codigo = i.rut_codigo))
   INSERT INTO MILANESA.Rutas
      SELECT ciudad_origen_id, ciudad_destino_id, rut_codigo, rut_precio_base_kg, rut_precio_base_pasaje, rut_activo
      FROM inserted
ELSE
	THROW 60501,'El código de ruta ya existe', 1;

	SET @rutaId = Scope_Identity()

	SELECT rut_id INTO #Trash FROM MILANESA.Rutas WHERE rut_id = @rutaId

END

GO

CREATE TRIGGER tr_rutas_io_update ON MILANESA.Rutas
INSTEAD OF UPDATE
AS
BEGIN
SET NOCOUNT ON
IF (NOT EXISTS (SELECT 1
      FROM MILANESA.Rutas R, inserted I
      WHERE r.rut_codigo = i.rut_codigo AND
	  r.rut_id <> i.rut_id))
   UPDATE MILANESA.Rutas
   SET
	ciudad_origen_id = i.ciudad_origen_id,
	ciudad_destino_id = i.ciudad_destino_id,
	rut_codigo = i.rut_codigo,
	rut_precio_base_kg = i.rut_precio_base_kg,
	rut_precio_base_pasaje = i.rut_precio_base_pasaje,
	rut_activo = i.rut_activo
   FROM inserted i
   WHERE MILANESA.Rutas.rut_id = i.rut_id
ELSE
	THROW 60501,'El código de ruta ya existe', 1;
END

GO

---------------------------------------------- CANCELACION/DEVOLUCION ---------------------------------------------

CREATE PROCEDURE [MILANESA].[pasajeBuscar]
(
	@codigo nvarchar(255)
)
AS
	SET NOCOUNT ON;
SELECT pas_id, pasajero_id, devolucion_id, venta_id, butaca_id, pas_codigo, pas_precio, pas_activo
FROM            MILANESA.Pasajes
WHERE         (CAST(pas_codigo as varchar(18)) = @codigo )
GO

CREATE PROCEDURE [MILANESA].[paqueteBuscar]
(
	@codigo nvarchar(255)
)
AS
	SET NOCOUNT ON;
SELECT paq_id, devolucion_id, venta_id, paq_codigo, paq_precio, paq_kg, paq_activo, cliente_id
FROM            MILANESA.Paquetes
WHERE        (CAST(paq_codigo as varchar(18)) =  @codigo )
GO

CREATE PROCEDURE [MILANESA].[VentaBuscar]
(
	@codigo nvarchar(255)
)
AS
	SET NOCOUNT ON;
SELECT ven_id, comprador_id, vuelo_id, pago_tarjeta_id, ven_fecha, ven_activo
FROM            MILANESA.Ventas
WHERE (CAST(ven_id as varchar(18)) =  @codigo)
GO

CREATE PROCEDURE [MILANESA].[ventaCancelacion]
(
	@venta_id int
)
AS	
	SET NOCOUNT OFF;	
	DECLARE @devolucion int, @motivo nvarchar(255), @fecha datetime, @pago_tarjeta_id int, @mailCliente nvarchar(255)
	SET @motivo = 'Cancelación de venta ' + CAST(@venta_id as varchar(18))
	SET @fecha = SYSDATETIME()
	EXEC @devolucion = MILANESA.devolucionInsertar @motivo, @fecha;
	EXEC MILANESA.pasajeBajaPorVenta @venta_id, @devolucion;
	EXEC MILANESA.paqueteBajaPorVenta @venta_id, @devolucion;
	EXEC MILANESa.devolucionPorVenta @venta_id, @devolucion;

UPDATE       MILANESA.Ventas
SET                ven_activo = 'false'
WHERE        (ven_id = @venta_id) and ven_activo = 1
GO


CREATE PROCEDURE [MILANESA].[devolucionBusca]
(
	@dev_id int
)
AS
SELECT dev_fecha, dev_motivo FROM [MILANESA].[Devoluciones]       
WHERE(dev_id = @dev_id)
GO


CREATE PROCEDURE [MILANESA].[paqueteCancelacion]
(
	@paquete_id int
)
AS	
	SET NOCOUNT OFF;	
	DECLARE @devolucion int, @motivo nvarchar(255), @fecha datetime, @paquete int, @venta_id int;
	SELECT @paquete = paq_codigo, @venta_id = venta_id FROM  MILANESA.Paquetes where (paq_id = @paquete_id) and paq_activo = 1;
	SET @motivo = 'Cancelación de paquete ' + CAST(@paquete as varchar(18))
	SET @fecha = SYSDATETIME()
	EXEC @devolucion = MILANESA.devolucionInsertar @motivo, @fecha;;
	EXEC MILANESa.devolucionPorVenta @venta_id, @devolucion;

UPDATE       MILANESA.Paquetes
SET                paq_activo = 'false', devolucion_id = @devolucion
WHERE        (paq_id = @paquete_id) and paq_activo = 1
GO

CREATE PROCEDURE [MILANESA].[pasajeCancelacion]
(
	@pasaje_id int
)
AS	
	SET NOCOUNT OFF;	
	DECLARE @devolucion int, @motivo nvarchar(255), @fecha datetime, @pasaje int, @venta_id int;
	SELECT @pasaje = pas_codigo, @venta_id = venta_id FROM  MILANESA.Pasajes where (pas_id = @pasaje_id) and pas_activo = 1;
	SET @motivo = 'Cancelación de paquete ' + CAST(@pasaje as varchar(18))
	SET @fecha = SYSDATETIME()
	EXEC @devolucion = MILANESA.devolucionInsertar @motivo, @fecha;;
	EXEC MILANESa.devolucionPorVenta @venta_id, @devolucion;

UPDATE       MILANESA.Pasajes
SET                pas_activo = 'false', devolucion_id = @devolucion
WHERE        (pas_id = @pasaje_id) and pas_activo = 1
GO

CREATE PROCEDURE [MILANESA].[rutasRepetidas]
AS
	SET NOCOUNT ON;
	select 
	ru.rut_id,
	ru.rut_codigo,
	ru.ciudad_origen_id,
	co.ciu_descripcion as ciudad_origen,
	ru.ciudad_destino_id,
	cd.ciu_descripcion as ciudad_destino,
	((select max(rut_codigo) FROM MILANESA.Rutas rut)+ROW_NUMBER() OVER(ORDER BY ru.rut_codigo DESC)) as codigo_nuevo 
	FROM MILANESA.Rutas ru
	JOIN [MILANESA].[Ciudades] co on co.ciu_id = ciudad_origen_id
	JOIN [MILANESA].[Ciudades] cd on cd.ciu_id = ciudad_destino_id
	where ru.rut_id in(SELECT max(ru.rut_id)--ru.rut_codigo
							FROM MILANESA.Rutas ru
							group by 
								ru.rut_codigo
							having count(*) > 1)

GO

CREATE PROCEDURE [MILANESA].[rutasRepetidasUpdate]
AS
	SET NOCOUNT ON;
	DECLARE @rutId int, @rutCodigo numeric(18,0)
	DECLARE rutasRepetidas CURSOR 
	FOR 
	Select ru.rut_id,((select max(rut_codigo) FROM MILANESA.Rutas rut)+ROW_NUMBER() OVER(ORDER BY ru.rut_codigo DESC)) as codigo_nuevo 
	FROM MILANESA.Rutas ru	
	where ru.rut_id in(SELECT max(ru.rut_id)
							FROM MILANESA.Rutas ru
							group by 
								ru.rut_codigo
							having count(*) > 1)
	OPEN rutasRepetidas
	FETCH next from rutasRepetidas INTO @rutId, @rutCodigo;
	WHILE (@@FETCH_STATUS = 0)
		BEGIN	
			UPDATE MILANESA.Rutas 
			SET rut_codigo= @rutCodigo
			WHERE rut_id= @rutId;
			FETCH next from rutasRepetidas INTO @rutId, @rutCodigo;
		END -- Fin del bucle WHILE	
	CLOSE rutasRepetidas
	DEALLOCATE rutasRepetidas
GO

	/* Drop Indices de Maestra */
IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_ruta')
	DROP INDEX ix_maestra_ruta ON gd_esquema.Maestra
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_venta')
	DROP INDEX ix_maestra_venta ON gd_esquema.Maestra
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_pasaje_codigo')
	DROP INDEX ix_maestra_pasaje_codigo ON gd_esquema.Maestra
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_pasaje_fecha')
	DROP INDEX ix_maestra_pasaje_fecha ON gd_esquema.Maestra
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_pasaje_butacas')
	DROP INDEX ix_maestra_pasaje_butacas ON gd_esquema.Maestra
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_paquete')
	DROP INDEX ix_maestra_paquete ON gd_esquema.Maestra
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.Maestra') AND NAME ='ix_maestra_paquete_fecha')
	DROP INDEX ix_maestra_paquete_fecha ON gd_esquema.Maestra
GO