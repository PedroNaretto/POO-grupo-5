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
    public partial class GeneradorMapa : Form
    {
        int filas;
        int columnas;
        Button celdaSeleccionada;
        TableLayoutPanelCellPosition posicion;

        Bitmons bitmons = new Bitmons();
        Mapa mapa = new Mapa();

        public GeneradorMapa(int filas, int columnas)
        {
            InitializeComponent();
            this.filas = filas;
            this.columnas = columnas;

            bitmons.bitmons_simulacion = new List<Bitmon>[filas, columnas];
            mapa.Mterrenos = new Terreno[filas, columnas];

            for(int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    bitmons.bitmons_simulacion[i, j] = new List<Bitmon> { };
                }
            }
        }

        private void GeneradorMapa_Load(object sender, EventArgs e)
        {
            tablaMapa.RowCount = filas;
            tablaMapa.ColumnCount = columnas;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Button b = new Button();
                    b.Name = $"Boton{i}{j}";
                    //b.Width = 526 / columnas;
                    //b.Height = 374 / filas;
                    b.Visible = true;
                    b.Enabled = true;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Dock = DockStyle.Fill;
                    tablaMapa.Controls.Add(b);
                }
            }

            TableLayoutColumnStyleCollection estiloColumna = tablaMapa.ColumnStyles;
            TableLayoutRowStyleCollection estiloFila = tablaMapa.RowStyles;

            int ancho = tablaMapa.Width;
            int alto = tablaMapa.Height;

            foreach (Button boton in tablaMapa.Controls)
            {
                boton.Width = ancho / columnas;
                boton.Height = alto / filas;
            }

            foreach (ColumnStyle style in estiloColumna)
            {
                style.SizeType = SizeType.AutoSize;
                style.Width = tablaMapa.Width / columnas;
            }

            foreach (RowStyle style in estiloFila)
            {
                style.SizeType = SizeType.AutoSize;
                style.Height = tablaMapa.Height / filas;
            }

            tablaMapa.Width = 50 * columnas;
            tablaMapa.Height = 50 * filas;
            tablaForm.AutoSize = true;
            this.AutoSize = true;

            foreach (Button boton in tablaMapa.Controls)
            {
                boton.Width = 50;
                boton.Height = 50;
            }

            //tablaMapa.AutoSize = true;
            //tablaForm.AutoSize = true;
            //this.AutoSize = true;

            foreach (Button button in tablaMapa.Controls)
            {
                button.Click += button_Click;
            }
            // Lista de items en terreno combobox
            List<string> tipoTerrenos = new List<string> { "Desierto", "Vegetacion", "Acuatico", "Nieve", "Volcan" };
            foreach (string terreno in tipoTerrenos)
            {
                comboBoxTipoTerreno.Items.Add(terreno);
            }
            // Lista de items en bitmons combobox
            List<string> tipoBitmons = new List<string> { "Taplan", "Wetar", "Gofue", "Dorvalo", "Doti", "Ent" };
            foreach (string bitmon in tipoBitmons)
            {
                comboBoxTipoBitmon.Items.Add(bitmon);
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            comboBoxTipoBitmon.Text = "";
            comboBoxTipoTerreno.Text = "";
            comboBoxTipoBitmon.Enabled = false;
            BotonAgregarBitmon.Enabled = false;
            // "sender" es el que originó el evento...
            // Como sabemos que button_Click se llama cuando hacemos click en un cierto botón,
            // "sender" corresponderá al botón que estamos haciéndole click. Pero siempre vendrá 
            // en una variable "object"... así que tenemos que "transformalo" a Button:
            Button button = (Button)sender;

            posicion = tablaMapa.GetPositionFromControl(button);
            celdaSeleccionada = button;

            comboBoxTipoTerreno.Enabled = true;
        }

        private void comboBoxTipoTerreno_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTipoBitmon.Enabled = true;
            celdaSeleccionada.Tag = comboBoxTipoTerreno.Text;
            celdaSeleccionada.BackColor = mapa.MostrarMapa(celdaSeleccionada.Tag.ToString());

            string tipoSeleccionado = comboBoxTipoTerreno.Text;
            mapa.Mterrenos[posicion.Row, posicion.Column] = new Terreno(tipoSeleccionado);

        }

        private void comboBoxTipoBitmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            BotonAgregarBitmon.Enabled = true;
        }

        private void BotonAgregarBitmon_Click(object sender, EventArgs e)
        {
            if (celdaSeleccionada.Tag.ToString() != "Acuatico" && comboBoxTipoBitmon.Text == "Wetar")
            {
                MessageBox.Show("Los Wetars no pueden ir fuera del agua");
            }
            else
            {
                if (bitmons.bitmons_simulacion[posicion.Row, posicion.Column].Count < 2)
                {
                    bitmons.bitmons_simulacion[posicion.Row, posicion.Column].Add(new Bitmon(comboBoxTipoBitmon.Text));
                    celdaSeleccionada.Text = bitmons.MostrarBitmons(bitmons.bitmons_simulacion[posicion.Row, posicion.Column]);
                }
                else
                {
                    MessageBox.Show("No pueden haber mas de 2 bitmons por terreno");
                }
            }
        }
    }
}
