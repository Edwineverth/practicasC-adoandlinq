USE [Marketperu]
GO
/****** Object:  StoredProcedure [dbo].[actualizarcategoria]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[actualizarcategoria] @idcategoria int,
 @categoria varchar(20), 
 @descripcion varchar(40) as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  update CATEGORIA set Categoria=@categoria, Descripcion=@descripcion where IdCategoria=@idcategoria
END

GO
/****** Object:  StoredProcedure [dbo].[actualizarlocal]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizarlocal]
	@idlocal int,
	@direccion varchar(60),
	@ciudad varchar(20),
	@telefono varchar(15),
	@fax varchar(15)
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update LOCAL set Direccion=@direccion,
	Ciudad=@ciudad,
	Telefono=@telefono,
	Fax=@fax
	where IdLocal=@idlocal
END

GO
/****** Object:  StoredProcedure [dbo].[actualizarproducto]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[actualizarproducto] @idproducto int,
 	@idcategoria int,
 	@idproveedor int,
 	@nombre varchar(40),
 	@unidadmedida varchar(30),
 	@precioproveedor money,
 	@stockactual smallint,
 	@stockminimo smallint as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update PRODUCTO set 
	IdCategoria=@idcategoria,
	IdProveedor=@idproveedor,
	Nombre=@nombre,
	UnidadMedida=@unidadmedida,
	PrecioProveedor=@precioproveedor,
	StockActual=@stockactual,
	StockMinimo=@stockminimo

	where PRODUCTO.IdProducto = @idproducto


END

GO
/****** Object:  StoredProcedure [dbo].[actualizarproveedor]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[actualizarproveedor] @idproveedor int,
 @cedproveedor varchar(10),
 @nombre varchar(40),
 @representante varchar(30),
 @direccion varchar(60),
 @ciudad varchar(15),
 @telefono varchar(15),
 @fax varchar(15) as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update PROVEEDOR set CedProveedor=@cedproveedor,
	Nombre=@nombre,
	Representante=@representante,
	Direccion=@direccion,
	Ciudad= @ciudad,
	Telefono= @telefono,
	Fax=@fax
	where IdProveedor=@idproveedor
END

GO
/****** Object:  StoredProcedure [dbo].[actualizarusuario]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualizarusuario]
@idusuario int ,
@cedula varchar(10),
@nombres varchar(40),
@direccion varchar(40),
@telefono varchar(40),
@loginuser varchar(40),
@claveuser varchar(40),
@foto image
as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   update USUARIO set CEDULA=@cedula,
   NOMBRES=@nombres,
   DIRECCION= @direccion,
   TELEFONO=@telefono,
   LOGINUSER=@loginuser,
   CLAVEUSER=@claveuser,
   FOTO=@foto
   where IDUSUARIO=@idusuario
	
END

GO
/****** Object:  StoredProcedure [dbo].[cp_ListaProveedores]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[cp_ListaProveedores] as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * from PROVEEDOR
END

GO
/****** Object:  StoredProcedure [dbo].[eliminarcategoria]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[eliminarcategoria] @idcategoria int as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE  FROM GUIA_DETALLE WHERE GUIA_DETALLE.IdProducto IN (select PRODUCTO.IdProducto from PRODUCTO  where PRODUCTO.IdCategoria =@idcategoria)
	DELETE  FROM ORDEN_DETALLE WHERE ORDEN_DETALLE.IdProducto IN (select PRODUCTO.IdProducto from PRODUCTO  where PRODUCTO.IdCategoria =@idcategoria)
	DELETE FROM PRODUCTO WHERE IdCategoria=@idcategoria
	DELETE FROM CATEGORIA WHERE IdCategoria=@idcategoria

END

GO
/****** Object:  StoredProcedure [dbo].[eliminarlocal]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminarlocal] 
	@idlocal int
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	delete from LOCAL where IdLocal=@idlocal
    END

GO
/****** Object:  StoredProcedure [dbo].[eliminarproducto]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[eliminarproducto] @idproducto int as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	delete from GUIA_DETALLE where IdProducto=@idproducto
	delete from ORDEN_DETALLE where IdProducto=@idproducto
	delete from PRODUCTO where PRODUCTO.IdProducto=@idproducto
END

GO
/****** Object:  StoredProcedure [dbo].[eliminarproveedor]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[eliminarproveedor] @idproveedor int as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DELETE  FROM GUIA_DETALLE WHERE GUIA_DETALLE.IdProducto IN (select PRODUCTO.IdProducto from PRODUCTO  where PRODUCTO.IdProveedor =@idproveedor)
	DELETE  FROM ORDEN_DETALLE WHERE ORDEN_DETALLE.IdProducto IN (select PRODUCTO.IdProducto from PRODUCTO  where PRODUCTO.IdProveedor =@idproveedor)
	DELETE FROM PRODUCTO WHERE IdProveedor=@idproveedor
	DELETE FROM PROVEEDOR WHERE IdProveedor=@idproveedor
	
END

GO
/****** Object:  StoredProcedure [dbo].[eliminarusuario]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminarusuario]
@idusuario int 

as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   delete from USUARIO where IDUSUARIO=@idusuario
END

GO
/****** Object:  StoredProcedure [dbo].[filtrarcategoria]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[filtrarcategoria] @filtro varchar(40) as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select @filtro=RTRIM(@filtro)+'%'
    -- Insert statements for procedure here
	select * from CATEGORIA where Categoria like @filtro
END

GO
/****** Object:  StoredProcedure [dbo].[filtrarlocal]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[filtrarlocal]
	@valor varchar(20)
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	select @valor=RTRIM(@valor)+'%'
	select * from LOCAL where LOCAL.Direccion like @valor

    END

GO
/****** Object:  StoredProcedure [dbo].[filtrarproducto]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[filtrarproducto] @filtro varchar(40) as
BEGIN
	
	SET NOCOUNT ON;
	select @filtro = rtrim(@filtro) +'%';
select * from [dbo].[VistaProducto]
where [dbo].[VistaProducto].nombreproducto like @filtro  

END

GO
/****** Object:  StoredProcedure [dbo].[filtrarproveedor]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[filtrarproveedor] @filtro varchar(40) as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT @filtro=RTRIM(@filtro)+'%'
	select * from PROVEEDOR
	where Nombre like @filtro
	
END

GO
/****** Object:  StoredProcedure [dbo].[filtrarusuario]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[filtrarusuario]
@valor varchar(20) 

as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select @valor=RTRIM(@valor)+'%'
	select IDUSUARIO,  CEDULA,NOMBRES,DIRECCION,TELEFONO,LOGINUSER,CLAVEUSER from USUARIO where NOMBRES like @valor
   
END

GO
/****** Object:  StoredProcedure [dbo].[filtrarVistaProducto]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[filtrarVistaProducto]
@categoria varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from dbo.VistaProducto where dbo.VistaProducto.Categoria=@categoria
END

GO
/****** Object:  StoredProcedure [dbo].[insertarcategoria]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[insertarcategoria] @categoria varchar(20),
 	@descripcion varchar(40) as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into CATEGORIA(Categoria,Descripcion) values(@categoria,@descripcion)
END

GO
/****** Object:  StoredProcedure [dbo].[insertarlocal]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[insertarlocal]
	@direccion varchar(60),
	@ciudad varchar(20),
	@telefono varchar(15),
	@fax varchar(15)
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into LOCAL(Direccion,Ciudad,Telefono,Fax) 
	values (@direccion,@ciudad,@telefono,@fax)

END

GO
/****** Object:  StoredProcedure [dbo].[insertarproducto]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[insertarproducto] @idcategoria int,
 	@idproveedor int,
 	@nombre varchar(40),
 	@unidadmedida varchar(30),
 	@precioproveedor money,
 	@stockactual smallint,
 	@stockminimo smallint as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into PRODUCTO(IdCategoria,IdProveedor,Nombre,UnidadMedida,PrecioProveedor,StockActual,StockMinimo)
	values (@idcategoria,@idproveedor,@nombre,@unidadmedida,@precioproveedor,@stockactual,@stockminimo)
END

GO
/****** Object:  StoredProcedure [dbo].[insertarproveedor]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[insertarproveedor] @cedproveedor varchar(10),
 @nombre varchar(40),
 @representante varchar(30),
 @direccion varchar(60),
 @ciudad varchar(15),
 @telefono varchar(15),
 @fax varchar(15) as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into PROVEEDOR(CedProveedor,Nombre,Representante,Direccion,Ciudad,Telefono,Fax)
values(@cedproveedor,@nombre,@representante,@direccion,@ciudad,@telefono,@fax)
END

GO
/****** Object:  StoredProcedure [dbo].[insertarusuario]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[insertarusuario]
@cedula varchar(10),
@nombres varchar(40),
@direccion varchar(40),
@telefono varchar(40),
@loginuser varchar(40),
@claveuser varchar(40),
@foto image
as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into USUARIO(CEDULA,NOMBRES,DIRECCION,TELEFONO,LOGINUSER,CLAVEUSER,FOTO)
	values(@cedula,@nombres,@direccion,@telefono,@loginuser,@claveuser,@foto)
	
END

GO
/****** Object:  StoredProcedure [dbo].[listarcategorias]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[listarcategorias] as
BEGIN
	
	SET NOCOUNT ON;

    select * from CATEGORIA
END

GO
/****** Object:  StoredProcedure [dbo].[listarnuevoprod]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[listarnuevoprod] @idpro int as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from PRODUCTO where PRODUCTO.IdProducto=@idpro
END

GO
/****** Object:  StoredProcedure [dbo].[listarproductos]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[listarproductos] as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   select * from PRODUCTO
END

GO
/****** Object:  StoredProcedure [dbo].[listarproveedores]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[listarproveedores] as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from PROVEEDOR
END

GO
/****** Object:  StoredProcedure [dbo].[miliprov]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[miliprov] @idprov int as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from PROVEEDOR  where IdProveedor=@idprov
END

GO
/****** Object:  StoredProcedure [dbo].[spFiltrarTransportista]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spFiltrarTransportista]
	-- Add the parameters for the stored procedure here
	@valor varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT @valor=RTRIM(@valor)+'%'
	select *from TRANSPORTISTA where Nombre like @valor
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertarGuia]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertarGuia]
  @idGuia int,
  @idLocal int,
  @fechaSalida datetime,
  @idtransportista int,
  @total money
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   insert into GUIA(IdGuia,IdLocal,FechaSalida,Idtransportista,Total)
    values(@idGuia,@idLocal,@fechaSalida,@idtransportista,@total)
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertarGuiaDetalle]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertarGuiaDetalle]
  @idGuia int,
  @idProducto int,
  @precioventa money,
  @cantidad smallint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   insert into GUIA_DETALLE(IdGuia,IdProducto,PrecioVenta, Cantidad)
    values(@idGuia,@idProducto,@precioventa,@cantidad)
END

GO
/****** Object:  View [dbo].[vistadeproductos]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==============================================================*/
/* View: vistadeproductos                                       */
/*==============================================================*/
create view [dbo].[vistadeproductos] as
SELECT        dbo.PRODUCTO.IdProducto, dbo.PRODUCTO.Nombre, dbo.PRODUCTO.UnidadMedida, dbo.PRODUCTO.PrecioProveedor, dbo.PRODUCTO.StockActual, dbo.PRODUCTO.StockMinimo, 
                         dbo.PROVEEDOR.Nombre AS Expr1, dbo.CATEGORIA.Categoria
