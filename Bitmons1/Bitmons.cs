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
        public List<Bitmon> bithalla;

        //lista con los bitmons de la simulacion
        public List<Bitmon> bitmons_s;

        //constructor de Bitmons
        public Bitmons()
        {
        }

        public void Spawn(int largo, int ancho)
        {
            //creacion de arrays para los bitmons y terrenos del usuario
            String[,] terrenos_simulacion = new string[ancho, largo];
            List<Bitmon>[,] bitmons_simulacion = new List<Bitmon>[ancho, largo];
            for (int i = 0; i < largo; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Console.WriteLine("Tipo de terreno en cada posicion: ");
                    string tipo_terreno = Console.ReadLine();

                    //agrega el tipo de terreno que la persona ingresa al array
                    terrenos_simulacion[i, j] = (tipo_terreno);

                    Console.WriteLine("Bitmon inicial en cada posicion: ");
                    string clase_bitmon = Console.ReadLine();
                    if (clase_bitmon != " ")
                    {
                        //crea el bitmon de la clase que el usuario ingreso
                        Bitmon bitmon_nuevo = new Bitmon(clase_bitmon);

                        //agrega el bitmon creado al array de bitmons
                        bitmons_simulacion[i, j].Add(bitmon_nuevo);

                        //agrega el bitmon creado a la lista de bitmons
                        bitmons_s.Add(bitmon_nuevo);
                    }
                    else
                    {
                        continue;
                    }
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
