using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Procesos_Entidades;
using System.Data;

namespace BiFachada
{
    class CAgente //clase de fachada
    {
        Procesos_Supervisor oProceso = new Procesos_Supervisor();
                
        public DataTable ListarAgente() 
        {
            return oProceso.ListarAgente();
        }
    }
}
