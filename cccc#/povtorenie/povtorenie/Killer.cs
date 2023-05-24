using project;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace povtorenie
{
    enum Type
    {
        Enemy, Hero, Traitor
    }
    class Killer : Robot
    {

        public Type type;
        public int Health { get; set; }

        public Killer()
        {

        }
        public Killer(string name, int weight, byte[] coordinates, int health, Type type) : base(name, weight, coordinates)
        {
            this.Health = health;
            this.type = type;
        }

        public override void printValues()
        {
            Console.WriteLine(this.Name + " weight: " + this.Weight);

            if(this.type == Type.Hero)
            {
                Console.WriteLine("He is hero!");
            }
            else { Console.WriteLine("He not hero"); }
        }
        public void Lazer()
        {
            Console.WriteLine("Lazer shoting");
            this.surname = "Doe";
            Console.WriteLine(surname);
        }
    }
}
