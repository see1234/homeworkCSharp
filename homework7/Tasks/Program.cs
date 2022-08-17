
//Task47(3, 4);
//Task50(3, 4);
Task52(4,4);

void Task52(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random rand = new Random();
            array[i, j] = rand.Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    double summa = 0.0;
    double avg = 0.0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            summa += array[i, j];
        }
        avg = Math.Round((summa / n), 1);
        summa = 0;
        Console.Write(avg + "; ");
    }
    Console.Write("\b\b.");
}

void Task50(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random rand = new Random();
            //Не получилось: "error CS1501: Ни одна из перегрузок метода "NextDouble" 
            //не принимает 2 аргументов."
            //array[i, j] = rand.NextDouble(-10.0, 10.0);
            array[i, j] = rand.Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Введи координату:");
    int x = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.WriteLine("Введи вторую координату:");
    int y = Convert.ToInt32(Console.ReadLine()) - 1;
    if (x + 1 > m || y + 1 > n)
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine("Ответ: " + array[x, y]);
    }

}


void Task47(int m, int n)
{
    double[,] array = new double[m, n];
    Console.WriteLine($"m = {m}, n = {n}");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random rand = new Random();
            //Не получилось: "error CS1501: Ни одна из перегрузок метода "NextDouble" 
            //не принимает 2 аргументов."
            //array[i, j] = rand.NextDouble(-10.0, 10.0);
            array[i, j] = rand.Next(-100, 100) / 10.0;
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}