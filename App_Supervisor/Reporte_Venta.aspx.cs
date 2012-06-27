using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entidades;
using Procesos_Entidades;
using BiProxy;
//report_supoer es una grilla
namespace App_Supervisor
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        Procesos_Supervisor pro_Supervisor = new Procesos_Supervisor();
        Supervisor usu_Master = new Supervisor();   
        DataTable dt;
        CProxy oProxy = new CProxy();
        protected void Page_Load(object sender, EventArgs e)
        {
            dt = pro_Supervisor.ObtenerReporteGeneral("");
            Reporte_super.DataSource = dt;
            Reporte_super.DataBind();
            if ((Usuario)Session["Online_user"] != null)
            {
                NavigationMenu1.Visible = true;
                Reporte_super.Visible = true;
                boton_suma.Visible = true;
            }
            
        }

        protected void evento_boton_calcular(object sender, EventArgs e)
        {
            dt = pro_Supervisor.ObtenerReporteGeneral("");
            labelVenta.Text=oProxy.Sumaventas(dt).ToString();
            labelVenta.Visible = true;
            //labelVenta.Text = dt.Rows[0][0].ToString();
        }
    }
}