using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using WCFAndEFService;

namespace ConsoleHost2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ProductService));
            string address = "net.tcp://localhost:8009/ProductService";
            Binding binding = new NetTcpBinding();
            Type contract = typeof(IProductService);
            host.AddServiceEndpoint(contract, binding, address);
            host.Open();
            Console.WriteLine("Service started. Press [Enter] to exit.");
            Console.ReadLine();
            host.Close();
        }
    }
}
