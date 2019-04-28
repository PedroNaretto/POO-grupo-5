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

        //retorna el multiplicador del bitmon
        public int Atacar(Bitmon bitmon)
        {
            int multiplicador = 0;

            //multiplicador varia por especie
            if (bitmon.especie == "Taplan")
            {
                multiplicador = 10;
            }
            if (bitmon.especie == "Wetar")
            {
                multiplicador = 15;
            }
            if (bitmon.especie == "Gofue")
            {
                multiplicador = 12;
            }
            if (bitmon.especie == "Dorvalo")
            {
                multiplicador = 20;
            }
            if (bitmon.especie == "Doti")
            {
                multiplicador = 5;
            }
            if (bitmon.especie == "Ent")
            {
                multiplicador = 0;
            }
            return multiplicador;
        }

        //constructor de los bitmons
        public Bitmon(string especie)
        {
            this.especie = especie;

            int max = 0;
            int min = 0;

            if (especie == "Taplan")
            {
                max = 200;
                min = 0;
                rivalidad = new List<string> { "Wetar", "Gofue" };
                debilidad = new List<string> { "Acuatico", "Nieve", "Volcan" };
                afinidad = new List<string> { "Vegetacion", "Desierto" };
                movimientos = 8;
            }

            if (especie == "Wetar")
            {
                max = 250;
                min = 20;
                rivalidad = new List<string> { "Dorvalo", "Taplan", "Gofue" };
                debilidad = new List<string> { "Vegetacion", "Desierto", "Nieve" };
                afinidad = new List<string> { "Acuatico" };
                movimientos = 8;
            }
            if (especie == "Gofue")
            {
                max = 300;
                min = 10;
                rivalidad = new List<string> { "Wetar", "Taplan" };
                debilidad = new List<string> { "Acuatico" };
                afinidad = new List<string> { "Vegetacion", "Desierto", "Nieve", "Volcan" };
                movimientos = 8;
            }
            if (especie == "Dorvalo")
            {
                max = 350;
                min = 5;
                rivalidad = new List<string> { "Ent", "Wetar" };
                debilidad = new List<string> { "ninguno" };
                afinidad = new List<string> { "Vegetacion", "Acuatico", "Desierto", "Nieve", "Volcan" };
                movimientos = 16;

            }
            if (especie == "Doti")
            {
                max = 400;
                min = 15;
                rivalidad = new List<string> { "Ent" };
                debilidad = new List<string> { "ninguno" };
                afinidad = new List<string> { "Vegetacion", "Acuatico", "Desierto", "Nieve", "Volcan" };
                movimientos = 8;
            }
            if (especie == "Ent")
            {
                max = 450;
                min = 25;
                rivalidad = new List<string> { "Doti", "Dorvalo" };
                debilidad = new List<string> { "Volcan", "Acuatico" };
                afinidad = new List<string> { "Vegetacion", "Desierto", "Nieve" };
                movimientos = 0;
            }

            //tiempo de vida aleatorio medido en meses, aleatorio entre un min y un max que varia segun especie.
            TiempoVida = rnd.Next(min, max);

            //no especifica hasta que numero es el random
            PuntosDeVida = rnd.Next(0, 1001);
            PuntosDeAtaque = rnd.Next(0, 501);

            //cada bitmon parte con cero hijos
            Hijos = 0;
        }
    }
}
