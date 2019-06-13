using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PluginClase
{
    public interface IPlugin
    {
        void run();
        String PluginName();
        
    }
}
