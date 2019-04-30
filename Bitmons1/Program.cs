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
            Random rnd = new Random();
            int filas;
            int columnas;
            int tiempo_simulacion;
            //datos que ingresa el usuario
            Console.WriteLine("Indique la configuracion inicial: ");
            Console.WriteLine("Indique el tamaño del mapa:");
            Console.Write("Filas: ");
            string filasS = Console.ReadLine();
            int.TryParse(filasS, out filas);
            while (filas.ToString() != filasS)
            {
                Console.Write("Numero de filas invalido \nFilas: ");
                filasS = Console.ReadLine();
                int.TryParse(filasS, out filas);
            }
            Console.Write("Columnas: ");
            string columnasS = Console.ReadLine();
            int.TryParse(columnasS, out columnas);
            while (columnas.ToString() != columnasS)
            {
                Console.Write("Numero de columnas invalido \nColumnas: ");
                columnasS = Console.ReadLine();
                int.TryParse(columnasS, out columnas);
            }

            Controlador controlador = new Controlador();
            Bitmons bitmons = new Bitmons();
            Mapa mapa = new Mapa();

            mapa.GenerarMapa(filas, columnas);
            bitmons.Spawn(mapa);

            Console.Write("Periodo de tiempo en meses de la simulacion: ");
            string tiempo_simulacionS = Console.ReadLine();
            int.TryParse(tiempo_simulacionS, out tiempo_simulacion);
            while (tiempo_simulacion.ToString() != tiempo_simulacionS)
            {
                Console.Write("Periodo de tiempo invalido \n Periodo de tiempo en meses de la simulacion: ");
                tiempo_simulacionS = Console.ReadLine();
                int.TryParse(tiempo_simulacionS, out tiempo_simulacion);
            }

            //for de la simulacion
<<<<<<< HEAD
            //Ent no se pueden reproducir, cada 3 meses aparece uno
            //bitmon permanece un mes en un terreno con el cual tiene debilidad, entonces su tiempo de vida - 2 meses, en otro caso - 1 mes

=======
            Console.WriteLine("Periodo de tiempo en meses de la simulacion: ");
            int tiempo_simulacion = Convert.ToInt32(Console.ReadLine());
