﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KubrikND.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KubrikND.Sprint0.Task2_V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMessage
            Console.WriteLine(DataService.GetMessage("Никита"));
            Console.ReadKey();
        }
    }
}
