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
            lighting.lightOff();
            tvSet.On();
            tvSet.OnVolume(50);
            tvSet.MovieFromUsb(2);           
        }

        public void OffMovie()
        {
            
            offTV();
        }

        public void watchTV()
        {

            lighting.lightForTv();
            tvSet.On();
            tvSet.OnVolume(50);
            tvSet.changeChannel(2);

        }
        public void offTV()
        {
            lighting.lightOn();
            tvSet.OffVolume();
            tvSet.Off();

        }


    }
}

