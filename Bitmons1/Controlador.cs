using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons1
{
    class Controlador
    {
        Mapa cMapa = new Mapa();
        Bitmons cBitmons = new Bitmons();

        public Controlador()
        {
        }

        public void generarMapas(int filas, int columnas)
        {
            cMapa.GenerarMapa(filas, columnas);
            cBitmons.Spawn(filas, columnas);
        }

        public void Entorno()
        {
            for (int i = 0; i < cMapa.mapa.GetUpperBound(0); i++)
            {
                for (int j = 0; j < cMapa.mapa.GetUpperBound(1); j++)
                {

                }
            }
        }
    }
}
