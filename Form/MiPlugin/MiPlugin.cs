using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiPlugin;
using System.Windows.Forms;
using PluginClase;
namespace MiPlugin
{
    public class MiPlugin : IPlugin
    {
        public string PluginName()
        {
            return "MiPlugin";
        }

        public void run()
        {            
            MessageBox.Show("Plugin de prueba");
        }
    }
}
