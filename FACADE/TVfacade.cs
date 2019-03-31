using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADE
{
    class TVfacade
    {
        TVset tvSet;
        Lighting lighting;

        public TVfacade(TVset tvSet, Lighting lighting)
        {
            this.tvSet = tvSet;
            this.lighting = lighting;
        }

        public void OnMovie()
        {
            lighting.lightForTv();
            tvSet.On();
            tvSet.OnVolume(50);
            tvSet.MovieFromUsb(2);           
        }

        public void OffMovie()
        {
            lighting.lightOn();
            tvSet.changeChannel(1);
        }

        public void watchTV()
        {
            lighting.lightOn();
            tvSet.On();
            tvSet.OnVolume(50);
            tvSet.changeChannel(2);

        }
        public void offTV()
        {
            lighting.lightOff();
            tvSet.OffVolume();
            tvSet.Off();

        }


    }
}

