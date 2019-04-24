using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons1
{
    class Bitmons
    {
        static Random rnd = new Random();
        List<Bitmon>[,] bitmons = new List<Bitmon>[rnd.Next(9, 30), rnd.Next(9, 30)];

        public Bitmons()
        {
        }

        public void Spawn()
        {
            for (int i = 0; i < bitmons.GetUpperBound(0); i++)
            {
                for (int c = 0; c < bitmons.GetUpperBound(1); c++)
                {
                    if ( rnd.Next(100) <= 50)
                    {
                        bitmons[i, c].Add(new Bitmon(rnd.Next(10), rnd.Next(10), rnd.Next(10)));
                    }
                }
            }
        }
    }
}
