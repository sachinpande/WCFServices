using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFAndEFService;

namespace ConsoleHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ProductService));
            host.Open();
            Console.WriteLine("Service started. Press [Enter] to exit.");
            Console.ReadLine();
            host.Close();
        }
    }
}
