using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADE
{
    class TVset
    {
        Volume volume;

        public TVset()
        {
            volume = new Volume();
        }

        public void On()
        {
            Console.WriteLine("On TV-set");
        }

        public void Off()
        {
            Console.WriteLine("Off TV-set");
        }

        public void changeChannel(ushort channel)
        {
            Console.WriteLine("Watch channel №: {0}", channel);
        }

        public void MovieFromUsb(string movieNumber)
        {
            Console.WriteLine("Whatch movie№: {0}", movieNumber);
        }

     
        public void OnVolume(ushort level)
        {
            volume.volumeOn();
            volume.setVolume(level);
        }

        public void OffVolume()
        {
            volume.volumeOff();
        }
    }
}

