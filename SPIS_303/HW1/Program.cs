using Leason1;

Console.Write("Введите первое число... ");
string number1 = Console.ReadLine();
Console.Write("Введите второе число... ");
string number2 = Console.ReadLine();

Console.WriteLine("Выберите операцию: ");
Console.WriteLine("1. Sum");
Console.WriteLine("2. Sub");
Console.WriteLine("3. Mult");
Console.WriteLine("4. Dev");

string OP = Console.ReadLine();

if (OP == "1")
{
    double res = Leason1.Math.Sum(int.Parse(number1), int.Parse(number2));

    Console.WriteLine(res);
}
else if (OP == "2")
{
    double res = int.Parse(number1) - int.Parse(number2);

    Console.WriteLine(res);
}
else if (OP == "3")
{
    double res = int.Parse(number1) * int.Parse(number2);

    Console.WriteLine(res);
}
else if (OP == "4")
{
    double res = int.Parse(number1) / int.Parse(number2);

    Console.WriteLine(res);
}
