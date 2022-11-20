using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbctractFactory;

namespace FactoryCocaColaPepsiWater
{
    class Program
    {
        private static Client client;
        static void Main(string[] args)
        {
            client = new Client(new CocaColaFactory());
            client.Run();

            client = new Client(new PepsiFactory());
            client.Run();
        }
    }
}
