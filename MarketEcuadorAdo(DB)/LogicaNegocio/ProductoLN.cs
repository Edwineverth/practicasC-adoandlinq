using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;
using System.Data.Common;
using System.Data;
using System.Windows.Forms;

namespace LogicaNegocio
{
    public class ProductoLN
    {
        
        public DataTable listar()
        {
            DataTable dt;
            try
            {
                dt = new DataTable();
                string prAlmacenado = "cp_ListarProductosVistaPers";
                Datos db = new Datos();
                db.Conectar();
                db.CrearComandoSP(prAlmacenado);
                DbDataReader datos = db.EjecutarConsulta();
                dt.Load(datos);
                datos.Close();
                db.Desconectar();
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error a obtener los productos.", ex);
            }
            return dt;
        }

        /// <summary>
        /// INSERTAR PRODUCTO
        /// </summary>
        /// <param name="pro"></param>
        public void insertar(Producto pro)
        {
            Datos db = new Datos();
            try
            {
                db.Conectar();
                string paName = "cp_InsertarProducto";
                db.CrearComandoSP(paName);
                db.AsignarParametroEnteroSP("@idCat", pro.IdCategoria_pro);
                db.AsignarParametroEnteroSP("@idProv", pro.IdProveedor_pro);
                db.AsignarParametroCadenaSP("@nombre", pro.Nombre_pro);
                db.AsignarParametroCadenaSP("@uniMe", pro.UnidadMedida_pro);
                db.AsignarParametroDoubleSP("@preP", pro.PrecioProveedor_pro);
                db.AsignarParametroEnteroSP("@stA", pro.StockAnual_pro);
                db.AsignarParametroEnteroSP("@stM", pro.StockMinimo_pro);
                db.EjecutarComando();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ReglasExcepciones("Error al registrar Producto.", ex);
            }
            finally
            {
                db.Desconectar();
            }
        }

        public void actualizar(Producto pro)
        {
            Datos db = new Datos();
            try
            {
                db.Conectar();
                string paName = "cp_ActualizarProducto";
                db.CrearComandoSP(paName);
                db.AsignarParametroEnteroSP("@id", pro.Id_pro);
                db.AsignarParametroEnteroSP("@idCat", pro.IdCategoria_pro);
                db.AsignarParametroEnteroSP("@idProv", pro.IdProveedor_pro);
                db.AsignarParametroCadenaSP("@nombre", pro.Nombre_pro);
                db.AsignarParametroDoubleSP("@uniMe", pro.PrecioProveedor_pro);
                db.AsignarParametroEnteroSP("@stA", pro.StockAnual_pro);
                db.AsignarParametroEnteroSP("@stM", pro.StockMinimo_pro);
                db.EjecutarComando();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ReglasExcepciones("Error al actualizar datos de Producto.", ex);
            }
            finally
            {
                db.Desconectar();
            }
        }

        public void eliminar(int id)
        {
            Datos db = new Datos();
            try
            {
                db.Conectar();
                string paName = "cp_EliminarProducto";
                db.CrearComandoSP(paName);
                db.AsignarParametroEnteroSP("@id", id);
                db.EjecutarComando();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ReglasExcepciones("Error al eliminar Producto.", ex);
            }
            finally
            {
                db.Desconectar();
            }
        }

        public DataTable filtrar(string valor)
        {
            DbDataReader datos;
            DataTable dt = new DataTable();
            try
            {
                string prAlmacenado = "cp_ListaProductosFiltro";
                Datos db = new Datos();
                db.Conectar();
                db.CrearComandoSP(prAlmacenado);
                db.AsignarParametroCadenaSP("@nombre", valor);
                datos = db.EjecutarConsulta();
                dt.Load(datos);//pasamos los datos del Reader al DataTable
                datos.Close();
                db.Desconectar();
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error a obtener productos filtrados.", ex);
            }
            return dt;
        }



        public Producto obtenerProducto(String id)
        {
            Producto p = null;
            try
            {
                string sql = "SELECT * FROM PRODUCTO WHERE IdProducto=" + id;
                Datos db = new Datos();
                db.Conectar();
                db.CrearComando(sql);
                DbDataReader datos = db.EjecutarConsulta();
                while (datos.Read())
                {
                    try
                    {
                        p = new Producto(datos.GetInt32(0), datos.GetInt32(1), datos.GetInt32(2),
                                        datos.GetString(3), datos.GetString(4), Convert.ToDouble(datos.GetDecimal(5)),
                                        datos.GetInt16(6), datos.GetInt16(7));
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
                throw new ReglasExcepciones("Error a obtener producto.", ex);
            }
            return p;
        }


        /*
        public List<Producto> listarCategorias()
        {
            List<Producto> ListCat = new List<Producto>();
            try
            {
                string prAlmacenado = "cp_ListaProductos";
                Datos db = new Datos();
                db.Conectar();
                db.CrearComandoSP(prAlmacenado);
                DbDataReader datos = db.EjecutarConsulta();
                Producto p = null;
                while (datos.Read())
                {
                    try
                    {

                        p = new Producto(datos.GetInt32(0), datos.GetString(1), datos.GetString(2));
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
                throw new ReglasExcepciones("Error a obtener las categorias.", ex);
            }
            return ListCat;
        }*/
    }
}
