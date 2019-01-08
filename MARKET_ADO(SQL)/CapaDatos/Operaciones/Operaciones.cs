using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos.Operaciones
{
    public class Operaciones:Conexion
    {
        /*-----Ejecutar procedimientos de INSERTAR - MODIFICAR - ELIMINAR----*/

        public void EjecutarProcedimientoA(List<Parametro> lista, string paNombre)
        {
            string cadena = this.CadenaConexion();
            SqlConnection Conexion = new SqlConnection(cadena);
            try
            {
                SqlCommand Comando = new SqlCommand(paNombre, Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                foreach (Parametro pa in lista)
                {
                    Comando.Parameters.AddWithValue(pa.Nombre_pa, pa.Valor_pa);
                }
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception mes)
            {
                throw new Exception(mes.Message);
            }
            finally
            {
                Conexion = null;
            }
        }
    }
}
