
using Entidades.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Facturacion;
namespace LogicaNegocio.Facturacion
{
    public class GuiaDetalleLN
    {
        public bool InsertarGuiaDetalle(Guia_Detalle p)
        {
                GuiaDetalleCD.Create(p);
                return true;
            

        }
    }
}
