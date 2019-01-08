using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Inventario
{
    public class ProductoCD
    {
        public static bool Existe(string nom)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    var query = (from prod in DB.PRODUCTO where prod.Nombre == nom select prod).Count();
                    if (query == 0)
                        return false;
                    else
                        return true;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Buscar Codigo del Producto.", ex);
            }
            finally
            {
                DB = null;
            }

        }

        public static bool ExisteID(int id)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    var query = (from prov in DB.PRODUCTO where prov.IdProducto == id select prov).Count();
                    if (query == 0)
                        return false;
                    else
                        return true;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Buscar Codigo del Producto.", ex);
            }
            finally
            {
                DB = null;
            }

        }


        public static List<filtrarproductoResult> ObtenerProductoes(string valor)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    
                    return DB.filtrarproducto(valor).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Listar Producto.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static List<filtrarVistaProductoResult> ObtenerProductosbycategoria(string categoria)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    return DB.filtrarVistaProducto(categoria).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Listar Producto.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static Producto Create(Producto p)
        {
            DatosDataContext bd = new DatosDataContext();
            try
            {
               // Producto p = new Producto();
                //  p.IdProducto = not.IdProducto;
               // p.CedProducto = not.CedProducto;>>
                //p.Nombre = not.Nombre;>>
               // p.Representante = not.Representante;>>
              //  p.Direccion = not.Direccion;>>
               // p.Ciudad = not.Ciudad;>>
              //  p.Telefono = not.Telefono;>>
              //  p.Fax = not.Fax;>>
                bd.insertarproducto(p.Idcategoria,p.Idproveedor,p.Nombre,p.Unidad_medida,p.Precio_proveedor,p.Stock_actual,p.Stock_minimo);
                bd.SubmitChanges();
            }
            catch (DatosExcepciones ex)
            {
                throw new DatosExcepciones("Error al  Insertar Producto.", ex);
            }
            finally
            {
                bd = null;
            }

            return p;
        }

        public static Producto Modificar(Producto p)
        {
            DatosDataContext bd = new DatosDataContext();
            try
            {
                //Producto p = new Producto();
                //p.IdProducto = not.IdProducto;
                //p.CedProducto = not.CedProducto;
                //p.Nombre = not.Nombre;
                //p.Representante = not.Representante;
                //p.Direccion = not.Direccion;
                //p.Ciudad = not.Ciudad;
                //p.Telefono = not.Telefono;
                //p.Fax = not.Fax;
                bd.actualizarproducto(p.Idproducto, p.Idcategoria, p.Idproveedor, p.Nombre, p.Unidad_medida, p.Precio_proveedor, p.Stock_actual, p.Stock_minimo);
                bd.SubmitChanges();
            }
            catch (DatosExcepciones ex)
            {
                throw new DatosExcepciones("Error al  Modificar Producto.", ex);
            }
            finally
            {
                bd = null;
            }

            return p;
        }
        public static Producto Eliminar(Producto p)
        {
            DatosDataContext bd = new DatosDataContext();
            try
            {
                //Producto p = new Producto();
                //p.idp = not.IdProducto;
                bd.eliminarproducto(p.Idproducto);
                bd.SubmitChanges();
            }
            catch (DatosExcepciones ex)
            {
                throw new DatosExcepciones("Error al  Eliminar Producto.", ex);
            }
            finally
            {
                bd = null;
            }

            return p;
        }


    }
}
