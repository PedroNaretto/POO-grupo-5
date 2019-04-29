using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons1
{
    public class Controlador
    {
        public Controlador()
        {
        }

        //para generar el mapa
        public void generarMapas(int filas, int columnas, Mapa cMapa, Bitmons cBitmons)
        {
            cMapa.GenerarMapa(filas, columnas);
            cBitmons.Spawn(filas, columnas);
        }

        //Para cada bitmon, revisa si se encuentra en un terreno que le haga daño
        public void Entorno(Mapa cMapa, Bitmons cBitmons)
        {
            for (int i = 0; i < cMapa.Mterrenos.GetUpperBound(0); i++)
            {
                for (int j = 0; j < cMapa.Mterrenos.GetUpperBound(1); j++)
                {
                    foreach(Bitmon bitmon in cBitmons.bitmons_simulacion[i,j])
                    {
                        string t = cMapa.Mterrenos[i, j].getTerreno();
                        if (bitmon.debilidad.Contains(t))
                        {
                            bitmon.TiempoVida -= 2;
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
