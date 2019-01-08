using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor
    {
        private int idProveedor;
        private string cedProveedor;
        private string nombre;
        private string representante;
        private string direccion;
        private string ciudad;
        private string telefono;
        private string fax;

        public Proveedor()
        {

        }

        public Proveedor(int id, string ced, string nom, string rep, string dir, string ciu, string tel, string fa)
        {
            idProveedor = id;
            cedProveedor = ced;
            nombre = nom;
            representante = rep;
            direccion = dir;
            ciudad = ciu;
            telefono = tel;
            fax = fa;
        }

        ~Proveedor()
        {

        }

        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }
        public string CedProveedor
        {
            get { return cedProveedor; }
            set { cedProveedor = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Representante
        {
            get { return representante; }
            set { representante = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }

    
    
    }
}
