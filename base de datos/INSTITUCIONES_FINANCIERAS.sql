USE [master]
GO
/****** Object:  Database [instituciones_financieras]    Script Date: 11/1/2019 20:05:13 ******/
CREATE DATABASE [instituciones_financieras]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'instituciones_financieras', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\instituciones_financieras.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'instituciones_financieras_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\instituciones_financieras_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [instituciones_financieras] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [instituciones_financieras].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [instituciones_financieras] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [instituciones_financieras] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [instituciones_financieras] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [instituciones_financieras] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [instituciones_financieras] SET ARITHABORT OFF 
GO
ALTER DATABASE [instituciones_financieras] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [instituciones_financieras] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [instituciones_financieras] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [instituciones_financieras] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [instituciones_financieras] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [instituciones_financieras] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [instituciones_financieras] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [instituciones_financieras] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [instituciones_financieras] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [instituciones_financieras] SET  DISABLE_BROKER 
GO
ALTER DATABASE [instituciones_financieras] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [instituciones_financieras] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [instituciones_financieras] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [instituciones_financieras] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [instituciones_financieras] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [instituciones_financieras] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [instituciones_financieras] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [instituciones_financieras] SET RECOVERY FULL 
GO
ALTER DATABASE [instituciones_financieras] SET  MULTI_USER 
GO
ALTER DATABASE [instituciones_financieras] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [instituciones_financieras] SET DB_CHAINING OFF 
GO
ALTER DATABASE [instituciones_financieras] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [instituciones_financieras] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [instituciones_financieras] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'instituciones_financieras', N'ON'
GO
ALTER DATABASE [instituciones_financieras] SET QUERY_STORE = OFF
GO
USE [instituciones_financieras]
GO
/****** Object:  Schema [instituciones_financieras]    Script Date: 11/1/2019 20:05:13 ******/
CREATE SCHEMA [instituciones_financieras]
GO
/****** Object:  Table [instituciones_financieras].[activo]    Script Date: 11/1/2019 20:05:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[activo](
	[id_activo] [nvarchar](23) NOT NULL,
	[id_tipo] [int] NOT NULL,
	[id_departamento] [int] NOT NULL,
	[id_institucion] [int] NOT NULL,
	[id_estado] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[correlativo] [nvarchar](45) NULL,
	[fecha_adquisicion] [date] NULL,
	[descripcion] [nvarchar](200) NULL,
	[estado] [nvarchar](45) NULL,
	[observaciones] [nvarchar](200) NULL,
	[id_depto] [nvarchar](50) NULL,
 CONSTRAINT [PK_activo_id_activo] PRIMARY KEY CLUSTERED 
(
	[id_activo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[activo_mant]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[activo_mant](
	[activo_mant] [nvarchar](23) NULL,
	[mant_acttivo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[balance_general]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[balance_general](
	[id_balance] [int] IDENTITY(1,1) NOT NULL,
	[id_persona_juridica] [int] NOT NULL,
	[periodo] [int] NULL,
	[prestable] [smallint] NULL,
	[efectivo] [real] NULL,
	[valor_negociable] [real] NULL,
	[cuentas_por_cobrar] [real] NULL,
	[inventarios] [real] NULL,
	[terrenos] [real] NULL,
	[edificio_equipo] [real] NULL,
	[depreciacion_acumulada] [real] NULL,
	[total_activo_corriente] [real] NULL,
	[total_activo_pasivo] [real] NULL,
	[total_activo] [real] NULL,
	[cuentas_por_pagar] [real] NULL,
	[documentos_por_pagar] [real] NULL,
	[total_pasivo_corriente] [real] NULL,
	[deuda_largo_plazo] [real] NULL,
	[acciones_comunes] [real] NULL,
	[ganancias_retenidas] [real] NULL,
	[total_pasivo] [real] NULL,
 CONSTRAINT [PK_balance_general_id_balance] PRIMARY KEY CLUSTERED 
(
	[id_balance] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[bien_hipotecario]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[bien_hipotecario](
	[id_bien] [int] IDENTITY(1,1) NOT NULL,
	[id_persona_natural] [int] NOT NULL,
	[descripcion] [nvarchar](200) NULL,
	[ubicacion] [nvarchar](45) NULL,
	[otros_datos] [nvarchar](45) NULL,
	[anexo] [varbinary](max) NULL,
 CONSTRAINT [PK_bien_hipotecario_id_bien] PRIMARY KEY CLUSTERED 
(
	[id_bien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[cartera]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[cartera](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](45) NULL,
	[id_cliente] [int] NOT NULL,
 CONSTRAINT [PK_cartera_id_categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[clasificacion]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[clasificacion](
	[id_clasificacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](45) NULL,
	[correlativo] [nvarchar](45) NULL,
	[tiempo_depreciacion] [int] NULL,
 CONSTRAINT [PK_clasificacion_id_clasificacion] PRIMARY KEY CLUSTERED 
(
	[id_clasificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[cliente]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](30) NULL,
	[apellido] [nvarchar](30) NULL,
	[direccion] [nvarchar](100) NULL,
	[dui] [nvarchar](15) NULL,
	[nit] [nvarchar](15) NULL,
	[correo] [nvarchar](30) NULL,
	[observaciones] [nvarchar](300) NULL,
	[telefono] [nvarchar](12) NULL,
	[contrato_pagare] [nvarchar](2000) NULL,
 CONSTRAINT [PK_cliente_id_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[departamento]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[departamento](
	[id_depto] [nvarchar](50) NOT NULL,
	[nombre] [nchar](10) NULL,
	[id_sucursal] [nvarchar](50) NULL,
 CONSTRAINT [PK_departamento] PRIMARY KEY CLUSTERED 
(
	[id_depto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[detalle_compra]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[detalle_compra](
	[id_cliente] [int] NOT NULL,
	[id_venta] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[detalle_venta]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[detalle_venta](
	[id_venta] [int] NOT NULL,
	[id_producto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[empleado]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[empleado](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](30) NULL,
	[apellido] [nvarchar](30) NULL,
	[zona] [nvarchar](30) NULL,
	[dui] [nvarchar](45) NULL,
	[pass] [nvarchar](45) NULL,
	[nivel] [nvarchar](45) NULL,
 CONSTRAINT [PK_empleado_id_empleado] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[encargado]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[encargado](
	[id_encargado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](45) NULL,
	[telefono] [nvarchar](45) NULL,
	[correo] [nvarchar](45) NULL,
	[direccion] [text] NULL,
 CONSTRAINT [PK_encargado_id_encargado] PRIMARY KEY CLUSTERED 
(
	[id_encargado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[estado]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[estado](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](45) NULL,
	[tiempo_de_uso] [int] NULL,
 CONSTRAINT [PK_estado_id_estado] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[estado_resultado]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[estado_resultado](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[id_persona_juridica] [int] NOT NULL,
	[periodo] [int] NULL,
	[prestable] [smallint] NULL,
	[ingreso_ventas] [real] NULL,
	[costo_venta] [real] NULL,
	[utilidad_bruta] [real] NULL,
	[gastos_operativos] [real] NULL,
	[gasto_venta] [real] NULL,
	[gasto_administrativo] [real] NULL,
	[gasto_arrendamiento] [real] NULL,
	[gasto_depreciacion] [real] NULL,
	[total_gasto_operativo] [real] NULL,
	[utlidad_operativa] [real] NULL,
	[gasto_interes] [real] NULL,
	[utilidad_antes_impuestos] [real] NULL,
	[impuestos] [real] NULL,
	[utilidad_neta] [real] NULL,
 CONSTRAINT [PK_estado_resultado_id_estado] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[expediente_juridico]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[expediente_juridico](
	[id_prestamo] [int] NOT NULL,
	[id_persona_juridica] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[fiador]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[fiador](
	[id_fiador] [int] IDENTITY(1,1) NOT NULL,
	[id_persona_natural] [int] NOT NULL,
	[nombre] [nvarchar](30) NULL,
	[apellido] [nvarchar](30) NULL,
	[direccion] [nvarchar](254) NULL,
	[dui] [nvarchar](15) NULL,
	[nit] [nvarchar](15) NULL,
	[correo] [nvarchar](30) NULL,
	[lugar_trabajo] [nvarchar](max) NULL,
	[telefono] [nvarchar](12) NULL,
 CONSTRAINT [PK_fiador_id_fiador] PRIMARY KEY CLUSTERED 
(
	[id_fiador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[inventario]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[inventario](
	[id_inventario] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [int] NOT NULL,
	[minimo] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
 CONSTRAINT [PK_inventario_id_inventario] PRIMARY KEY CLUSTERED 
(
	[id_inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[mant_enca]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[mant_enca](
	[mant_enca] [int] NULL,
	[enca_mant] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[mantenimiento]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[mantenimiento](
	[id_mantenimiento] [int] NOT NULL,
	[fecha] [date] NULL,
	[costo] [real] NULL,
	[detalle] [text] NULL,
 CONSTRAINT [PK_mantenimiento] PRIMARY KEY CLUSTERED 
(
	[id_mantenimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[pago]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[pago](
	[id_pago] [int] IDENTITY(1,1) NOT NULL,
	[id_venta] [int] NOT NULL,
	[monto] [real] NULL,
	[fecha] [date] NULL,
 CONSTRAINT [PK_pago_id_pago] PRIMARY KEY CLUSTERED 
(
	[id_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[persona_juridica]    Script Date: 11/1/2019 20:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[persona_juridica](
	[id_persona_juridica] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](45) NULL,
	[categoria] [nvarchar](45) NULL,
	[numero] [nvarchar](45) NULL,
	[dui] [nvarchar](45) NULL,
	[nit] [nvarchar](45) NULL,
 CONSTRAINT [PK_persona_juridica_id_persona_juridica] PRIMARY KEY CLUSTERED 
(
	[id_persona_juridica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[plan_pago]    Script Date: 11/1/2019 20:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[plan_pago](
	[id_plan] [int] IDENTITY(1,1) NOT NULL,
	[tasa] [real] NULL,
	[cuotas] [int] NULL,
 CONSTRAINT [PK_plan_pago_id_plan] PRIMARY KEY CLUSTERED 
(
	[id_plan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[producto]    Script Date: 11/1/2019 20:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[producto](
	[id_producto] [int] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[nombre] [nvarchar](45) NULL,
	[descripcion] [nvarchar](200) NULL,
	[precio_compra] [real] NULL,
	[precio_venta] [real] NULL,
 CONSTRAINT [PK_producto_id_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[proveedor]    Script Date: 11/1/2019 20:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](45) NULL,
	[dui] [nvarchar](45) NULL,
	[direccion] [nvarchar](45) NULL,
	[telefono] [nvarchar](45) NULL,
 CONSTRAINT [PK_proveedor_id_proveedor] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[sucursal]    Script Date: 11/1/2019 20:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[sucursal](
	[id_sucursal] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[direccion] [text] NULL,
	[telefono] [nvarchar](10) NULL,
 CONSTRAINT [PK_sucursal] PRIMARY KEY CLUSTERED 
(
	[id_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[tipo_activo]    Script Date: 11/1/2019 20:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[tipo_activo](
	[id_tipo] [int] IDENTITY(1,1) NOT NULL,
	[id_clasificacion] [int] NOT NULL,
	[nombre] [nvarchar](45) NULL,
	[correlativo] [nvarchar](45) NULL,
 CONSTRAINT [PK_tipo_activo_id_tipo] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[tipo_credito]    Script Date: 11/1/2019 20:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[tipo_credito](
	[id_tipo_credito] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](20) NULL,
	[terminis_condiciones] [nvarchar](300) NULL,
 CONSTRAINT [PK_tipo_credito_id_tipo_credito] PRIMARY KEY CLUSTERED 
(
	[id_tipo_credito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [instituciones_financieras].[venta]    Script Date: 11/1/2019 20:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [instituciones_financieras].[venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_plan] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[prestamo_original] [real] NULL,
	[saldo_actual] [real] NULL,
	[mora_acumulada] [real] NULL,
	[intereses_acumulados] [real] NULL,
	[estado] [nvarchar](20) NULL,
	[proximo_pago] [date] NULL,
	[fecha] [date] NULL,
 CONSTRAINT [PK_venta_id_venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [fk_activo_departamento1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_activo_departamento1_idx] ON [instituciones_financieras].[activo]
(
	[id_departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_activo_estado1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_activo_estado1_idx] ON [instituciones_financieras].[activo]
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_activo_institucion1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_activo_institucion1_idx] ON [instituciones_financieras].[activo]
(
	[id_institucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_activo_proveedor1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_activo_proveedor1_idx] ON [instituciones_financieras].[activo]
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_activo_tipo_activo1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_activo_tipo_activo1_idx] ON [instituciones_financieras].[activo]
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_activo_usuario1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_activo_usuario1_idx] ON [instituciones_financieras].[activo]
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_balance_general_persona_juridica1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_balance_general_persona_juridica1_idx] ON [instituciones_financieras].[balance_general]
(
	[id_persona_juridica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_bien_hipotecario_persona_natural1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_bien_hipotecario_persona_natural1_idx] ON [instituciones_financieras].[bien_hipotecario]
(
	[id_persona_natural] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_cartera_cliente1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_cartera_cliente1_idx] ON [instituciones_financieras].[cartera]
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_persona_natural_has_prestamo_persona_natural1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_persona_natural_has_prestamo_persona_natural1_idx] ON [instituciones_financieras].[detalle_compra]
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_persona_natural_has_prestamo_prestamo1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_persona_natural_has_prestamo_prestamo1_idx] ON [instituciones_financieras].[detalle_compra]
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_venta_has_producto_producto1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_venta_has_producto_producto1_idx] ON [instituciones_financieras].[detalle_venta]
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_venta_has_producto_venta1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_venta_has_producto_venta1_idx] ON [instituciones_financieras].[detalle_venta]
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_estado_resultado_persona_juridica1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_estado_resultado_persona_juridica1_idx] ON [instituciones_financieras].[estado_resultado]
(
	[id_persona_juridica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_prestamo_has_persona_juridica_persona_juridica1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_prestamo_has_persona_juridica_persona_juridica1_idx] ON [instituciones_financieras].[expediente_juridico]
(
	[id_persona_juridica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_prestamo_has_persona_juridica_prestamo1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_prestamo_has_persona_juridica_prestamo1_idx] ON [instituciones_financieras].[expediente_juridico]
(
	[id_prestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_codeudor_persona_natural1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_codeudor_persona_natural1_idx] ON [instituciones_financieras].[fiador]
(
	[id_persona_natural] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_inventario_producto1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_inventario_producto1_idx] ON [instituciones_financieras].[inventario]
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_pago_prestamo1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_pago_prestamo1_idx] ON [instituciones_financieras].[pago]
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_producto_proveedor1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_producto_proveedor1_idx] ON [instituciones_financieras].[producto]
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_tipo_activo_clasificacion1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_tipo_activo_clasificacion1_idx] ON [instituciones_financieras].[tipo_activo]
(
	[id_clasificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_prestamo_asesor_credito1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_prestamo_asesor_credito1_idx] ON [instituciones_financieras].[venta]
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_prestamo_plan_pago1_idx]    Script Date: 11/1/2019 20:05:15 ******/
CREATE NONCLUSTERED INDEX [fk_prestamo_plan_pago1_idx] ON [instituciones_financieras].[venta]
(
	[id_plan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [instituciones_financieras].[activo] ADD  DEFAULT (NULL) FOR [correlativo]
GO
ALTER TABLE [instituciones_financieras].[activo] ADD  DEFAULT (NULL) FOR [fecha_adquisicion]
GO
ALTER TABLE [instituciones_financieras].[activo] ADD  DEFAULT (NULL) FOR [descripcion]
GO
ALTER TABLE [instituciones_financieras].[activo] ADD  DEFAULT (NULL) FOR [estado]
GO
ALTER TABLE [instituciones_financieras].[activo] ADD  DEFAULT (NULL) FOR [observaciones]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [periodo]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [prestable]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [efectivo]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [valor_negociable]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [cuentas_por_cobrar]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [inventarios]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [terrenos]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [edificio_equipo]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [depreciacion_acumulada]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [total_activo_corriente]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [total_activo_pasivo]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [total_activo]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [cuentas_por_pagar]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [documentos_por_pagar]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [total_pasivo_corriente]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [deuda_largo_plazo]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [acciones_comunes]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [ganancias_retenidas]
GO
ALTER TABLE [instituciones_financieras].[balance_general] ADD  DEFAULT (NULL) FOR [total_pasivo]
GO
ALTER TABLE [instituciones_financieras].[bien_hipotecario] ADD  DEFAULT (NULL) FOR [descripcion]
GO
ALTER TABLE [instituciones_financieras].[bien_hipotecario] ADD  DEFAULT (NULL) FOR [ubicacion]
GO
ALTER TABLE [instituciones_financieras].[bien_hipotecario] ADD  DEFAULT (NULL) FOR [otros_datos]
GO
ALTER TABLE [instituciones_financieras].[cartera] ADD  DEFAULT (NULL) FOR [nombre]
GO
ALTER TABLE [instituciones_financieras].[clasificacion] ADD  DEFAULT (NULL) FOR [nombre]
GO
ALTER TABLE [instituciones_financieras].[clasificacion] ADD  DEFAULT (NULL) FOR [correlativo]
GO
ALTER TABLE [instituciones_financieras].[clasificacion] ADD  DEFAULT (NULL) FOR [tiempo_depreciacion]
GO
ALTER TABLE [instituciones_financieras].[cliente] ADD  DEFAULT (NULL) FOR [nombre]
GO
ALTER TABLE [instituciones_financieras].[cliente] ADD  DEFAULT (NULL) FOR [apellido]
GO
ALTER TABLE [instituciones_financieras].[cliente] ADD  DEFAULT (NULL) FOR [direccion]
GO
ALTER TABLE [instituciones_financieras].[cliente] ADD  DEFAULT (NULL) FOR [dui]
GO
ALTER TABLE [instituciones_financieras].[cliente] ADD  DEFAULT (NULL) FOR [nit]
GO
ALTER TABLE [instituciones_financieras].[cliente] ADD  DEFAULT (NULL) FOR [correo]
GO
ALTER TABLE [instituciones_financieras].[cliente] ADD  DEFAULT (NULL) FOR [observaciones]
GO
ALTER TABLE [instituciones_financieras].[cliente] ADD  DEFAULT (NULL) FOR [telefono]
GO
ALTER TABLE [instituciones_financieras].[cliente] ADD  DEFAULT (NULL) FOR [contrato_pagare]
GO
ALTER TABLE [instituciones_financieras].[empleado] ADD  DEFAULT (NULL) FOR [nombre]
GO
ALTER TABLE [instituciones_financieras].[empleado] ADD  DEFAULT (NULL) FOR [apellido]
GO
ALTER TABLE [instituciones_financieras].[empleado] ADD  DEFAULT (NULL) FOR [zona]
GO
ALTER TABLE [instituciones_financieras].[empleado] ADD  DEFAULT (NULL) FOR [dui]
GO
ALTER TABLE [instituciones_financieras].[empleado] ADD  DEFAULT (NULL) FOR [pass]
GO
ALTER TABLE [instituciones_financieras].[empleado] ADD  DEFAULT (NULL) FOR [nivel]
GO
ALTER TABLE [instituciones_financieras].[encargado] ADD  DEFAULT (NULL) FOR [nombre]
GO
ALTER TABLE [instituciones_financieras].[encargado] ADD  DEFAULT (NULL) FOR [telefono]
GO
ALTER TABLE [instituciones_financieras].[encargado] ADD  DEFAULT (NULL) FOR [correo]
GO
ALTER TABLE [instituciones_financieras].[estado] ADD  DEFAULT (NULL) FOR [nombre]
GO
ALTER TABLE [instituciones_financieras].[estado] ADD  DEFAULT (NULL) FOR [tiempo_de_uso]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [periodo]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [prestable]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [ingreso_ventas]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [costo_venta]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [utilidad_bruta]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [gastos_operativos]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [gasto_venta]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [gasto_administrativo]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [gasto_arrendamiento]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [gasto_depreciacion]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [total_gasto_operativo]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [utlidad_operativa]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [gasto_interes]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [utilidad_antes_impuestos]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [impuestos]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] ADD  DEFAULT (NULL) FOR [utilidad_neta]
GO
ALTER TABLE [instituciones_financieras].[fiador] ADD  DEFAULT (NULL) FOR [nombre]
GO
ALTER TABLE [instituciones_financieras].[fiador] ADD  DEFAULT (NULL) FOR [apellido]
GO
ALTER TABLE [instituciones_financieras].[fiador] ADD  DEFAULT (NULL) FOR [direccion]
GO
ALTER TABLE [instituciones_financieras].[fiador] ADD  DEFAULT (NULL) FOR [dui]
GO
ALTER TABLE [instituciones_financieras].[fiador] ADD  DEFAULT (NULL) FOR [nit]
GO
ALTER TABLE [instituciones_financieras].[fiador] ADD  DEFAULT (NULL) FOR [correo]
GO
ALTER TABLE [instituciones_financieras].[fiador] ADD  DEFAULT (NULL) FOR [telefono]
GO
ALTER TABLE [instituciones_financieras].[pago] ADD  DEFAULT (NULL) FOR [monto]
GO
ALTER TABLE [instituciones_financieras].[pago] ADD  DEFAULT (NULL) FOR [fecha]
GO
ALTER TABLE [instituciones_financieras].[persona_juridica] ADD  DEFAULT (NULL) FOR [nombre]
GO
ALTER TABLE [instituciones_financieras].[persona_juridica] ADD  DEFAULT (NULL) FOR [categoria]
GO
ALTER TABLE [instituciones_financieras].[persona_juridica] ADD  DEFAULT (NULL) FOR [numero]
GO
ALTER TABLE [instituciones_financieras].[persona_juridica] ADD  DEFAULT (NULL) FOR [dui]
GO
ALTER TABLE [instituciones_financieras].[persona_juridica] ADD  DEFAULT (NULL) FOR [nit]
GO
ALTER TABLE [instituciones_financieras].[plan_pago] ADD  DEFAULT (NULL) FOR [tasa]
GO
ALTER TABLE [instituciones_financieras].[plan_pago] ADD  DEFAULT (NULL) FOR [cuotas]
GO
ALTER TABLE [instituciones_financieras].[producto] ADD  DEFAULT (NULL) FOR [nombre]
GO
ALTER TABLE [instituciones_financieras].[producto] ADD  DEFAULT (NULL) FOR [descripcion]
GO
ALTER TABLE [instituciones_financieras].[producto] ADD  DEFAULT (NULL) FOR [precio_compra]
GO
ALTER TABLE [instituciones_financieras].[producto] ADD  DEFAULT (NULL) FOR [precio_venta]
GO
ALTER TABLE [instituciones_financieras].[proveedor] ADD  DEFAULT (NULL) FOR [nombre]
GO
ALTER TABLE [instituciones_financieras].[proveedor] ADD  DEFAULT (NULL) FOR [dui]
GO
ALTER TABLE [instituciones_financieras].[proveedor] ADD  DEFAULT (NULL) FOR [direccion]
GO
ALTER TABLE [instituciones_financieras].[proveedor] ADD  DEFAULT (NULL) FOR [telefono]
GO
ALTER TABLE [instituciones_financieras].[tipo_activo] ADD  DEFAULT (NULL) FOR [nombre]
GO
ALTER TABLE [instituciones_financieras].[tipo_activo] ADD  DEFAULT (NULL) FOR [correlativo]
GO
ALTER TABLE [instituciones_financieras].[tipo_credito] ADD  DEFAULT (NULL) FOR [nombre]
GO
ALTER TABLE [instituciones_financieras].[tipo_credito] ADD  DEFAULT (NULL) FOR [terminis_condiciones]
GO
ALTER TABLE [instituciones_financieras].[venta] ADD  DEFAULT (NULL) FOR [prestamo_original]
GO
ALTER TABLE [instituciones_financieras].[venta] ADD  DEFAULT (NULL) FOR [saldo_actual]
GO
ALTER TABLE [instituciones_financieras].[venta] ADD  DEFAULT (NULL) FOR [mora_acumulada]
GO
ALTER TABLE [instituciones_financieras].[venta] ADD  DEFAULT (NULL) FOR [intereses_acumulados]
GO
ALTER TABLE [instituciones_financieras].[venta] ADD  DEFAULT (NULL) FOR [estado]
GO
ALTER TABLE [instituciones_financieras].[venta] ADD  DEFAULT (NULL) FOR [proximo_pago]
GO
ALTER TABLE [instituciones_financieras].[venta] ADD  DEFAULT (NULL) FOR [fecha]
GO
ALTER TABLE [instituciones_financieras].[activo]  WITH CHECK ADD  CONSTRAINT [activo$fk_activo_estado1] FOREIGN KEY([id_estado])
REFERENCES [instituciones_financieras].[estado] ([id_estado])
GO
ALTER TABLE [instituciones_financieras].[activo] CHECK CONSTRAINT [activo$fk_activo_estado1]
GO
ALTER TABLE [instituciones_financieras].[activo]  WITH CHECK ADD  CONSTRAINT [activo$fk_activo_proveedor1] FOREIGN KEY([id_proveedor])
REFERENCES [instituciones_financieras].[proveedor] ([id_proveedor])
GO
ALTER TABLE [instituciones_financieras].[activo] CHECK CONSTRAINT [activo$fk_activo_proveedor1]
GO
ALTER TABLE [instituciones_financieras].[activo]  WITH CHECK ADD  CONSTRAINT [activo$fk_activo_tipo_activo1] FOREIGN KEY([id_tipo])
REFERENCES [instituciones_financieras].[tipo_activo] ([id_tipo])
GO
ALTER TABLE [instituciones_financieras].[activo] CHECK CONSTRAINT [activo$fk_activo_tipo_activo1]
GO
ALTER TABLE [instituciones_financieras].[activo]  WITH CHECK ADD  CONSTRAINT [activo$fk_activo_usuario1] FOREIGN KEY([id_usuario])
REFERENCES [instituciones_financieras].[empleado] ([id_empleado])
GO
ALTER TABLE [instituciones_financieras].[activo] CHECK CONSTRAINT [activo$fk_activo_usuario1]
GO
ALTER TABLE [instituciones_financieras].[activo]  WITH CHECK ADD  CONSTRAINT [af] FOREIGN KEY([id_depto])
REFERENCES [instituciones_financieras].[departamento] ([id_depto])
GO
ALTER TABLE [instituciones_financieras].[activo] CHECK CONSTRAINT [af]
GO
ALTER TABLE [instituciones_financieras].[activo_mant]  WITH CHECK ADD  CONSTRAINT [fk_act_mant] FOREIGN KEY([activo_mant])
REFERENCES [instituciones_financieras].[activo] ([id_activo])
GO
ALTER TABLE [instituciones_financieras].[activo_mant] CHECK CONSTRAINT [fk_act_mant]
GO
ALTER TABLE [instituciones_financieras].[activo_mant]  WITH CHECK ADD  CONSTRAINT [fk_mant_act] FOREIGN KEY([mant_acttivo])
REFERENCES [instituciones_financieras].[mantenimiento] ([id_mantenimiento])
GO
ALTER TABLE [instituciones_financieras].[activo_mant] CHECK CONSTRAINT [fk_mant_act]
GO
ALTER TABLE [instituciones_financieras].[balance_general]  WITH CHECK ADD  CONSTRAINT [balance_general$fk_balance_general_persona_juridica1] FOREIGN KEY([id_persona_juridica])
REFERENCES [instituciones_financieras].[persona_juridica] ([id_persona_juridica])
GO
ALTER TABLE [instituciones_financieras].[balance_general] CHECK CONSTRAINT [balance_general$fk_balance_general_persona_juridica1]
GO
ALTER TABLE [instituciones_financieras].[bien_hipotecario]  WITH CHECK ADD  CONSTRAINT [bien_hipotecario$fk_bien_hipotecario_persona_natural1] FOREIGN KEY([id_persona_natural])
REFERENCES [instituciones_financieras].[cliente] ([id_cliente])
GO
ALTER TABLE [instituciones_financieras].[bien_hipotecario] CHECK CONSTRAINT [bien_hipotecario$fk_bien_hipotecario_persona_natural1]
GO
ALTER TABLE [instituciones_financieras].[cartera]  WITH CHECK ADD  CONSTRAINT [cartera$fk_cartera_cliente1] FOREIGN KEY([id_cliente])
REFERENCES [instituciones_financieras].[cliente] ([id_cliente])
GO
ALTER TABLE [instituciones_financieras].[cartera] CHECK CONSTRAINT [cartera$fk_cartera_cliente1]
GO
ALTER TABLE [instituciones_financieras].[departamento]  WITH CHECK ADD  CONSTRAINT [jakj] FOREIGN KEY([id_sucursal])
REFERENCES [instituciones_financieras].[sucursal] ([id_sucursal])
GO
ALTER TABLE [instituciones_financieras].[departamento] CHECK CONSTRAINT [jakj]
GO
ALTER TABLE [instituciones_financieras].[detalle_compra]  WITH CHECK ADD  CONSTRAINT [detalle_compra$fk_persona_natural_has_prestamo_persona_natural1] FOREIGN KEY([id_cliente])
REFERENCES [instituciones_financieras].[cliente] ([id_cliente])
GO
ALTER TABLE [instituciones_financieras].[detalle_compra] CHECK CONSTRAINT [detalle_compra$fk_persona_natural_has_prestamo_persona_natural1]
GO
ALTER TABLE [instituciones_financieras].[detalle_compra]  WITH CHECK ADD  CONSTRAINT [detalle_compra$fk_persona_natural_has_prestamo_prestamo1] FOREIGN KEY([id_venta])
REFERENCES [instituciones_financieras].[venta] ([id_venta])
GO
ALTER TABLE [instituciones_financieras].[detalle_compra] CHECK CONSTRAINT [detalle_compra$fk_persona_natural_has_prestamo_prestamo1]
GO
ALTER TABLE [instituciones_financieras].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [detalle_venta$fk_venta_has_producto_producto1] FOREIGN KEY([id_producto])
REFERENCES [instituciones_financieras].[producto] ([id_producto])
GO
ALTER TABLE [instituciones_financieras].[detalle_venta] CHECK CONSTRAINT [detalle_venta$fk_venta_has_producto_producto1]
GO
ALTER TABLE [instituciones_financieras].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [detalle_venta$fk_venta_has_producto_venta1] FOREIGN KEY([id_venta])
REFERENCES [instituciones_financieras].[venta] ([id_venta])
GO
ALTER TABLE [instituciones_financieras].[detalle_venta] CHECK CONSTRAINT [detalle_venta$fk_venta_has_producto_venta1]
GO
ALTER TABLE [instituciones_financieras].[estado_resultado]  WITH CHECK ADD  CONSTRAINT [estado_resultado$fk_estado_resultado_persona_juridica1] FOREIGN KEY([id_persona_juridica])
REFERENCES [instituciones_financieras].[persona_juridica] ([id_persona_juridica])
GO
ALTER TABLE [instituciones_financieras].[estado_resultado] CHECK CONSTRAINT [estado_resultado$fk_estado_resultado_persona_juridica1]
GO
ALTER TABLE [instituciones_financieras].[expediente_juridico]  WITH CHECK ADD  CONSTRAINT [expediente_juridico$fk_prestamo_has_persona_juridica_persona_juridica1] FOREIGN KEY([id_persona_juridica])
REFERENCES [instituciones_financieras].[persona_juridica] ([id_persona_juridica])
GO
ALTER TABLE [instituciones_financieras].[expediente_juridico] CHECK CONSTRAINT [expediente_juridico$fk_prestamo_has_persona_juridica_persona_juridica1]
GO
ALTER TABLE [instituciones_financieras].[expediente_juridico]  WITH CHECK ADD  CONSTRAINT [expediente_juridico$fk_prestamo_has_persona_juridica_prestamo1] FOREIGN KEY([id_prestamo])
REFERENCES [instituciones_financieras].[venta] ([id_venta])
GO
ALTER TABLE [instituciones_financieras].[expediente_juridico] CHECK CONSTRAINT [expediente_juridico$fk_prestamo_has_persona_juridica_prestamo1]
GO
ALTER TABLE [instituciones_financieras].[fiador]  WITH CHECK ADD  CONSTRAINT [fiador$fk_codeudor_persona_natural1] FOREIGN KEY([id_persona_natural])
REFERENCES [instituciones_financieras].[cliente] ([id_cliente])
GO
ALTER TABLE [instituciones_financieras].[fiador] CHECK CONSTRAINT [fiador$fk_codeudor_persona_natural1]
GO
ALTER TABLE [instituciones_financieras].[inventario]  WITH CHECK ADD  CONSTRAINT [inventario$fk_inventario_producto1] FOREIGN KEY([id_producto])
REFERENCES [instituciones_financieras].[producto] ([id_producto])
GO
ALTER TABLE [instituciones_financieras].[inventario] CHECK CONSTRAINT [inventario$fk_inventario_producto1]
GO
ALTER TABLE [instituciones_financieras].[mant_enca]  WITH CHECK ADD  CONSTRAINT [fk_enca_mant] FOREIGN KEY([enca_mant])
REFERENCES [instituciones_financieras].[encargado] ([id_encargado])
GO
ALTER TABLE [instituciones_financieras].[mant_enca] CHECK CONSTRAINT [fk_enca_mant]
GO
ALTER TABLE [instituciones_financieras].[mant_enca]  WITH CHECK ADD  CONSTRAINT [fk_mant_enca] FOREIGN KEY([mant_enca])
REFERENCES [instituciones_financieras].[mantenimiento] ([id_mantenimiento])
GO
ALTER TABLE [instituciones_financieras].[mant_enca] CHECK CONSTRAINT [fk_mant_enca]
GO
ALTER TABLE [instituciones_financieras].[pago]  WITH CHECK ADD  CONSTRAINT [pago$fk_pago_prestamo1] FOREIGN KEY([id_venta])
REFERENCES [instituciones_financieras].[venta] ([id_venta])
GO
ALTER TABLE [instituciones_financieras].[pago] CHECK CONSTRAINT [pago$fk_pago_prestamo1]
GO
ALTER TABLE [instituciones_financieras].[producto]  WITH CHECK ADD  CONSTRAINT [producto$fk_producto_proveedor1] FOREIGN KEY([id_proveedor])
REFERENCES [instituciones_financieras].[proveedor] ([id_proveedor])
GO
ALTER TABLE [instituciones_financieras].[producto] CHECK CONSTRAINT [producto$fk_producto_proveedor1]
GO
ALTER TABLE [instituciones_financieras].[tipo_activo]  WITH CHECK ADD  CONSTRAINT [tipo_activo$fk_tipo_activo_clasificacion1] FOREIGN KEY([id_clasificacion])
REFERENCES [instituciones_financieras].[clasificacion] ([id_clasificacion])
GO
ALTER TABLE [instituciones_financieras].[tipo_activo] CHECK CONSTRAINT [tipo_activo$fk_tipo_activo_clasificacion1]
GO
ALTER TABLE [instituciones_financieras].[venta]  WITH CHECK ADD  CONSTRAINT [venta$fk_prestamo_asesor_credito1] FOREIGN KEY([id_empleado])
REFERENCES [instituciones_financieras].[empleado] ([id_empleado])
GO
ALTER TABLE [instituciones_financieras].[venta] CHECK CONSTRAINT [venta$fk_prestamo_asesor_credito1]
GO
ALTER TABLE [instituciones_financieras].[venta]  WITH CHECK ADD  CONSTRAINT [venta$fk_prestamo_plan_pago1] FOREIGN KEY([id_plan])
REFERENCES [instituciones_financieras].[plan_pago] ([id_plan])
GO
ALTER TABLE [instituciones_financieras].[venta] CHECK CONSTRAINT [venta$fk_prestamo_plan_pago1]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.activo' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'activo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.balance_general' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'balance_general'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.bien_hipotecario' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'bien_hipotecario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.cartera' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'cartera'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.clasificacion' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'clasificacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.cliente' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.detalle_compra' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'detalle_compra'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.detalle_venta' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'detalle_venta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.empleado' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'empleado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.encargado' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'encargado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.estado' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.estado_resultado' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'estado_resultado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.expediente_juridico' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'expediente_juridico'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.fiador' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'fiador'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.inventario' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'inventario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.pago' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'pago'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.persona_juridica' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'persona_juridica'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.plan_pago' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'plan_pago'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.producto' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'producto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.proveedor' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'proveedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.tipo_activo' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'tipo_activo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.tipo_credito' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'tipo_credito'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'instituciones_financieras.venta' , @level0type=N'SCHEMA',@level0name=N'instituciones_financieras', @level1type=N'TABLE',@level1name=N'venta'
GO
USE [master]
GO
ALTER DATABASE [instituciones_financieras] SET  READ_WRITE 
GO
