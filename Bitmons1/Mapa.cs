using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons1
{
    public class Mapa
    {
        static Random rnd = new Random();
        public Terreno[,] Mterrenos;

        public Mapa()
        {
        }

        //Metodo que le pide al usuario el tipo de terreno en cada indice del array
        public void GenerarMapa (int filas, int columnas)
        {
            Mterrenos = new Terreno[filas, columnas];

            Console.WriteLine("Generando mapa, escoja el tipo de terrenos por casilla:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Casilla {i}, {j}");
                    int t;
                    List<string> tipos = new List<string> { "Desierto", "Vegetacion","Acuatico", "Nieve", "Volcan" };
                    Console.WriteLine("Escoja tipo el tipo de terreno:");
                    Console.WriteLine("1.-Desierto \n2.-Vegetacion \n3.-Acuatico \n4.-Nieve \n5.-Volcan");
                    string ts = Console.ReadLine();
                    int.TryParse(ts, out t);
                    while (t.ToString() != ts || t < 1 || t > 6)
                    {
                        Console.WriteLine("Escoja tipo el tipo de terreno valido:");
                        Console.WriteLine("1.-Desierto \n2.-Vegetacion \n3.-Acuatico \n4.-Nieve \n6.-Volcan");
                        ts = Console.ReadLine();
                        int.TryParse(ts, out t);
                    }

                    Mterrenos[i, j] = new Terreno(tipos[t-1]);
                }
            }
        }

        public void MostrarMapa()
        {
            for (int i = 0; i <= Mterrenos.GetUpperBound(0); i++)
            {
                for (int c = 0; c <= Mterrenos.GetUpperBound(1); c++)
                {
                    if (Mterrenos[i, c].tipo == "Desierto")
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write("   ");
                    }
                    else if (Mterrenos[i, c].tipo == "Vegetacion")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("   ");
                    }
                    else if (Mterrenos[i, c].tipo == "Acuatico")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("   ");
                    }
                    else if (Mterrenos[i, c].tipo == "Nieve")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("   ");
                    }
                    else if (Mterrenos[i, c].tipo == "Desierto")
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
