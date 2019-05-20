using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmonsForms
{
    class Mapa
    {
        static Random rnd = new Random();
        public Terreno[,] Mterrenos;

        public Mapa()
        {
        }

        //Metodo que le pide al usuario el tipo de terreno en cada indice del array
        public void GenerarMapa(int filas, int columnas)
        {
            Mterrenos = new Terreno[filas, columnas];

            Console.WriteLine("Generando mapa, escoja el tipo de terrenos por casilla:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Casilla {i + 1}, {j + 1}");
                    int t;
                    List<string> tipos = new List<string> { "Desierto", "Vegetacion", "Acuatico", "Nieve", "Volcan" };
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

                    Mterrenos[i, j] = new Terreno(tipos[t - 1]);
                }
            }
        }

        public System.Drawing.Color MostrarMapa( string color)
        {
            if (color == "Desierto")
            {
                return System.Drawing.Color.Yellow;
            }
            else if (color == "Vegetacion")
            {
                return System.Drawing.Color.Green;
            }
            else if (color == "Acuatico")
            {
                return System.Drawing.Color.Blue;
            }
            else if (color == "Nieve")
            {
                return System.Drawing.Color.White;
            }
            else
            {
                return System.Drawing.Color.Red;
            }
        }
    }
}
