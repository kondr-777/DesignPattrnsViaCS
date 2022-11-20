using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;

namespace FactoryProduct
{
    class Program
    {
        private Client client;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.client = new Client(new ConcreteFactory1());
            p.client.Run();

            p.client = new Client(new ConcreteFactory2());
            p.client.Run();
        }
    }
}
