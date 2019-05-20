using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmonsForms
{
    class Terreno
    {
        public string tipo;

        public Terreno(string tipo)
        {
            this.tipo = tipo;
        }

        public string getTerreno()
        {
            return tipo;
        }
    }
}
