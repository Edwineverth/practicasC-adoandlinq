using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos.Inventario
{
    public class CategoriaCD
    {
        public static bool Existe(string cate)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    var query = (from cat in DB.CATEGORIA where cat.Categoria1 == cate select cat).Count();
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
                    var query = (from cat in DB.CATEGORIA where cat.IdCategoria == id select cat).Count();
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

        public static List<filtrarcategoriaResult> Obtenercategorias(string valor)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    return DB.filtrarcategoria(valor).ToList();
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

        public static Categoria Create(Categoria p)
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
                bd.insertarcategoria(p.Categoria1, p.Descripcion);
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

        public static Categoria Modificar(Categoria p)
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
                bd.actualizarcategoria(p.Idcategoria, p.Categoria1, p.Descripcion);
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
        public static Categoria Eliminar(Categoria p)
        {
            DatosDataContext bd = new DatosDataContext();
            try
            {
                //Categoria p = new Categoria();
                //p.Idcategoria = not.IdProveedor;
                bd.eliminarcategoria(p.Idcategoria);
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

            return p;
        }

        public static int getidcategoriabynombr(string categorianombre)
        {

            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    var sql = from i in DB.CATEGORIA
                              where i.Categoria1 == categorianombre
                              select i.IdCategoria;

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
        public static string getcatenombbyidcat(int idcate)
        {


            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    var sql = from i in DB.CATEGORIA
                              where i.IdCategoria == idcate
                              select i.Categoria1;
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
        public static List<String> getcategorias()
        {

            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {

                    var sql = from i in DB.CATEGORIA
                              select i.Categoria1;
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
