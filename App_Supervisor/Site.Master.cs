using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Entidades;
using Procesos_Entidades;

namespace App_Supervisor
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        
        Supervisor usu_Master = new Supervisor();
        Procesos_Usuario pro_us = new Procesos_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Supervisor)Session["Online_user"] != null)
            {
                usu_log.Visible = true;
                HeadLoginView.Visible = false;
                usu_Master = (Supervisor)Session["Online_user"];
                usu_log.Text = "Bienvenido, "+usu_Master.Nombre+" "+usu_Master.Ape_pa;
                bot_logout.Visible = true;                
            }
        }
        protected void bot_logout_click(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["Online_user"];
            pro_us.Cambiar_Estado(usu_Master);
            HeadLoginView.Visible = true;
            usu_log.Visible = false;
            bot_logout.Visible = false;  
            Page.Session.RemoveAll();
            Response.Redirect("Default.aspx"); 
        }
    }
}
