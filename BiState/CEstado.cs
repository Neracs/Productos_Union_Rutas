using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiState
{
    abstract class CEstado
    {
        protected CCuenta cuenta;

        public CCuenta Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }
        //metodos
        public abstract void Cambiarestado();
    }
}
