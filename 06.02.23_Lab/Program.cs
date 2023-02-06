using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06._02._23_Lab;

namespace _06._02._23_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City a = new City("Odessa", "Ukraine", 1000000, "+380", "Primorskiy, Kievskiy, Malinovskiy, Suvorivskiy") ;
            Console.WriteLine(a);
            Console.WriteLine();
            a.Name = "Одесса";
            a.Country = "Украина";
            a.Count = 1015826;
            a.Key = "+38048";
            a.Areas = "Приморский, Киевский, Малиновский, Суворовский";
            a.Print();
        }
    }
}
