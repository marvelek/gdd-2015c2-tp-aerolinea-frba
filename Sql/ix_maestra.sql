USE [GD2C2015]
GO

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
