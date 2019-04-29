using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons1
{
    public class Controlador
    {
        public Controlador()
        {
        }

        //para generar el mapa
        public void generarMapas(Mapa cMapa, Bitmons cBitmons)
        {
            for(int i = 0; i <= cMapa.Mterrenos.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= cMapa.Mterrenos.GetUpperBound(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    string celda = "";
                    foreach (Bitmon bitmon in cBitmons.bitmons_simulacion[i,j])
                    {
                        celda += bitmon.especie[0].ToString() + bitmon.especie[1].ToString() + bitmon.especie[2].ToString();
                    }
                    while (celda.Count() <= 6)
                    {
                        celda += " ";
                    }
                    celda = celda.Insert( 3, ",");
                    if (cMapa.Mterrenos[i, j].tipo == "Tierra")
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(celda);
                    }
                    else if (cMapa.Mterrenos[i, j].tipo == "Pasto")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(celda);
                    }
                    else if (cMapa.Mterrenos[i, j].tipo == "Agua")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(celda);
                    }
                    else if (cMapa.Mterrenos[i, j].tipo == "Hielo")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(celda);
                    }
                    else if (cMapa.Mterrenos[i, j].tipo == "Lava")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(celda);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(celda);
                    }
                }
                Console.Write("\n");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Para cada bitmon, revisa si se encuentra en un terreno que le haga daño
        public void Entorno(Mapa cMapa, Bitmons cBitmons)
        {
            for (int i = 0; i < cMapa.Mterrenos.GetUpperBound(0); i++)
            {
                for (int j = 0; j < cMapa.Mterrenos.GetUpperBound(1); j++)
                {
                    foreach(Bitmon bitmon in cBitmons.bitmons_simulacion[i,j])
                    {
                        string t = cMapa.Mterrenos[i, j].getTerreno();
                        if (bitmon.debilidad.Contains(t))
                        {
                            bitmon.TiempoVida -= 2;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }

    }
}
