using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons1
{
    class Bitmon
    {
        public int TiempoVida;
        public int PuntosDeVida;
        public int PuntosDeAtaque;
        public int Hijos = 0;

        public Bitmon(int tiempoVida, int puntosDeVida, int puntosDeAtaque)
        {
            TiempoVida = tiempoVida;
            PuntosDeVida = puntosDeVida;
            PuntosDeAtaque = puntosDeAtaque;
        }

        public int atacar(Bitmon bitmon)
        {
            return 0;
        }
    }
}
