using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building SmallHouse = new Building("с. ольховка, ул. Ленина, д1", 5, 4, 6);
            MultiBuilding BigHouse = new MultiBuilding("г. Калинин, ул. Ленина, д3", 25, 15, 20, 6);

            Console.WriteLine("Маленький дом: ");
            SmallHouse.Print();
            Console.WriteLine("");
            Console.WriteLine("Большой дом: ");
            BigHouse.Print();
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
