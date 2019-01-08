using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos.Inventario
{
    public class LocalCD
    {
       

        public static bool ExisteID(int id)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    var query = (from loc in DB.LOCAL where loc.IdLocal == id select loc).Count();
                    if (query == 0)
                        return false;
                    else
                        return true;
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

        public static List<filtrarlocalResult> ObtenerLocales(string valor)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    return DB.filtrarlocal(valor).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Listar Categorias.", ex);
            }
            finally
            {
                DB = null;
            }
        }


        public static Local Create(Local p)
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
                bd.insertarlocal(p.direccion, p.ciudad,p.telefono,p.fax);
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

        public static Local Modificar(Local p)
        {
            DatosDataContext bd = new DatosDataContext();
            try
            {
                //    Categoria p = new Proveedor();
                //    p.IdProveedor = not.IdProveedor;
                //    p.CedProveedor = not.CedProveedor;
                //    p.Nombre = not.Nombre;
                //    p.Representante = not.Representante;
                //    p.Direccion = not.Direccion;
                //    p.Ciudad = not.Ciudad;
                //    p.Telefono = not.Telefono;
                //    p.Fax = not.Fax;
                bd.actualizarlocal(p.idLocal, p.direccion, p.ciudad,p.telefono,p.fax);
                bd.SubmitChanges();
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
        public static Local Eliminar(Local p)
        {
            DatosDataContext bd = new DatosDataContext();
            try
            {
                //Categoria p = new Categoria();
                //p.Idcategoria = not.IdProveedor;
                bd.eliminarlocal(p.idLocal);
                bd.SubmitChanges();
            }
            catch (DatosExcepciones ex)
            {
                throw new DatosExcepciones("Error al  Eliminar Local.", ex);
            }
            finally
            {
                bd = null;
            }

            return p;
        }
    }
}
