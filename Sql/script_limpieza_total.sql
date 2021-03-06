USE [GD2C2015]
GO

/*Drop Tables*/
BEGIN
	DROP TABLE MILANESA.Funciones_Roles
	DROP TABLE MILANESA.Funciones
	DROP TABLE MILANESA.Millas
	DROP TABLE MILANESA.Paquetes
	DROP TABLE MILANESA.Pasajes
	DROP TABLE MILANESA.Ventas
	DROP TABLE MILANESA.Pagos_Tarjeta
	DROP TABLE MILANESA.Tarjetas_Credito
	DROP TABLE MILANESA.Canjes
	DROP TABLE MILANESA.Productos
	DROP TABLE MILANESA.Usuarios
	DROP TABLE MILANESA.Roles
	DROP TABLE MILANESA.Devoluciones
	DROP TABLE MILANESA.Clientes
	DROP TABLE MILANESA.Tipos_Servicio_Rutas
	DROP TABLE MILANESA.Vuelos
	DROP TABLE MILANESA.Rutas
	DROP TABLE MILANESA.Arribos
	DROP TABLE MILANESA.Ciudades
	DROP TABLE MILANESA.Periodos_Fuera_Servicio
	DROP TABLE MILANESA.Butacas
	DROP TABLE MILANESA.Aeronaves
	DROP TABLE MILANESA.Tipos_Servicio
	DROP TABLE MILANESA.Estados_Arribos
END

/*Drop Indices de Maestra*/
BEGIN
	DROP INDEX [ix_maestra_ruta] ON [gd_esquema].[Maestra] 
	DROP INDEX [ix_maestra_venta] ON [gd_esquema].[Maestra] 
	DROP INDEX [ix_maestra_pasaje_codigo] ON [gd_esquema].[Maestra]
	DROP INDEX [ix_maestra_pasaje_fecha] ON [gd_esquema].[Maestra]
	DROP INDEX [ix_maestra_pasaje_butacas] ON [gd_esquema].[Maestra] 
	DROP INDEX [ix_maestra_paquete] ON [gd_esquema].[Maestra] 
	DROP INDEX [ix_maestra_paquete_fecha] ON [gd_esquema].[Maestra]
END

