using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Parametro
    {
        private string nombre_pa;
        private object valor_pa;

        public Parametro()
        {

        }

        ~Parametro()
        {
        }

        public Parametro(string nom, object val)
        {
            Nombre_pa = nom;
            Valor_pa = val;
        }

        public string Nombre_pa
        {
            get { return nombre_pa; }
            set { nombre_pa = value; }
        }

        public object Valor_pa
        {
            get { return valor_pa; }
            set { valor_pa = value; }
        }
    }
}
