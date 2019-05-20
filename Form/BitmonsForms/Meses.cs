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
    public partial class Meses : Form
    {
        //Delegate 
        public delegate void PasarMeses(int meses);
        //Evento
        public event PasarMeses E_PasarMeses;

        public Meses()
        {
            InitializeComponent();
        }

        private void botonOK_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Escoja numero de meses mayor a 0");
            }
            else
            {
                E_PasarMeses(Convert.ToInt32(numericUpDown1.Value));
                this.Close();
            }
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            E_PasarMeses(0);
            this.Close();
        }
    }
}
