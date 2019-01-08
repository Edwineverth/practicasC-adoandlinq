using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos.Seguridad;
using CapaDatos;
namespace LogicaNegocio.Seguridad
{
    public class UsuarioLN
    {

        public List<filtrarusuarioResult> ListarUsuarios (string val)
        {
            return UsuarioCD.ObtenerUsuarios(val);
        }
        public bool existeProveedor(string id)
        {
            return UsuarioCD.Existe(id);
        }

        public bool InsertarUsuario(Usuario p)
        {
            if (UsuarioCD.Existe(p.cedula))
                return true;
            else
            {
                UsuarioCD.Create(p);
                return false;
            }

        }
        public bool ModificarUsuario(Usuario p)
        {
            UsuarioCD.Modificar(p);
            return false;


        }
        public bool EliminarUsuario(Usuario p)
        {
            UsuarioCD.Eliminar(p);
            return false;

        }
        public byte[] getImageById(string id)
        {

            return UsuarioCD.getImageById(id);
        }
    }
}
