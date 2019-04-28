using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons1
{
    public class Program
    {

        static void Main(string[] args)
        {

            //datos que ingresa el usuario
            Console.WriteLine("Indique la configuracion inicial: ");
            Console.WriteLine("Indique el tamaño del mapa:");
            Console.WriteLine("Largo: ");
            int largo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ancho: ");
            int ancho = Convert.ToInt32(Console.ReadLine());

            Bitmons bitmons = new Bitmons();
            bitmons.Spawn(largo, ancho);

            //con esto hacer el for de la simulacion
            Console.WriteLine("Periodo de tiempo en meses de la simulacion: ");
            int tiempo_simulacion = Convert.ToInt32(Console.ReadLine());

            Mapa mapa = new Mapa();
            mapa.GenerarMapa();

            Console.WriteLine(mapa.mapa.GetUpperBound(0));
            Console.WriteLine(mapa.mapa.GetUpperBound(1));

            mapa.MostrarMapa();
            Console.ReadKey();

        }
    }
}
