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
        Bitmons Bit;
        Mapa mapa;
        int filas;
        int columnas;
        TableLayoutControlCollection controles;

        public Simulacion( Bitmons Bit, Mapa mapa, int filas, int columnas, TableLayoutControlCollection controles)
        {
            InitializeComponent();
            this.Bit = Bit;
            this.mapa = mapa;
            this.filas = filas;
            this.columnas = columnas;
            this.controles = controles;
        }

        private void Simulacion_Load(object sender, EventArgs e)
        {
            marica.RowCount = filas;
            marica.ColumnCount = columnas;

            foreach (Control con in controles)
            {
                marica.Controls.Add(con);
            }

            MessageBox.Show(Convert.ToString(controles.Count));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hacer simulacion NARUTO APURATE
        }
    }
}
