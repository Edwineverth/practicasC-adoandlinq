using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace CapaDatos
{
    public class Datos
    {
        private DbConnection conexión = null;
        private DbCommand comando = null;
        private DbDataAdapter adaptador = null;
        private string cadenaConexion;
        private static DbProviderFactory factory = null;
        public Datos()
        {
            Configurar();
        }
        private void Configurar()
        {
            try
            {
                string proveedor = ConfigurationManager.AppSettings.Get("PROVEEDOR_ADONET");
                this.cadenaConexion = ConfigurationManager.AppSettings.Get("CADENA_CONEXION");
                Datos.factory = DbProviderFactories.GetFactory(proveedor);
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al cargar la configuración de acceso a datos",ex);
            }
        }
        public void Conectar()
        {
            if (this.conexión != null && !this.conexión.State.Equals(ConnectionState.Closed))
            {
                throw new DatosExcepciones("La conexion ya se encuentra abierta");

            }
            try
            {
                if (this.conexión == null)
                {
                    this.conexión = factory.CreateConnection();
                    this.conexión.ConnectionString = cadenaConexion;

                }
                this.conexión.Open();
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al conectarse a la base de datos",ex);
            }
        }

        public void Desconectar()
        {
            if (this.conexión.State.Equals(ConnectionState.Open))
            {
                this.conexión.Close();
            }

        }
        public void CrearComando(string sentenciasSQL)
        {
            this.comando = factory.CreateCommand();
            this.comando.Connection = this.conexión;
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = sentenciasSQL;
        }
        public void CrearComandoSP(string nomsp)
        {
            this.comando = factory.CreateCommand();
            this.comando.Connection = this.conexión;
            this.comando.CommandType = CommandType.StoredProcedure;
            this.comando.CommandText = nomsp;
        }

        public DataTable EjecutarCoonsulta(String sentencia, params DbParameter[] parametros)
        {
            this.adaptador = factory.CreateDataAdapter();
            adaptador.SelectCommand = factory.CreateCommand();
            adaptador.SelectCommand.Connection = this.conexión;
            adaptador.SelectCommand.CommandText = sentencia;
            foreach (DbParameter item in parametros)
            {
                adaptador.SelectCommand.Parameters.Add(item);

            }
            DataSet resultado = new DataSet();
            adaptador.Fill(resultado);
            return resultado.Tables[0];
        }
        public void ejecutarOperacion(string sentancia, params DbParameter[] parametros)
        {
            comando = factory.CreateCommand();
            comando.Connection = this.conexión;
            comando.CommandText = sentancia;
            foreach (DbParameter item in parametros)
            {
                comando.Parameters.Add(item);

            }
        }

        private void AsignarParametro(string nombre, string separador, string valor)
        {
            int indice = this.comando.CommandText.IndexOf(nombre);
            string prefijo = this.comando.CommandText.Substring(0, indice);
            string sufijo = this.comando.CommandText.Substring(indice + nombre.Length);
            this.comando.CommandText = prefijo + separador + valor + separador + sufijo;
        }
        public void asignarParametroCadena(string nombre, string valor)
        {
            AsignarParametro(nombre, "'", valor);

        }
        public void asignarParametroEntero(string nombre, int valor)
        {
            AsignarParametro(nombre, "", valor.ToString());
        }

        public void asignarParametroFecha(string nombre, DateTime valor)
        {
            AsignarParametro(nombre, "'", valor.ToString());
        }
        public DbDataReader ejecutarConsulta()
        {
            return this.comando.ExecuteReader();
        }
        public void asignarParametroCadenaSP(string nombre, string valor)
        {
            DbParameter pa = comando.CreateParameter();
            pa.ParameterName = nombre;
            pa.DbType = DbType.String;
            pa.Direction = ParameterDirection.Input;
            pa.Value = valor;
            comando.Parameters.Add(pa);
        }
        public void asignarParametroEnteroSP(string nombre, int valor)
        {
            DbParameter pa = comando.CreateParameter();
            pa.ParameterName = nombre;
            pa.DbType = DbType.Int32;
            pa.Direction = ParameterDirection.Input;
            pa.Value = valor;
            comando.Parameters.Add(pa);
        }

        public void asignarParametroDoubleSP(string nombre, double valor)
        {
            DbParameter pa = comando.CreateParameter();
            pa.ParameterName = nombre;
            pa.DbType = DbType.Double;
            pa.Direction = ParameterDirection.Input;
            pa.Value = valor;
            comando.Parameters.Add(pa);
        }
        public int EjecutarEscalar()
        {
            int escalar = 0;
            try
            {
                escalar = int.Parse(this.comando.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al ejecutar un escalar.", ex);
            }
            return escalar;
        }
        public void EjecutarComando()
        {
            this.comando.ExecuteNonQuery();
        }
    }
}
