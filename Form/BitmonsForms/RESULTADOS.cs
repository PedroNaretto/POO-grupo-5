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

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tiempo_vida_promedio = Convert.ToString(calculos.TiempoVidaPromedio(bitmons));
            listView1.Items.Add(new ListViewItem(new string[] { tiempo_vida_promedio}));
        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<double> vida_promedio_especie = calculos.TiempoVidaPromedio_especie(bitmons);
            for (int i = 0; i < vida_promedio_especie.Count; i++)
            {
                for (int j = 0; j < especies.Count; j++)
                {
                    string especie = Convert.ToString(especies[j]);
                    string vida_prom = Convert.ToString(vida_promedio_especie[i]);
                    listView2.Items.Add(new ListViewItem(new string[] { especie, ":", vida_prom }));
                }
            }
        }

        private void ListView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<double> tasa_nat_especie = calculos.TasaNatalidad_especie(bitmons);
            for (int i = 0; i < tasa_nat_especie.Count; i++)
            {
                for (int j = 0; j < especies.Count; j++)
                {
                    string especie = Convert.ToString(especies[j]);
                    string tasa_nat = Convert.ToString(tasa_nat_especie[i]);
                    listView3.Items.Add(new ListViewItem(new string[] { especie, ":", tasa_nat }));
                }
            }
        }

        private void ListView6_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<double> tasa_mort_especie = calculos.TasaMortalidad_especie(bitmons);
            for (int i = 0; i < tasa_mort_especie.Count; i++)
            {
                for (int j = 0; j < especies.Count; j++)
                {
                    string especie = Convert.ToString(especies[j]);
                    string tasa_mort = Convert.ToString(tasa_mort_especie[i]);
                    listView6.Items.Add(new ListViewItem(new string[] { especie, ":", tasa_mort }));
                }
            }
        }

        private void ListView5_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> extintas_especies = calculos.EspeciesExtintas();
            for (int i = 0; i < extintas_especies.Count; i++)
            {
                for (int j = 0; j < especies.Count; j++)
                {
                    string especie = Convert.ToString(especies[j]);
                    string extinta = Convert.ToString(extintas_especies[i]);
                    listView5.Items.Add(new ListViewItem(new string[] { especie, ":", extinta }));
                }
            }
        }

        private void ListView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<double> cantidad_bit = calculos.PoblacionBithalla();
            for (int i = 0; i < cantidad_bit.Count; i++)
            {
                for (int j = 0; j < especies.Count; j++)
                {
                    string especie = Convert.ToString(especies[j]);
                    string bitmon_bit = Convert.ToString(cantidad_bit[i]);
                    listView4.Items.Add(new ListViewItem(new string[] { especie, ":", bitmon_bit }));
                }
            }
        }

        private void ListView7_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<double> porcentaje_bit = calculos.PorcentajeBithalla();
            for (int i = 0; i < porcentaje_bit.Count; i++)
            {
                for (int j = 0; j < especies.Count; j++)
                {
                    string especie = Convert.ToString(especies[j]);
                    string porcentaje = Convert.ToString(porcentaje_bit[i]);
                    listView7.Items.Add(new ListViewItem(new string[] { especie, ":", porcentaje }));
                }
            }
        }

        private void ListView8_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<double> hijos_promedio = calculos.CantidadHijos_especie();
            for (int i = 0; i < hijos_promedio.Count; i++)
            {
                for (int j = 0; j < especies.Count; j++)
                {
                    string especie = Convert.ToString(especies[j]);
                    string hijos = Convert.ToString(hijos_promedio[i]);
                    listView8.Items.Add(new ListViewItem(new string[] { especie, ":", hijos }));
                }
            }
        }


    }
}
