using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace capaDatos
{
    class Conexion
    {
        public SqlConnection conectar()
        {
            ///Este metodo es para la coneccion al abase de datos
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Productos;Integrated Security=True;";
            return cn;

        }
    }
}
