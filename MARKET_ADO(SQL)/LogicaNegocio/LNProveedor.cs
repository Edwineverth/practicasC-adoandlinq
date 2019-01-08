using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;
using CapaDatos.Operaciones;
using Entidades;
using Entidades.Objetos;

namespace LogicaNegocio
{
    public class LNProveedor
    {
        int opc = 0;

        public void Insertar(Proveedor p)
        {
            opc = 1;
            string paNombre = "cp_InsertarProveedor";

            List<Parametro> listPar = getListParametros(p);

            try
            {
                Operaciones op = new Operaciones();
                op.EjecutarProcedimientoA(listPar, paNombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar! " + e.Message);
            }
        }

        public void Actualizar(Proveedor p)
        {
            opc = 2;
            string paNombre = "cp_ActualizarProveedor";
            List<Parametro> listPar = getListParametros(p);

            try
            {
                Operaciones op = new Operaciones();
                op.EjecutarProcedimientoA(listPar, paNombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al actualizar! " + e.Message);
            }
        }


        /*--------------------------------LISTAR PROVEEDOR------------------------------*/

        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            string paNombre = "cp_ListaProveedores";

            try
            {
                Listar op = new Listar();
                dt = op.ListarTabla(paNombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar!" + e.Message);
            }
            return dt;
        }

        public List<DataRow> ListarEnLista()
        {
            DataTable dt = new DataTable();
            string paNombre = "cp_ListaProveedores";

            try
            {
                Listar op = new Listar();
                dt = op.ListarTabla(paNombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar!" + e.Message);
            }
            List<DataRow> list = dt.AsEnumerable().ToList();
            return list;
        }

        public DataTable ListarFiltro(string parBuscar)
        {
            DataTable dt = new DataTable();
            string paNombre = "cp_ListaProveedorFiltro";

            Parametro buscar = new Parametro("@valor", parBuscar);
            List<Parametro> list = new List<Parametro>();
            list.Add(buscar);

            try
            {
                Listar op = new Listar();
                dt = op.ListarFiltro(list, paNombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar!" + e.Message);
            }

            return dt;
        }


        public void Eliminar(int idProv)
        {
            string paNombre = "cp_EliminarProveedor";

            Parametro buscar = new Parametro("@id", idProv);
            List<Parametro> list = new List<Parametro>();
            list.Add(buscar);

            try
            {
                Operaciones op = new Operaciones();
                op.EjecutarProcedimientoA(list, paNombre);
            }
            catch (Exception mes)
            {
                throw new Exception("Error al Eliminar " + mes.Message);
            }
        }

        private List<Parametro> getListParametros(Proveedor p)
        {
            List<Parametro> list = new List<Parametro>();
            Parametro ced = new Parametro("@cedula", p.Cedula_pro);
            Parametro nom = new Parametro("@nombre", p.Nombre_pro);
            Parametro rep = new Parametro("@representante", p.Representante_pro);
            Parametro dir = new Parametro("@direccion", p.Direccion_pro);
            Parametro ciu = new Parametro("@ciudad", p.Ciudad_pro);
            Parametro tel = new Parametro("@telefono", p.Telefono_pro);
            Parametro fax = new Parametro("@fax", p.Fax_pro);
            if (opc == 2)
            {
                Parametro id = new Parametro("@id", p.Id_pro);
                list.Add(id);
            }
            list.Add(ced);
            list.Add(nom);
            list.Add(rep);
            list.Add(dir);
            list.Add(ciu);
            list.Add(tel);
            list.Add(fax);
            return list;
        }
    }
}
