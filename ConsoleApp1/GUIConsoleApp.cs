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
            Max = 3,
            Min = 4,
            Factorial = 5,
            Add = 6,
            Sub = 7,
            Mult = 8,
            Div = 9,
            Precent = 10,
            Depercent = 11,
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
                                  $"$4 Min\n" +
                                  $"$5 Factorial\n" +
                                  $"$6 Add\n" +
                                  $"$7 Sub\n" +
                                  $"$8 Mult\n" +
                                  $"$9 Div\n" +
                                  $"$10 Precent\n" +
                                  $"$11 Depercent\n");
                Console.Write("Please enter your Command: ");
                Command command = (Command)int.Parse(Console.ReadLine());

                double[] array = new double[] { 4, 5, 6 };
                if (command == Command.Exit)
                    break;
                else if (command == Command.Sum)
                    Console.WriteLine($"Sum:{clsMath.Sum(array)}");
                else if (command == Command.Count)
                    Console.WriteLine($"Сount:{clsMath.Count(array)}");
                else if (command == Command.Max)
                    Console.WriteLine($"Max: {clsMath.Max(array)}");
                else if (command == Command.Min)
                    Console.WriteLine($"Min: {clsMath.Min(array)}");
                else if (command == Command.Factorial)
                    Console.WriteLine($"Factorial: {clsMath.Fact(array)}");
                else if (command == Command.Add)
                    Console.WriteLine($"Add: {clsMath.Add(array)}");
                else if (command == Command.Sub)
                    Console.WriteLine($"Sub: {clsMath.Sub(array)}");
                else if (command == Command.Mult)
                    Console.WriteLine($"Mult: {clsMath.Mult(array)}");
                else if (command == Command.Div)
                    Console.WriteLine($"Div: {clsMath.Div(array)}");
                else if (command == Command.Precent)
                    Console.WriteLine($"Precent: {clsMath.Precent(array)}");
                else if (command == Command.Depercent)
                    Console.WriteLine($"Depercent: {clsMath.Depercent(array)}");
            }
        }
    }
}