using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Math
    {
        public double Sum(double[] numbers)
        {
            var result = 0.0;
            foreach (var elm in numbers)
            {
                result += elm;
            }
            return result;
        }
        public int Count(double[] numbers)
        {
            return numbers.Length;
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
        public static double Fact(double numder)
        {
            double res = 1;
            int n = (int)numder + 1;
            for (int i = 2; i < n; ++i)
                res *= i;
            return res;
        }
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Mult(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Div(double num1, double num2){
            return num1 / num2;
        }
        public
    }
}