using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Inventario;
using CapaDatos;
using Entidades;

namespace LogicaNegocio.Inventario
{
    public class ProveedorLN
    {


        public List<filtrarproveedorResult> ListarProveedores(string val)
        {
            return ProveedorCD.ObtenerProveedores(val);
        }
        public bool existeProveedor(string id)
        {
            return ProveedorCD.Existe(id);
        }

        public List<PROVEEDOR> ListarProveedoresTodos()
        {
            return ProveedorCD.ListarProveedoresTodos();
        }
        public bool InsertarProveedor(Proveedor p)
        {
            if (ProveedorCD.Existe(p.CedProveedor))
                return true;
            else
            {
                ProveedorCD.Create(p);
                return false;
            }

        }
        public bool ModificarProveedor(Proveedor p)
        {
             ProveedorCD.Modificar(p);
                return false;
            

        }
        public bool EliminarProveedor(Proveedor p)
        {
            ProveedorCD.Eliminar(p);
            return false;


        }
        public int getidproveedorbyprovnombre(string provnombre)
        {
            return ProveedorCD.getidproveedorbyprovnombre(provnombre);

        }
        public string getnombrebyidprov(int idprov)
        {
            return ProveedorCD.getnombrebyidprov(idprov);
        }
        public List<string> getnombresprov()
        {
            return ProveedorCD.getnombresprov();
        }
    }
}

