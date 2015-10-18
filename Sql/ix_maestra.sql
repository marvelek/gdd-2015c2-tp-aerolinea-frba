/****** Object:  Index [ix_maestra_aeronave]    Script Date: 18/10/2015 17:57:21 ******/
CREATE NONCLUSTERED INDEX [ix_maestra_aeronave] ON [gd_esquema].[Maestra]
(
	[Aeronave_Matricula] ASC,
	[Aeronave_Modelo] ASC,
	[Aeronave_KG_Disponibles] ASC,
	[Aeronave_Fabricante] ASC,
	[Tipo_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

SET ANSI_PADDING ON

GO

/****** Object:  Index [ix_maestra_butaca]    Script Date: 18/10/2015 17:57:21 ******/
CREATE NONCLUSTERED INDEX [ix_maestra_butaca] ON [gd_esquema].[Maestra]
(
	[Butaca_Nro] ASC,
	[Butaca_Tipo] ASC,
	[Butaca_Piso] ASC,
	[Aeronave_Matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

SET ANSI_PADDING ON

GO

/****** Object:  Index [ix_maestra_clientes]    Script Date: 18/10/2015 17:57:21 ******/
CREATE NONCLUSTERED INDEX [ix_maestra_clientes] ON [gd_esquema].[Maestra]
(
	[Cli_Nombre] ASC,
	[Cli_Apellido] ASC,
	[Cli_Dni] ASC,
	[Cli_Fecha_Nac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

SET ANSI_PADDING ON

GO

/****** Object:  Index [ix_maestra_paquete]    Script Date: 18/10/2015 17:57:21 ******/
CREATE NONCLUSTERED INDEX [ix_maestra_paquete] ON [gd_esquema].[Maestra]
(
	[Paquete_Codigo] ASC,
	[Paquete_Precio] ASC,
	[Paquete_KG] ASC,
	[Paquete_FechaCompra] ASC,
	[Cli_Nombre] ASC,
	[Cli_Apellido] ASC,
	[Cli_Dni] ASC,
	[Cli_Fecha_Nac] ASC,
	[Aeronave_Matricula] ASC,
	[Tipo_Servicio] ASC,
	[Ruta_Ciudad_Origen] ASC,
	[Ruta_Ciudad_Destino] ASC,
	[Ruta_Codigo] ASC,
	[FechaSalida] ASC,
	[Fecha_LLegada_Estimada] ASC,
	[FechaLLegada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

SET ANSI_PADDING ON

GO

/****** Object:  Index [ix_maestra_pasaje]    Script Date: 18/10/2015 17:57:21 ******/
CREATE NONCLUSTERED INDEX [ix_maestra_pasaje] ON [gd_esquema].[Maestra]
(
	[Pasaje_Codigo] ASC,
	[Pasaje_Precio] ASC,
	[Pasaje_FechaCompra] ASC,
	[Cli_Nombre] ASC,
	[Cli_Apellido] ASC,
	[Cli_Dni] ASC,
	[Cli_Fecha_Nac] ASC,
	[Ruta_Ciudad_Origen] ASC,
	[Ruta_Ciudad_Destino] ASC,
	[Tipo_Servicio] ASC,
	[Aeronave_Matricula] ASC,
	[Ruta_Codigo] ASC,
	[FechaSalida] ASC,
	[Fecha_LLegada_Estimada] ASC,
	[FechaLLegada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

SET ANSI_PADDING ON

GO

/****** Object:  Index [ix_maestra_ruta]    Script Date: 18/10/2015 17:57:21 ******/
CREATE NONCLUSTERED INDEX [ix_maestra_ruta] ON [gd_esquema].[Maestra]
(
	[Ruta_Codigo] ASC,
	[Ruta_Precio_BaseKG] ASC,
	[Ruta_Precio_BasePasaje] ASC,
	[Ruta_Ciudad_Origen] ASC,
	[Ruta_Ciudad_Destino] ASC,
	[Tipo_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

SET ANSI_PADDING ON

GO

/****** Object:  Index [ix_maestra_vuelo]    Script Date: 18/10/2015 17:57:21 ******/
CREATE NONCLUSTERED INDEX [ix_maestra_vuelo] ON [gd_esquema].[Maestra]
(
	[FechaSalida] ASC,
	[Fecha_LLegada_Estimada] ASC,
	[FechaLLegada] ASC,
	[Ruta_Codigo] ASC,
	[Ruta_Ciudad_Origen] ASC,
	[Ruta_Ciudad_Destino] ASC,
	[Aeronave_Matricula] ASC,
	[Tipo_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO