using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADE
{
    class Program
    {
        static void Main(string[] args)
        {
            TVfacade tvSet = new TVfacade(new TVset(), new Lighting());
           
            tvSet.OnMovie();
            Console.WriteLine();
            tvSet.OffMovie();
            Console.WriteLine();
            tvSet.watchTV();
            Console.WriteLine();
            tvSet.offTV();

            Console.ReadKey();
        }
    }
}
