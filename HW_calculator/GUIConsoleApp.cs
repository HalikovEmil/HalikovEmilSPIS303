using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class GUIConsoleApp
    {
        public enum Command
        {
            Exit = 0,
            Sum = 1,
            Count = 2,
            Max,
            Min,
            Factorial,
            add,
            Sub,
            Mult,
            Precent,
            Depercent,
        }

        Math clsMath = new Math();

        internal void GetGUI()
        {
            while (true)
            {
                Console.WriteLine($"|Select Command From List|\n" +
                                  $"$0 for Exit\n" +
                                  $"$1 Sum\n" +
                                  $"$2 Count \n" +
                                  $"$3 Max\n" +
                                  $"$4 Min\n");
                Console.Write("Please enter your Command: ");
                Command command = (Command)int.Parse(Console.ReadLine());


                double[] array = new double[] { 4, 5, 6 };
                if (command == Command.Exit)
                    break;
                else if (command == Command.Sum)
                    Console.WriteLine($"Sum:{clsMath.Sum(array)}");
                else if (command == Command.Count)
                    Console.WriteLine($"count:{clsMath.Count(array)}");
            }
        }
    }
}