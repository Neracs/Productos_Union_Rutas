using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BiFachada;
using Procesos_Entidades;
using System.Data;

namespace App_Supervisor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Procesos_Supervisor oProceso = new Procesos_Supervisor();
        DataTable oTabla;
        CInformacionFacade oFachada = new CInformacionFacade();
        protected void Page_Load(object sender, EventArgs e)
        {
            oTabla = oFachada.VerFachada1();
            Reporte_facha.DataSource = oTabla;
            Reporte_facha.DataBind();
            NavigationMenu1.Visible = true;
            Reporte_facha.Visible = true;
            
        }
    }
}