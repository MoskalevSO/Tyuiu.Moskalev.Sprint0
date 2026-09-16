using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MoskalevSO.Sprint0.Task3.V0.Lib;

namespace Tyuiu.MoskalevSO.Sprint0.Task3.V0
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine(DataService.Sum(7, 7));
            Console.ReadKey();
        }
    }
}