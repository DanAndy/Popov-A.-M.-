using project;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace povtorenie
{
    class Bot : Robot
    {
        public Bot()
        {

        }
        public Bot(string name, int weight, byte[] coordinates) : base(name, weight, coordinates)
        {

        }

        public override void printValues()
        {
            Console.WriteLine(this.Name + " weight: " + this.Weight + ". Coordinates: ");
            foreach (byte el in this.Coordinates)
            {
                Console.WriteLine(el);
            }

        }
    }
}
