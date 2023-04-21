for(int i = 1; i <= 10; i++)
{
    Console.WriteLine("Enter the temperature in Degree Celsius");
    double C = double.Parse(Console.ReadLine());
    double F = (C * 9 / 5) + 32;
    Console.WriteLine($"Temperature(in celsius) {C} is Equivalent to Temperature(in Fahrenheit) {F}");
}