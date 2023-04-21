Console.WriteLine("Temperature(in celsius) \t Temperature(in Fahrenheit)");
for (int i = 1; i <= 10; i++)
{
    double C = double.Parse(Console.ReadLine());
    double F = (C * 9 / 5) + 32;
    Console.Write(C);
    Console.Write("\t\t\t\t"+F);
    Console.WriteLine();
}