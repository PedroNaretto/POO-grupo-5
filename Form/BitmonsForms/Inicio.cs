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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void InicioSimulacion_Click(object sender, EventArgs e)
        {
            if (NumeroFilas.Value == 0 || NumeroColumnas.Value == 0)
            {
                MessageBox.Show("Tamaño de mapa invalido, el numero de filas y columnas tienen que ser mayores a 0");
            }
            else
            {
                GeneradorMapa simulacion = new GeneradorMapa(Convert.ToInt32(NumeroFilas.Value), Convert.ToInt32(NumeroColumnas.Value));
                this.Hide();
                simulacion.ShowDialog();
                this.Show();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
