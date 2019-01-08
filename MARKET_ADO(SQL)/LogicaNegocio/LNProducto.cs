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
    public class LNProducto
    {
        int opc = 0;

        public void Insertar(Producto p)
        {
            opc = 1;
            string paNombre = "cp_InsertarProducto";

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

        public void Actualizar(Producto p)
        {
            opc = 2;
            string paNombre = "cp_ActualizarProducto";
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
        
        public Producto Buscar(string parBuscar)
        {
            DataTable dt = new DataTable();
            string paNombre = "cp_BuscarProducto";

            Parametro buscar = new Parametro("@id", parBuscar);
            List<Parametro> list = new List<Parametro>();
            list.Add(buscar);

            try
            {
                Listar op = new Listar();
                dt = op.ListarFiltro(list, paNombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar!" + e.Message);
            }

            Producto pr = new Producto();

            if(dt.Rows.Count>0)
            {
                pr.Id_pro=Convert.ToInt32(dt.Rows[0][0]);
                pr.IdCategoria_pro = Convert.ToInt32(dt.Rows[0][1]);
                pr.IdProveedor_pro = Convert.ToInt32(dt.Rows[0][2]);
                pr.Nombre_pro = dt.Rows[0][3].ToString();
                pr.UnidadMedida_pro = dt.Rows[0][4].ToString();
                pr.PrecioProveedor_pro = Convert.ToDouble(dt.Rows[0][5]);
                pr.StockAnual_pro = Convert.ToInt32(dt.Rows[0][6]);
                pr.StockMinimo_pro = Convert.ToInt32(dt.Rows[0][7]);
            }
            return pr;
        }


        /*--------------------------------LISTAR PROVEEDOR------------------------------*/

        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            string paNombre = "cp_ListaProductos";

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

        public DataTable ListarFiltro(string parBuscar)
        {
            DataTable dt = new DataTable();
            string paNombre = "cp_ListaProductosFiltro";

            Parametro buscar = new Parametro("@nombre", parBuscar);
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


        public void Eliminar(int idProd)
        {
            string paNombre = "cp_EliminarProducto";

            Parametro buscar = new Parametro("@id", idProd);
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

        private List<Parametro> getListParametros(Producto p)
        {
            List<Parametro> list = new List<Parametro>();
            Parametro idCat = new Parametro("@idCat", p.IdCategoria_pro);
            Parametro idProv = new Parametro("@idProv", p.IdProveedor_pro);
            Parametro nombre = new Parametro("@nombre", p.Nombre_pro);
            Parametro uniMe = new Parametro("@uniMe", p.UnidadMedida_pro);
            Parametro preP = new Parametro("@preP", p.PrecioProveedor_pro);
            Parametro stA = new Parametro("@stA", p.StockAnual_pro);
            Parametro stM = new Parametro("@stM", p.StockMinimo_pro);
            if (opc == 2)
            {
                Parametro id = new Parametro("@id", p.Id_pro);
                list.Add(id);
            }
            list.Add(idCat);
            list.Add(idProv);
            list.Add(nombre);
            list.Add(uniMe);
            list.Add(preP);
            list.Add(stA);
            list.Add(stM);
            return list;
        }
    }
}
