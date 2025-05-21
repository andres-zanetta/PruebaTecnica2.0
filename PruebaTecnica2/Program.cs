using System;
using PruebaTecnica2;

class Program
{
    static void Main(string[] args)
    {
        Sala sala = new Sala();
        int total = 0;
        int vendidos = 0;

        while (true)
        {
            Console.Clear();
            sala.MostrarMapa();
            Console.WriteLine("\nIngrese fila (1-5) o 0 para salir:");
            int fila = int.Parse(Console.ReadLine());
            if (fila == 0) break;

            Console.WriteLine("Ingrese asiento (1-8):");
            int asiento = int.Parse(Console.ReadLine());

            var precio = sala.IntentarReservar(fila - 1, asiento - 1);
            if (precio != null)
            {
                Console.WriteLine($"✅ Reserva confirmada. Precio: ${precio}");
                total += precio.Value;
                vendidos++;
            }
            else
            {
                Console.WriteLine("❌ Asiento ocupado. Intente otro.");
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        Console.WriteLine($"\n🎟 Entradas vendidas: {vendidos}");
        Console.WriteLine($"💰 Total recaudado: ${total}");
    }
}

