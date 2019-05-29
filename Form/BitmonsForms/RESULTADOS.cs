using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmonsForms
{
    class RESULTADOS
    {

        public double TiempoVidaPromedio(Bitmons bitmons)
        {
            double suma_tiempovida = 0;
            double total_tiempovida = Convert.ToDouble(bitmons.bitmons_simulacion.Length);
            foreach (Bitmon bitmon in bitmons.bitmons_s)
            {
                suma_tiempovida += bitmon.TiempoVida;
            }
            return (suma_tiempovida / total_tiempovida);
        }


        public float suma_tvida_taplan = 0, suma_tvida_wetar = 0, suma_tvida_gofue = 0, suma_tvida_dorvalo = 0, suma_tvida_doti = 0, suma_tvida_ent = 0;
        public float total_taplan = 0, total_wetar = 0, total_gofue = 0, total_dorvalo = 0, total_doti = 0, total_ent = 0;

        public void TiempoVidaPromedio_especie (Bitmons bitmons)
        {
            List<float> TiempoVidaPromedioxEspecie = new List<float>();
            foreach (Bitmon bitmon in bitmons.bitmons_s)
            {
                if (bitmon.especie == "Taplan")
                {
                    suma_tvida_taplan += bitmon.TiempoVida;
                    total_taplan += 1;
                }
                if (bitmon.especie == "Wetar")
                {
                    suma_tvida_wetar += bitmon.TiempoVida;
                    total_wetar += 1;
                }
                if (bitmon.especie == "Gofue")
                {
                    suma_tvida_gofue += bitmon.TiempoVida;
                    total_gofue += 1;
                }
                if (bitmon.especie == "Dorvalo")
                {
                    suma_tvida_dorvalo += bitmon.TiempoVida;
                    total_dorvalo += 1;
                }
                if (bitmon.especie == "Doti")
                {
                    suma_tvida_doti += bitmon.TiempoVida;
                    total_doti += 1;
                }
                if (bitmon.especie == "Ent")
                {
                    suma_tvida_ent += bitmon.TiempoVida;
                    total_ent += 1;
                }
                else
                {
                    continue;
                }
            }
            TiempoVidaPromedioxEspecie.Add(suma_tvida_taplan);
            TiempoVidaPromedioxEspecie.Add(suma_tvida_wetar);
            TiempoVidaPromedioxEspecie.Add(suma_tvida_gofue);
            TiempoVidaPromedioxEspecie.Add(suma_tvida_dorvalo);
            TiempoVidaPromedioxEspecie.Add(suma_tvida_doti);
            TiempoVidaPromedioxEspecie.Add(suma_tvida_ent);

        }

        //tasa natalidad cada especie
        public double hijos_taplan = 0, hijos_wetar = 0, hijos_gofue = 0, hijos_dorvalo = 0, hijos_doti = 0, hijos_ent = 0;

        public void TasaNatalidad_especie (Bitmons bitmons)
        {
            List<double> TasaNatalidadxEspecie = new List<double>();
            List<double> CantidadHijoPromedioxEspecie = new List<double>();
            double total = Convert.ToDouble(bitmons.bitmons_simulacion.Length);
            foreach (Bitmon bitmon in bitmons.bitmons_s)
            {
                if (bitmon.especie == "Taplan")
                {
                    if (bitmon.Hijos != 0)
                    {
                        hijos_taplan += Convert.ToDouble(bitmon.Hijos);
                    }
                }
                if (bitmon.especie == "Wetar")
                {
                    if (bitmon.Hijos != 0)
                    {
                        hijos_wetar += Convert.ToDouble(bitmon.Hijos);
                    }
                }
                if (bitmon.especie == "Gofue")
                {
                    if (bitmon.Hijos != 0)
                    {
                        hijos_gofue += Convert.ToDouble(bitmon.Hijos);
                    }
                }
                if (bitmon.especie == "Dorvalo")
                {
                    if (bitmon.Hijos != 0)
                    {
                        hijos_dorvalo += Convert.ToDouble(bitmon.Hijos);
                    }
                }
                if (bitmon.especie == "Doti")
                {
                    if (bitmon.Hijos != 0)
                    {
                        hijos_doti += Convert.ToDouble(bitmon.Hijos);
                    }
                }
                if (bitmon.especie == "Ent")
                {
                    if (bitmon.Hijos != 0)
                    {
                        hijos_ent += Convert.ToDouble(bitmon.Hijos);
                    }
                }
                else
                {
                    continue;
                }

                TasaNatalidadxEspecie.Add((hijos_taplan / total) * 100);
                TasaNatalidadxEspecie.Add((hijos_wetar / total) * 100);
                TasaNatalidadxEspecie.Add((hijos_gofue / total) * 100);
                TasaNatalidadxEspecie.Add((hijos_dorvalo / total) * 100);
                TasaNatalidadxEspecie.Add((hijos_doti / total) * 100);
                TasaNatalidadxEspecie.Add((hijos_ent / total) * 100);

                CantidadHijoPromedioxEspecie.Add((hijos_taplan / total_taplan) * 100);
                CantidadHijoPromedioxEspecie.Add((hijos_wetar / total_wetar) * 100);
                CantidadHijoPromedioxEspecie.Add((hijos_gofue / total_gofue) * 100);
                CantidadHijoPromedioxEspecie.Add((hijos_dorvalo / total_dorvalo) * 100);
                CantidadHijoPromedioxEspecie.Add((hijos_doti / total_doti) * 100);
                CantidadHijoPromedioxEspecie.Add((hijos_ent / total_ent) * 100);

            }
        }

        //tasa mortalidad cada especie
        public double muertos_taplan = 0, muertos_wetar = 0, muertos_gofue = 0, muertos_dorvalo = 0, muertos_doti = 0, muertos_ent = 0;
        public double total_bithalla;

        public void TasaMortalidad_especie(Bitmons bitmons)
        {
            List<double> TasaMortalidadxEspecie = new List<double>();
            total_bithalla = Convert.ToDouble(bitmons.bithalla.Count());
            foreach (Bitmon bitmon in bitmons.bithalla)
            {
                if (bitmon.especie == "Taplan")
                {
                    muertos_taplan += 1;
                }
                if (bitmon.especie == "Wetar")
                {
                    muertos_wetar += 1;
                }
                if (bitmon.especie == "Gofue")
                {
                    muertos_gofue += 1;
                }
                if (bitmon.especie == "Dorvalo")
                {
                    muertos_dorvalo += 1;
                }
                if (bitmon.especie == "Doti")
                {
                    muertos_doti += 1;
                }
                if (bitmon.especie == "Ent")
                {
                    muertos_ent += 1;
                }
                else
                {
                    continue;
                }
            }
            TasaMortalidadxEspecie.Add((muertos_taplan / total_bithalla) * 100);
            TasaMortalidadxEspecie.Add((muertos_wetar / total_bithalla) * 100);
            TasaMortalidadxEspecie.Add((muertos_gofue / total_bithalla) * 100);
            TasaMortalidadxEspecie.Add((muertos_dorvalo / total_bithalla) * 100);
            TasaMortalidadxEspecie.Add((muertos_doti / total_bithalla) * 100);
            TasaMortalidadxEspecie.Add((muertos_ent / total_bithalla) * 100);
        }


        public void EspeciesExtintas()
        {
            //listado especies extintas
            List<string> extintas = new List<string>();

            if (total_taplan == 0)
            {
                extintas.Add("Taplan");
            }
            if (total_wetar == 0)
            {
                extintas.Add("Wetar");
            }
            if (total_gofue == 0)
            {
                extintas.Add("Gofue");
            }
            if (total_dorvalo == 0)
            {
                extintas.Add("Dorvalo");
            }
            if (total_doti == 0)
            {
                extintas.Add("Doti");
            }
            if (total_ent == 0)
            {
                extintas.Add("Ent");
            }
        }

        //descripcion poblacion de Bitmons en bithalla (cantidad de cada especie, %)
        public void PoblacionBithalla()
        {
            List<double> cantidadBithalla = new List<double>();
            List<double> porcentaje = new List<double>();

            cantidadBithalla.Add(muertos_taplan);
            cantidadBithalla.Add(muertos_wetar);
            cantidadBithalla.Add(muertos_gofue);
            cantidadBithalla.Add(muertos_dorvalo);
            cantidadBithalla.Add(muertos_doti);
            cantidadBithalla.Add(muertos_ent);

            porcentaje.Add((muertos_taplan / total_bithalla) * 100);
            porcentaje.Add((muertos_wetar / total_bithalla) * 100);
            porcentaje.Add((muertos_gofue / total_bithalla) * 100);
            porcentaje.Add((muertos_dorvalo / total_bithalla) * 100);
            porcentaje.Add((muertos_doti / total_bithalla) * 100);
            porcentaje.Add((muertos_ent / total_bithalla) * 100);

        }

    }
}
