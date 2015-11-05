using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Poryecto_InfoAplicada.Modelo
{
    class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conexion = new SqlConnection(@"Data Source=AND2109\CLIENTES;Initial Catalog=AdventureWorks2000;Integrated Security=True");
            Conexion.Open();
            return Conexion;

        }
    }
}
