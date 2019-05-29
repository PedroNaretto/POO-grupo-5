using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons1
{
    public class Bitmon
    {
        Random rnd = new Random();
        public string especie;
        public int TiempoVida;
        public int PuntosDeVida;
        public int PuntosDeAtaque;
        public int Hijos;
        public List<string> rivalidad;
        public List<string> debilidad;
        public List<string> afinidad;
        public int movimientos;

        //constructor de los bitmons
        public Bitmon(string especie)
        {
            this.especie = especie;

            int max = 0;
            int min = 0;

            if (especie == "Taplan")
            {
                max = 35;
                min = 5;
                rivalidad = new List<string> { "Wetar", "Gofue" };
                debilidad = new List<string> { "Acuatico", "Nieve", "Volcan" };
                afinidad = new List<string> { "Vegetacion", "Desierto" };
                movimientos = 8;
            }

            if (especie == "Wetar")
            {
                max = 25;
                min = 20;
                rivalidad = new List<string> { "Dorvalo", "Taplan", "Gofue" };
                debilidad = new List<string> { "Vegetacion", "Desierto", "Nieve" };
                afinidad = new List<string> { "Acuatico" };
                movimientos = 8;
            }
            if (especie == "Gofue")
            {
                max = 30;
                min = 10;
                rivalidad = new List<string> { "Wetar", "Taplan" };
                debilidad = new List<string> { "Acuatico" };
                afinidad = new List<string> { "Vegetacion", "Desierto", "Nieve", "Volcan" };
                movimientos = 8;
            }
            if (especie == "Dorvalo")
            {
                max = 45;
                min = 20;
                rivalidad = new List<string> { "Ent", "Wetar" };
                debilidad = new List<string> { "ninguno" };
                afinidad = new List<string> { "Vegetacion", "Acuatico", "Desierto", "Nieve", "Volcan" };
                movimientos = 16;

            }
            if (especie == "Doti")
            {
                max = 40;
                min = 15;
                rivalidad = new List<string> { "Ent" };
                debilidad = new List<string> { "ninguno" };
                afinidad = new List<string> { "Vegetacion", "Acuatico", "Desierto", "Nieve", "Volcan" };
                movimientos = 8;
            }
            if (especie == "Ent")
            {
                max = 20;
                min = 5;
                rivalidad = new List<string> { "Doti", "Dorvalo" };
                debilidad = new List<string> { "Volcan", "Acuatico" };
                afinidad = new List<string> { "Vegetacion", "Desierto", "Nieve" };
                movimientos = 0;
            }

            //tiempo de vida aleatorio medido en meses, aleatorio entre un min y un max que varia segun especie.
            TiempoVida = rnd.Next(min, max);

            //no especifica hasta que numero es el random
            PuntosDeVida = rnd.Next(0, 1001);
            PuntosDeAtaque = rnd.Next(0, 51);

            //cada bitmon parte con cero hijos
            Hijos = 0;
        }

        //retorna el multiplicador del bitmon
        public double Atacar(Bitmon bitmon1, Bitmon bitmon2)
        {
            double multiplicador = 1;

            //multiplicador varia por especie
            if (bitmon1.especie == "Taplan")
            {
                if (bitmon2.especie == "Wetar")
                {
                    multiplicador = 1.5;
                }
                if (bitmon2.especie == "Gofue")
                {
                    multiplicador = 1.15;
                }
            }
            if (bitmon1.especie == "Wetar")
            {
                if (bitmon2.especie == "Taplan")
                {
                    multiplicador = 1.1;
                }
                if (bitmon2.especie == "Gofue")
                {
                    multiplicador = 2;
                }
                if (bitmon2.especie == "Dorvalo")
                {
                    multiplicador = 0.2;
                }
            }
            if (bitmon1.especie == "Gofue")
            {
                if (bitmon2.especie == "Taplan")
                {
                    multiplicador = 2;
                }
                if (bitmon2.especie == "Wetar")
                {
                    multiplicador = 0.8;
                }
            }
            if (bitmon1.especie == "Dorvalo")
            {
                if (bitmon2.especie == "Wetar")
                {
                    multiplicador = 3;
                }
                    if (bitmon2.especie == "Ent")
                {
                    multiplicador = 1;
                }
            }
            if (bitmon1.especie == "Doti")
            {
                if (bitmon2.especie == "Ent")
                {
                    multiplicador = 2.2;
                }
            }
            if (bitmon1.especie == "Ent")
            {
                if (bitmon1.especie == "Doti")
                {
                    multiplicador = 1;
                }
                if (bitmon2.especie == "Dorvalo")
                {
                    multiplicador = 1.3;
                }
            }
            else
            {
                multiplicador = 1;
            }  
                return multiplicador ;
        }
    }
}
