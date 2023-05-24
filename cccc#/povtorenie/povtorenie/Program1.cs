using povtorenie;
using System;
using System.Collections.Generic;

namespace project
{
    class Program1
    {
        static void Main()
        {
            //Bot bot = new Bot("Bot", 800, new byte[] { 0, 0, 0 });
            //bot.setValues();
            //bot.printValues();

            //Killer killer = new Killer("Killer", 1000, new byte[] { 0, 0, 1 }, 100, povtorenie.Type.Enemy);
            //////bot.setValues();
            //killer.printValues();
            //////killer.Health = 100;
            //killer.Lazer();

            //Bot bot1 = new Bot();
            //bot1.Weight = -100;
            //Console.WriteLine(bot1.Weight);

            //bot1.Width = -100;
            //Console.WriteLine(bot1.Width);

            //Robot.count = 5;

            //Robot.Print();
            //урок 19
            //List<Killer> robots = new List<Killer>();
            //robots.Add(new Killer("Alex", 500, new byte[] {10,12,15}, 100));
            //robots.Add(new Killer("Bobi", 600, new byte[] { 12, 10, 15 }, 100));
            //robots.Add(new Killer("Shiki", 200, new byte[] { 12, 15, 15 }, 100));
            //robots.Add(new Killer("Adrew", 1000, new byte[] { 12, 15, 10 }, 100));

            //Robot newRobot = null;
            //foreach(Killer obj in robots)
            //{
            //    if (obj.Name == "Bobi")
            //    {
            //        newRobot = obj as Robot;
            //    }
            //    Console.WriteLine(obj is Robot);
            //}
            //Multiply(5, 6);
            Book idiot = new Book();
            idiot.setValues("Идиот", "Федор Достоевский");
            idiot.printValues();
        }
        //public static void Multiply(int a, int b)
        //{
        //    int res = a * b;
        //    Console.WriteLine("Result: " + res);
        //}
        //public static void Multiply(float a, float b)
        //{
        //    float res = a * b;
        //    Console.WriteLine("Result: " + res);
        //}
    }
}