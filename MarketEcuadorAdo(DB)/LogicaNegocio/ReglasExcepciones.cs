using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    class ReglasExcepciones : ApplicationException
    {
        public ReglasExcepciones(string mensaje, Exception original)
            : base(mensaje, original)
        {
        }

        /// <summary>
        /// Construye una instancia con un mensaje de error, 
        /// invocando al constructor de la clase base.
        /// </summary>
        /// <param name="mensaje">El mensaje de error.</param>
        public ReglasExcepciones(string mensaje)
            : base(mensaje)
        {
        }
    }
}
