using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        private int idcategoria;

        public int Idcategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }
        private string categoria;

        public string Categoria1
        {
            get { return categoria; }
            set { categoria = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public Categoria()
        {

        }
        
    }
}
