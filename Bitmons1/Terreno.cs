using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons1
{
    class Terreno
    {
        static Random rnd = new Random();
        static List<string> tipos = new List<string> { "tierra", "pasto", "agua", "hielo", "lava", "bosque" };
        public string tipo = tipos[rnd.Next(tipos.Count())];
    }
}
