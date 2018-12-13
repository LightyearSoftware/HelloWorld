﻿using HelloWorldLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IOutput demo = Output.OutputFactory();
            demo.WriteData("Hello World");

            Console.ReadKey();
        }
    }
}
