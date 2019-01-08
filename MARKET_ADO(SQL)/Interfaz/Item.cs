using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public class Item
    {
        private string text;
        private object value;

        public object Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        

    }
}
