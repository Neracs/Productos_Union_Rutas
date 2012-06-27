using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Procesos_Entidades;


namespace BiProxy
{
    public class CValidaciones:CHerramientas
    {
        public string resp_veri_reg = "";
        Procesos_Supervisor oListar = new Procesos_Supervisor();

        public override bool Validardni(string dni)
        {
            //Validar si el DNi es correcto
            if (dni != "")
            {
                try
                {
                    int nr;
                    //for (int j = 0; j < dni.Length; j++)
                        nr = Convert.ToInt32(dni);
                    if (dni.Length == 8)
                    {
                        this.resp_veri_reg = "";
                        return true;

                    }
                    else
                    {
                        this.resp_veri_reg = "El Dni ingresado tiene mas de 8 digitos, ingrese denuevo";
                        return false;
                    }
                }
                catch
                {
                    this.resp_veri_reg = "Ingrese numeros";
                    return false;
                }
            }
            else
            {
                this.resp_veri_reg = "Ingrese un DNI!...";
                return false;
            }
        }

        public override bool Validarporlogin(string login)
        {

            if (login != "")
            {
                try
                {

                    if (oListar.Listarloginsupervisor().Rows[0]["Login"].ToString() != login)
                    {
                        this.resp_veri_reg = "";
                        return true;
                    }
                    else
                    {
                        this.resp_veri_reg = "Login ingresado ya existe";
                        return false;
                    }


                }
                catch
                {
                    this.resp_veri_reg = "Login incorrecto";
                    return false;
                }
            }
            else
            {
                this.resp_veri_reg = "Ingrese una Login!...";
                return true;
            }
        }
        public override bool Validarfecha(string fecha)
        {
            if (fecha != "")
            {
                try
                {
                    if (fecha.Length == 10)
                    {
                        this.resp_veri_reg = "";
                        return true;
                    }
                    else
                    {
                        this.resp_veri_reg = "El formato de la fecha es incorrecto, ingrese denuevo";
                        return false;
                    }
                }
                catch
                {
                    this.resp_veri_reg = "El formato de la fecha es incorrecto, ingrese denuevo";
                    return false;
                }
            }
            else
            {
                this.resp_veri_reg = "Ingrese una fecha!...";
                return true;
            }
        }
        public override double Sumaventas(DataTable oTabla)
        {

            double Sumatotal = 0;
            for (int i = 0; i < oTabla.Rows.Count; i++)
            {
                Sumatotal = Sumatotal +double.Parse(oTabla.Rows[i]["Importe"].ToString());
            }

            return Sumatotal;
        }
        public override string mensajeError()
        {
            return this.resp_veri_reg;
        }
    }
}