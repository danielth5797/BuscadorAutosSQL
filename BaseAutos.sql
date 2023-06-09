USE [master]
GO
/****** Object:  Database [BaseAutos]    Script Date: 12/7/2022 1:07:19 AM ******/
CREATE DATABASE [BaseAutos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BaseAutos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BaseAutos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BaseAutos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BaseAutos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BaseAutos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BaseAutos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BaseAutos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BaseAutos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BaseAutos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BaseAutos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BaseAutos] SET ARITHABORT OFF 
GO
ALTER DATABASE [BaseAutos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BaseAutos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BaseAutos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BaseAutos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BaseAutos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BaseAutos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BaseAutos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BaseAutos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BaseAutos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BaseAutos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BaseAutos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BaseAutos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BaseAutos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BaseAutos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BaseAutos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BaseAutos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BaseAutos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BaseAutos] SET RECOVERY FULL 
GO
ALTER DATABASE [BaseAutos] SET  MULTI_USER 
GO
ALTER DATABASE [BaseAutos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BaseAutos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BaseAutos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BaseAutos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BaseAutos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BaseAutos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BaseAutos', N'ON'
GO
ALTER DATABASE [BaseAutos] SET QUERY_STORE = OFF
GO
USE [BaseAutos]
GO
/****** Object:  Table [dbo].[anio]    Script Date: 12/7/2022 1:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[anio](
	[id_Anio] [bigint] IDENTITY(1,1) NOT NULL,
	[anio] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Anio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[coche]    Script Date: 12/7/2022 1:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coche](
	[id_Auto] [bigint] IDENTITY(1,1) NOT NULL,
	[id_Marca] [bigint] NOT NULL,
	[modelo] [varchar](30) NOT NULL,
	[id_Estilo] [bigint] NOT NULL,
	[cilindrada] [varchar](30) NOT NULL,
	[id_Combustible] [bigint] NOT NULL,
	[id_Transmision] [bigint] NOT NULL,
	[id_Color] [bigint] NOT NULL,
	[id_Anio] [bigint] NOT NULL,
	[kilometraje] [varchar](15) NOT NULL,
	[precio] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Auto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[color]    Script Date: 12/7/2022 1:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[color](
	[id_Color] [bigint] IDENTITY(1,1) NOT NULL,
	[color] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Color] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[combustible]    Script Date: 12/7/2022 1:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[combustible](
	[id_Combustible] [bigint] IDENTITY(1,1) NOT NULL,
	[combustible] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Combustible] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estilo]    Script Date: 12/7/2022 1:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estilo](
	[id_Estilo] [bigint] IDENTITY(1,1) NOT NULL,
	[estilo] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Estilo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[marca]    Script Date: 12/7/2022 1:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marca](
	[id_Marca] [bigint] IDENTITY(1,1) NOT NULL,
	[marca] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transmision]    Script Date: 12/7/2022 1:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transmision](
	[id_Transmision] [bigint] IDENTITY(1,1) NOT NULL,
	[transmision] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Transmision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[anio] ON 

INSERT [dbo].[anio] ([id_Anio], [anio]) VALUES (1, N'2000')
INSERT [dbo].[anio] ([id_Anio], [anio]) VALUES (2, N'2001')
INSERT [dbo].[anio] ([id_Anio], [anio]) VALUES (3, N'2002')
INSERT [dbo].[anio] ([id_Anio], [anio]) VALUES (4, N'2003')
INSERT [dbo].[anio] ([id_Anio], [anio]) VALUES (5, N'2004')
INSERT [dbo].[anio] ([id_Anio], [anio]) VALUES (6, N'2005')
INSERT [dbo].[anio] ([id_Anio], [anio]) VALUES (7, N'2006')
INSERT [dbo].[anio] ([id_Anio], [anio]) VALUES (8, N'2007')
INSERT [dbo].[anio] ([id_Anio], [anio]) VALUES (9, N'2008')
INSERT [dbo].[anio] ([id_Anio], [anio]) VALUES (10, N'2009')
SET IDENTITY_INSERT [dbo].[anio] OFF
GO
SET IDENTITY_INSERT [dbo].[coche] ON 

INSERT [dbo].[coche] ([id_Auto], [id_Marca], [modelo], [id_Estilo], [cilindrada], [id_Combustible], [id_Transmision], [id_Color], [id_Anio], [kilometraje], [precio]) VALUES (4, 1, N'Tacoma', 3, N'3000', 1, 1, 1, 6, N'120000', N'24000')
INSERT [dbo].[coche] ([id_Auto], [id_Marca], [modelo], [id_Estilo], [cilindrada], [id_Combustible], [id_Transmision], [id_Color], [id_Anio], [kilometraje], [precio]) VALUES (5, 2, N'Explorer', 2, N'2500', 1, 1, 1, 1, N'15222', N'12200')
INSERT [dbo].[coche] ([id_Auto], [id_Marca], [modelo], [id_Estilo], [cilindrada], [id_Combustible], [id_Transmision], [id_Color], [id_Anio], [kilometraje], [precio]) VALUES (6, 1, N'Prado', 2, N'3000', 2, 2, 2, 10, N'45000', N'25000')
INSERT [dbo].[coche] ([id_Auto], [id_Marca], [modelo], [id_Estilo], [cilindrada], [id_Combustible], [id_Transmision], [id_Color], [id_Anio], [kilometraje], [precio]) VALUES (7, 3, N'Silverado', 3, N'4500', 1, 2, 4, 8, N'56000', N'34000')
SET IDENTITY_INSERT [dbo].[coche] OFF
GO
SET IDENTITY_INSERT [dbo].[color] ON 

INSERT [dbo].[color] ([id_Color], [color]) VALUES (1, N'Azul')
INSERT [dbo].[color] ([id_Color], [color]) VALUES (2, N'Rojo')
INSERT [dbo].[color] ([id_Color], [color]) VALUES (3, N'Verde')
INSERT [dbo].[color] ([id_Color], [color]) VALUES (4, N'Beige')
SET IDENTITY_INSERT [dbo].[color] OFF
GO
SET IDENTITY_INSERT [dbo].[combustible] ON 

INSERT [dbo].[combustible] ([id_Combustible], [combustible]) VALUES (1, N'Gasolina')
INSERT [dbo].[combustible] ([id_Combustible], [combustible]) VALUES (2, N'Diesel')
INSERT [dbo].[combustible] ([id_Combustible], [combustible]) VALUES (3, N'Gas')
SET IDENTITY_INSERT [dbo].[combustible] OFF
GO
SET IDENTITY_INSERT [dbo].[estilo] ON 

INSERT [dbo].[estilo] ([id_Estilo], [estilo]) VALUES (1, N'HatchBack')
INSERT [dbo].[estilo] ([id_Estilo], [estilo]) VALUES (2, N'SUV')
INSERT [dbo].[estilo] ([id_Estilo], [estilo]) VALUES (3, N'PickUp')
INSERT [dbo].[estilo] ([id_Estilo], [estilo]) VALUES (4, N'HatchBack')
INSERT [dbo].[estilo] ([id_Estilo], [estilo]) VALUES (5, N'Automóvil')
SET IDENTITY_INSERT [dbo].[estilo] OFF
GO
SET IDENTITY_INSERT [dbo].[marca] ON 

INSERT [dbo].[marca] ([id_Marca], [marca]) VALUES (1, N'Toyota')
INSERT [dbo].[marca] ([id_Marca], [marca]) VALUES (2, N'Ford')
INSERT [dbo].[marca] ([id_Marca], [marca]) VALUES (3, N'Chevrolet')
INSERT [dbo].[marca] ([id_Marca], [marca]) VALUES (4, N'Mercedes Benz')
SET IDENTITY_INSERT [dbo].[marca] OFF
GO
SET IDENTITY_INSERT [dbo].[transmision] ON 

INSERT [dbo].[transmision] ([id_Transmision], [transmision]) VALUES (1, N'Manual')
INSERT [dbo].[transmision] ([id_Transmision], [transmision]) VALUES (2, N'Automática')
SET IDENTITY_INSERT [dbo].[transmision] OFF
GO
ALTER TABLE [dbo].[coche]  WITH CHECK ADD  CONSTRAINT [fk_id_Anio] FOREIGN KEY([id_Anio])
REFERENCES [dbo].[anio] ([id_Anio])
GO
ALTER TABLE [dbo].[coche] CHECK CONSTRAINT [fk_id_Anio]
GO
ALTER TABLE [dbo].[coche]  WITH CHECK ADD  CONSTRAINT [fk_id_Color] FOREIGN KEY([id_Color])
REFERENCES [dbo].[color] ([id_Color])
GO
ALTER TABLE [dbo].[coche] CHECK CONSTRAINT [fk_id_Color]
GO
ALTER TABLE [dbo].[coche]  WITH CHECK ADD  CONSTRAINT [fk_id_Combustible] FOREIGN KEY([id_Combustible])
REFERENCES [dbo].[combustible] ([id_Combustible])
GO
ALTER TABLE [dbo].[coche] CHECK CONSTRAINT [fk_id_Combustible]
GO
ALTER TABLE [dbo].[coche]  WITH CHECK ADD  CONSTRAINT [fk_id_Estilo] FOREIGN KEY([id_Estilo])
REFERENCES [dbo].[estilo] ([id_Estilo])
GO
ALTER TABLE [dbo].[coche] CHECK CONSTRAINT [fk_id_Estilo]
GO
ALTER TABLE [dbo].[coche]  WITH CHECK ADD  CONSTRAINT [fk_id_Marca_M] FOREIGN KEY([id_Marca])
REFERENCES [dbo].[marca] ([id_Marca])
GO
ALTER TABLE [dbo].[coche] CHECK CONSTRAINT [fk_id_Marca_M]
GO
ALTER TABLE [dbo].[coche]  WITH CHECK ADD  CONSTRAINT [fk_id_Transimision] FOREIGN KEY([id_Transmision])
REFERENCES [dbo].[transmision] ([id_Transmision])
GO
ALTER TABLE [dbo].[coche] CHECK CONSTRAINT [fk_id_Transimision]
GO
/****** Object:  StoredProcedure [dbo].[autos_existentes]    Script Date: 12/7/2022 1:07:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[autos_existentes]
@cod_error int output,
@msg_error varchar(MaX) output
As
	BEGIN
				--VARIABLES DE SALIDA
			set @cod_error=0
			set @msg_error=''
		BEGIN TRY

			SELECT 
			m.marca, c.modelo, c.cilindrada, e.estilo, a.anio, c.precio, col.color, com.combustible, t.transmision, c.kilometraje

			FROM dbo.coche c
			Inner Join marca m on c.id_Marca = m.id_Marca
			Inner Join estilo e on c.id_Estilo = e.id_Estilo
			Inner Join combustible com on c.id_Combustible = com.id_Combustible
			Inner Join transmision t on c.id_Transmision = t.id_Transmision
			Inner Join color col on c.id_Color = col.id_Color
			Inner Join anio a on c.id_Anio = a.id_Anio

		END TRY
		BEGIN CATCH
			set @cod_error=@@ERROR
			set @msg_error=ERROR_MESSAGE()
		END CATCH
	END
GO
/****** Object:  StoredProcedure [dbo].[consultar_coche_fecha]    Script Date: 12/7/2022 1:07:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[consultar_coche_fecha]
@fecha int
As
	BEGIN

			Declare 
			@id Int

			SET @id = (SELECT id_Anio  FROM dbo.anio WHERE anio = @fecha)

			SELECT 
			m.marca, c.modelo, c.cilindrada, e.estilo, a.anio, c.precio, col.color, com.combustible, t.transmision, c.kilometraje

			FROM dbo.coche c
			Inner Join marca m on c.id_Marca = m.id_Marca
			Inner Join estilo e on c.id_Estilo = e.id_Estilo
			Inner Join combustible com on c.id_Combustible = com.id_Combustible
			Inner Join transmision t on c.id_Transmision = t.id_Transmision
			Inner Join color col on c.id_Color = col.id_Color
			Inner Join anio a on c.id_Anio = a.id_Anio
			WHERE c.id_Anio = @id

	END
GO
/****** Object:  StoredProcedure [dbo].[consultar_coche_marca]    Script Date: 12/7/2022 1:07:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[consultar_coche_marca]
@marca Varchar(30),

@cod_error int output,
@msg_error varchar(MaX) output
As
	BEGIN
				--VARIABLES DE SALIDA
			set @cod_error=0
			set @msg_error=''
		BEGIN TRY

			Declare 
			@id Int

			SET @id = (SELECT id_Marca  FROM dbo.marca WHERE marca like '%' + @marca + '%' )

			SELECT 
			m.marca, c.modelo, c.cilindrada, e.estilo, a.anio, c.precio, col.color, com.combustible, t.transmision, c.kilometraje

			FROM dbo.coche c
			Inner Join marca m on c.id_Marca = m.id_Marca
			Inner Join estilo e on c.id_Estilo = e.id_Estilo
			Inner Join combustible com on c.id_Combustible = com.id_Combustible
			Inner Join transmision t on c.id_Transmision = t.id_Transmision
			Inner Join color col on c.id_Color = col.id_Color
			Inner Join anio a on c.id_Anio = a.id_Anio
			WHERE c.id_Marca = @id


		END TRY
		BEGIN CATCH
			set @cod_error=@@ERROR
			set @msg_error=ERROR_MESSAGE()
		END CATCH
	END
GO
/****** Object:  StoredProcedure [dbo].[consultar_coche_marca_fecha]    Script Date: 12/7/2022 1:07:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[consultar_coche_marca_fecha]
@marca Varchar(30),
@fecha int,

@cod_error int output,
@msg_error varchar(MaX) output
As
	BEGIN
				--VARIABLES DE SALIDA
			set @cod_error=0
			set @msg_error=''
		BEGIN TRY

			Declare 
			@id_marca Int,
			@id_anio Int

			SET @id_marca = (SELECT id_Marca  FROM dbo.marca WHERE marca like '%' + @marca + '%')
			SET @id_anio = (SELECT id_Anio  FROM dbo.anio WHERE anio = @fecha)

			SELECT 
			m.marca, c.modelo, c.cilindrada, e.estilo, a.anio, c.precio, col.color, com.combustible, t.transmision, c.kilometraje

			FROM dbo.coche c
			Inner Join marca m on c.id_Marca = m.id_Marca
			Inner Join estilo e on c.id_Estilo = e.id_Estilo
			Inner Join combustible com on c.id_Combustible = com.id_Combustible
			Inner Join transmision t on c.id_Transmision = t.id_Transmision
			Inner Join color col on c.id_Color = col.id_Color
			Inner Join anio a on c.id_Anio = a.id_Anio
			WHERE c.id_Marca = @id_marca AND c.id_Anio = @id_anio


		END TRY
		BEGIN CATCH
			set @cod_error=@@ERROR
			set @msg_error=ERROR_MESSAGE()
		END CATCH
	END
GO
/****** Object:  StoredProcedure [dbo].[insertar_coche]    Script Date: 12/7/2022 1:07:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento almacenado para ingresar datos a la tabla Coche

--Insertar auto

CREATE PROCEDURE [dbo].[insertar_coche]
@id_marca int,
@modelo varchar(30),
@id_estilo int,
@id_combustible int,
@id_transmision int,
@id_color int,
@cilindrada varchar(30),
@id_anio int,
@kilometraje varchar(30),
@precio varchar(30),
@cod_error int output,
@msg_error varchar(MaX) output
As

	BEGIN
		
		SET	 @cod_error = 0
		SET @msg_error = ''

		BEGIN TRY
		
			INSERT INTO dbo.coche (id_Marca, modelo, id_Estilo, cilindrada, id_Combustible, id_Transmision, id_Color,  id_Anio, kilometraje, precio)
			VALUES (@id_marca, @modelo, @id_estilo,@cilindrada, @id_combustible, @id_transmision, @id_color, @id_anio, @kilometraje, @precio);

		END TRY
		BEGIN CATCH
			set @cod_error = @@ERROR
			set @msg_error = ERROR_MESSAGE()
		END CATCH
	
	END
GO
/****** Object:  StoredProcedure [dbo].[obtener_anio]    Script Date: 12/7/2022 1:07:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_anio]
As
	BEGIN
	SELECT * FROM dbo.anio
	END
GO
/****** Object:  StoredProcedure [dbo].[obtener_color]    Script Date: 12/7/2022 1:07:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_color]
As

	BEGIN
	SELECT * FROM dbo.color
	END
GO
/****** Object:  StoredProcedure [dbo].[obtener_combustible]    Script Date: 12/7/2022 1:07:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_combustible]
As

	BEGIN
	SELECT * FROM dbo.combustible
	END
GO
/****** Object:  StoredProcedure [dbo].[obtener_estilos]    Script Date: 12/7/2022 1:07:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_estilos]
As

	BEGIN
	SELECT * FROM dbo.estilo
	END
GO
/****** Object:  StoredProcedure [dbo].[obtener_marcas]    Script Date: 12/7/2022 1:07:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_marcas]
As

	BEGIN
	SELECT * FROM dbo.marca
	END
GO
/****** Object:  StoredProcedure [dbo].[obtener_transmision]    Script Date: 12/7/2022 1:07:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtener_transmision]
As

	BEGIN
	SELECT * FROM dbo.transmision
	END
GO
USE [master]
GO
ALTER DATABASE [BaseAutos] SET  READ_WRITE 
GO