>>>>>>> 174dee45f3455e919b14b5fb18461385e3b03a4a
            List<Bitmon>[,] bitmons_simulacion = bitmons.GetArray();
            List<Bitmon> bitmons_s = bitmons.GetLista();

            for (int meses = 0; meses < tiempo_simulacion; meses++)
            {
                //Ent no se pueden reproducir, cada 3 meses aparece uno
                if (meses%3 == 0)
                {
                    Bitmon bitmon = new Bitmon("Ent");
                    bool a = true;
                    while (a == true)
                    {
                        int fila = rnd.Next(0, columnas - 1);
                        int colun = rnd.Next(0, filas - 1);
                        if (bitmons_simulacion[colun, fila].Count() <= 2)
                        {
                            bitmons_simulacion[colun, fila].Add(bitmon);
                            bitmons_s.Add(bitmon);
                            a = false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
<<<<<<< HEAD
                for(int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (bitmons_simulacion[i,j].Count() == 2)
                        {
                            Bitmon b1 = bitmons_simulacion[i, j][0];
                            Bitmon b2 = bitmons_simulacion[i, j][1];
                            if (b1.rivalidad.Contains(b2.especie))
                            {
                                bitmons.Peleas(b1, b2);
                            }
                            else if (b1.afinidad.Contains(b2.especie))
                            {
                                bitmons.Relaciones(b1, b2, filas, columnas);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }

                }
                controlador.Entorno(mapa, bitmons);
                bitmons.Bithalla();
=======


>>>>>>> 174dee45f3455e919b14b5fb18461385e3b03a4a
                bitmons.movimientos(mapa);
                mapa.MostrarMapa();
                Console.ReadKey();
            }

            //tiempo vida promedio de bitmon
            int suma_tvida = 0;
            int total = bitmons_simulacion.Length;
            foreach (Bitmon bitmon in bitmons_simulacion)
            {
                suma_tvida += bitmon.TiempoVida;
            }
            int TiempoVidaPromedio_Bit = suma_tvida / total;
            Console.WriteLine("Tiempo de vida promedio de los Bitmons: " + Convert.ToString(TiempoVidaPromedio_Bit));


            //tiempo de vida promedio de cada especie de bitmon
            int suma_tvida_taplan = 0, suma_tvida_wetar = 0, suma_tvida_gofue = 0, suma_tvida_dorvalo = 0, suma_tvida_doti = 0, suma_tvida_ent = 0;
            int total_taplan = 0, total_wetar = 0, total_gofue = 0, total_dorvalo = 0, total_doti = 0, total_ent = 0;
            foreach (Bitmon bitmon in bitmons_simulacion)
            {
                if (bitmon.especie == "Taplan")
                {
                    suma_tvida_taplan += bitmon.TiempoVida;
                    total_taplan += 1;
                }
                if (bitmon.especie == "Wetar")
                {
                    suma_tvida_wetar += bitmon.TiempoVida;
                    total_wetar += 1;
                }
                if (bitmon.especie == "Gofue")
                {
                    suma_tvida_gofue += bitmon.TiempoVida;
                    total_gofue += 1;
                }
                if (bitmon.especie == "Dorvalo")
                {
                    suma_tvida_dorvalo += bitmon.TiempoVida;
                    total_dorvalo += 1;
                }
                if (bitmon.especie == "Doti")
                {
                    suma_tvida_doti += bitmon.TiempoVida;
                    total_doti += 1;
                }
                if (bitmon.especie == "Ent")
                {
                    suma_tvida_ent += bitmon.TiempoVida;
                    total_ent += 1;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Tiempo de vida promedio de los Taplan: " + Convert.ToString(suma_tvida_taplan / total_taplan));
            Console.WriteLine("Tiempo de vida promedio de los Wetar: " + Convert.ToString(suma_tvida_wetar / total_wetar));
            Console.WriteLine("Tiempo de vida promedio de los Gofue: " + Convert.ToString(suma_tvida_gofue / total_gofue));
            Console.WriteLine("Tiempo de vida promedio de los Dorvalo: " + Convert.ToString(suma_tvida_dorvalo / total_dorvalo));
            Console.WriteLine("Tiempo de vida promedio de los Doti: " + Convert.ToString(suma_tvida_doti / total_doti));
            Console.WriteLine("Tiempo de vida promedio de los Ent: " + Convert.ToString(suma_tvida_ent / total_ent));


            //tasa natalidad cada especie
            int hijos_taplan = 0, hijos_wetar = 0, hijos_gofue = 0, hijos_dorvalo = 0, hijos_doti = 0, hijos_ent = 0;
            foreach (Bitmon bitmon in bitmons_simulacion)
            {
                if (bitmon.especie == "Taplan")
                {
                    hijos_taplan += 1;
                }
                if (bitmon.especie == "Wetar")
                {
                    hijos_wetar += 1;
                }
                if (bitmon.especie == "Gofue")
                {
                    hijos_gofue += 1;
                }
                if (bitmon.especie == "Dorvalo")
                {
                    hijos_dorvalo += 1;
                }
                if (bitmon.especie == "Doti")
                {
                    hijos_doti += 1;
                }
                if (bitmon.especie == "Ent")
                {
                    hijos_ent += 1;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Tasa natalidad de los Taplan: " + Convert.ToString((hijos_taplan / total) * 100));
            Console.WriteLine("Tasa natalidad de los Wetar: " + Convert.ToString((hijos_wetar / total) * 100));
            Console.WriteLine("Tasa natalidad de los Gofue: " + Convert.ToString((hijos_gofue / total) * 100));
            Console.WriteLine("Tasa natalidad de los Dorvalo: " + Convert.ToString((hijos_dorvalo / total) * 100));
            Console.WriteLine("Tasa natalidad de los Doti: " + Convert.ToString((hijos_doti / total) * 100));
            Console.WriteLine("Tasa natalidad de los Ent: " + Convert.ToString((hijos_ent / total) * 100));


            //tasa mortalidad cada especie
            List<Bitmon> bithalla = bitmons.GetBithalla();
            int muertos_taplan = 0, muertos_wetar = 0, muertos_gofue = 0, muertos_dorvalo = 0, muertos_doti = 0, muertos_ent = 0;
            int total_bithalla = bithalla.Count();
            foreach (Bitmon bitmon in bithalla)
            {
                if (bitmon.especie == "Taplan")
                {
                    muertos_taplan += 1;
                }
                if (bitmon.especie == "Wetar")
                {
                    muertos_wetar += 1; 
                }
                if (bitmon.especie == "Gofue")
                {
                    muertos_gofue += 1;
                }
                if (bitmon.especie == "Dorvalo")
                {
                    muertos_dorvalo += 1;
                }
                if (bitmon.especie == "Doti")
                {
                    muertos_doti += 1;
                }
                if (bitmon.especie == "Ent")
                {
                    muertos_ent += 1;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Tasa mortalidad de los Taplan: " + Convert.ToString((muertos_taplan / total) * 100));
            Console.WriteLine("Tasa mortalidad de los Wetar: " + Convert.ToString((muertos_wetar / total) * 100));
            Console.WriteLine("Tasa mortalidad de los Gofue: " + Convert.ToString((muertos_gofue / total) * 100));
            Console.WriteLine("Tasa mortalidad de los Dorvalo: " + Convert.ToString((muertos_dorvalo / total) * 100));
            Console.WriteLine("Tasa mortalidad de los Doti: " + Convert.ToString((muertos_doti / total) * 100));
            Console.WriteLine("Tasa mortalidad de los Ent: " + Convert.ToString((muertos_ent / total) * 100));

            //cantidad hijos en promedio por especie
            Console.WriteLine("Cantidad hijos en promedio de los Taplan: " + Convert.ToString((hijos_taplan / total_taplan) / 100));
            Console.WriteLine("Cantidad hijos en promedio de los Wetar: " + Convert.ToString((hijos_wetar / total_wetar) / 100));
            Console.WriteLine("Cantidad hijos en promedio Gofue: " + Convert.ToString((hijos_gofue / total_gofue) / 100));
            Console.WriteLine("Cantidad hijos en promedio de los Dorvalo: " + Convert.ToString((hijos_dorvalo / total_dorvalo) / 100));
            Console.WriteLine("Cantidad hijos en promedio de los Doti: " + Convert.ToString((hijos_doti / total_doti) / 100));
            Console.WriteLine("Cantidad hijos en promedio de los Ent: " + Convert.ToString((hijos_ent / total_ent) / 100));

            //listado especies extintas
            List<string> extintas = new List<string>();
            if (total_taplan == 0)
            {
                extintas.Add("Taplan");
            }
            if (total_wetar == 0)
            {
                extintas.Add("Wetar");
            }
            if (total_gofue == 0)
            {
                extintas.Add("Gofue");
            }
            if (total_dorvalo == 0)
            {
                extintas.Add("Dorvalo");
            }
            if (total_doti == 0)
            {
                extintas.Add("Doti");
            }
            if (total_ent == 0)
            {
                extintas.Add("Ent");
            }
            Console.WriteLine("El listado de las especies extintas: " + extintas);

            //descripcion poblacion de Bitmons en bithalla (cantidad de cada especie, %)
            Console.WriteLine("Descripcion Taplan en bithalla: " + "cantidad: " + Convert.ToString(muertos_taplan) + Convert.ToString((muertos_taplan*100 /total_bithalla)));
            Console.WriteLine("Descripcion Wetar en bithalla: " + "cantidad: " + Convert.ToString(muertos_wetar) + Convert.ToString((muertos_wetar * 100 /total_bithalla)));
            Console.WriteLine("Descripcion Gofue en bithalla: " + "cantidad: " + Convert.ToString(muertos_gofue) + Convert.ToString((muertos_gofue * 100 / total_bithalla)));
            Console.WriteLine("Descripcion Dorvalo en bithalla: " + "cantidad: " + Convert.ToString(muertos_dorvalo) + Convert.ToString((muertos_dorvalo * 100 /total_bithalla)));
            Console.WriteLine("Descripcion Doti en bithalla: " + "cantidad: " + Convert.ToString(muertos_doti) + Convert.ToString((muertos_doti * 100 / total_bithalla)));
            Console.WriteLine("Descripcion Ent en bithalla: " + "cantidad: " + Convert.ToString(muertos_ent) + Convert.ToString((muertos_ent * 100 / total_bithalla)));

        }
    }
}

