using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica2
{
    public class Asiento
    {
        public bool Ocupado { get; private set; }
        public int Precio { get; set; }

        public Asiento(int precio)
        {
            Precio = precio;
            Ocupado = false;
        }

        public bool Reservar()
        {
            if (Ocupado) return false;
            Ocupado = true;
            return true;
        }

        public override string ToString()
        {
            return Ocupado ? "X" : "L";
        }
    }

}
