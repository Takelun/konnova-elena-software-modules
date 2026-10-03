class Program
{
    static void Main()
    {
        Console.Write("p1 =  ");
        double p1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("p2 = ");
        double p2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("p3 = ");
        double p3 = Convert.ToDouble(Console.ReadLine());

        double A = (p1 + p2 + p3) / 3.0;
        double G = Math.Pow(p1 * p2 * p3, 1.0 / 3.0);

        Console.WriteLine($"Среднее арифметическое A = {A:F4}");
        Console.WriteLine($"Среднее геометрическое G = {G:F4}");
        Console.ReadKey();
    }
}
