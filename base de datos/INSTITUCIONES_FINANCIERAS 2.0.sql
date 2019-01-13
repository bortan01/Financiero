
USE instituciones_financieras
GO
 IF NOT EXISTS(SELECT * FROM sys.schemas WHERE [name] = N'instituciones_financieras')      
     EXEC (N'CREATE SCHEMA instituciones_financieras')                                   
 GO                                                               

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'activo'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'activo'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[activo]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[activo]
(
   [id_activo] nvarchar(23)  NOT NULL,
   [id_tipo] int  NOT NULL,
   [id_depto] nvarchar(3)  NOT NULL,
   [id_estado] int  NOT NULL,
   [id_usuario] int  NOT NULL,
   [id_proveedor] int  NOT NULL,
   [correlativo] nvarchar(45)  NULL,
   [fecha_adquisicion] date  NULL,
   [descripcion] nvarchar(200)  NULL,
   [estado] nvarchar(45)  NULL,
   [observaciones] nvarchar(200)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.activo',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'activo'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'activo_mant'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'activo_mant'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[activo_mant]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[activo_mant]
(
   [idactivo_mant] nvarchar(23)  NULL,
   [mant_activo] int  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.activo_mant',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'activo_mant'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'balance_general'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'balance_general'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[balance_general]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[balance_general]
(
   [id_balance] int IDENTITY(1, 1)  NOT NULL,
   [id_persona_juridica] int  NOT NULL,
   [periodo] int  NULL,
   [prestable] smallint  NULL,
   [efectivo] float(24)  NULL,
   [valor_negociable] float(24)  NULL,
   [cuentas_por_cobrar] float(24)  NULL,
   [inventarios] float(24)  NULL,
   [terrenos] float(24)  NULL,
   [edificio_equipo] float(24)  NULL,
   [depreciacion_acumulada] float(24)  NULL,
   [total_activo_corriente] float(24)  NULL,
   [total_activo_pasivo] float(24)  NULL,
   [total_activo] float(24)  NULL,
   [cuentas_por_pagar] float(24)  NULL,
   [documentos_por_pagar] float(24)  NULL,
   [total_pasivo_corriente] float(24)  NULL,
   [deuda_largo_plazo] float(24)  NULL,
   [acciones_comunes] float(24)  NULL,
   [ganancias_retenidas] float(24)  NULL,
   [total_pasivo] float(24)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.balance_general',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'balance_general'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'bien_hipotecario'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'bien_hipotecario'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[bien_hipotecario]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[bien_hipotecario]
(
   [id_bien] int IDENTITY(1, 1)  NOT NULL,
   [id_persona_natural] int  NOT NULL,
   [descripcion] nvarchar(200)  NULL,
   [ubicacion] nvarchar(45)  NULL,
   [otros_datos] nvarchar(45)  NULL,
   [anexo] varbinary(max)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.bien_hipotecario',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'bien_hipotecario'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'clasificacion'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'clasificacion'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[clasificacion]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[clasificacion]
(
   [id_clasificacion] int IDENTITY(1, 1)  NOT NULL,
   [nombre] nvarchar(45)  NULL,
   [correlativo] nvarchar(45)  NULL,
   [tiempo_depreciacion] int  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.clasificacion',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'clasificacion'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'cliente'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'cliente'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[cliente]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[cliente]
(
   [id_cliente] int IDENTITY(1, 1)  NOT NULL,
   [nombre] nvarchar(30)  NULL,
   [apellido] nvarchar(30)  NULL,
   [direccion] nvarchar(100)  NULL,
   [dui] nvarchar(15)  NULL,
   [nit] nvarchar(15)  NULL,
   [correo] nvarchar(30)  NULL,
   [observaciones] nvarchar(300)  NULL,
   [telefono] nvarchar(12)  NULL,
   [contrato_pagare] nvarchar(2000)  NULL,
   [cartera] nvarchar(45)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.cliente',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'cliente'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'compras'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'compras'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[compras]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[compras]
(
   [id_compra] int IDENTITY(1, 1)  NOT NULL,
   [total] decimal(18, 2)  NULL,
   [fecha_compra] datetime2(0)  NULL,
   [comprobante] varbinary(max)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.compras',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'compras'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'departamento'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'departamento'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[departamento]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[departamento]
(
   [id_departamento] nvarchar(3)  NOT NULL,
   [nombre] nvarchar(45)  NULL,
   [id_sucursal] nvarchar(3)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.departamento',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'departamento'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'detalle_compra'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'detalle_compra'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[detalle_compra]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[detalle_compra]
(
   [id_cliente] int  NOT NULL,
   [id_venta] int  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.detalle_compra',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'detalle_compra'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'detalle_compras'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'detalle_compras'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[detalle_compras]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[detalle_compras]
(
   [id_compra] int  NOT NULL,
   [id_producto] int  NOT NULL,
   [cantidad] int  NULL,
   [precio] decimal(18, 2)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.detalle_compras',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'detalle_compras'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'detalle_venta'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'detalle_venta'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[detalle_venta]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[detalle_venta]
(
   [id_venta] int  NOT NULL,
   [id_producto] int  NOT NULL,
   [cantidad] int  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.detalle_venta',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'detalle_venta'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'empleado'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'empleado'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[empleado]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[empleado]
(
   [id_empleado] int IDENTITY(1, 1)  NOT NULL,
   [nombre] nvarchar(30)  NULL,
   [apellido] nvarchar(30)  NULL,
   [zona] nvarchar(30)  NULL,
   [dui] nvarchar(45)  NULL,
   [pass] nvarchar(45)  NULL,
   [nivel] nvarchar(45)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.empleado',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'empleado'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'encargado'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'encargado'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[encargado]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[encargado]
(
   [id_encargado] int  NOT NULL,
   [nombre] nvarchar(45)  NULL,
   [direccion] nvarchar(45)  NULL,
   [telefono] nvarchar(45)  NULL,
   [correo] nvarchar(45)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.encargado',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'encargado'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'estado'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'estado'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[estado]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[estado]
(
   [id_estado] int IDENTITY(1, 1)  NOT NULL,
   [nombre] nvarchar(45)  NULL,
   [tiempo_de_uso] int  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.estado',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'estado'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'estado_resultado'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'estado_resultado'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[estado_resultado]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[estado_resultado]
(
   [id_estado] int IDENTITY(1, 1)  NOT NULL,
   [id_persona_juridica] int  NOT NULL,
   [periodo] int  NULL,
   [prestable] smallint  NULL,
   [ingreso_ventas] float(24)  NULL,
   [costo_venta] float(24)  NULL,
   [utilidad_bruta] float(24)  NULL,
   [gastos_operativos] float(24)  NULL,
   [gasto_venta] float(24)  NULL,
   [gasto_administrativo] float(24)  NULL,
   [gasto_arrendamiento] float(24)  NULL,
   [gasto_depreciacion] float(24)  NULL,
   [total_gasto_operativo] float(24)  NULL,
   [utlidad_operativa] float(24)  NULL,
   [gasto_interes] float(24)  NULL,
   [utilidad_antes_impuestos] float(24)  NULL,
   [impuestos] float(24)  NULL,
   [utilidad_neta] float(24)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.estado_resultado',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'estado_resultado'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'expediente_juridico'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'expediente_juridico'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[expediente_juridico]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[expediente_juridico]
(
   [id_prestamo] int  NOT NULL,
   [id_persona_juridica] int  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.expediente_juridico',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'expediente_juridico'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'fiador'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'fiador'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[fiador]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[fiador]
(
   [id_fiador] int IDENTITY(1, 1)  NOT NULL,
   [id_persona_natural] int  NOT NULL,
   [nombre] nvarchar(30)  NULL,
   [apellido] nvarchar(30)  NULL,
   [direccion] nvarchar(254)  NULL,
   [dui] nvarchar(15)  NULL,
   [nit] nvarchar(15)  NULL,
   [correo] nvarchar(30)  NULL,
   [lugar_trabajo] nvarchar(max)  NULL,
   [telefono] nvarchar(12)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.fiador',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'fiador'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'inventario'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'inventario'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[inventario]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[inventario]
(
   [id_inventario] int IDENTITY(1, 1)  NOT NULL,
   [cantidad] int  NULL,
   [id_producto] int  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.inventario',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'inventario'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'mant_encar'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'mant_encar'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[mant_encar]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[mant_encar]
(
   [idmant_encar] int  NOT NULL,
   [encarg_mant] int  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.mant_encar',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'mant_encar'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'mantenimiento'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'mantenimiento'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[mantenimiento]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[mantenimiento]
(
   [id_mantenimiento] int  NOT NULL,
   [fecha] date  NULL,
   [costo] float(53)  NULL,
   [detalle] nvarchar(max)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.mantenimiento',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'mantenimiento'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'pago'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'pago'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[pago]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[pago]
(
   [id_pago] int IDENTITY(1, 1)  NOT NULL,
   [id_venta] int  NOT NULL,
   [monto] float(24)  NULL,
   [fecha] date  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.pago',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'pago'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'persona_juridica'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'persona_juridica'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[persona_juridica]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[persona_juridica]
(
   [id_persona_juridica] int IDENTITY(1, 1)  NOT NULL,
   [nombre] nvarchar(45)  NULL,
   [categoria] nvarchar(45)  NULL,
   [numero] nvarchar(45)  NULL,
   [dui] nvarchar(45)  NULL,
   [nit] nvarchar(45)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.persona_juridica',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'persona_juridica'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'plan_pago'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'plan_pago'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[plan_pago]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[plan_pago]
(
   [id_plan] int IDENTITY(1, 1)  NOT NULL,
   [tasa] float(24)  NULL,
   [cuotas] int  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.plan_pago',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'plan_pago'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'producto'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'producto'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[producto]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[producto]
(
   [id_producto] int  NOT NULL,
   [id_proveedor] int  NOT NULL,
   [nombre] nvarchar(45)  NULL,
   [descripcion] nvarchar(200)  NULL,
   [precio_compra] float(24)  NULL,
   [precio_venta] float(24)  NULL,
   [minimo] int  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.producto',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'producto'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'proveedor'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'proveedor'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[proveedor]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[proveedor]
(
   [id_proveedor] int IDENTITY(1, 1)  NOT NULL,
   [nombre] nvarchar(45)  NULL,
   [dui] nvarchar(45)  NULL,
   [direccion] nvarchar(45)  NULL,
   [telefono] nvarchar(45)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.proveedor',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'proveedor'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'sucursal'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'sucursal'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[sucursal]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[sucursal]
(
   [id_sucursal] nvarchar(3)  NOT NULL,
   [nombre] nvarchar(45)  NULL,
   [direccion] nvarchar(85)  NULL,
   [telefono] nvarchar(45)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.sucursal',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'sucursal'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'tipo_activo'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'tipo_activo'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[tipo_activo]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[tipo_activo]
(
   [id_tipo] int IDENTITY(1, 1)  NOT NULL,
   [id_clasificacion] int  NOT NULL,
   [nombre] nvarchar(45)  NULL,
   [correlativo] nvarchar(45)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.tipo_activo',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'tipo_activo'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'tipo_credito'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'tipo_credito'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[tipo_credito]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[tipo_credito]
(
   [id_tipo_credito] int IDENTITY(1, 1)  NOT NULL,
   [nombre] nvarchar(20)  NULL,
   [terminis_condiciones] nvarchar(300)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.tipo_credito',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'tipo_credito'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'venta'  AND sc.name = N'instituciones_financieras'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'venta'  AND sc.name = N'instituciones_financieras'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [instituciones_financieras].[venta]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[instituciones_financieras].[venta]
(
   [id_venta] int IDENTITY(1, 1)  NOT NULL,
   [id_plan] int  NOT NULL,
   [id_empleado] int  NOT NULL,
   [prestamo_original] float(24)  NULL,
   [saldo_actual] float(24)  NULL,
   [mora_acumulada] float(24)  NULL,
   [intereses_acumulados] float(24)  NULL,
   [estado] nvarchar(20)  NULL,
   [proximo_pago] date  NULL,
   [fecha] date  NULL,
   [cuota] float(24)  NULL,
   [contador_mora] int  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'instituciones_financieras.venta',
        N'SCHEMA', N'instituciones_financieras',
        N'TABLE', N'venta'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_activo_id_activo'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[activo] DROP CONSTRAINT [PK_activo_id_activo]
 GO



ALTER TABLE [instituciones_financieras].[activo]
 ADD CONSTRAINT [PK_activo_id_activo]
   PRIMARY KEY
   CLUSTERED ([id_activo] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_balance_general_id_balance'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[balance_general] DROP CONSTRAINT [PK_balance_general_id_balance]
 GO



ALTER TABLE [instituciones_financieras].[balance_general]
 ADD CONSTRAINT [PK_balance_general_id_balance]
   PRIMARY KEY
   CLUSTERED ([id_balance] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_bien_hipotecario_id_bien'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[bien_hipotecario] DROP CONSTRAINT [PK_bien_hipotecario_id_bien]
 GO



ALTER TABLE [instituciones_financieras].[bien_hipotecario]
 ADD CONSTRAINT [PK_bien_hipotecario_id_bien]
   PRIMARY KEY
   CLUSTERED ([id_bien] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_clasificacion_id_clasificacion'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[clasificacion] DROP CONSTRAINT [PK_clasificacion_id_clasificacion]
 GO



ALTER TABLE [instituciones_financieras].[clasificacion]
 ADD CONSTRAINT [PK_clasificacion_id_clasificacion]
   PRIMARY KEY
   CLUSTERED ([id_clasificacion] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_cliente_id_cliente'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[cliente] DROP CONSTRAINT [PK_cliente_id_cliente]
 GO



ALTER TABLE [instituciones_financieras].[cliente]
 ADD CONSTRAINT [PK_cliente_id_cliente]
   PRIMARY KEY
   CLUSTERED ([id_cliente] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_compras_id_compra'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[compras] DROP CONSTRAINT [PK_compras_id_compra]
 GO



ALTER TABLE [instituciones_financieras].[compras]
 ADD CONSTRAINT [PK_compras_id_compra]
   PRIMARY KEY
   CLUSTERED ([id_compra] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_departamento_id_departamento'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[departamento] DROP CONSTRAINT [PK_departamento_id_departamento]
 GO



ALTER TABLE [instituciones_financieras].[departamento]
 ADD CONSTRAINT [PK_departamento_id_departamento]
   PRIMARY KEY
   CLUSTERED ([id_departamento] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_empleado_id_empleado'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[empleado] DROP CONSTRAINT [PK_empleado_id_empleado]
 GO



ALTER TABLE [instituciones_financieras].[empleado]
 ADD CONSTRAINT [PK_empleado_id_empleado]
   PRIMARY KEY
   CLUSTERED ([id_empleado] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_encargado_id_encargado'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[encargado] DROP CONSTRAINT [PK_encargado_id_encargado]
 GO



ALTER TABLE [instituciones_financieras].[encargado]
 ADD CONSTRAINT [PK_encargado_id_encargado]
   PRIMARY KEY
   CLUSTERED ([id_encargado] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_estado_id_estado'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[estado] DROP CONSTRAINT [PK_estado_id_estado]
 GO



ALTER TABLE [instituciones_financieras].[estado]
 ADD CONSTRAINT [PK_estado_id_estado]
   PRIMARY KEY
   CLUSTERED ([id_estado] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_estado_resultado_id_estado'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[estado_resultado] DROP CONSTRAINT [PK_estado_resultado_id_estado]
 GO



ALTER TABLE [instituciones_financieras].[estado_resultado]
 ADD CONSTRAINT [PK_estado_resultado_id_estado]
   PRIMARY KEY
   CLUSTERED ([id_estado] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_fiador_id_fiador'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[fiador] DROP CONSTRAINT [PK_fiador_id_fiador]
 GO



ALTER TABLE [instituciones_financieras].[fiador]
 ADD CONSTRAINT [PK_fiador_id_fiador]
   PRIMARY KEY
   CLUSTERED ([id_fiador] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_inventario_id_inventario'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[inventario] DROP CONSTRAINT [PK_inventario_id_inventario]
 GO



ALTER TABLE [instituciones_financieras].[inventario]
 ADD CONSTRAINT [PK_inventario_id_inventario]
   PRIMARY KEY
   CLUSTERED ([id_inventario] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_mantenimiento_id_mantenimiento'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[mantenimiento] DROP CONSTRAINT [PK_mantenimiento_id_mantenimiento]
 GO



ALTER TABLE [instituciones_financieras].[mantenimiento]
 ADD CONSTRAINT [PK_mantenimiento_id_mantenimiento]
   PRIMARY KEY
   CLUSTERED ([id_mantenimiento] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_pago_id_pago'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[pago] DROP CONSTRAINT [PK_pago_id_pago]
 GO



ALTER TABLE [instituciones_financieras].[pago]
 ADD CONSTRAINT [PK_pago_id_pago]
   PRIMARY KEY
   CLUSTERED ([id_pago] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_persona_juridica_id_persona_juridica'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[persona_juridica] DROP CONSTRAINT [PK_persona_juridica_id_persona_juridica]
 GO



ALTER TABLE [instituciones_financieras].[persona_juridica]
 ADD CONSTRAINT [PK_persona_juridica_id_persona_juridica]
   PRIMARY KEY
   CLUSTERED ([id_persona_juridica] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_plan_pago_id_plan'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[plan_pago] DROP CONSTRAINT [PK_plan_pago_id_plan]
 GO



ALTER TABLE [instituciones_financieras].[plan_pago]
 ADD CONSTRAINT [PK_plan_pago_id_plan]
   PRIMARY KEY
   CLUSTERED ([id_plan] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_producto_id_producto'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[producto] DROP CONSTRAINT [PK_producto_id_producto]
 GO



ALTER TABLE [instituciones_financieras].[producto]
 ADD CONSTRAINT [PK_producto_id_producto]
   PRIMARY KEY
   CLUSTERED ([id_producto] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_proveedor_id_proveedor'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[proveedor] DROP CONSTRAINT [PK_proveedor_id_proveedor]
 GO



ALTER TABLE [instituciones_financieras].[proveedor]
 ADD CONSTRAINT [PK_proveedor_id_proveedor]
   PRIMARY KEY
   CLUSTERED ([id_proveedor] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_sucursal_id_sucursal'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[sucursal] DROP CONSTRAINT [PK_sucursal_id_sucursal]
 GO



ALTER TABLE [instituciones_financieras].[sucursal]
 ADD CONSTRAINT [PK_sucursal_id_sucursal]
   PRIMARY KEY
   CLUSTERED ([id_sucursal] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_tipo_activo_id_tipo'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[tipo_activo] DROP CONSTRAINT [PK_tipo_activo_id_tipo]
 GO



ALTER TABLE [instituciones_financieras].[tipo_activo]
 ADD CONSTRAINT [PK_tipo_activo_id_tipo]
   PRIMARY KEY
   CLUSTERED ([id_tipo] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_tipo_credito_id_tipo_credito'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[tipo_credito] DROP CONSTRAINT [PK_tipo_credito_id_tipo_credito]
 GO



ALTER TABLE [instituciones_financieras].[tipo_credito]
 ADD CONSTRAINT [PK_tipo_credito_id_tipo_credito]
   PRIMARY KEY
   CLUSTERED ([id_tipo_credito] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_venta_id_venta'  AND sc.name = N'instituciones_financieras'  AND type in (N'PK'))
ALTER TABLE [instituciones_financieras].[venta] DROP CONSTRAINT [PK_venta_id_venta]
 GO



ALTER TABLE [instituciones_financieras].[venta]
 ADD CONSTRAINT [PK_venta_id_venta]
   PRIMARY KEY
   CLUSTERED ([id_venta] ASC)

GO


USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'activo_mant'  AND sc.name = N'instituciones_financieras'  AND si.name = N'activo_mant_idx' AND so.type in (N'U'))
   DROP INDEX [activo_mant_idx] ON [instituciones_financieras].[activo_mant] 
GO
CREATE NONCLUSTERED INDEX [activo_mant_idx] ON [instituciones_financieras].[activo_mant]
(
   [idactivo_mant] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'mant_encar'  AND sc.name = N'instituciones_financieras'  AND si.name = N'enca_mant_idx' AND so.type in (N'U'))
   DROP INDEX [enca_mant_idx] ON [instituciones_financieras].[mant_encar] 
GO
CREATE NONCLUSTERED INDEX [enca_mant_idx] ON [instituciones_financieras].[mant_encar]
(
   [encarg_mant] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'departamento'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fj_detop_sucusrsal_idx' AND so.type in (N'U'))
   DROP INDEX [fj_detop_sucusrsal_idx] ON [instituciones_financieras].[departamento] 
GO
CREATE NONCLUSTERED INDEX [fj_detop_sucusrsal_idx] ON [instituciones_financieras].[departamento]
(
   [id_sucursal] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'activo'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_activo_estado1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_activo_estado1_idx] ON [instituciones_financieras].[activo] 
GO
CREATE NONCLUSTERED INDEX [fk_activo_estado1_idx] ON [instituciones_financieras].[activo]
(
   [id_estado] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'activo'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_activo_proveedor1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_activo_proveedor1_idx] ON [instituciones_financieras].[activo] 
GO
CREATE NONCLUSTERED INDEX [fk_activo_proveedor1_idx] ON [instituciones_financieras].[activo]
(
   [id_proveedor] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'activo'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_activo_sucursal_idx' AND so.type in (N'U'))
   DROP INDEX [fk_activo_sucursal_idx] ON [instituciones_financieras].[activo] 
GO
CREATE NONCLUSTERED INDEX [fk_activo_sucursal_idx] ON [instituciones_financieras].[activo]
(
   [id_depto] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'activo'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_activo_tipo_activo1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_activo_tipo_activo1_idx] ON [instituciones_financieras].[activo] 
GO
CREATE NONCLUSTERED INDEX [fk_activo_tipo_activo1_idx] ON [instituciones_financieras].[activo]
(
   [id_tipo] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'activo'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_activo_usuario1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_activo_usuario1_idx] ON [instituciones_financieras].[activo] 
GO
CREATE NONCLUSTERED INDEX [fk_activo_usuario1_idx] ON [instituciones_financieras].[activo]
(
   [id_usuario] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'balance_general'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_balance_general_persona_juridica1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_balance_general_persona_juridica1_idx] ON [instituciones_financieras].[balance_general] 
GO
CREATE NONCLUSTERED INDEX [fk_balance_general_persona_juridica1_idx] ON [instituciones_financieras].[balance_general]
(
   [id_persona_juridica] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'bien_hipotecario'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_bien_hipotecario_persona_natural1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_bien_hipotecario_persona_natural1_idx] ON [instituciones_financieras].[bien_hipotecario] 
GO
CREATE NONCLUSTERED INDEX [fk_bien_hipotecario_persona_natural1_idx] ON [instituciones_financieras].[bien_hipotecario]
(
   [id_persona_natural] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'fiador'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_codeudor_persona_natural1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_codeudor_persona_natural1_idx] ON [instituciones_financieras].[fiador] 
GO
CREATE NONCLUSTERED INDEX [fk_codeudor_persona_natural1_idx] ON [instituciones_financieras].[fiador]
(
   [id_persona_natural] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'detalle_compras'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_compras_has_producto_compras1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_compras_has_producto_compras1_idx] ON [instituciones_financieras].[detalle_compras] 
GO
CREATE NONCLUSTERED INDEX [fk_compras_has_producto_compras1_idx] ON [instituciones_financieras].[detalle_compras]
(
   [id_compra] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'detalle_compras'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_compras_has_producto_producto1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_compras_has_producto_producto1_idx] ON [instituciones_financieras].[detalle_compras] 
GO
CREATE NONCLUSTERED INDEX [fk_compras_has_producto_producto1_idx] ON [instituciones_financieras].[detalle_compras]
(
   [id_producto] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'estado_resultado'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_estado_resultado_persona_juridica1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_estado_resultado_persona_juridica1_idx] ON [instituciones_financieras].[estado_resultado] 
GO
CREATE NONCLUSTERED INDEX [fk_estado_resultado_persona_juridica1_idx] ON [instituciones_financieras].[estado_resultado]
(
   [id_persona_juridica] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'inventario'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_inventario_producto1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_inventario_producto1_idx] ON [instituciones_financieras].[inventario] 
GO
CREATE NONCLUSTERED INDEX [fk_inventario_producto1_idx] ON [instituciones_financieras].[inventario]
(
   [id_producto] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'pago'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_pago_prestamo1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_pago_prestamo1_idx] ON [instituciones_financieras].[pago] 
GO
CREATE NONCLUSTERED INDEX [fk_pago_prestamo1_idx] ON [instituciones_financieras].[pago]
(
   [id_venta] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'detalle_compra'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_persona_natural_has_prestamo_persona_natural1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_persona_natural_has_prestamo_persona_natural1_idx] ON [instituciones_financieras].[detalle_compra] 
GO
CREATE NONCLUSTERED INDEX [fk_persona_natural_has_prestamo_persona_natural1_idx] ON [instituciones_financieras].[detalle_compra]
(
   [id_cliente] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'detalle_compra'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_persona_natural_has_prestamo_prestamo1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_persona_natural_has_prestamo_prestamo1_idx] ON [instituciones_financieras].[detalle_compra] 
GO
CREATE NONCLUSTERED INDEX [fk_persona_natural_has_prestamo_prestamo1_idx] ON [instituciones_financieras].[detalle_compra]
(
   [id_venta] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'venta'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_prestamo_asesor_credito1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_prestamo_asesor_credito1_idx] ON [instituciones_financieras].[venta] 
GO
CREATE NONCLUSTERED INDEX [fk_prestamo_asesor_credito1_idx] ON [instituciones_financieras].[venta]
(
   [id_empleado] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'expediente_juridico'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_prestamo_has_persona_juridica_persona_juridica1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_prestamo_has_persona_juridica_persona_juridica1_idx] ON [instituciones_financieras].[expediente_juridico] 
GO
CREATE NONCLUSTERED INDEX [fk_prestamo_has_persona_juridica_persona_juridica1_idx] ON [instituciones_financieras].[expediente_juridico]
(
   [id_persona_juridica] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'expediente_juridico'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_prestamo_has_persona_juridica_prestamo1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_prestamo_has_persona_juridica_prestamo1_idx] ON [instituciones_financieras].[expediente_juridico] 
GO
CREATE NONCLUSTERED INDEX [fk_prestamo_has_persona_juridica_prestamo1_idx] ON [instituciones_financieras].[expediente_juridico]
(
   [id_prestamo] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'venta'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_prestamo_plan_pago1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_prestamo_plan_pago1_idx] ON [instituciones_financieras].[venta] 
GO
CREATE NONCLUSTERED INDEX [fk_prestamo_plan_pago1_idx] ON [instituciones_financieras].[venta]
(
   [id_plan] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'producto'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_producto_proveedor1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_producto_proveedor1_idx] ON [instituciones_financieras].[producto] 
GO
CREATE NONCLUSTERED INDEX [fk_producto_proveedor1_idx] ON [instituciones_financieras].[producto]
(
   [id_proveedor] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'tipo_activo'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_tipo_activo_clasificacion1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_tipo_activo_clasificacion1_idx] ON [instituciones_financieras].[tipo_activo] 
GO
CREATE NONCLUSTERED INDEX [fk_tipo_activo_clasificacion1_idx] ON [instituciones_financieras].[tipo_activo]
(
   [id_clasificacion] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'detalle_venta'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_venta_has_producto_producto1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_venta_has_producto_producto1_idx] ON [instituciones_financieras].[detalle_venta] 
GO
CREATE NONCLUSTERED INDEX [fk_venta_has_producto_producto1_idx] ON [instituciones_financieras].[detalle_venta]
(
   [id_producto] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'detalle_venta'  AND sc.name = N'instituciones_financieras'  AND si.name = N'fk_venta_has_producto_venta1_idx' AND so.type in (N'U'))
   DROP INDEX [fk_venta_has_producto_venta1_idx] ON [instituciones_financieras].[detalle_venta] 
GO
CREATE NONCLUSTERED INDEX [fk_venta_has_producto_venta1_idx] ON [instituciones_financieras].[detalle_venta]
(
   [id_venta] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'activo_mant'  AND sc.name = N'instituciones_financieras'  AND si.name = N'mant_acti_idx' AND so.type in (N'U'))
   DROP INDEX [mant_acti_idx] ON [instituciones_financieras].[activo_mant] 
GO
CREATE NONCLUSTERED INDEX [mant_acti_idx] ON [instituciones_financieras].[activo_mant]
(
   [mant_activo] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'mant_encar'  AND sc.name = N'instituciones_financieras'  AND si.name = N'mante_enca_idx' AND so.type in (N'U'))
   DROP INDEX [mante_enca_idx] ON [instituciones_financieras].[mant_encar] 
GO
CREATE NONCLUSTERED INDEX [mante_enca_idx] ON [instituciones_financieras].[mant_encar]
(
   [idmant_encar] ASC
)
WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY] 
GO
GO

USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'activo$fk_activo_estado1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[activo] DROP CONSTRAINT [activo$fk_activo_estado1]
 GO



ALTER TABLE [instituciones_financieras].[activo]
 ADD CONSTRAINT [activo$fk_activo_estado1]
 FOREIGN KEY 
   ([id_estado])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[estado]     ([id_estado])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'activo$fk_activo_proveedor1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[activo] DROP CONSTRAINT [activo$fk_activo_proveedor1]
 GO



ALTER TABLE [instituciones_financieras].[activo]
 ADD CONSTRAINT [activo$fk_activo_proveedor1]
 FOREIGN KEY 
   ([id_proveedor])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[proveedor]     ([id_proveedor])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'activo$fk_activo_sucursal'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[activo] DROP CONSTRAINT [activo$fk_activo_sucursal]
 GO



ALTER TABLE [instituciones_financieras].[activo]
 ADD CONSTRAINT [activo$fk_activo_sucursal]
 FOREIGN KEY 
   ([id_depto])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[departamento]     ([id_departamento])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'activo$fk_activo_tipo_activo1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[activo] DROP CONSTRAINT [activo$fk_activo_tipo_activo1]
 GO



ALTER TABLE [instituciones_financieras].[activo]
 ADD CONSTRAINT [activo$fk_activo_tipo_activo1]
 FOREIGN KEY 
   ([id_tipo])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[tipo_activo]     ([id_tipo])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'activo$fk_activo_usuario1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[activo] DROP CONSTRAINT [activo$fk_activo_usuario1]
 GO



ALTER TABLE [instituciones_financieras].[activo]
 ADD CONSTRAINT [activo$fk_activo_usuario1]
 FOREIGN KEY 
   ([id_usuario])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[empleado]     ([id_empleado])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'activo_mant$activo_mant'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[activo_mant] DROP CONSTRAINT [activo_mant$activo_mant]
 GO



ALTER TABLE [instituciones_financieras].[activo_mant]
 ADD CONSTRAINT [activo_mant$activo_mant]
 FOREIGN KEY 
   ([idactivo_mant])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[activo]     ([id_activo])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'activo_mant$mant_acti'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[activo_mant] DROP CONSTRAINT [activo_mant$mant_acti]
 GO



ALTER TABLE [instituciones_financieras].[activo_mant]
 ADD CONSTRAINT [activo_mant$mant_acti]
 FOREIGN KEY 
   ([mant_activo])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[mantenimiento]     ([id_mantenimiento])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'balance_general$fk_balance_general_persona_juridica1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[balance_general] DROP CONSTRAINT [balance_general$fk_balance_general_persona_juridica1]
 GO



ALTER TABLE [instituciones_financieras].[balance_general]
 ADD CONSTRAINT [balance_general$fk_balance_general_persona_juridica1]
 FOREIGN KEY 
   ([id_persona_juridica])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[persona_juridica]     ([id_persona_juridica])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'bien_hipotecario$fk_bien_hipotecario_persona_natural1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[bien_hipotecario] DROP CONSTRAINT [bien_hipotecario$fk_bien_hipotecario_persona_natural1]
 GO



ALTER TABLE [instituciones_financieras].[bien_hipotecario]
 ADD CONSTRAINT [bien_hipotecario$fk_bien_hipotecario_persona_natural1]
 FOREIGN KEY 
   ([id_persona_natural])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[cliente]     ([id_cliente])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'departamento$fj_detop_sucusrsal'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[departamento] DROP CONSTRAINT [departamento$fj_detop_sucusrsal]
 GO



ALTER TABLE [instituciones_financieras].[departamento]
 ADD CONSTRAINT [departamento$fj_detop_sucusrsal]
 FOREIGN KEY 
   ([id_sucursal])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[sucursal]     ([id_sucursal])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'detalle_compra$fk_persona_natural_has_prestamo_persona_natural1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[detalle_compra] DROP CONSTRAINT [detalle_compra$fk_persona_natural_has_prestamo_persona_natural1]
 GO



ALTER TABLE [instituciones_financieras].[detalle_compra]
 ADD CONSTRAINT [detalle_compra$fk_persona_natural_has_prestamo_persona_natural1]
 FOREIGN KEY 
   ([id_cliente])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[cliente]     ([id_cliente])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'detalle_compra$fk_persona_natural_has_prestamo_prestamo1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[detalle_compra] DROP CONSTRAINT [detalle_compra$fk_persona_natural_has_prestamo_prestamo1]
 GO



ALTER TABLE [instituciones_financieras].[detalle_compra]
 ADD CONSTRAINT [detalle_compra$fk_persona_natural_has_prestamo_prestamo1]
 FOREIGN KEY 
   ([id_venta])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[venta]     ([id_venta])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'detalle_compras$fk_compras_has_producto_compras1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[detalle_compras] DROP CONSTRAINT [detalle_compras$fk_compras_has_producto_compras1]
 GO



ALTER TABLE [instituciones_financieras].[detalle_compras]
 ADD CONSTRAINT [detalle_compras$fk_compras_has_producto_compras1]
 FOREIGN KEY 
   ([id_compra])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[compras]     ([id_compra])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'detalle_compras$fk_compras_has_producto_producto1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[detalle_compras] DROP CONSTRAINT [detalle_compras$fk_compras_has_producto_producto1]
 GO



ALTER TABLE [instituciones_financieras].[detalle_compras]
 ADD CONSTRAINT [detalle_compras$fk_compras_has_producto_producto1]
 FOREIGN KEY 
   ([id_producto])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[producto]     ([id_producto])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'detalle_venta$fk_venta_has_producto_producto1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[detalle_venta] DROP CONSTRAINT [detalle_venta$fk_venta_has_producto_producto1]
 GO



ALTER TABLE [instituciones_financieras].[detalle_venta]
 ADD CONSTRAINT [detalle_venta$fk_venta_has_producto_producto1]
 FOREIGN KEY 
   ([id_producto])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[producto]     ([id_producto])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'detalle_venta$fk_venta_has_producto_venta1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[detalle_venta] DROP CONSTRAINT [detalle_venta$fk_venta_has_producto_venta1]
 GO



ALTER TABLE [instituciones_financieras].[detalle_venta]
 ADD CONSTRAINT [detalle_venta$fk_venta_has_producto_venta1]
 FOREIGN KEY 
   ([id_venta])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[venta]     ([id_venta])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'estado_resultado$fk_estado_resultado_persona_juridica1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[estado_resultado] DROP CONSTRAINT [estado_resultado$fk_estado_resultado_persona_juridica1]
 GO



ALTER TABLE [instituciones_financieras].[estado_resultado]
 ADD CONSTRAINT [estado_resultado$fk_estado_resultado_persona_juridica1]
 FOREIGN KEY 
   ([id_persona_juridica])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[persona_juridica]     ([id_persona_juridica])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'expediente_juridico$fk_prestamo_has_persona_juridica_persona_juridica1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[expediente_juridico] DROP CONSTRAINT [expediente_juridico$fk_prestamo_has_persona_juridica_persona_juridica1]
 GO



ALTER TABLE [instituciones_financieras].[expediente_juridico]
 ADD CONSTRAINT [expediente_juridico$fk_prestamo_has_persona_juridica_persona_juridica1]
 FOREIGN KEY 
   ([id_persona_juridica])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[persona_juridica]     ([id_persona_juridica])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'expediente_juridico$fk_prestamo_has_persona_juridica_prestamo1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[expediente_juridico] DROP CONSTRAINT [expediente_juridico$fk_prestamo_has_persona_juridica_prestamo1]
 GO



ALTER TABLE [instituciones_financieras].[expediente_juridico]
 ADD CONSTRAINT [expediente_juridico$fk_prestamo_has_persona_juridica_prestamo1]
 FOREIGN KEY 
   ([id_prestamo])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[venta]     ([id_venta])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'fiador$fk_codeudor_persona_natural1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[fiador] DROP CONSTRAINT [fiador$fk_codeudor_persona_natural1]
 GO



ALTER TABLE [instituciones_financieras].[fiador]
 ADD CONSTRAINT [fiador$fk_codeudor_persona_natural1]
 FOREIGN KEY 
   ([id_persona_natural])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[cliente]     ([id_cliente])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'inventario$fk_inventario_producto1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[inventario] DROP CONSTRAINT [inventario$fk_inventario_producto1]
 GO



ALTER TABLE [instituciones_financieras].[inventario]
 ADD CONSTRAINT [inventario$fk_inventario_producto1]
 FOREIGN KEY 
   ([id_producto])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[producto]     ([id_producto])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'mant_encar$enca_mant'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[mant_encar] DROP CONSTRAINT [mant_encar$enca_mant]
 GO



ALTER TABLE [instituciones_financieras].[mant_encar]
 ADD CONSTRAINT [mant_encar$enca_mant]
 FOREIGN KEY 
   ([encarg_mant])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[encargado]     ([id_encargado])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'mant_encar$mante_enca'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[mant_encar] DROP CONSTRAINT [mant_encar$mante_enca]
 GO



ALTER TABLE [instituciones_financieras].[mant_encar]
 ADD CONSTRAINT [mant_encar$mante_enca]
 FOREIGN KEY 
   ([idmant_encar])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[mantenimiento]     ([id_mantenimiento])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'pago$fk_pago_prestamo1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[pago] DROP CONSTRAINT [pago$fk_pago_prestamo1]
 GO



ALTER TABLE [instituciones_financieras].[pago]
 ADD CONSTRAINT [pago$fk_pago_prestamo1]
 FOREIGN KEY 
   ([id_venta])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[venta]     ([id_venta])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'producto$fk_producto_proveedor1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[producto] DROP CONSTRAINT [producto$fk_producto_proveedor1]
 GO



ALTER TABLE [instituciones_financieras].[producto]
 ADD CONSTRAINT [producto$fk_producto_proveedor1]
 FOREIGN KEY 
   ([id_proveedor])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[proveedor]     ([id_proveedor])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'tipo_activo$fk_tipo_activo_clasificacion1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[tipo_activo] DROP CONSTRAINT [tipo_activo$fk_tipo_activo_clasificacion1]
 GO



ALTER TABLE [instituciones_financieras].[tipo_activo]
 ADD CONSTRAINT [tipo_activo$fk_tipo_activo_clasificacion1]
 FOREIGN KEY 
   ([id_clasificacion])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[clasificacion]     ([id_clasificacion])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'venta$fk_prestamo_asesor_credito1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[venta] DROP CONSTRAINT [venta$fk_prestamo_asesor_credito1]
 GO



ALTER TABLE [instituciones_financieras].[venta]
 ADD CONSTRAINT [venta$fk_prestamo_asesor_credito1]
 FOREIGN KEY 
   ([id_empleado])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[empleado]     ([id_empleado])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'venta$fk_prestamo_plan_pago1'  AND sc.name = N'instituciones_financieras'  AND type in (N'F'))
ALTER TABLE [instituciones_financieras].[venta] DROP CONSTRAINT [venta$fk_prestamo_plan_pago1]
 GO



ALTER TABLE [instituciones_financieras].[venta]
 ADD CONSTRAINT [venta$fk_prestamo_plan_pago1]
 FOREIGN KEY 
   ([id_plan])
 REFERENCES 
   [instituciones_financieras].[instituciones_financieras].[plan_pago]     ([id_plan])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[activo]
 ADD DEFAULT NULL FOR [correlativo]
GO

ALTER TABLE  [instituciones_financieras].[activo]
 ADD DEFAULT NULL FOR [fecha_adquisicion]
GO

ALTER TABLE  [instituciones_financieras].[activo]
 ADD DEFAULT NULL FOR [descripcion]
GO

ALTER TABLE  [instituciones_financieras].[activo]
 ADD DEFAULT NULL FOR [estado]
GO

ALTER TABLE  [instituciones_financieras].[activo]
 ADD DEFAULT NULL FOR [observaciones]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[activo_mant]
 ADD DEFAULT NULL FOR [idactivo_mant]
GO

ALTER TABLE  [instituciones_financieras].[activo_mant]
 ADD DEFAULT NULL FOR [mant_activo]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [periodo]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [prestable]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [efectivo]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [valor_negociable]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [cuentas_por_cobrar]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [inventarios]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [terrenos]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [edificio_equipo]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [depreciacion_acumulada]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [total_activo_corriente]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [total_activo_pasivo]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [total_activo]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [cuentas_por_pagar]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [documentos_por_pagar]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [total_pasivo_corriente]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [deuda_largo_plazo]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [acciones_comunes]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [ganancias_retenidas]
GO

ALTER TABLE  [instituciones_financieras].[balance_general]
 ADD DEFAULT NULL FOR [total_pasivo]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[bien_hipotecario]
 ADD DEFAULT NULL FOR [descripcion]
GO

ALTER TABLE  [instituciones_financieras].[bien_hipotecario]
 ADD DEFAULT NULL FOR [ubicacion]
GO

ALTER TABLE  [instituciones_financieras].[bien_hipotecario]
 ADD DEFAULT NULL FOR [otros_datos]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[clasificacion]
 ADD DEFAULT NULL FOR [nombre]
GO

ALTER TABLE  [instituciones_financieras].[clasificacion]
 ADD DEFAULT NULL FOR [correlativo]
GO

ALTER TABLE  [instituciones_financieras].[clasificacion]
 ADD DEFAULT NULL FOR [tiempo_depreciacion]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[cliente]
 ADD DEFAULT NULL FOR [nombre]
GO

ALTER TABLE  [instituciones_financieras].[cliente]
 ADD DEFAULT NULL FOR [apellido]
GO

ALTER TABLE  [instituciones_financieras].[cliente]
 ADD DEFAULT NULL FOR [direccion]
GO

ALTER TABLE  [instituciones_financieras].[cliente]
 ADD DEFAULT NULL FOR [dui]
GO

ALTER TABLE  [instituciones_financieras].[cliente]
 ADD DEFAULT NULL FOR [nit]
GO

ALTER TABLE  [instituciones_financieras].[cliente]
 ADD DEFAULT NULL FOR [correo]
GO

ALTER TABLE  [instituciones_financieras].[cliente]
 ADD DEFAULT NULL FOR [observaciones]
GO

ALTER TABLE  [instituciones_financieras].[cliente]
 ADD DEFAULT NULL FOR [telefono]
GO

ALTER TABLE  [instituciones_financieras].[cliente]
 ADD DEFAULT NULL FOR [contrato_pagare]
GO

ALTER TABLE  [instituciones_financieras].[cliente]
 ADD DEFAULT N'NORMAL' FOR [cartera]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[compras]
 ADD DEFAULT NULL FOR [total]
GO

ALTER TABLE  [instituciones_financieras].[compras]
 ADD DEFAULT NULL FOR [fecha_compra]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[departamento]
 ADD DEFAULT NULL FOR [nombre]
GO

ALTER TABLE  [instituciones_financieras].[departamento]
 ADD DEFAULT NULL FOR [id_sucursal]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[detalle_compras]
 ADD DEFAULT NULL FOR [cantidad]
GO

ALTER TABLE  [instituciones_financieras].[detalle_compras]
 ADD DEFAULT NULL FOR [precio]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[detalle_venta]
 ADD DEFAULT NULL FOR [cantidad]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[empleado]
 ADD DEFAULT NULL FOR [nombre]
GO

ALTER TABLE  [instituciones_financieras].[empleado]
 ADD DEFAULT NULL FOR [apellido]
GO

ALTER TABLE  [instituciones_financieras].[empleado]
 ADD DEFAULT NULL FOR [zona]
GO

ALTER TABLE  [instituciones_financieras].[empleado]
 ADD DEFAULT NULL FOR [dui]
GO

ALTER TABLE  [instituciones_financieras].[empleado]
 ADD DEFAULT NULL FOR [pass]
GO

ALTER TABLE  [instituciones_financieras].[empleado]
 ADD DEFAULT NULL FOR [nivel]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[encargado]
 ADD DEFAULT NULL FOR [nombre]
GO

ALTER TABLE  [instituciones_financieras].[encargado]
 ADD DEFAULT NULL FOR [direccion]
GO

ALTER TABLE  [instituciones_financieras].[encargado]
 ADD DEFAULT NULL FOR [telefono]
GO

ALTER TABLE  [instituciones_financieras].[encargado]
 ADD DEFAULT NULL FOR [correo]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[estado]
 ADD DEFAULT NULL FOR [nombre]
GO

ALTER TABLE  [instituciones_financieras].[estado]
 ADD DEFAULT NULL FOR [tiempo_de_uso]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [periodo]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [prestable]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [ingreso_ventas]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [costo_venta]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [utilidad_bruta]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [gastos_operativos]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [gasto_venta]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [gasto_administrativo]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [gasto_arrendamiento]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [gasto_depreciacion]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [total_gasto_operativo]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [utlidad_operativa]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [gasto_interes]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [utilidad_antes_impuestos]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [impuestos]
GO

ALTER TABLE  [instituciones_financieras].[estado_resultado]
 ADD DEFAULT NULL FOR [utilidad_neta]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[fiador]
 ADD DEFAULT NULL FOR [nombre]
GO

ALTER TABLE  [instituciones_financieras].[fiador]
 ADD DEFAULT NULL FOR [apellido]
GO

ALTER TABLE  [instituciones_financieras].[fiador]
 ADD DEFAULT NULL FOR [direccion]
GO

ALTER TABLE  [instituciones_financieras].[fiador]
 ADD DEFAULT NULL FOR [dui]
GO

ALTER TABLE  [instituciones_financieras].[fiador]
 ADD DEFAULT NULL FOR [nit]
GO

ALTER TABLE  [instituciones_financieras].[fiador]
 ADD DEFAULT NULL FOR [correo]
GO

ALTER TABLE  [instituciones_financieras].[fiador]
 ADD DEFAULT NULL FOR [telefono]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[inventario]
 ADD DEFAULT NULL FOR [cantidad]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[mant_encar]
 ADD DEFAULT NULL FOR [encarg_mant]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[mantenimiento]
 ADD DEFAULT NULL FOR [fecha]
GO

ALTER TABLE  [instituciones_financieras].[mantenimiento]
 ADD DEFAULT NULL FOR [costo]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[pago]
 ADD DEFAULT NULL FOR [monto]
GO

ALTER TABLE  [instituciones_financieras].[pago]
 ADD DEFAULT NULL FOR [fecha]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[persona_juridica]
 ADD DEFAULT NULL FOR [nombre]
GO

ALTER TABLE  [instituciones_financieras].[persona_juridica]
 ADD DEFAULT NULL FOR [categoria]
GO

ALTER TABLE  [instituciones_financieras].[persona_juridica]
 ADD DEFAULT NULL FOR [numero]
GO

ALTER TABLE  [instituciones_financieras].[persona_juridica]
 ADD DEFAULT NULL FOR [dui]
GO

ALTER TABLE  [instituciones_financieras].[persona_juridica]
 ADD DEFAULT NULL FOR [nit]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[plan_pago]
 ADD DEFAULT NULL FOR [tasa]
GO

ALTER TABLE  [instituciones_financieras].[plan_pago]
 ADD DEFAULT NULL FOR [cuotas]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[producto]
 ADD DEFAULT NULL FOR [nombre]
GO

ALTER TABLE  [instituciones_financieras].[producto]
 ADD DEFAULT NULL FOR [descripcion]
GO

ALTER TABLE  [instituciones_financieras].[producto]
 ADD DEFAULT NULL FOR [precio_compra]
GO

ALTER TABLE  [instituciones_financieras].[producto]
 ADD DEFAULT NULL FOR [precio_venta]
GO

ALTER TABLE  [instituciones_financieras].[producto]
 ADD DEFAULT NULL FOR [minimo]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[proveedor]
 ADD DEFAULT NULL FOR [nombre]
GO

ALTER TABLE  [instituciones_financieras].[proveedor]
 ADD DEFAULT NULL FOR [dui]
GO

ALTER TABLE  [instituciones_financieras].[proveedor]
 ADD DEFAULT NULL FOR [direccion]
GO

ALTER TABLE  [instituciones_financieras].[proveedor]
 ADD DEFAULT NULL FOR [telefono]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[sucursal]
 ADD DEFAULT NULL FOR [nombre]
GO

ALTER TABLE  [instituciones_financieras].[sucursal]
 ADD DEFAULT NULL FOR [direccion]
GO

ALTER TABLE  [instituciones_financieras].[sucursal]
 ADD DEFAULT NULL FOR [telefono]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[tipo_activo]
 ADD DEFAULT NULL FOR [nombre]
GO

ALTER TABLE  [instituciones_financieras].[tipo_activo]
 ADD DEFAULT NULL FOR [correlativo]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[tipo_credito]
 ADD DEFAULT NULL FOR [nombre]
GO

ALTER TABLE  [instituciones_financieras].[tipo_credito]
 ADD DEFAULT NULL FOR [terminis_condiciones]
GO


USE instituciones_financieras
GO
ALTER TABLE  [instituciones_financieras].[venta]
 ADD DEFAULT NULL FOR [prestamo_original]
GO

ALTER TABLE  [instituciones_financieras].[venta]
 ADD DEFAULT NULL FOR [saldo_actual]
GO

ALTER TABLE  [instituciones_financieras].[venta]
 ADD DEFAULT NULL FOR [mora_acumulada]
GO

ALTER TABLE  [instituciones_financieras].[venta]
 ADD DEFAULT NULL FOR [intereses_acumulados]
GO

ALTER TABLE  [instituciones_financieras].[venta]
 ADD DEFAULT NULL FOR [estado]
GO

ALTER TABLE  [instituciones_financieras].[venta]
 ADD DEFAULT NULL FOR [proximo_pago]
GO

ALTER TABLE  [instituciones_financieras].[venta]
 ADD DEFAULT NULL FOR [fecha]
GO

ALTER TABLE  [instituciones_financieras].[venta]
 ADD DEFAULT NULL FOR [cuota]
GO

ALTER TABLE  [instituciones_financieras].[venta]
 ADD DEFAULT NULL FOR [contador_mora]
GO

