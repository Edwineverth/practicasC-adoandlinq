using Entidades.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Facturacion
{
    public class GuiaCD
    {
       
        public static bool ExisteID(int id)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    var query = (from cat in DB.GUIA where cat.IdGuia == id select cat).Count();
                    if (query == 0)
                        return false;
                    else
                        return true;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Buscar Codigo de Guia.", ex);
            }
            finally
            {
                DB = null;
            }

        }

        public static List<filtrarcategoriaResult> Obtenercategorias(string valor)
        {
            //DatosDataContext DB;
            //try
            //{
            //    using (DB = new DatosDataContext())
            //    {
            //        return DB.filtrarcategoria(valor).ToList();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw new DatosExcepciones("Error al Listar Categorias.", ex);
            //}
            //finally
            //{
            //    DB = null;
            //}
            return null;
        }

        public static Guia Create(Guia p)
        {

            DatosDataContext bd = new DatosDataContext();
            try
            {
                //Categoria p = new C>
                //  p.IdProveedor = not.IdProveedor;
                //p.CedProveedor = not.CedProveedor;>
                //p.Nombre = not.Nombre;>
                //p.Representante = not.Representante;>
                //p.Direccion = not.Direccion;>
                //p.Ciudad = not.Ciudad;>
                //p.Telefono = not.Telefono;>
                //p.Fax = not.Fax;>
                bd.spInsertarGuia(p.idGuia, p.idLocal,p.fechaSalida,p.idTransportista,p.total);
                bd.SubmitChanges();
            }
            catch (DatosExcepciones ex)
            {
                throw new DatosExcepciones("Error al  Insertar Proveedor.", ex);
            }
            finally
            {
                bd = null;
            }

            return p;
        }

        public static Guia Modificar(Guia p)
        {
            DatosDataContext bd = new DatosDataContext();
            try
            {
                
                
            //    bd.actualizarcategoria(p.Idcategoria, p.Categoria1, p.Descripcion);
               // bd.SubmitChanges();
            }
            catch (DatosExcepciones ex)
            {
                throw new DatosExcepciones("Error al  Modificar Proveedor.", ex);
            }
            finally
            {
                bd = null;
            }

            return p;
        }
        public static Guia Eliminar(Guia p)
        {
            DatosDataContext bd = new DatosDataContext();
            try
            {
               
                //bd.eliminarcategoria(p.Idcategoria);
                //bd.SubmitChanges();
            }
            catch (DatosExcepciones ex)
            {
                throw new DatosExcepciones("Error al  Eliminar Proveedor.", ex);
            }
            finally
            {
                bd = null;
            }

            return p;
        }
        public static int getnextguia()
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {

                    var sql = from i in DB.GUIA
                              select i.IdGuia;
                    return sql.ToList().Last()+1;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Buscar Codigo del Proveedor.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
