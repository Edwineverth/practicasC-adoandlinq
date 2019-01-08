using CapaDatos;
using CapaDatos.Inventario;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Inventario
{
    public class LocalLN
    {
        public List<filtrarlocalResult> ListarLocales(string val)
        {
            return LocalCD.ObtenerLocales(val);
        }
        public bool existeLocal(int id)
        {
            return LocalCD.ExisteID(id);
        }

        public bool InsertarLocal(Local p)
        {
            if (LocalCD.ExisteID(p.idLocal))
                return true;
            else
            {
                LocalCD.Create(p);
                return false;
            }

        }
        public bool ModificarLocal(Local p)
        {
            LocalCD.Modificar(p);
            return false;


        }
        public bool EliminarLocal(Local p)
        {
            LocalCD.Eliminar(p);
            return false;


        }
    }
}
