USE [GD2C2015]
GO

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