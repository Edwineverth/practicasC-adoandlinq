using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;
using System.Windows.Forms;
using System.Data.Common;
using System.Data;

namespace LogicaNegocio
{
    public class ProveedorLN
    {
        public List<Proveedor> ObtenerProveedoresSP()
        {
            List<Proveedor> ListProv = new List<Proveedor>();
            try
            {
                string sql = "cp_ListaProveedores";
                Datos db = new Datos();
                db.Conectar();
                db.CrearComandoSP(sql);
                DbDataReader datos = db.EjecutarConsulta();
                Proveedor p = null;
                while (datos.Read())
                {
                    try
                    {

                        p = new Proveedor(datos.GetInt32(0), datos.GetString(1), datos.GetString(2), datos.GetString(3), datos.GetString(4), datos.GetString(5), datos.GetString(6), datos.GetString(7));
                        ListProv.Add(p);
                    }
                    catch (Exception ex)
                    {
                        throw new ReglasExcepciones("Los tipos no coinciden.", ex);
                    }

                }
                datos.Close();
                db.Desconectar();
            }
            catch (ReglasExcepciones)
            {
                throw new ReglasExcepciones("Error a obtener los productos.");
            }
            return ListProv;
        }

        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> ListProv = new List<Proveedor>();
            try
            {
                string sql = "SELECT * FROM PROVEEDOR";
                Datos db = new Datos();
                db.Conectar();
                db.CrearComando(sql);
                DbDataReader datos = db.EjecutarConsulta();
                Proveedor p = null;
                while (datos.Read())
                {
                    try
                    {

                        p = new Proveedor(datos.GetInt32(0), datos.GetString(1), datos.GetString(2), datos.GetString(3), datos.GetString(4), datos.GetString(5), datos.GetString(6), datos.GetString(7));
                        ListProv.Add(p);
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
                throw new ReglasExcepciones("Error a obtener los productos.", ex);
            }
            return ListProv;
        }

        public List<Proveedor> ObtenerProveedoresFiltro(string filtro)
        {
            List<Proveedor> ListProv = new List<Proveedor>();
            try
            {
                string sql = "" +
                " SELECT * FROM PROVEEDOR " +
                    "where CedProveedor like " + filtro + " or Nombre like " + filtro;
                Datos db = new Datos();
                db.Conectar();
                db.CrearComando(sql);
                DbDataReader datos = db.EjecutarConsulta();
                Proveedor p = null;
                while (datos.Read())
                {
                    try
                    {

                        p = new Proveedor(datos.GetInt32(0), datos.GetString(1), datos.GetString(2), datos.GetString(3), datos.GetString(4), datos.GetString(5), datos.GetString(6), datos.GetString(7));
                        ListProv.Add(p);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw new ReglasExcepciones("Los tipos no coinciden.", ex);
                    }

                }
                datos.Close();
                db.Desconectar();
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error a obtener los productos.", ex);
            }
            return ListProv;
        }

        public List<Proveedor> ObtenerProveedor(String id)
        {
            List<Proveedor> ListProv = new List<Proveedor>();
            try
            {
                string sql = "SELECT * FROM PROVEEDOR WHERE IdProveedor=" + id;
                Datos db = new Datos();
                db.Conectar();
                db.CrearComando(sql);
                DbDataReader datos = db.EjecutarConsulta();
                Proveedor p = null;
                while (datos.Read())
                {
                    try
                    {

                        p = new Proveedor(datos.GetInt32(0), datos.GetString(1), datos.GetString(2), datos.GetString(3), datos.GetString(4), datos.GetString(5), datos.GetString(6), datos.GetString(7));
                        ListProv.Add(p);
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
                throw new ReglasExcepciones("Error a obtener los productos.", ex);
            }
            return ListProv;
        }

        public void InsertarProveedor(Proveedor prov)
        {
            Datos db = new Datos();
            try
            {
                db.Conectar();
                string sql = "INSERT INTO PROVEEDOR ( CedProveedor, Nombre, Representante, Direccion, Ciudad, Telefono, Fax)" +
                                            " VALUES ( @CedProveedor, @Nombre, @Representante, @Direccion, @Ciudad, @Telefono, @Fax)";
                db.CrearComando(sql);
                //db.AsignarParametroEntero("@IdProveedor", prov.IdProveedor);
                db.AsignarParametroCadena("@CedProveedor", prov.CedProveedor);
                db.AsignarParametroCadena("@Nombre", prov.Nombre);
                db.AsignarParametroCadena("@Representante", prov.Representante);
                db.AsignarParametroCadena("@Direccion", prov.Direccion);
                db.AsignarParametroCadena("@Ciudad", prov.Ciudad);
                db.AsignarParametroCadena("@Telefono", prov.Telefono);
                db.AsignarParametroCadena("@Fax", prov.Fax);
                db.EjecutarComando(); ;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ReglasExcepciones("Error al registrar Proveedor.", ex);
            }
            finally
            {
                db.Desconectar();
            }
        }



        public void ModificarProveedor(Proveedor prov)
        {
            Datos db = new Datos();
            try
            {
                db.Conectar();
                string sql = "UPDATE PROVEEDOR  SET CedProveedor=@CedProveedor, Nombre=@Nombre, Representante=@Representante," +
                    " Direccion=@Direccion, Ciudad=@Ciudad, Telefono=@Telefono, Fax=@Fax WHERE IdProveedor = @IdProveedor";
                db.CrearComando(sql);
                db.AsignarParametroEntero("@IdProveedor", prov.IdProveedor);
                db.AsignarParametroCadena("@CedProveedor", prov.CedProveedor);
                db.AsignarParametroCadena("@Nombre", prov.Nombre);
                db.AsignarParametroCadena("@Representante", prov.Representante);
                db.AsignarParametroCadena("@Direccion", prov.Direccion);
                db.AsignarParametroCadena("@Ciudad", prov.Ciudad);
                db.AsignarParametroCadena("@Telefono", prov.Telefono);
                db.AsignarParametroCadena("@Fax", prov.Fax);
                db.EjecutarComando(); ;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ReglasExcepciones("Error al registrar Proveedor.", ex);
            }
            finally
            {
                db.Desconectar();
            }
        }

        public void EliminarProveedor(string id)
        {
            Datos db = new Datos();
            try
            {
                db.Conectar();
                string sql = "DELETE FROM PROVEEDOR WHERE IdProveedor =@IdProveedor";
                db.CrearComando(sql);
                //db.AsignarParametroEntero("@IdProveedor", prov.IdProveedor);
                db.AsignarParametroCadena("@IdProveedor", id);
                db.EjecutarComando(); ;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ReglasExcepciones("Error al registrar Proveedor.", ex);
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
                string prAlmacenado = "cp_ListaProveedorFiltro";
                Datos db = new Datos();
                db.Conectar();
                db.CrearComandoSP(prAlmacenado);
                db.AsignarParametroCadenaSP("@valor", valor);
                datos = db.EjecutarConsulta();
                dt.Load(datos);//pasamos los datos del Reader al DataTable
                datos.Close();
                db.Desconectar();
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error a obtener los proveedores filtradas.", ex);
            }
            return dt;
        }

        /*
        public DataTable filtrar(string valor)
        {
            DbDataReader datos;
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from PROVEEDOR "+
                    "where CedProveedor like '%@valor%' or Nombre like '%@valor%'";
                Datos db = new Datos();
                db.Conectar();
                db.CrearComando(sql);
                db.AsignarParametroCadena("@valor", valor);
                datos = db.EjecutarConsulta();
                dt.Load(datos);//pasamos los datos del Reader al DataTable
                datos.Close();
                db.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ReglasExcepciones("Error a obtener productos filtrados.", ex);
            }
            return dt;
        }*/
    }
}