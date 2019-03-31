using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADE
{
    class Volume
    {
        public Volume()
        {

        }

        public void volumeOn()
        {
            Console.WriteLine("On Volume");
        }

        public void volumeOff()
        {
            Console.WriteLine("Off Volume");
        }

        public void setVolume(ushort level)
        {
            Console.WriteLine("Volume level: {0}", level);
        }
    }
}
