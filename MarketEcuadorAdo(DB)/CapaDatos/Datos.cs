using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Datos
    {
        private DbConnection conexion = null;//Permite realizar la conexion a la base de datos
        private DbCommand comando = null;//Permite ejecutar dentro de una base de datos, recoriendo solo de lectura
        //private DbTransaction transaccion = null;//conveniente usarlo en la base de datos
        private DbDataAdapter adaptador = null;//intermediario de la base de datos y el data set, permite llevar la sentencia, ejecutaba y llenaba el data set
        private string cadenaConexion;//
        private static DbProviderFactory factory = null;//

        public Datos()
        {
            Configurar();
        }

        /// Configura el acceso a la base de datos para su utilización.
       

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
                throw new DatosExcepciones("Error al cargar la configuración del acceso a datos.", ex);
            }
        }


        /// Se concecta con la base de datos.

        public void Conectar()
        {
            if (this.conexion != null && !this.conexion.State.Equals(ConnectionState.Closed))
            {
                throw new DatosExcepciones("La conexión ya se encuentra abierta.");
            }
            try
            {
                if (this.conexion == null)
                {
                    this.conexion = factory.CreateConnection();
                    this.conexion.ConnectionString = cadenaConexion;
                }
                this.conexion.Open();
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al conectarse a la base de datos.", ex);
            }
        }

        public void Desconectar()
        {
            if (this.conexion.State.Equals(ConnectionState.Open))
            {
                this.conexion.Close();
            }
        }



        /// <code>SELECT * FROM Tabla WHERE campo1=@campo1, campo2=@campo2</code>
        /// Guarda el comando para el seteo de parámetros y la posterior ejecución.
        /// </summary>
        /// <param name="sentenciaSQL">La sentencia SQL con el formato: SENTENCIA [param = @param,]</param>

        public void CrearComando(string sentenciaSQL)
        {
            this.comando = factory.CreateCommand();
            this.comando.Connection = this.conexion;
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = sentenciaSQL;

        }


        public void CrearComandoSP(string nomsp)
        {
            this.comando = factory.CreateCommand();
            this.comando.Connection = this.conexion;
            this.comando.CommandType = CommandType.StoredProcedure;
            this.comando.CommandText = nomsp;

        }

        // Permite ejecutar un dbDataAdapter en el cual puede enviar una sentencia SQL o un Store Procedure para Listar

        public DataTable EjecutarConsulta(string sentencia, params DbParameter[] parametros)
        {
            this.adaptador = factory.CreateDataAdapter();
            adaptador.SelectCommand = factory.CreateCommand(); //SqlCommand();
            adaptador.SelectCommand.Connection = this.conexion;
            adaptador.SelectCommand.CommandText = sentencia;

            foreach (DbParameter item in parametros)
            {
                adaptador.SelectCommand.Parameters.Add(item);
            }

            DataSet resultado = new DataSet();
            adaptador.Fill(resultado);

            return resultado.Tables[0];
        }

        public void EjecutarOperacion(string sentencia, params DbParameter[] parametros)
        {

            comando = factory.CreateCommand();
            comando.Connection = this.conexion;
            comando.CommandText = sentencia;
            foreach (DbParameter item in parametros)
            {
                comando.Parameters.Add(item);
            }

            //  comando.ExecuteNonQuery();


        }
        /// <summary>
        /// Asigna un parámetro al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="separador">El separador que será agregado al valor del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        private void AsignarParametro(string nombre, string separador, string valor)
        {
            int indice = this.comando.CommandText.IndexOf(nombre);
            string prefijo = this.comando.CommandText.Substring(0, indice);
            string sufijo = this.comando.CommandText.Substring(indice + nombre.Length);
            this.comando.CommandText = prefijo + separador + valor + separador + sufijo;
        }
        public void AsignarParametroNulo(string nombre)
        {
            AsignarParametro(nombre, "", "NULL");
        }

        /// <summary>
        /// Asigna un parámetro de tipo cadena al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametroCadena(string nombre, string valor)
        {
            AsignarParametro(nombre, "'", valor);
            
        }


        /// <summary>
        /// Asigna un parámetro de tipo entero al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametroEntero(string nombre, int valor)
        {
            AsignarParametro(nombre, "", valor.ToString());
        }



        /// <summary>
        /// Asigna un parámetro de tipo fecha al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametroFecha(string nombre, DateTime valor)
        {
            AsignarParametro(nombre, "'", valor.ToString());
        }

        /// <summary>
        /// Ejecuta el comando creado y retorna el resultado de la consulta.
        /// </summary>
        /// <returns>El resultado de la consulta.</returns>
        /// <exception cref="BaseDatosException">Si ocurre un error al ejecutar el comando.</exception>
        public DbDataReader EjecutarConsulta()
        {
            return this.comando.ExecuteReader();
        }


        public void AsignarParametroCadenaSP(string nombre, string valor)
        {
            DbParameter pa = comando.CreateParameter();
            pa.ParameterName = nombre;
            pa.DbType = DbType.String;
            pa.Direction = ParameterDirection.Input;
            pa.Value = valor;
            comando.Parameters.Add(pa);
        }

        public void AsignarParametroEnteroSP(string nombre, int valor)
        {
            DbParameter pa = comando.CreateParameter();
            pa.ParameterName = nombre;
            pa.DbType = DbType.Int32;
            pa.Direction = ParameterDirection.Input;
            pa.Value = valor;
            comando.Parameters.Add(pa);
        }

        public void AsignarParametroDoubleSP(string nombre, double valor)
        {
            DbParameter pa = comando.CreateParameter();
            pa.ParameterName = nombre;
            pa.DbType = DbType.Double;
            pa.Direction = ParameterDirection.Input;
            pa.Value = valor;
            comando.Parameters.Add(pa);
        }

        /// <summary>
        /// Ejecuta el comando creado y retorna un escalar.
        /// </summary>
        /// <returns>El escalar que es el resultado del comando.</returns>
        /// <exception cref="BaseDatosException">Si ocurre un error al ejecutar el comando.</exception>
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


        /// <summary>
        /// Ejecuta el comando creado.
        /// </summary>
        public void EjecutarComando()
        {
            this.comando.ExecuteNonQuery();
        }

       
        /// <summary>
        /// Comienza una transacción en base a la conexion abierta.
        /// Todo lo que se ejecute luego de esta ionvocación estará 
        /// dentro de una tranasacción.
        /// </summary>



    }
    
}
