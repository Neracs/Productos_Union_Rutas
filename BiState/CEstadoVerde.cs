using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiState
{
     class CEstadoVerde:CEstado// color verde estado que compro
    {
       public override void Cambiarestado()
        {
            cambioestado();
        }
        public CEstadoVerde(CEstado estado)
        {
            Cuenta = estado.Cuenta;
        }
        public void cambioestado()
        {
            Cuenta.Estado = new CEstadoRojo(this);
        }

    }
}
