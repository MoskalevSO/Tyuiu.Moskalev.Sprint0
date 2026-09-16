using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MoskalevSO.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MoskalevSO.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Степан"));
            Console.ReadKey();
        }
    }
}