using povtorenie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    abstract class Robot : IRun, IJump
    {
        private static int count;

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            private set { }
        }


        private int weight;

        private byte[] coordinates;

        public byte[] Coordinates
        {
            get { return coordinates; }
            private set { }
        }

        protected string surname;

        public int Weight
        {
            get
            {
                Console.Write("Результат: ");
                return this.weight;
                //при получении данных будет срабатывать
                //возвращает значение
            }
            set
            {
                if(value < 1)
                    this.weight = 1;
                else if(value > 500)
                    this.weight = 500;
                else
                    this.weight = value;
                //будет срабатывать при устаовке
                //которое будет передавать пользователь
            }
        }

        public int Width
        {
            get;
            set;
        }
        public float speed { get; set; }
        public float y { get; set; }

        public Robot(string name, int weight, byte[] coordinates) 
        {
            Console.WriteLine("Obj has been created");
            this.setValues(name, weight, coordinates);
            count++;
        }

        public Robot(string name)
        {
            Console.WriteLine("Obj has been created");
            this.name= name;
            count++;
        }
        public Robot()
        {
            count++;
        }

        public void setValues(string name, int weight, byte[] coordinates)
        {
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }
        public void setValues(string name)
        {
            this.name = name;
        }
        public void setValues(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public abstract void printValues();

        public static void Print()
        {
            Console.WriteLine("Count: " + count);
        }

        public void RobotRun()
        {
            Console.WriteLine("Robot is now runnig");
        }

        public void Jump()
        {
            Console.WriteLine("Robot is now jumping");
        }
    }
}
