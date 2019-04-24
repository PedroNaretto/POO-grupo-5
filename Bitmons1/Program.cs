using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Mapa mapa = new Mapa();
            mapa.GenerarMapa();

            Console.WriteLine(mapa.mapa.GetUpperBound(0));
            Console.WriteLine(mapa.mapa.GetUpperBound(1));

            mapa.MostrarMapa();
            Console.ReadKey();

        }
    }
}
