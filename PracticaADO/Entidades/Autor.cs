using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Autor
       
    {
        private int idAutor;

        public int IdAutor
        {
            get { return idAutor; }
            set { idAutor = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string web;

        public string Web
        {
            get { return web; }
            set { web = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        ~ Autor()
        {

        }
        public Autor()
        {

        }
        public Autor (int idAutor, string nombre, string web, string email){
            this.idAutor = idAutor;
            this.nombre = nombre;
            this.web = web;
            this.email = email;
        }

    }
}