/*Drop Stored Procedures*/
BEGIN
	DROP PROCEDURE MILANESA.sp_migracion_datos
	DROP PROCEDURE MILANESA.sp_migracion_clientes
	DROP PROCEDURE MILANESA.sp_migracion_ciudades
	DROP PROCEDURE MILANESA.sp_migracion_tipos_servicio
	DROP PROCEDURE MILANESA.sp_migracion_aeronaves
	DROP PROCEDURE MILANESA.sp_migracion_butacas
	DROP PROCEDURE MILANESA.sp_migracion_rutas
	DROP PROCEDURE MILANESA.sp_migracion_vuelos
	DROP PROCEDURE MILANESA.sp_migracion_ventas
	DROP PROCEDURE MILANESA.sp_migracion_pasajes
	DROP PROCEDURE MILANESA.sp_migracion_paquetes
	DROP PROCEDURE MILANESA.rolBajaLogica
	DROP PROCEDURE MILANESA.funcionesRolesBorrar
	DROP PROCEDURE MILANESA.rolBuscar
	DROP PROCEDURE MILANESA.rolInsertar
	DROP PROCEDURE MILANESA.funcionesRolesInsertar
	DROP PROCEDURE MILANESA.rolModificar
	DROP PROCEDURE [MILANESA].[paqueteBajaPorVenta]
	DROP PROCEDURE [MILANESA].[pasajeBajaPorVenta]
	DROP PROCEDURE [MILANESA].[ventaBajaPorVuelo]
	DROP PROCEDURE [MILANESA].[vueloBajaPorRuta]
	DROP PROCEDURE [MILANESA].[rutaBajaLogica]
	DROP PROCEDURE [MILANESA].[rutaBuscar]
	DROP PROCEDURE [MILANESA].[rutaInsertar]
	DROP PROCEDURE [MILANESA].[rutaModificar]
	DROP PROCEDURE [MILANESA].[tipo_Servicio_RutaInsertar]
	DROP PROCEDURE [MILANESA].[tipos_Servicio_RutasBorrar]
	DROP PROCEDURE [MILANESA].[vuelos_disponibles]
	DROP PROCEDURE [MILANESA].[arribosInsertar]
	DROP PROCEDURE [MILANESA].[acreditarMillas]
	DROP PROCEDURE [MILANESA].[acreditarMillasCliente]
	DROP PROCEDURE [MILANESA].[historialMillas]
	DROP PROCEDURE [MILANESA].[devolucionInsertar]
	DROP PROCEDURE [MILANESA].[millasDisponibles]
	DROP PROCEDURE [MILANESA].[debitoMillas]
	DROP PROCEDURE [MILANESA].[canjearProducto]
	DROP PROCEDURE [MILANESA].[estadisticaDestinosPasajes]
	DROP PROCEDURE [MILANESA].[estadisticaDestinosButacas]
	DROP PROCEDURE [MILANESA].[estadisticaDestinosCancelados]
	DROP PROCEDURE [MILANESA].[estadisticaAeronavesFueraDeServicio]
	DROP PROCEDURE [MILANESA].[estadisticaClientesMillas]
	DROP PROCEDURE MILANESA.ButacasInsert
	DROP PROCEDURE MILANESA.AeronavesBuscar
	DROP PROCEDURE MILANESA.AeronavesInsert
	DROP PROCEDURE MILANESA.precioPasaje
	DROP PROCEDURE MILANESA.precioPaquete
	DROP PROCEDURE MILANESA.generarVenta 
	DROP PROCEDURE MILANESA.generarPasaje
	DROP PROCEDURE MILANESA.generarPaquete
	DROP PROCEDURE MILANESA.pagoTarjeta
	DROP PROCEDURE MILANESA.AeronavesBajaDefinitiva
	DROP PROCEDURE MILANESA.AeronavesIniciarFueraDeServicio
	DROP PROCEDURE MILANESA.AeronavesFueraServicioActualmente
	DROP PROCEDURE MILANESA.VuelossFuturosByAer
	DROP PROCEDURE MILANESA.VuelossFuturosByAerFS
	DROP PROCEDURE [MILANESA].[AeronavesBuscarMany]
	DROP PROCEDURE [MILANESA].[AeronavesCancelacionBajaFS]
	DROP PROCEDURE [MILANESA].[AeronavesCancelacionBajaDef]
	DROP PROCEDURE [MILANESA].[AeronavesReemplazo]
	DROP PROCEDURE [MILANESA].[AeronavesReemplazoDef]
	DROP PROCEDURE [MILANESA].[AeronavesReemplazoFS]
	DROP PROCEDURE [MILANESA].[AeronavesReemplazoVueloYButacas]
	DROP PROCEDURE [MILANESA].[pasajesReemplazoButaca]
	DROP PROCEDURE MILANESA.pasajeBuscar
	DROP PROCEDURE MILANESA.paqueteBuscar
	DROP PROCEDURE MILANESA.VentaBuscar
	DROP PROCEDURE MILANESA.devolucionEfectivo
	DROP PROCEDURE MILANESA.devolucionTarjeta
	DROP PROCEDURE MILANESA.devolucionPorVenta
	DROP PROCEDURE MILANESA.ventaCancelacion
	DROP PROCEDURE MILANESA.devolucionBusca
	DROP PROCEDURE MILANESA.paqueteCancelacion
	DROP PROCEDURE MILANESA.pasajeCancelacion
	DROP PROCEDURE [MILANESA].[aeronavesDisponiblesEnFechas]
	DROP PROCEDURE MILANESA.clienteDisponibleParaVuelo
	DROP PROCEDURE MILANESA.rutasRepetidas
	DROP PROCEDURE MILANESA.rutasRepetidasUpdate
END

/* Drop Schema*/
BEGIN
	DROP SCHEMA MILANESA;
END
