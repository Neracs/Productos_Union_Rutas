using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataSQLserver
{
    public class Querys
    {
        public DataTable Search_Data(string query)
        {
            Conexion conn = new Conexion();
            conn.Begin_conexion();
            System.Data.SqlClient.SqlDataAdapter qu;
            DataSet ds = new DataSet();
            qu = new System.Data.SqlClient.SqlDataAdapter(query, conn.conexion);
            qu.Fill(ds);
            conn.conexion.Close();
            return ds.Tables[0];
        }
        public void Send_Process(string process)
        {
            Conexion conn = new Conexion();
            conn.Begin_conexion();
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            command.CommandText = process;
            command.Connection = conn.conexion;            
            int rows_mod = command.ExecuteNonQuery();
            conn.conexion.Close();
        }
        public DataTable EjecutarProcedimientoAlmacenado(string nombreProceso,string datos)
        {
            Conexion conn = new Conexion();
            conn.Begin_conexion();
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(nombreProceso);
            command.CommandType = CommandType.StoredProcedure;
            string cadenaProcedimiento = nombreProceso + datos;
            System.Data.SqlClient.SqlDataAdapter oAdapter = new System.Data.SqlClient.SqlDataAdapter(cadenaProcedimiento,conn.conex);
            DataTable oTabla = new DataTable();
            oAdapter.Fill(oTabla);
            return oTabla;                  
        }
    }
}
