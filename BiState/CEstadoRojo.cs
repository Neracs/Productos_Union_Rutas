using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiState
{
    class CEstadoRojo:CEstado //color rojo---no compró
    {
        public override void Cambiarestado()
        {
            cambioestado();
        }
        public CEstadoRojo(CEstado estado)
        {
            Cuenta = estado.Cuenta;
        }
        public void cambioestado()
        {
            Cuenta.Estado = new CEstadoVerde(this);
        }

    }
}
