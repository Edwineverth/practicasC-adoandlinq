using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        public string DataBase = "MarketECUADOR";
        public string Server = "(local)";

        public string CadenaConexion()
        {
            SqlConnectionStringBuilder cadena = new SqlConnectionStringBuilder();
            cadena.DataSource = this.Server;
            try
            {
                cadena.InitialCatalog = this.DataBase;
                cadena.IntegratedSecurity = true;
            }
            catch (Exception err)
            {
                throw new Exception("" + err.Message);
            }
            return cadena.ConnectionString;
        }
    }
}
