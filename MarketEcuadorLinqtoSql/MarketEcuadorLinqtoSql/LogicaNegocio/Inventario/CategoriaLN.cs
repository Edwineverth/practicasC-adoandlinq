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
    public class CategoriaLN
    {

        public List<filtrarcategoriaResult> ListarCategorias(string val)
        {
            return CategoriaCD.Obtenercategorias(val) ;
            
        }
        public bool existeCategoria(string id)
        {
            return ProveedorCD.Existe(id);
        }

        public bool InsertarCategoria(Categoria p)
        {
            if (CategoriaCD.Existe(p.Categoria1))
                return true;
            else
            {
                CategoriaCD.Create(p);
                return false;
            }

        }
        public bool ModificarCategoria(Categoria p)
        {
            CategoriaCD.Modificar(p);
            return false;


        }
        public bool EliminarCategoria(Categoria p)
        {
            CategoriaCD.Eliminar(p);
            return false;


        }
        public int getidcategoriabynombr(string categorianombre)
        {
            return CategoriaCD.getidcategoriabynombr(categorianombre);

        }
        public string getcatenombbyidcat(int idcate)
        {
            return CategoriaCD.getcatenombbyidcat(idcate);
        }
        public List<String> getcategorias()
        {
            return CategoriaCD.getcategorias();
        }
        
    }
}
