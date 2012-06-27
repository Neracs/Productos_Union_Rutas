using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataSQLserver;
using Entidades;

namespace Procesos_Entidades
{
    public class Procesos_Usuario
    {
        Querys query = new Querys();
        public bool Autentificar(Supervisor us)
        {
            DataTable dt = new DataTable();
            dt = query.Search_Data("Select * from TSupervisor where su_login='" + us.User + "' and su_password='" + us.Pass + "'");
            if (dt.Rows.Count == 1)
                return true;
            else
                return false;
        }
        public bool VeriOnline(string user)
        {
            DataTable dt = new DataTable();
            dt = query.Search_Data("Select su_estado from TSupervisor where su_login='" + user + "'");
            if (dt.Rows[0][0].ToString() == "OnLine")
                return true;
            else
                return false;
        }
        public Supervisor Loguear_user(string nick)
        {
            DataTable dt = new DataTable();
            Supervisor user = new Supervisor();
            dt = query.Search_Data("Select * from TSupervisor where su_login='" + nick + "'");
            user.Id = dt.Rows[0]["idsupervisor"].ToString();
            user.User = dt.Rows[0]["su_login"].ToString();
            user.Nombre = dt.Rows[0]["su_nombre"].ToString();
            user.Ape_pa = dt.Rows[0]["su_apePat"].ToString();
            user.Ape_ma = dt.Rows[0]["su_apeMat"].ToString();          
            user.Idtipousuario = dt.Rows[0]["idtipoUsuario"].ToString();
            user.Estado = dt.Rows[0]["su_estado"].ToString();
            return user;
        }
        public void Cambiar_Estado(Supervisor user)
        {
            string estado;
            if (user.Estado == "OnLine")
                estado = "OffLine";
            else
                estado = "OnLine";
            query.Send_Process("update TSupervisor set su_estado='" + estado + "' where su_login='" + user.User+ "'");
        }
    }
}
