using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Operaciones;
using Entidades;
using Entidades.Objetos;
using System.Data;

namespace LogicaNegocio
{
    public class LNCategoria
    {
        int opc = 0;

        public void Insertar(Categoria c)
        {
            opc = 1;
            string paNombre = "cp_InsertarCategoria";

            List<Parametro> listPar = getListParametros(c);

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

        public void Actualizar(Categoria c)
        {
            opc = 2;
            string paNombre = "cp_ActualizarCategoria";
            List<Parametro> listPar = getListParametros(c);

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


        /*--------------------------------LISTAR CATEGORIA------------------------------*/

        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            string paNombre = "cp_ListaCategorias";

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
            string paNombre = "cp_ListaCategorias";

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
            string paNombre = "cp_ListaCategoriaFiltro";

            Parametro buscar = new Parametro("@busqueda", parBuscar);
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


        public void Eliminar(int idCat)
        {
            string paNombre = "cp_EliminarCategoria";

            Parametro buscar = new Parametro("@id", idCat);
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

        private List<Parametro> getListParametros(Categoria p)
        {
            List<Parametro> list = new List<Parametro>();
            Parametro ced = new Parametro("@categoria", p.Categoria_cat);
            Parametro nom = new Parametro("@descripcion", p.Descripcion_cat);
            if (opc == 2)
            {
                Parametro id = new Parametro("@id", p.Id_cat);
                list.Add(id);
            }
            list.Add(ced);
            list.Add(nom);
            return list;
        }
    }
}
