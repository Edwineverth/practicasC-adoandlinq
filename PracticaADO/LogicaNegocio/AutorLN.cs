using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using Entidades;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.Common;

namespace LogicaNegocio
{
    public class AutorLN
    {

        public List<Autor> obtenerAutor()
        {
            List<Autor> ListAutor = new List<Autor>();
            try
            {
               
                string prAlmacenado = "sp_listarAutor";
                Datos db = new Datos();
                db.Conectar();
                db.CrearComandoSP(prAlmacenado);
                DbDataReader datos = db.ejecutarConsulta();
                Autor a = null;
                while (datos.Read())
                {
                    try
                    {
                        a = new Autor(datos.GetInt32(0), datos.GetString(1), datos.GetString(2), datos.GetString(3));
                        ListAutor.Add(a);
                    }
                    catch (Exception ex)
                    {
                        throw new ReglasExcepciones("Los tipos no coinciden", ex);
                    }
                }
                datos.Close();
                db.Desconectar();
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Erro a obtener Autor.", ex);
            }
            return ListAutor;

        }
        public void insertarAutor(Autor aut)
        {
            Datos db = new Datos();
            try{
                db.Conectar();
                string paName = "sp_insertarAutor";
                db.CrearComandoSP(paName);
                db.asignarParametroCadenaSP("@Nombre",aut.Nombre);
                db.asignarParametroCadenaSP("@Web", aut.Web);
                db.asignarParametroCadenaSP("@Email", aut.Email);
                db.EjecutarComando();
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error al registrar autor.", ex);
            }
            finally
            {
                db.Desconectar();
            }
        }
        public void actualizarAutor(Autor aut)
        {
            Datos db = new Datos();
            try
            {
                db.Conectar();
                string paName = "sp_actualizarAutor";
                db.CrearComandoSP(paName);
                db.asignarParametroEnteroSP("@AutorId", aut.IdAutor);
                db.asignarParametroCadenaSP("@Nombre", aut.Nombre);
                db.asignarParametroCadenaSP("@Web", aut.Web);
                db.asignarParametroCadenaSP("@Email", aut.Email);
                db.EjecutarComando();
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error al actualizar Autor. ", ex);
            }
            finally
            {
                db.Desconectar();
            }
        }
        public void eliminarAutor(int id)
        {
            Datos db = new Datos();
            try
            {
                db.Conectar();
                string paName = "sp_eliminarAutor";
                db.CrearComandoSP(paName);
                db.asignarParametroEnteroSP("@AutorId", id);
                db.EjecutarComando();

            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error al eliminar Autor . ", ex);

            }
            finally
            {
                db.Desconectar();
            }

        }

        public DataTable filtrarAutor(string valor)
        {
            DbDataReader datos;
            DataTable dt = new DataTable();
            try
            {
                string paAlmacenado = "sp_listarAutorP";
                Datos db = new Datos();
                db.Conectar();
                db.CrearComandoSP(paAlmacenado);
                db.asignarParametroCadenaSP("@parametro", valor);
                datos = db.ejecutarConsulta();
                dt.Load(datos);
                datos.Close();
                db.Desconectar();

            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error al filtrar. ", ex);
            }
            return dt;
        }
    }





  }

