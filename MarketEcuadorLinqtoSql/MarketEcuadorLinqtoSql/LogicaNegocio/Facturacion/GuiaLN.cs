using CapaDatos.Facturacion;
using Entidades.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Facturacion
{
    public class GuiaLN
    {
        public bool InsertarGuia(Guia p)
        {
            
                GuiaCD.Create(p);
                return true;
            
        }
        public int getnextguia(){

           return GuiaCD.getnextguia();
            
        }

    }
}
