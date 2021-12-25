using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_1
{
    public class Building
    {

        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Heitght = height;
        }
       
        public string Address { get; set; } 
        public double Length { get; set; } 
        public double Width { get; set; }  
        public double Heitght { get; set; } 
                
        public void Print()
        {
            
            Console.Write($"Здание длинной {Length}, шириной {Width}, высотой {Heitght}, по адерсу {Address}");

        }

    }
}
