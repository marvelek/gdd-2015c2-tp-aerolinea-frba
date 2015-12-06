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
	DROP PROCEDURE MILANESA.ButacasInsert
	DROP PROCEDURE MILANESA.AeronavesBuscar
	DROP PROCEDURE MILANESA.AeronavesInsert
END

/* Drop Schema*/
BEGIN
	DROP SCHEMA MILANESA;
END
