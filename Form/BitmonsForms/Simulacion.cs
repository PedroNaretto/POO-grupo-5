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
    public partial class Simulacion : Form
    {
        int contador = 0;
        Bitmons bitmons;
        Mapa mapa;
        int filas;
        int columnas;
        int meses;

        public Simulacion(Bitmons bitmons, Mapa mapa, int filas, int columnas, int meses)
        {
            InitializeComponent();
            this.bitmons = bitmons;
            this.mapa = mapa;
            this.filas = filas;
            this.columnas = columnas;
            this.meses = meses;
        }

        private void Simulacion_Load(object sender, EventArgs e)
        {
            MapaSimulacion.RowCount = filas;
            MapaSimulacion.ColumnCount = columnas;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Button b = new Button();
                    b.Name = $"Boton{i}{j}";
                    b.Visible = true;
                    b.Enabled = false;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Dock = DockStyle.Fill;
                    b.Height = 55;
                    b.Width = 55;
                    b.Text = bitmons.MostrarBitmons(bitmons.bitmons_simulacion[i, j]);
                    b.Tag = mapa.Mterrenos[i, j].tipo;
                    b.BackColor = mapa.MostrarMapa(b.Tag.ToString());
                    MapaSimulacion.Controls.Add(b);
                }
            }

            //Controlamos el estilo y tamaño de cada boton
            //TableLayoutColumnStyleCollection estiloColumna = MapaSimulacion.ColumnStyles;
            //TableLayoutRowStyleCollection estiloFila = MapaSimulacion.RowStyles;

            //int ancho = MapaSimulacion.Width;
            //int alto = MapaSimulacion.Height;

            //foreach (ColumnStyle style in estiloColumna)
            //{
            //    style.SizeType = SizeType.AutoSize;
            //}

            //foreach (RowStyle style in estiloFila)
            //{
            //    style.SizeType = SizeType.AutoSize;
            //}

            //foreach (Button boton in MapaSimulacion.Controls)
            //{
            //    boton.Height = 50;
            //    boton.Width = 50;
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contador < meses)
            {
                contador += 1;
            }
        }
    }
}
