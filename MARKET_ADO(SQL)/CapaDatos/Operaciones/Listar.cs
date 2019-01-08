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
    public class Listar:Conexion
    {
        /*----------------------LISTAR SIN PARAMETROS------------------------*/

        public DataTable ListarTabla(string paNombre)
        {
            DataTable ds = new DataTable();
            string Cadena = CadenaConexion();
            using (SqlConnection conexion = new SqlConnection(Cadena))
            {
                conexion.Open();
                SqlDataAdapter da = new SqlDataAdapter(paNombre, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandTimeout = 10;
                da.Fill(ds);
                conexion.Close();
                return ds;
            }
        }

        /*----------------------LISTAR FILTRANDO------------------------*/
        public DataTable ListarFiltro(List<Parametro> par, string paNombbre)
        {
            DataTable dt = new DataTable();
            try
            {
                string cadena = this.CadenaConexion();
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    SqlDataAdapter Comando = new SqlDataAdapter(paNombbre, conexion);
                    Comando.SelectCommand.CommandType = CommandType.StoredProcedure;
                    foreach (Parametro pa in par)
                    {
                        Comando.SelectCommand.Parameters.AddWithValue(pa.Nombre_pa, pa.Valor_pa);
                    }
                    Comando.Fill(dt);
                    conexion.Close();
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            return dt;
        }
    }
}
