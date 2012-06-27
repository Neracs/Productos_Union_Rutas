using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSQLserver
{
    public class Conexion
    {
        public System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
        public string conex = @"Data Source=.;Initial Catalog=ReporteadorF;Integrated Security=True;";
        public void Begin_conexion()
        {            
            conexion.ConnectionString = conex;
            conexion.Open();
        }
    }
}
