using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace CapaDatos.Inventario
{
    public class ProveedorCD
    {
        
        public static bool Existe(string ced)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    var query = (from prov in DB.PROVEEDOR where prov.CedProveedor == ced select prov).Count();
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

        public static bool ExisteID(int id)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    var query = (from prov in DB.PROVEEDOR where prov.IdProveedor == id select prov).Count();
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


        public static List<filtrarproveedorResult> ObtenerProveedores(string valor)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    return DB.filtrarproveedor(valor).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Listar Proveedor.", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static List<PROVEEDOR> ListarProveedoresTodos()
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    return DB.PROVEEDOR.ToList(); ; ;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Listar Proveedor.", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static Proveedor Create(Proveedor not)
        {
            DatosDataContext bd = new DatosDataContext();
           try
            {
                Proveedor p = new Proveedor();
              //  p.IdProveedor = not.IdProveedor;
                p.CedProveedor = not.CedProveedor;
                p.Nombre = not.Nombre;
                p.Representante = not.Representante;
                p.Direccion = not.Direccion;
                p.Ciudad = not.Ciudad;
                p.Telefono = not.Telefono;
                p.Fax = not.Fax;
                bd.insertarproveedor(p.CedProveedor, p.Nombre, p.Representante, p.Direccion, p.Ciudad, p.Telefono, p.Fax);
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
            
            return not;
        }

        public static Proveedor Modificar(Proveedor not)
        {
            DatosDataContext bd = new DatosDataContext();
            try
            {
                Proveedor p = new Proveedor();
                p.IdProveedor = not.IdProveedor;
                p.CedProveedor = not.CedProveedor;
                p.Nombre = not.Nombre;
                p.Representante = not.Representante;
                p.Direccion = not.Direccion;
                p.Ciudad = not.Ciudad;
                p.Telefono = not.Telefono;
                p.Fax = not.Fax;
                bd.actualizarproveedor(p.IdProveedor,p.CedProveedor, p.Nombre, p.Representante, p.Direccion, p.Ciudad, p.Telefono, p.Fax);
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

            return not;
        }
        public static Proveedor Eliminar(Proveedor not)
        {
            DatosDataContext bd = new DatosDataContext();
            try
            {
                Proveedor p = new Proveedor();
                p.IdProveedor = not.IdProveedor;
                bd.eliminarproveedor(p.IdProveedor);
                bd.SubmitChanges();
            }
            catch (DatosExcepciones ex)
            {
                throw new DatosExcepciones("Error al  Eliminar Proveedor.", ex);
            }
            finally
            {
                bd = null;
            }

            return not;
        }


        public static int getidproveedorbyprovnombre(string provnombre)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    var sql = from i in DB.PROVEEDOR
                    where i.Nombre == provnombre
                    select i.IdProveedor;
                    return sql.ToList().First();
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
        public static string getnombrebyidprov(int idprov)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {

                    var sql = from i in DB.PROVEEDOR
                              where i.IdProveedor == idprov
                              select i.Nombre;
                    return sql.First();
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
        public static List<string> getnombresprov()
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    var sql = from i in DB.PROVEEDOR
                              select i.Nombre;
                    return sql.ToList();
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
