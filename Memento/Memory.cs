using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    public class Memory
    {
        private string fecha;

        public string Fecha
        {
          get { return fecha; }
          set { fecha = value; }
        }
        public Memory(string pfecha)
        {
            Fecha = pfecha;
        }   
    }
}
