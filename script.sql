USE [master]
GO
/****** Object:  Database [Restaurante]    Script Date: 8/01/2023 7:05:21 p.m. ******/
CREATE DATABASE [Restaurante]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Restaurante', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Restaurante.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Restaurante_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Restaurante_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Restaurante] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Restaurante].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Restaurante] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Restaurante] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Restaurante] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Restaurante] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Restaurante] SET ARITHABORT OFF 
GO
ALTER DATABASE [Restaurante] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Restaurante] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Restaurante] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Restaurante] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Restaurante] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Restaurante] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Restaurante] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Restaurante] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Restaurante] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Restaurante] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Restaurante] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Restaurante] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Restaurante] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Restaurante] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Restaurante] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Restaurante] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Restaurante] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Restaurante] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Restaurante] SET  MULTI_USER 
GO
ALTER DATABASE [Restaurante] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Restaurante] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Restaurante] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Restaurante] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Restaurante] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Restaurante]
GO
/****** Object:  Table [dbo].[departamentos]    Script Date: 8/01/2023 7:05:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[departamentos](
	[cod] [int] IDENTITY(0,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[estado] [tinyint] NULL,
 CONSTRAINT [PK_departamentos] PRIMARY KEY CLUSTERED 
(
	[cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inicio_sesion]    Script Date: 8/01/2023 7:05:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inicio_sesion](
	[codigo] [bigint] IDENTITY(1,1) NOT NULL,
	[vendedor_id] [bigint] NOT NULL,
	[role_id] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[pc_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_inicio_sesion] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mesas]    Script Date: 8/01/2023 7:05:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mesas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[salon_id] [int] NULL,
	[descripcion] [varchar](20) NULL,
	[posx] [int] NULL,
	[posy] [int] NULL,
	[estado] [tinyint] NULL,
	[disponible] [varchar](20) NULL,
 CONSTRAINT [PK_Mesas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 8/01/2023 7:05:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Roles](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[activo] [tinyint] NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salones]    Script Date: 8/01/2023 7:05:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salones](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[impuesto] [decimal](18, 2) NULL,
	[activo] [tinyint] NULL,
 CONSTRAINT [PK_Salones] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[secciones]    Script Date: 8/01/2023 7:05:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[secciones](
	[id] [int] IDENTITY(0,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[dpto_id] [int] NULL,
	[color_fondo] [int] NULL,
	[color_texto] [int] NULL,
	[activo] [tinyint] NULL,
 CONSTRAINT [PK_secciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vendedores]    Script Date: 8/01/2023 7:05:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vendedores](
	[codigo] [bigint] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](50) NULL,
	[apellidos] [varchar](50) NULL,
	[tipo_doc] [varchar](20) NULL,
	[nro_doc] [varchar](20) NULL,
	[direccion] [varchar](50) NULL,
	[telefono] [varchar](20) NULL,
	[celular] [varchar](20) NULL,
	[email] [varchar](150) NULL,
	[ciudad] [varchar](50) NULL,
	[pais] [varchar](50) NULL,
	[clave] [varchar](50) NULL,
	[foto] [image] NULL,
	[activo] [tinyint] NULL,
	[salario_base] [decimal](18, 2) NULL,
	[comision] [decimal](18, 2) NULL,
	[salario]  AS ([salario_base]+[comision]),
	[role_id] [int] NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[cp_iniciar_sesion]    Script Date: 8/01/2023 7:05:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[cp_iniciar_sesion]
@clave varchar(50) = '',
@pc_name varchar(50) = ''
as
begin try
	begin tran
		declare @idvendedor int;
		declare @idrole int;
		declare @estado varchar(30);
		select 
			codigo,
			(nombres + ' ' + apellidos) as vendedor,
			nro_doc
		from Vendedores
		where clave = @clave

		set @idvendedor = (select codigo from Vendedores where clave = @clave)
		set @idrole= (select role_id from Vendedores where clave = @clave)

				insert into Inicio_sesion values(@idvendedor,@idrole,
		getdate(),'activo',@pc_name)
	commit
end try
begin catch
	rollback
end catch
GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_mesas]    Script Date: 8/01/2023 7:05:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_guardar_mesas]
@salon_id int = 0,
@posx int = 0,
@posy int = 0
as
declare @nomMesa varchar(30)
declare @mesaId int
set @mesaId = (select max(id) from Mesas)
declare @totalMesas int
set @totalMesas = (select count(id) as total from Mesas)
if @totalMesas = 0
	begin
		insert into Mesas values(@salon_id,'1',@posx,@posy,1,'libre')
	end
else
	begin
		insert into Mesas 
		values(@salon_id,convert(varchar(20),@mesaId+1),
		@posx,@posy,1,'libre')
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_roles]    Script Date: 8/01/2023 7:05:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_guardar_roles]
@codigo int = 0,
@nombre varchar(30) = '',
@descripcion varchar(50) = '',
@activo int = 0,
@opcion int = 0
as
if @opcion = 0
	begin
		if exists(select nombre from roles where nombre=@nombre)
			raiserror('Ya existe un rol con este nombre',16,1)
		else
			insert into roles(nombre,descripcion,activo)
			values(@nombre,@descripcion,@activo)
	end
else if @opcion = 1
	begin
		if exists(select nombre from roles where nombre=@nombre and codigo <> @codigo)
			raiserror('Ya existe un rol con este nombre',16,1)
		else
			update roles set 
				nombre = @nombre,
				descripcion = @descripcion,
				activo = @activo
			where codigo=@codigo
	end

GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_vendedor]    Script Date: 8/01/2023 7:05:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_guardar_vendedor]
@codigo int = 0,
@nombres varchar(50) = '',
@apellidos varchar(50) = '',
@tipo_doc varchar(20) = '',
@nro_doc varchar(20) = '',
@direccion varchar(50) = '',
@telefono varchar(20) = '',
@celular varchar(20) = '',
@email varchar(150) = '',
@ciudad varchar(50) = '',
@pais varchar(50) = '',
@clave varchar(50) = '',
@foto image = null,
@activo tinyint = 0,
@salario_base decimal(18,2) = 0.0,
@comision decimal(18,2) = 0.0,
@role_id int = 0,
@opcion int = 0
as
if( @opcion = 0)
	begin 
		if exists(select nro_doc from Vendedores 
		where nro_doc = @nro_doc)
		raiserror('Ya existe este número de documento',16,1)
		else if exists(select clave from Vendedores 
		where clave = @clave)
		raiserror('Ingrese una clave diferente',16,1)
		else
		insert into Vendedores 
		(nombres,apellidos,tipo_doc,nro_doc,direccion,
		telefono,celular,email,ciudad,pais,clave,
		foto,activo,salario_base,comision,role_id) 
		values
		(@nombres,@apellidos,@tipo_doc,@nro_doc,@direccion,
		@telefono,@celular,@email,@ciudad,@pais,@clave,
		@foto,@activo,@salario_base,@comision,@role_id)
	end
else
	begin 
		if exists(select nro_doc from Vendedores 
		where nro_doc = @nro_doc and codigo <> @codigo)
		raiserror('Ya existe este número de documento',16,1)
		else
		update Vendedores set 
		nombres = @nombres,
		apellidos = @apellidos,
		tipo_doc = @tipo_doc,
		nro_doc = @nro_doc,
		direccion = @direccion,
		telefono = @telefono,
		celular = @celular,
		email = @email,
		ciudad = @ciudad,
		pais = @pais,
		clave = @clave,
		foto = @foto,
		activo = @activo,
		salario_base = @salario_base,
		comision = @comision,
		role_id = @role_id
		 where codigo=@codigo
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_vendedores]    Script Date: 8/01/2023 7:05:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_vendedores]
@buscar varchar(20) = ''
as
select v.*, r.nombre as role from Vendedores v 
	inner join roles r 
	on v.role_id = r.codigo
	where
	 v.nombres+v.apellidos+v.nro_doc+v.telefono+v.celular
	  like '%' + @buscar +'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_obtener_datos_inicio_sesion]    Script Date: 8/01/2023 7:05:21 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_obtener_datos_inicio_sesion]
@pc varchar(50) = ''
as
select 
	ins.codigo as in_codigo,
	ve.codigo,
	(ve.nombres + ' '+ ve.apellidos ) as vendedor,
	ro.nombre as roles,
	ins.estado,
	ins.pc_name
	from Inicio_sesion as ins
	inner join Vendedores as ve
		on ins.vendedor_id = ve.codigo
	inner join Roles as ro
		on ins.role_id = ro.codigo
	where ins.pc_name=@pc
	and ins.estado='activo'
GO
USE [master]
GO
ALTER DATABASE [Restaurante] SET  READ_WRITE 
GO
