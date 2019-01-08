using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Objetos
{
    public class Proveedor
    {
        private int id_pro;
        private string cedula_pro;
        private string nombre_pro;
        private string representante_pro;
        private string direccion_pro;
        private string ciudad_pro;
        private string telefono_pro;
        private string fax_pro;

        ~Proveedor()
        {

        }

        public virtual void Dispose()
        {

        }

        public Proveedor()
        {

        }

        /// 
        /// <param name="id"></param>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="representante"></param>
        /// <param name="direccion"></param>
        /// <param name="ciudad"></param>
        /// <param name="telefono"></param>
        /// <param name="fax"></param>
        public Proveedor(int id, string cedula, string nombre,
            string representante, string direccion, string ciudad,
            string telefono, string fax)
        {
            Id_pro = id;
            Cedula_pro = cedula;
            Nombre_pro = nombre;
            Representante_pro = representante;
            Direccion_pro = direccion;
            Ciudad_pro = ciudad;
            Telefono_pro = telefono;
            Fax_pro = fax;
        }

        public int Id_pro
        {
            get
            {
                return id_pro;
            }
            set
            {
                id_pro = value;
            }
        }

        public string Cedula_pro
        {
            get
            {
                return cedula_pro;
            }
            set
            {
                cedula_pro = value;
            }
        }

        public string Nombre_pro
        {
            get
            {
                return nombre_pro;
            }
            set
            {
                nombre_pro = value;
            }
        }

        public string Representante_pro
        {
            get
            {
                return representante_pro;
            }
            set
            {
                representante_pro = value;
            }
        }

        public string Direccion_pro
        {
            get
            {
                return direccion_pro;
            }
            set
            {
                direccion_pro = value;
            }
        }

        public string Ciudad_pro
        {
            get
            {
                return ciudad_pro;
            }
            set
            {
                ciudad_pro = value;
            }
        }

        public string Telefono_pro
        {
            get
            {
                return telefono_pro;
            }
            set
            {
                telefono_pro = value;
            }
        }

        public string Fax_pro
        {
            get
            {
                return fax_pro;
            }
            set
            {
                fax_pro = value;
            }
        }
    }
}
