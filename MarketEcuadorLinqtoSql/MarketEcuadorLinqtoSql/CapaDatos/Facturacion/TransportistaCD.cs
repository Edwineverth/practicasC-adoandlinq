using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Facturacion
{
    public class TransportistaCD
    {
        public static List<spFiltrarTransportistaResult> ObtenerTransportistas(string valor)
        {
            DatosDataContext DB;
            try
            {
                using (DB = new DatosDataContext())
                {
                    return DB.spFiltrarTransportista(valor).ToList();
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

    }
}
