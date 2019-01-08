using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Objetos
{
    public class Producto
    {
        private int id_pro;
        private int idCategoria_pro;
        private int idProveedor_pro;
        private string nombre_pro;
        private string unidadMedida_pro;
        private double precioProveedor_pro;
        private int stockAnual_pro;
        private int stockMinimo_pro;

        public Producto(int idPro, int idCat, int idProv, string nombre,
            string uni, double pre, int stA, int stM)
        {
            Id_pro = idPro;
            IdCategoria_pro = idCat;
            IdProveedor_pro = idProv;
            Nombre_pro = nombre;
            UnidadMedida_pro = uni;
            PrecioProveedor_pro = pre;
            StockAnual_pro = stA;
            StockMinimo_pro = stM;
        }

        public Producto() { }
        ~Producto() { }

        public int Id_pro
        {
            get { return id_pro; }
            set { id_pro = value; }
        }

        public int IdCategoria_pro
        {
            get { return idCategoria_pro; }
            set { idCategoria_pro = value; }
        }

        public int IdProveedor_pro
        {
            get { return idProveedor_pro; }
            set { idProveedor_pro = value; }
        }

        public string Nombre_pro
        {
            get { return nombre_pro; }
            set { nombre_pro = value; }
        }

        public string UnidadMedida_pro
        {
            get { return unidadMedida_pro; }
            set { unidadMedida_pro = value; }
        }

        public double PrecioProveedor_pro
        {
            get { return precioProveedor_pro; }
            set { precioProveedor_pro = value; }
        }

        public int StockAnual_pro
        {
            get { return stockAnual_pro; }
            set { stockAnual_pro = value; }
        }

        public int StockMinimo_pro
        {
            get { return stockMinimo_pro; }
            set { stockMinimo_pro = value; }
        }



    }
}
