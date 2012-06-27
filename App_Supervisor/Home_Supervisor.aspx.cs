using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Procesos_Entidades;
using Entidades;

namespace App_Supervisor
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        Usuario usu_Master = new Supervisor();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Usuario)Session["Online_user"] != null)
            {
                NavigationMenu1.Visible = true;               
            }
        }
    }
}