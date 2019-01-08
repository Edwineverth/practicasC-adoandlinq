using CapaDatos;
using CapaDatos.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Facturacion
{
    public class TransportistaLN
    {
        public TransportistaLN(){

        }
        public List<spFiltrarTransportistaResult> ListarTransportistas(string val)
        {
            return TransportistaCD.ObtenerTransportistas(val);
        }
      

    }

}
