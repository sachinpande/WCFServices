﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
            host.Open();
            Console.WriteLine("Service started. Press [Enter] to exit.");
            Console.ReadLine();
            host.Close();
        }
    }
}
