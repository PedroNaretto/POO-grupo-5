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

        //configuracion inicial del mapa
        public void Spawn(Mapa mapa)
        {
            int filas = mapa.Mterrenos.GetUpperBound(0) +1;
            int columnas = mapa.Mterrenos.GetUpperBound(1) +1;

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
                    Console.WriteLine("Generando Bitmons, escoja fila y columna donde crear Bitmon:");
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
                    while (c.ToString() != cs || c < 1 || c > columnas)
                    {
                        Console.Write("Numero de columna fuera de rango \nColumna: ");
                        cs = Console.ReadLine();
                        int.TryParse(cs, out c);
                    }
                    List<string> tipos = new List<string> { "Taplan", "Wetar", "Gofue", "Dorvalo", "Doti", "Ent" };
                    Console.WriteLine("Introduzca la clase de bitmon que desea:");
                    Console.WriteLine("1.-Taplan \n2.-Wetar \n3.-Gofue \n4.-Dorvalo \n5.-Doti \n6.-Ent");
                    string ts = Console.ReadLine();
                    int.TryParse(ts, out t);
                    while (t.ToString() != ts || t < 1 || t > 6)
                    {
                        Console.WriteLine("Introduzca clase de Bitmon valida:");
                        Console.WriteLine("1.-Taplan \n2.-Wetar \n3.-Gofue \n4.-Dorvalo \n5.-Doti \n6.-Ent");
                        ts = Console.ReadLine();
                        int.TryParse(ts, out t);
                    }

                    if ((mapa.Mterrenos[f - 1, c - 1].tipo != "Agua" && tipos[t - 1] == "Wetar") || bitmons_simulacion[f - 1, c - 1].Count() >= 2)
                    {
                        Console.WriteLine("No se puede introducir el bitmon");
                    }
                    else
                    {
                        Bitmon b = new Bitmon(tipos[t - 1]);
                        bitmons_simulacion[f - 1, c - 1].Add(b);
                        bitmons_s.Add(b);
                    }
                }
                else
                {
                    break;
                }
            }

        }

        //movimiento x mes para los bitmons
        public void movimientos(Mapa mapa)
        {
            List<Bitmon>[,] bit_mov = new List<Bitmon>[bitmons_simulacion.GetUpperBound(0)+1, bitmons_simulacion.GetUpperBound(1)+1];
            for (int i = 0; i <= bitmons_simulacion.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= bitmons_simulacion.GetUpperBound(0); j++)
                {
                    bit_mov[i, j] = new List<Bitmon> { };
                }
            }
             for ( int i = 0; i <= bitmons_simulacion.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= bitmons_simulacion.GetUpperBound(0); j++)
                {
                    foreach (Bitmon bitmon in bitmons_simulacion[i, j])
                    {
                        if (bitmon.especie == "Wetar")
                        {
                            bool bitmonscerca = false;
                            while (bitmonscerca == false)
                            {                                
                                for (int a = -1; a < 2; a++)
                                {
                                    for (int b = -1; b < 2; b++)
                                    {
                                        int alrededor = bitmons_simulacion[i + a, j + b].Count();
                                        if (alrededor < 2)
                                        {
                                            bitmonscerca = true;
                                        }
                                    }
                                }
                            }
                            if (bitmonscerca == true)
                            {
                                int m = 1;
                                while (m > 0)
                                {
                                    int m1 = rnd.Next(-1, 2);
                                    int m2 = rnd.Next(-1, 2);
                                    try
                                    {
                                        if (bitmon.especie == "Wetar" && mapa.Mterrenos[i + m1, j + m2].getTerreno() == "Agua" && bitmons_simulacion[i + m1, j + m2].Count() < 2 && bit_mov[i + m1, j + m2].Count() < 2)
                                        {
                                            bit_mov[i + m1, j + m2].Add(bitmon);
                                        }
                                        m -= 1;
                                    }
                                    catch
                                    {
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bitmon.especie == "Dorvalo")
                        {
                            int m = 2;
                            int alrededor = 0;
                            for (int a = -2; a < 3; a++)
                            {
                                for (int b = -2; b < 3; b++)
                                {
                                    alrededor += bitmons_simulacion[i + a, j + b].Count();
                                }
                            }
                            if (alrededor != 18)
                            {
                                while (m > 0)
                                {
                                    int m1 = rnd.Next(-1, 2);
                                    int m2 = rnd.Next(-1, 2);
                                    try
                                    {
                                        if (mapa.Mterrenos[i + m1, j + m2].getTerreno() != "Acuatico" && bitmons_simulacion[i + m1, j + m2].Count() < 2 && bit_mov[i + m1, j + m2].Count() < 2)
                                        {
                                            bit_mov[i + m1, j + m2].Add(bitmon);
                                        }
                                        m -= 1;
                                    }
                                    catch
                                    {
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bitmon.especie == "Ent")
                        {
                            bit_mov[i, j].Add(bitmon);
                        }
                        else
                        {
                            int m = 1;
                            int alrededor = 0;
                            for (int a = -1; a < 2; a++)
                            {
                                for (int b = -1; b < 2; b++)
                                {
                                    alrededor += bitmons_simulacion[i + a, j + b].Count();
                                }
                            }
                            if (alrededor != 18)
                            {
                                while (m > 0)
                                {
                                    int m1 = rnd.Next(-1, 2);
                                    int m2 = rnd.Next(-1, 2);
                                    try
                                    {
                                        if (bitmons_simulacion[i + m1, j + m2].Count() < 2 && bit_mov[i + m1, j + m2].Count() < 2)
                                        {
                                            bit_mov[i + m1, j + m2].Add(bitmon);
                                            m -= 1;
                                        }
                                    }
                                    catch
                                    {
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
            }
            bitmons_simulacion = bit_mov;
        }

        //relacion de pelea entre bitmons
        public void Peleas(Bitmon bitmon1, Bitmon bitmon2)
        {
            //bitmon ataque simultaneo
            foreach (string bitmon in bitmon1.rivalidad)
            {
                if (bitmon == bitmon2.especie)
                {
                    //daño = puntos de ataque*multiplicador  
                    //cada bitmon descuenta de sus puntos de vida el daño 
                    bitmon2.PuntosDeVida -= bitmon2.PuntosDeVida * (bitmon1.PuntosDeAtaque * Convert.ToInt32(bitmon2.Atacar(bitmon1, bitmon2)));
                    bitmon1.PuntosDeVida -= bitmon1.PuntosDeVida * (bitmon2.PuntosDeAtaque * Convert.ToInt32(bitmon1.Atacar(bitmon1, bitmon2)));
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
                bitmon2.PuntosDeVida += bitmon2.PuntosDeVida * (bitmon1.PuntosDeAtaque * Convert.ToInt32(bitmon2.Atacar(bitmon1, bitmon2)));
            }
            if (bitmon2.PuntosDeVida <= 0)
            {
                bithalla.Add(bitmon2);
                bitmon1.PuntosDeVida += bitmon1.PuntosDeVida * (bitmon2.PuntosDeAtaque * Convert.ToInt32(bitmon1.Atacar(bitmon1, bitmon2)));
            }

            //pueden ambos irse a bithalla despues
            if (bitmon1.PuntosDeVida == 0 && bitmon2.PuntosDeVida == 0)
            {
                bithalla.Add(bitmon1);
                bithalla.Add(bitmon2);
            }
        }

        //relacion de reproduccion entre bitmons
        //luego de reproducirse recuperan el 30% de tiempo de vida
        public void Relaciones(Bitmon bitmon1, Bitmon bitmon2, int filas, int columnas)
        {
            Bitmon bitmon_hijo;
            //probabilidad de la especie del hijo
            int IP_hijo = rnd.Next(0, 101);
            //para calcular la probabilidad que sea de un padre o el otro
            int total = bitmon1.Hijos + bitmon2.Hijos + 2;
            int IP_bit1 = ((bitmon1.Hijos + 1) * 100) / total;
            int IP_bit2 = ((bitmon2.Hijos + 1) * 100) / total;
            bool a = true;

            //probabilidad de ser bitmon 1 mayor a la de bitmon 2
            if (IP_bit1 >= IP_bit2)
            {
                if (IP_bit1 <= IP_hijo)
                {
                    //es de la clase bitmon 1
                    bitmon_hijo = new Bitmon(bitmon1.especie);
                    bitmon1.Hijos += 1;
                    while (a)
                    {
                        int fila = rnd.Next(0, filas - 1);
                        int colun = rnd.Next(0, columnas - 1);
                        if (bitmons_simulacion[colun, fila][1] == null)
                        {
                            bitmons_simulacion[colun, fila].Add(bitmon_hijo);
                            bitmons_s.Add(bitmon_hijo);
                            a = false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    //es de la clase bitmon 2
                    bitmon_hijo = new Bitmon(bitmon2.especie);
                    bitmon2.Hijos += 1;
                    while (a)
                    {
                        int fila = rnd.Next(0, filas - 1);
                        int colun = rnd.Next(0, columnas - 1);
                        if (bitmons_simulacion[colun, fila][1] == null)
                        {
                            bitmons_simulacion[colun, fila].Add(bitmon_hijo);
                            bitmons_s.Add(bitmon_hijo);
                            a = false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                bitmon1.TiempoVida += (bitmon1.TiempoVida) * (30 / 100);
                bitmon2.TiempoVida += (bitmon2.TiempoVida) * (30 / 100);

            }

            //probabilidad de ser bitmon 2 mayor a la de bitmon 1
            else if (IP_bit2 > IP_bit1)
            {
                if (IP_bit2 <= IP_hijo)
                {
                    //es de la clase bitmon 2
                    bitmon_hijo = new Bitmon(bitmon2.especie);
                    bitmon2.Hijos += 1;
                    while (a)
                    {
                        int fila = rnd.Next(0, filas - 1);
                        int colun = rnd.Next(0, columnas - 1);
                        if (bitmons_simulacion[colun, fila][1] == null)
                        {
                            bitmons_simulacion[colun, fila].Add(bitmon_hijo);
                            bitmons_s.Add(bitmon_hijo);
                            a = false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    //es de la clase bitmon 1
                    bitmon_hijo = new Bitmon(bitmon1.especie);
                    bitmon1.Hijos += 1;
                    while (a)
                    {
                        int fila = rnd.Next(0, filas - 1);
                        int colun = rnd.Next(0, columnas - 1);
                        if (bitmons_simulacion[colun, fila][1] == null)
                        {
                            bitmons_simulacion[colun, fila].Add(bitmon_hijo);
                            bitmons_s.Add(bitmon_hijo);
                            a = false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                bitmon1.TiempoVida += (bitmon1.TiempoVida) * (30 / 100);
                bitmon2.TiempoVida += (bitmon2.TiempoVida) * (30 / 100);
            }

            bool b = true;
            while (b)
            {
                int fila = rnd.Next(0, filas);
                int colun = rnd.Next(0, columnas);
                if (bitmons_simulacion[colun, fila].Count < 2)
                {
                    bitmons_simulacion[fila, colun].Add(bitmon_hijo);
                    bitmons_s.Add(bitmon_hijo);
                    b = false;
                }
                else
                {
                    continue;
                }
            }
        }



        //tiempo de vida menor o igual a cero se va al cielo
        public void Bithalla()
        {
            List<Bitmon> bits = new List<Bitmon> { };
            foreach (Bitmon bit in bitmons_s)
            {
                bits.Add(bit);
            }

            foreach (Bitmon bitmon in bits)
            {
                if (bitmon.TiempoVida <= 0)
                {
                    //agrega el bitmon a la lista de bithalla
                    bithalla.Add(bitmon);

                    //elimina el bitmon de la lista de la simulacion
                    bitmons_s.Remove(bitmon);

                    //elimina el bitmon del array de la simulacion
                    for (int i = 0; i <= bitmons_simulacion.GetUpperBound(0); i++)
                    {
                        for (int j = 0; j <= bitmons_simulacion.GetUpperBound(1); j++)
                        {
                            if (bitmons_simulacion[i,j].Contains(bitmon))
                            {
                                bitmons_simulacion[i, j].Remove(bitmon);
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
}
