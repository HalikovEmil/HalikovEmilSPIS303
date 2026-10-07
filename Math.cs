using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Math
    {
        public double Div(double num1, double num2){
            return num1 / num2;
        }
        public double Mult(double num1, double num2)
        {
            return num1 * num2;
        }
        public double add(double num1, double num2){
            return num1 + num2;
        }
        public double sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Sum(double[] numbers)
        {
            var result = 0.0;
            foreach (var elm in numbers)
            {
                result += elm;
            }
            return result;
        }
        public double Max(double[] numbers)
        {
            var result = 0.0;
            foreach (var elm in numbers)
            {
                if (elm > result)
                {
                    result = elm;
                }
            }
            return result;
        }

        public double Min(double[] numbers)
        {
            var result = 0.0;
            foreach (var elm in numbers)
            {
                if (elm < result)
                {
                    result = elm;
                }
            }
            return result;
        }

        public int Count(double[] numbers)
        {
            return numbers.Length;
        }
    }
}