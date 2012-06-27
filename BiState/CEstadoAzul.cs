using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiState
{
    class CEstadoAzul:CEstado //color azul estado en espera
    {
        //public override string Cambiarestado()
        //{
        //    string estado = "Azul";
        //    return estado;
        //}
        public override void Cambiarestado()
        {
            cambioestado();
        }
        //public CEstadoAzul(CEstado estado)
        //{
        //    Cuenta = estado.Cuenta;
        //}
        public CEstadoAzul(CCuenta pCuenta)
        {
            Cuenta = pCuenta; 
        }
        public void cambioestado()
        {
            Cuenta.Estado = new CEstadoVerde(this);
        }
        
    }
}
