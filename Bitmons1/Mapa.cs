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
        public Terreno[,] mapa;

        public Mapa()
        {
        }

        public void GenerarMapa (int filas, int columnas)
        {
            mapa = new Terreno[filas, columnas];

            Console.WriteLine("Generando mapa, escoja el tipo de terrenos por casilla:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Casilla {i}, {j}");
                    int t;
                    List<string> tipos = new List<string> { "tierra", "pasto", "bosque","agua", "hielo", "lava" };
                    Console.WriteLine("Escoja tipo el tipo de terreno:");
                    Console.WriteLine("1.-Tierra \n2.-Pasto \n3.-Bosque \n4.-Agua \n5.-Hielo \n6.-Lava");
                    string ts = Console.ReadLine();
                    int.TryParse(ts, out t);
                    while (t.ToString() != ts || t < 1 || t > 6)
                    {
                        Console.WriteLine("Escoja tipo el tipo de terreno valido:");
                        Console.WriteLine("1.-Tierra \n2.-Pasto \n3.-Bosque \n4.-Agua \n5.-Hielo \n6.-Lava");
                        ts = Console.ReadLine();
                        int.TryParse(ts, out t);
                    }

                    mapa[i, j] = new Terreno(tipos[t-1]);
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
