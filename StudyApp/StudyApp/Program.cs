using System;
using Microsoft.SmallBasic.Library;
namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine(" hello in my turtle program");
            Console.WriteLine("----------------------------");
            Console.Write("input turtle speed not bigger than 9: ");
            int speed = Convert.ToInt32(Console.ReadLine());
            if (speed <= 9)
            {
                Console.Write("How much times turtle will drow a square: ");
                int times = Convert.ToInt32(Console.ReadLine());
                Turtle.Speed = speed;
                int i = 0;
                while (i < times)
                {
                    Turtle.Move(100);
                    Turtle.TurnRight();
                    Turtle.Move(100);
                    Turtle.TurnRight();
                    Turtle.Move(100);
                    Turtle.TurnRight();
                    Turtle.Move(100);
                    Turtle.TurnRight();
                    i++;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("faster than sonic!!");
                Console.ReadKey();
            }
            
        }
    }
}