FROM            dbo.CATEGORIA INNER JOIN
                         dbo.PRODUCTO ON dbo.CATEGORIA.IdCategoria = dbo.PRODUCTO.IdCategoria INNER JOIN
                         dbo.PROVEEDOR ON dbo.PRODUCTO.IdProveedor = dbo.PROVEEDOR.IdProveedor

GO
/****** Object:  View [dbo].[VistaProducto]    Script Date: 24/08/2014 9:36:41 AH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     31/07/2014 21:44:23 JH                       */
/*==============================================================*/



/*==============================================================*/
/* View: VistaProducto                                          */
/*==============================================================*/
create view [dbo].[VistaProducto] as
SELECT        dbo.PRODUCTO.IdProducto, dbo.CATEGORIA.Categoria, dbo.PROVEEDOR.Nombre AS NombreProveedor, dbo.PRODUCTO.Nombre AS Nombreproducto, dbo.PRODUCTO.UnidadMedida, 
                         dbo.PRODUCTO.PrecioProveedor, dbo.PRODUCTO.StockActual, dbo.PRODUCTO.StockMinimo
FROM            dbo.CATEGORIA INNER JOIN
                         dbo.PRODUCTO ON dbo.CATEGORIA.IdCategoria = dbo.PRODUCTO.IdCategoria INNER JOIN
                         dbo.PROVEEDOR ON dbo.PRODUCTO.IdProveedor = dbo.PROVEEDOR.IdProveedor

GO
