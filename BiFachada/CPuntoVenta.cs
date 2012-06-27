using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Procesos_Entidades;
using System.Data;

namespace BiFachada
{
    public class CPuntoVenta
    {
        Procesos_Supervisor oProceso = new Procesos_Supervisor();
        
        public DataTable ListarPuntoVenta()
        {
            return oProceso.ListarPuntoVenta();
        }
    }
}
