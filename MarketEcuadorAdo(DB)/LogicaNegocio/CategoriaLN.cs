using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;

namespace LogicaNegocio
{
    public class CategoriaLN
    {
        public List<Categoria> obtenerCategorias()
        {
            List<Categoria> ListCat = new List<Categoria>();
            try
            {
                string prAlmacenado = "cp_ListaCategorias";
                Datos db = new Datos();
                db.Conectar();
                db.CrearComandoSP(prAlmacenado);
                DbDataReader datos = db.EjecutarConsulta();
                Categoria c = null;
                while (datos.Read())
                {
                    try
                    {

                        c = new Categoria(datos.GetInt32(0), datos.GetString(1), datos.GetString(2));
                        ListCat.Add(c);
                    }
                    catch (Exception ex)
                    {
                        throw new ReglasExcepciones("Los tipos no coinciden.", ex);
                    }

                }
                datos.Close();
                db.Desconectar();
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error a obtener las categorias.", ex);
            }
            return ListCat;
        }

        public void insertarCategoria(Categoria cat)
        {
            Datos db = new Datos();
            try
            {
                db.Conectar();
                string paName = "cp_InsertarCategoria";
                db.CrearComandoSP(paName);
                db.AsignarParametroCadenaSP("@categoria", cat.Categoria_cat);
                db.AsignarParametroCadenaSP("@descripcion", cat.Descripcion_cat);
                db.EjecutarComando();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ReglasExcepciones("Error al registrar Categoria.", ex);
            }
            finally
            {
                db.Desconectar();
            }
        }

        public void actualizarCategoria(Categoria cat)
        {
            Datos db = new Datos();
            try
            {
                db.Conectar();
                string paName = "cp_ActualizarCategoria";
                db.CrearComandoSP(paName);
                db.AsignarParametroEnteroSP("@id", cat.Id_cat);
                db.AsignarParametroCadenaSP("@categoria", cat.Categoria_cat);
                db.AsignarParametroCadenaSP("@descripcion", cat.Descripcion_cat);
                db.EjecutarComando();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ReglasExcepciones("Error al registrar Categoria.", ex);
            }
            finally
            {
                db.Desconectar();
            }
        }

        public void eliminarCategoria(int id)
        {
            Datos db = new Datos();
            try
            {
                db.Conectar();
                string paName = "cp_EliminarCategoria";
                db.CrearComandoSP(paName);
                db.AsignarParametroEnteroSP("@id", id);
                db.EjecutarComando();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ReglasExcepciones("Error al eliminar Categoria.", ex);
            }
            finally
            {
                db.Desconectar();
            }
        }    

        public DataTable filtrarCategorias(string valor)
        {
            DbDataReader datos;
            DataTable dt = new DataTable();
            try
            {
                string prAlmacenado = "cp_ListaCategoriaFiltro";
                Datos db = new Datos();
                db.Conectar();
                db.CrearComandoSP(prAlmacenado);
                db.AsignarParametroCadenaSP("@busqueda", valor);
                datos = db.EjecutarConsulta();
                dt.Load(datos);//pasamos los datos del Reader al DataTable
                datos.Close();
                db.Desconectar();
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error a obtener las categorias filtradas.", ex);
            }
            return dt;
        }

        

        public List<Categoria> obtenerCategoria(String id)
        {
            List<Categoria> ListCat = new List<Categoria>();
            try
            {
                string sql = "SELECT * FROM CATEGORIA WHERE IdCategoria=" + id;
                Datos db = new Datos();
                db.Conectar();
                db.CrearComando(sql);
                DbDataReader datos = db.EjecutarConsulta();
                Categoria p = null;
                while (datos.Read())
                {
                    try
                    {

                        p = new Categoria(datos.GetInt32(0), datos.GetString(1), datos.GetString(2));
                        ListCat.Add(p);
                    }
                    catch (Exception ex)
                    {
                        throw new ReglasExcepciones("Los tipos no coinciden.", ex);
                    }

                }
                datos.Close();
                db.Desconectar();
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error a obtener la categoria.", ex);
            }
            return ListCat;
        }

    }
}
