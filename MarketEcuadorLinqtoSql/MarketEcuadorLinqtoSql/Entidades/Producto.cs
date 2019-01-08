using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private int idproducto;

        public int Idproducto
        {
            get { return idproducto; }
            set { idproducto = value; }
        }
        private int idcategoria;

        public int Idcategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }


        private int idproveedor;

        public int Idproveedor
        {
            get { return idproveedor; }
            set { idproveedor = value; }
        }


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }
        private string unidad_medida;

        public string Unidad_medida
        {
            get { return unidad_medida; }
            set { unidad_medida = value.ToUpper(); }
        }
        private decimal precio_proveedor;

        public decimal Precio_proveedor
        {
            get { return precio_proveedor; }
            set { precio_proveedor = value; }
        }
        private short stock_actual;

        public short Stock_actual
        {
            get { return stock_actual; }
            set { stock_actual = value; }
        }
        private short stock_minimo;

        public short Stock_minimo
        {
            get { return stock_minimo; }
            set { stock_minimo = value; }
        }
        public Producto() { }
    }
}
