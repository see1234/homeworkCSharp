Console.WriteLine("Введите число");
Console.WriteLine(sum(Convert.ToInt64(Console.ReadLine())));
long sum(long number)
{
    long sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}