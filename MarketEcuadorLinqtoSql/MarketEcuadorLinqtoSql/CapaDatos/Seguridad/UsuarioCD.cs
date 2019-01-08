using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Seguridad
{
    public class UsuarioCD
    {
        public static bool Existe(string ced){
                         
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    var query = (from usu in DB.USUARIO where usu.CEDULA == ced select usu).Count();
                    if (query == 0)
                        return false;
                    else
                        return true;
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al Buscar cedual del usuairo", ex);
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
                    var query = (from cat in DB.USUARIO where cat.IDUSUARIO == id select cat).Count();
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

        public static List<filtrarusuarioResult> ObtenerUsuarios(string valor)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    return DB.filtrarusuario(valor).ToList();
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

        public static Usuario Create(Usuario p)
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
                byte[] a = ImageToByteArray(p.foto);
                if (a == null)
                {
                    bd.insertarusuario(p.cedula, p.nombres, p.direccion, p.telefono, p.login, p.clave,  null );
                }
                else
                {
                    bd.insertarusuario(p.cedula, p.nombres, p.direccion, p.telefono, p.login, p.clave,  a);
                }

               
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

        public static Usuario Modificar(Usuario p)
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
                byte[] j=ImageToByteArray(p.foto);
                if (j == null)
              //  {
                  //  int hj = 7;
               // }
              //  else
              //  {
                   // int hhj = 447;
               // }
                bd.actualizarusuario(p.idusuario,p.cedula,p.nombres,p.direccion, p.telefono, p.login,p.clave,j);
                bd.SubmitChanges();
            }
            catch (DatosExcepciones ex)
            {
                throw new DatosExcepciones("Error al  Modificar Usuario.", ex);
            }
            finally
            {
                bd = null;
            }

            return p;
        }
        public static Usuario Eliminar(Usuario p)
        {
            DatosDataContext bd = new DatosDataContext();
            try
            {
                //Categoria p = new Categoria();
                //p.Idcategoria = not.IdProveedor;
                bd.eliminarusuario(p.idusuario );
                bd.SubmitChanges();
            }
            catch (DatosExcepciones ex)
            {
                throw new DatosExcepciones("Error al  Eliminar Usuario.", ex);
            }
            finally
            {
                bd = null;
            }

            return p;
        }
        public static byte[] getImageById(string id)
        {

            DatosDataContext bd = new DatosDataContext();
            try
            {
                //Categoria p = new Categoria();
                //p.Idcategoria = not.IdProveedor;
                USUARIO j=(from usu in bd.USUARIO where usu.IDUSUARIO == int.Parse(id) select usu).Single();
                if (j.FOTO != null)
                { 
                    return j.FOTO.ToArray();
                 }
                else
                {
                    return null;
                }  
               
            }
            catch (DatosExcepciones ex)
            {
                throw new DatosExcepciones("Error al  Eliminar Usuario.", ex);
            }
            finally
            {
                bd = null;
            }
        }
      
        public static byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn != null)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();

            }
            else
            {
                return null;
            }
            
        }
    }
}
