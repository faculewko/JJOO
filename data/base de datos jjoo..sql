USE [base de datos jjoo]
GO
/****** Object:  Table [dbo].[Deporte]    Script Date: 15/8/2024 15:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deporte](
	[Id_deporte] [int] NOT NULL,
	[Nombre_deporte] [varchar](20) NOT NULL,
	[foto] [text] NOT NULL,
 CONSTRAINT [PK_Deporte] PRIMARY KEY CLUSTERED 
(
	[Id_deporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deportista]    Script Date: 15/8/2024 15:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deportista](
	[id_deportista] [int] NOT NULL,
	[Nombre] [varchar](10) NOT NULL,
	[Apellido] [varchar](10) NOT NULL,
	[FechaNaciemiento] [date] NOT NULL,
	[idPais] [int] NOT NULL,
	[idDeporte] [int] NOT NULL,
 CONSTRAINT [PK_Deportista] PRIMARY KEY CLUSTERED 
(
	[id_deportista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 15/8/2024 15:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paises](
	[IdPais] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[bandera] [text] NOT NULL,
	[FechaFundacion] [date] NOT NULL,
 CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
(
	[IdPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Deportista]  WITH CHECK ADD  CONSTRAINT [FK_Deportista_Deporte] FOREIGN KEY([idDeporte])
REFERENCES [dbo].[Deporte] ([Id_deporte])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Deportista] CHECK CONSTRAINT [FK_Deportista_Deporte]
GO
ALTER TABLE [dbo].[Deportista]  WITH CHECK ADD  CONSTRAINT [FK_Deportista_Paises] FOREIGN KEY([idPais])
REFERENCES [dbo].[Paises] ([IdPais])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Deportista] CHECK CONSTRAINT [FK_Deportista_Paises]
GO
