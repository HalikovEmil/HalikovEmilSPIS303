using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Math
    {
        // 1. Сумма нескольких элем.
        public double Sum(double[] numbers)
        {
            var result = 0.0;
            foreach (var elm in numbers)
            {
                result += elm;
            }
            return result;
        }
        // 2. Кол-во элементов
        public int Count(double[] numbers)
        {
            return numbers.Length;
        }
        // 3. Максимальный
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
        // 4. Минимальное
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
        // 5. Факториал
        public double Fact(double[] numbers)
        {
            double res = 1;
            int n = (int)numbers[0] + 1;
            for (int i = 2; i < n; ++i)
                res *= i;
            return res;
        }
        // 6. Сумма элементов
        public double Add(double[] numbers)
        {
            return numbers[0] + numbers[1];
        }
        // 7. Вычесть элименты
        public double Sub(double[] numbers)
        {
            return numbers[0] - numbers[1];
        }
        // 8. Перемножить элиенты
        public double Mult(double[] numbers)
        {
            return numbers[0] * numbers[1];
        }
        // 9. Разделить элименты
        public double Div(double[] numbers)
        {
            return numbers[0] / numbers[1];
        }
        // 10. Процент второго числа от первого
        public double Precent(double[] numbers)
        {
            return (numbers[0] / numbers[1]) * 100;
        }
        // 11. Процент от числа
        public double Depercent(double[] numbers)
        {
            return numbers[0] * numbers[1] / 100.0;
        }
    }
}