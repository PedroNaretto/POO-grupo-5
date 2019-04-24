using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons1
{
    class Mapa
    {
        static Random rnd = new Random();
        public Terreno[,] mapa = new Terreno[rnd.Next(9,20), rnd.Next(9, 20)];

        public Mapa()
        {
        }

        public void GenerarMapa ()
        {
            for (int i = 0; i < mapa.GetUpperBound(0); i++)
            {
                for (int c = 0; c < mapa.GetUpperBound(1); c++)
                {
                    mapa[i, c] = new Terreno();
                }
            }
        }

        public void MostrarMapa()
        {
            for (int i = 0; i < mapa.GetUpperBound(0); i++)
            {
                for (int c = 0; c < mapa.GetUpperBound(1); c++)
                {
                    if (mapa[i, c].tipo == "tierra")
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write("   ");
                    }
                    else if (mapa[i, c].tipo == "pasto")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("   ");
                    }
                    else if (mapa[i, c].tipo == "agua")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("   ");
                    }
                    else if (mapa[i, c].tipo == "hielo")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("   ");
                    }
                    else if (mapa[i, c].tipo == "lava")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write("   ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
