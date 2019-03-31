using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADE
{
    class Lighting
    {
        public Lighting()
        {

        }

        public void lightOn()
        {
            Console.WriteLine("On Lighting");
        }

        public void lightOff()
        {
            Console.WriteLine("Off Lighting");
        }

        public void lightForTv()
        {
            Console.WriteLine("TV adapted Lighting");
        }
    }
}
