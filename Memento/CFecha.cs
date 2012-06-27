using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entidades;
namespace Memento
{
    public class CFecha
    {        
        private string fecha;
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public CFecha()
        { 
        }
        public CFecha(string pfecha)
        {
            Fecha = pfecha;
        }
        public Memory saveMemento()
        {
            return new Memory(Fecha);
        }
        public void restoreMemento(Memory memento)
        {
            this.Fecha = memento.Fecha;
        }
    }
}
