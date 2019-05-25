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
        //numero de filas y columnas del mapa
        int filas;
        int columnas;
        int meses;

        //celda (boton) seleccionado que se esta configurando
        Button celdaSeleccionada;
        //Indices del boton seleccionado dentro del TableLayoutPanel
        TableLayoutPanelCellPosition posicion;

        //Objeto Bitmons y Mapa creados donde se guarda la info del mapa
        Bitmons bitmons = new Bitmons();
        Mapa mapa = new Mapa();

        public GeneradorMapa(int filas, int columnas)
        {
            InitializeComponent();
            this.filas = filas;
            this.columnas = columnas;

            //Se crean las arreglos de los mapas para los bitmons y los terrenos
            bitmons.bitmons_simulacion = new List<Bitmon>[filas, columnas];
            mapa.Mterrenos = new Terreno[filas, columnas];

            //Se crea una lista de bitmons para cada celda de la matriz de bitmons 
            for(int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    bitmons.bitmons_simulacion[i, j] = new List<Bitmon> { };
                    mapa.Mterrenos[i, j] = new Terreno(null); 
                }
            }
        }

        private void GeneradorMapa_Load(object sender, EventArgs e)
        {
            //TableLayoutPanel tablaMapa le agregamos todas las lineas y columnas necesarias para poner los botones
            tablaMapa.RowCount = filas;
            tablaMapa.ColumnCount = columnas;

            //Creamos los botones para cada celda del TableLayoutPanel
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Button b = new Button();
                    b.Name = $"Boton{i}{j}";
                    //b.Width = 526 / columnas;+
                    //b.Height = 374 / filas;
                    b.Visible = true;
                    b.Enabled = true;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Dock = DockStyle.Fill;
                    b.Height = 55;
                    b.Width = 55;
                    tablaMapa.Controls.Add(b);
                }
            }




            ////Controlamos el estilo y tamaño de cada boton
            //TableLayoutColumnStyleCollection estiloColumna = tablaMapa.ColumnStyles;
            //TableLayoutRowStyleCollection estiloFila = tablaMapa.RowStyles;

            //int ancho = tablaMapa.Width;
            //int alto = tablaMapa.Height;

            //foreach (ColumnStyle style in estiloColumna)
            //{
            //    style.SizeType = SizeType.AutoSize;
            //}

            //foreach (RowStyle style in estiloFila)
            //{
            //    style.SizeType = SizeType.AutoSize;
            //}

            //foreach (Button boton in tablaMapa.Controls)
            //{
            //    boton.Height = 55;
            //    boton.Width = 55;
            //}

            //tablaMapa.Width = tablaMapa.Height;

            //Controlamos el tamaño de los TableLayoutPanels y del form
            //tablaMapa.Width = 500;
            //tablaMapa.Height = 500;
            //tablaForm.AutoSize = true;
            //this.AutoSize = true;

            //tablaMapa.AutoSize = true;
            //tablaForm.AutoSize = true;
            //this.AutoSize = true;




            //A cada boton le agregamos el evento Button_click
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
            // "sender" es el que originó el evento...
            // Como sabemos que button_Click se llama cuando hacemos click en un cierto botón,
            // "sender" corresponderá al botón que estamos haciéndole click. Pero siempre vendrá 
            // en una variable "object"... así que tenemos que "transformalo" a Button:
            Button button = (Button)sender;

            //Configuramos la info para que parta todo en blanco
            comboBoxTipoTerreno.Text = "";
            comboBoxTipoBitmon.Text = "";
            BotonAgregarBitmon.Enabled = false;
            if (button.Tag != null)
            {
                //comboBoxTipoTerreno.Text = button.Tag.ToString();
                comboBoxTipoBitmon.Enabled = true;
            }
            else
            {
                comboBoxTipoTerreno.Text = "";
                comboBoxTipoBitmon.Enabled = false;
            }

            //guardamos la posicion del boton para poder trabajar la info despues
            posicion = tablaMapa.GetPositionFromControl(button);
            celdaSeleccionada = button;

            //Activamos el comboBoxTipoTerreno para que no se pueda escojer terreno antes de tener escojido una celda
            comboBoxTipoTerreno.Enabled = true;
        }

        private void comboBoxTipoTerreno_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Activamos el comboBoxTipoBitmon para que no se puedan agregar bitmons antes de tener escojido el terreno
            comboBoxTipoBitmon.Enabled = true;

            //Guardamos el tipo de terreno y cambiamos el color del terreno
            celdaSeleccionada.Tag = comboBoxTipoTerreno.Text;
            celdaSeleccionada.BackColor = mapa.MostrarMapa(celdaSeleccionada.Tag.ToString());

            string tipoSeleccionado = comboBoxTipoTerreno.Text;
            //Creamos el objeto terreno
            mapa.Mterrenos[posicion.Row, posicion.Column].tipo = comboBoxTipoTerreno.Text;

        }

        private void comboBoxTipoBitmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Activamos el BotonAgregarBitmon para que no se pueda agregar un bitmon antes de tiempo
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

        private void botonInicioSimulacion_Click(object sender, EventArgs e)
        {
            bool IniciarSimulacion = true;

            //revisamos que cada celda tenga ya escojido un terreno
            foreach( Button boton in tablaMapa.Controls)
            {
                if (boton.Tag == null)
                {
                    IniciarSimulacion = false;
                }
            }
            
            if (IniciarSimulacion)
            {
                //Form meses para recibir el numero de meses que durara la simulacion 
                //Manera en que la info llegua del Form meses al form GeneradorMapa, para pasar toda la info al siguiente form
                Meses Fmeses = new Meses();
                Fmeses.E_PasarMeses += new Meses.PasarMeses(recibirMeses);
                Fmeses.ShowDialog();

                //Condicion para partir la simulacion
                if (meses != 0)
                {
                    Simulacion simulacion = new Simulacion(bitmons, mapa, filas, columnas, meses);
                    this.Hide();
                    simulacion.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe definir cada terreno antes de partir la simulacion");
            }

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            celdaSeleccionada.Tag = null;
            celdaSeleccionada.BackColor = SystemColors.Control;
            celdaSeleccionada.Text = "";

            mapa.Mterrenos[posicion.Row, posicion.Column] = null;
            bitmons.bitmons_simulacion[posicion.Row, posicion.Column].Clear();

            comboBoxTipoBitmon.Text = "";
            comboBoxTipoTerreno.Text = "";
            BotonAgregarBitmon.Enabled = false;
            comboBoxTipoBitmon.Enabled = false;
        }

        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recibirMeses(int NumeroMeses)
        {
            meses = NumeroMeses;
        }
    }
}
