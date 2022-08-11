Console.WriteLine();
Console.Write("k1 = ");
int k1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();
Console.Write("k2 = ");
int k2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();
Console.Write("b1 = ");
int b1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();
Console.Write("b2 = ");
int b2 = Convert.ToInt16(Console.ReadLine());

getResult(k1, k2, b1, b2);
void getResult(double k1 = 0, double k2 = 0, double b1 = 0, double b2 = 0)
{

    if (k1 != k2)
    {
        double x;
        x = (b2 - b1) / (k1 - k2);
        Console.WriteLine($"Точка пересечения: ({Math.Round(x, 2)}; {Math.Round(k1 * x + b1, 2)})");
    }
    else if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine($"Две прямые полностью равны");
    }
    else if (k1 == k2)
    {
        Console.WriteLine($"Две прямые не пересекаются");
    }

}



