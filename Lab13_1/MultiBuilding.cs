using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_1
{    
    public sealed class MultiBuilding : Building 
    {        
        public MultiBuilding(string address, double length, double width, double height, int stories) : base(address, length, width, height)
        {            
            Stories = stories;
        }
               
        public int Stories { get; set; }
                
        public new void Print()
        {            
            base.Print();
            Console.Write($", имеющее {Stories} этажей");
        }

    }
}
