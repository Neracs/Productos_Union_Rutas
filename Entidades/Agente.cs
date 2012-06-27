using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    class Agente:Usuario
    {
        private string codAgente;

        public string CodAgente
        {
            get { return codAgente; }
            set { codAgente = value; }
        }

       
        public Agente()
            :base()
        {
            this.CodAgente = "";
        }
         public Agente(string pdi, string puser, string ppass, string pnombre, string papepa, string papema, string ptipo, string pestado,string pcod)
             :base(pdi, puser, ppass, pnombre, papepa, papema, ptipo, pestado)
        {
            this.CodAgente = pcod;
        }
         public override Usuario Clonar()
         {
             return (Usuario)this.MemberwiseClone();
         }
    }
}
