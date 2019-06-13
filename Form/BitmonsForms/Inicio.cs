using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginClase;
using System.IO;
using System.Reflection;

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
                GeneradorMapa GenerarMapa = new GeneradorMapa(Convert.ToInt32(NumeroFilas.Value), Convert.ToInt32(NumeroColumnas.Value));
                this.Hide();
                GenerarMapa.ShowDialog();
                this.Show();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Assembly.LoadFrom(open.FileName);
                foreach(Assembly a in AppDomain.CurrentDomain.GetAssemblies())
                {
                    foreach(Type t in a.GetTypes())
                    {
                        if (t.GetInterface("Plugin") != null)
                            {
                            IPlugin p = Activator.CreateInstance(t) as IPlugin;
                            label5.Text = p.PluginName();
                            p.run();
                            }
                            

                        
                    }
                }
            }
        }
    }
}
