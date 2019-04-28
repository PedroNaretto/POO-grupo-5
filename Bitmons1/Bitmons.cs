using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons1
{
    public class Bitmons
    {
        Random rnd = new Random();

        //lista con los bitmons que se van a bithalla
        public List<Bitmon> bithalla = new List<Bitmon> { };
        //Lista con los bitmons en la simulacion
        public List<Bitmon> bitmons_s = new List<Bitmon> { };
        //Array con los bitmons de la simulacion
        public List<Bitmon>[,] bitmons_simulacion;

        //constructor de Bitmons
        public Bitmons()
        {
        }

        public void Spawn(int filas, int columnas)
        {
            //creacion de arrays para los bitmons y terrenos del usuario
            bitmons_simulacion = new List<Bitmon>[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    bitmons_simulacion[i, j] = new List<Bitmon> { };
                }
            }

            while (true)
            {
                int f;
                int c;
                int t;

                Console.WriteLine("Generando mapa \n1.-Ingresar Bitmon \n2.-Continuar");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Generando Bitmons, escoja fila y columna donde para crear Bitmon:");
                    Console.Write("Fila: ");
                    string fs = Console.ReadLine();
                    int.TryParse(fs, out f);
                    while (f.ToString() != fs || f < 1 || f > filas)
                    {
                        Console.Write("Numero de fila fuera de rango \nFila: ");
                        fs = Console.ReadLine();
                        int.TryParse(fs, out f);
                    }
                    Console.Write("Columna: ");
                    string cs = Console.ReadLine();
                    int.TryParse(cs, out c);
                    while (c.ToString() != cs || c < 1 || c > filas)
                    {
                        Console.Write("Numero de columna fuera de rango \nColumna: ");
                        cs = Console.ReadLine();
                        int.TryParse(cs, out c);
                    }
                    List<string> tipos = new List<string> { "Taplan", "Wetar", "Gofue", "Dorvalo", "Doti", "Ent" };
                    Console.WriteLine("Introdusca la clase de bitmon que desea:");
                    Console.WriteLine("1.-Taplan \n2.-Wetar \n3.-Gofue \n4.-Dorvalo \n5.-Doti \n6.-Ent");
                    string ts = Console.ReadLine();
                    int.TryParse(ts, out t);
                    while (t.ToString() != ts || t < 1 || t > 6)
                    {
                        Console.WriteLine("Introdusca clase de Bitmon valida:");
                        Console.WriteLine("1.-Taplan \n2.-Wetar \n3.-Gofue \n4.-Dorvalo \n5.-Doti \n6.-Ent");
                        ts = Console.ReadLine();
                        int.TryParse(ts, out t);
                    }

                    Bitmon b = new Bitmon(tipos[t - 1]);
                    bitmons_simulacion[f - 1, c - 1].Add(b);
                    bitmons_s.Add(b);
                }
                else
                {
                    break;
                }
            }

        }

        public void Peleas(Bitmon bitmon1, Bitmon bitmon2)
        {
            //FALTA: misma celda con otro que no tiene afinidad -> pelean

            //bitmon ataque simultaneo
            foreach (string bitmon in bitmon1.rivalidad)
            {
                if (bitmon == bitmon2.especie)
                {
                    //daño = puntos de ataque*multiplicador  
                    //cada bitmon descuenta de sus puntos de vida el daño 
                    bitmon2.PuntosDeVida -= bitmon2.PuntosDeVida * (bitmon1.PuntosDeAtaque * bitmon2.Atacar(bitmon2));
                    bitmon1.PuntosDeVida -= bitmon1.PuntosDeVida * (bitmon2.PuntosDeAtaque * bitmon1.Atacar(bitmon1));
                }
                else
                {
                    continue;
                }
            }

            //si uno muere el otro recupera los puntos de vida que perdio
            if (bitmon1.PuntosDeVida <= 0)
            {
                bithalla.Add(bitmon1);
                bitmon2.PuntosDeVida += bitmon2.PuntosDeVida * (bitmon1.PuntosDeAtaque * bitmon2.Atacar(bitmon2));
            }
            if (bitmon2.PuntosDeVida <= 0)
            {
                bithalla.Add(bitmon2);
                bitmon1.PuntosDeVida += bitmon1.PuntosDeVida * (bitmon2.PuntosDeAtaque * bitmon1.Atacar(bitmon1));
            }

            //pueden ambos irse a bithalla despues
            if (bitmon1.PuntosDeVida == 0 && bitmon2.PuntosDeVida == 0)
            {
                bithalla.Add(bitmon1);
                bithalla.Add(bitmon2);
            }
        }

        public void Relaciones(Bitmon bitmon1, Bitmon bitmon2)
        {
            //FALTA: misma celda con otro que tiene afinidad -> se reproducen

            if (bitmon1.Hijos != 0 || bitmon2.Hijos != 0)
            {
                //probabilidad de la especie del hijo
                int IP_hijo = rnd.Next(0, 101);

                //FALTA: Ent no se pueden reproducir, cada 3 meses aparece uno
                //FALTA:hijo aparece en un lugar random

                //para calcular la probabilidad que sea de un padre o el otro
                int total = bitmon1.Hijos + bitmon2.Hijos + 2;
                int IP_bit1 = ((bitmon1.Hijos + 1) * 100) / total;
                int IP_bit2 = ((bitmon2.Hijos + 1) * 100) / total;

                //probabilidad de ser bitmon 1 mayor a la de bitmon 2
                if (IP_bit1 > IP_bit2)
                {
                    if (IP_bit1 <= IP_hijo)
                    {
                        //es de la clase bitmon 1
                        Bitmon hijo = new Bitmon(bitmon1.especie);
                        bitmon1.Hijos += 1;
                    }
                    else
                    {
                        //es de la clase bitmon 2
                        Bitmon hijo = new Bitmon(bitmon2.especie);
                        bitmon2.Hijos += 1;
                    }
                }

                //probabilidad de ser bitmon 2 mayor a la de bitmon 1
                if (IP_bit2 > IP_bit1)
                {
                    if (IP_bit2 <= IP_hijo)
                    {
                        //es de la clase bitmon 2
                        Bitmon hijo = new Bitmon(bitmon2.especie);
                        bitmon2.Hijos += 1;
                    }
                    else
                    {
                        //es de la clase bitmon 1
                        Bitmon hijo = new Bitmon(bitmon1.especie);
                        bitmon1.Hijos += 1;
                    }
                }
            }
        }

        public void Movimientos()
        {
            //ent no se mueven
            //dorvalo 2 espacios
            //demas 1 espacio
            //aletoria
            //watar solo en agua
        }

        //tiempo de vida menor o igual a cero se va al cielo
        public void Bithalla()
        {
            foreach (Bitmon bitmon in bitmons_s)
            {
                if (bitmon.TiempoVida <= 0)
                {
                    bithalla.Add(bitmon);
                }
            }
        }
    }
}
