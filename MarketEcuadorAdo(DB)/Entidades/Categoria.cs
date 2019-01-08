using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        private int id_cat;
        private string descripcion_cat;
        private string categoria_cat;

        public Categoria(int id, string cat, string des)
        {
            Id_cat = id;
            Descripcion_cat = des;
            Categoria_cat = cat;
        }

        public Categoria()
        {

        }

        ~Categoria() { }

        public int Id_cat
        {
            get { return id_cat; }
            set { id_cat = value; }
        }

        public string Categoria_cat
        {
            get { return categoria_cat; }
            set { categoria_cat = value; }
        }

        public string Descripcion_cat
        {
            get { return descripcion_cat; }
            set { descripcion_cat = value; }
        }

    }
}
