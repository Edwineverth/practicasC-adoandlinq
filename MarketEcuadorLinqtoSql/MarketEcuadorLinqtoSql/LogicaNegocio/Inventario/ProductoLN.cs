using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Inventario;
using Entidades;
namespace LogicaNegocio.Inventario
{
    public class ProductoLN
    {
        public List<filtrarproductoResult> ListarProductos(string val)
        {
            return ProductoCD.ObtenerProductoes(val);
        }
        public List<filtrarVistaProductoResult> ObtenerProductosbycategoria(string categoria){
            return ProductoCD.ObtenerProductosbycategoria(categoria);
        }
        public bool existeProveedor(string id)
        {
            return ProductoCD.Existe(id);
        }

        public bool InsertarProducto(Producto p)
        {
            if (ProductoCD.Existe(""+p.Nombre))
                return true;
            else
            {
                ProductoCD.Create(p);
                return false;
            }

        }
        public bool ModificarProducto(Producto p)
        {
            ProductoCD.Modificar(p);
            return false;


        }
        public bool EliminarProducto(Producto p)
        {
            ProductoCD.Eliminar(p);
            return false;


        }



    }
}
