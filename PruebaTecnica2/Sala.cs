using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica2
{
    public class Sala
    {
        private Asiento[,] asientos;

        public Sala()
        {
            asientos = new Asiento[5, 8];
            for (int i = 0; i < 5; i++)
            {
                int precio = i < 2 ? 1500 : (i < 4 ? 1200 : 1000);
                for (int j = 0; j < 8; j++)
                {
                    asientos[i, j] = new Asiento(precio);
                }
            }
        }

        public void MostrarMapa()
        {
            Console.WriteLine("     A1 A2 A3 A4 A5 A6 A7 A8");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"F{i + 1} | ");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{asientos[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        public int? IntentarReservar(int fila, int columna)
        {
            var asiento = asientos[fila, columna];
            if (asiento.Reservar())
                return asiento.Precio;
            return null;
        }
    }
}
