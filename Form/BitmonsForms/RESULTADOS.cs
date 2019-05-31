using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmonsForms
{
    public partial class Resultados : Form
    {
        Bitmons bitmons;
        Calculos calculos = new Calculos();
        List<string> especies = new List<string>{ "Taplan", "Wetar", "Gofue", "Dorvalo", "Doti", "Ent" };

        public Resultados(Bitmons bitmons)
        {
            InitializeComponent();
            this.bitmons = bitmons;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //tiempo vida promedio de bitmons
            string tiempo_vida_promedio = Convert.ToString(calculos.TiempoVidaPromedio(bitmons));
            richTextBox1.Text = tiempo_vida_promedio + "  meses";

            //tiempo de vida promedio por especie
            List<string> resultado_2 = new List<string>();
            List<double> vida_promedio_especie = calculos.TiempoVidaPromedio_especie(bitmons);
            for (int i = 0; i < vida_promedio_especie.Count; i++)
            {
                string vida_prom = Convert.ToString(vida_promedio_especie[i]);
                if (vida_prom == "NaN")
                {
                    vida_prom = "0";
                }
                    resultado_2.Add(vida_prom);
            }
            for (int i = 0; i < resultado_2.Count; i ++)
            {
                    richTextBox2.Text += especies[i] + ":" + resultado_2[i] + "\n";
            }

            //tasa natalidad por especie
            List<string> resultado_3 = new List<string>();
            List<double> tasa_nat_especie = calculos.TasaNatalidad_especie(bitmons);
            for (int i = 0; i < tasa_nat_especie.Count; i++)
            {
                string tasa_nat = Convert.ToString(tasa_nat_especie[i]);
                if (tasa_nat == "NaN")
                {
                    tasa_nat = "0";
                }
                resultado_3.Add(tasa_nat);
            }
            for (int i = 0; i < resultado_3.Count; i++)
            {

                    richTextBox3.Text += especies[i] + ":" + resultado_3[i] + "\n";
            }

            //tasa mortalidad por especie 
            List<string> resultado_4 = new List<string>();
            List<double> tasa_mort_especie = calculos.TasaMortalidad_especie(bitmons);
            for (int i = 0; i < tasa_mort_especie.Count; i++)
            {
                string tasa_mort = Convert.ToString(tasa_mort_especie[i]);
                if (tasa_mort == "NaN")
                {
                    tasa_mort = "0";
                }
                resultado_4.Add(tasa_mort);
            }
            for (int i = 0; i < resultado_4.Count; i++)
            {
                    richTextBox4.Text += especies[i] + ":" + resultado_4[i] + "\n";
            }

            //especies extintas
            List<string> resultado_5 = new List<string>();
            List<string> extintas_especies = calculos.EspeciesExtintas();
            for (int i = 0; i < extintas_especies.Count; i++)
            {
                string extinta = Convert.ToString(extintas_especies[i]);
                resultado_5.Add(extinta);
            }
            for (int i = 0; i < resultado_5.Count; i++)
            {  
                    richTextBox5.Text +=  resultado_5[i] + "\n";

            }

            //cantidad bitmons en bithalla
            List<string> resultado_6 = new List<string>();
            List<double> cantidad_bit = calculos.PoblacionBithalla();
            for (int i = 0; i < cantidad_bit.Count; i++)
            {
                string bitmon_bit = Convert.ToString(cantidad_bit[i]);
                if (bitmon_bit == "NaN")
                {
                    bitmon_bit = "0";
                }
                resultado_6.Add(bitmon_bit);
            }
            for (int i = 0; i < resultado_6.Count; i++)
            {
                    richTextBox6.Text += especies[i] + ":" + resultado_6[i] + "\n";
            }

            //porcentaje bitmons en bithalla
            List<string> resultado_7 = new List<string>();
            List<double> porcentaje_bit = calculos.PorcentajeBithalla();
            for (int i = 0; i < porcentaje_bit.Count; i++)
            {
                string porcentaje = Convert.ToString(porcentaje_bit[i]);
                if (porcentaje == "NaN")
                {
                    porcentaje = "0";
                }
                resultado_7.Add(porcentaje);
            }
            for (int i = 0; i < resultado_7.Count; i++)
            {
                    richTextBox7.Text += especies[i] + ":" + resultado_7[i] + "\n";
            }

            //cantidad hijos promedio por especie
            List<string> resultado_8 = new List<string>();
            List<double> hijos_promedio = calculos.CantidadHijos_especie();
            for (int i = 0; i < hijos_promedio.Count; i++)
            {
                string hijos = Convert.ToString(hijos_promedio[i]);
                if (hijos == "NaN")
                {
                    hijos = "0";
                }
                resultado_8.Add(hijos);
            }
            for (int i = 0; i < resultado_8.Count; i++)
            {
                    richTextBox8.Text += especies[i] + ":" + resultado_8[i] + "\n";
            }
        }


    }
}
