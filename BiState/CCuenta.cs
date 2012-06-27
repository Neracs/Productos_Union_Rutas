using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiState
{
    public class CCuenta
    {
        private CEstado estado;
        
        internal CEstado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public CCuenta()
        {
            Estado = new CEstadoAzul(this);
        }
        public void Cambiarestado()
        {
            Estado.Cambiarestado();
        }
    }
}
