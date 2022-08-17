//Task54(4, 4);
//Task56(4,4);
Task58(4,4);
void Task54(int m, int n)
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
    Console.WriteLine("Отсортированный:");
    Sort(array);
}
void Task56(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        Console.Write(i + 1 + ": ");
        for (int j = 0; j < n; j++)
        {
            Random rand = new Random();
            array[i, j] = rand.Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("номер строки с наименьшей суммой элементов: " + FindStringMinNumber(array));
}

int FindStringMinNumber(double[,] array)
{
    int stringnumber = 1;
    double summax = 0;
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum > summax)
        {
            summax = sum;
            stringnumber = i;
        }
        sum = 0;

    }
    return stringnumber + 1;
}
void Sort(double[,] arr)
{
    double[] array = new double[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[j] = arr[i, j];

        }
        Array.Sort(array);
        Array.Reverse(array);

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(array[j] + " ");


        }
        Console.WriteLine();
        array = new double[arr.GetLength(0)];
    }

}
void Task58(int m = 4, int n = 4)
{
    


    int s = 1;


    int[,] array = new int[m, n];

    for (int y = 0; y < n; y++)
    {
        array[0,y] = s;
        s++;
    }
    for (int x = 1; x < m; x++)
    {
        array[x,n - 1] = s;
        s++;
    }
    for (int y = n - 2; y >= 0; y--)
    {
        array[m - 1,y] = s;
        s++;
    }
    for (int x = m - 2; x > 0; x--)
    {
        array[x,0] = s;
        s++;
    }


    int c = 1;
    int d = 1;

    while (s < m * n)
    {

        while (array[c,d + 1] == 0)
        {
            array[c,d] = s;
            s++;
            d++;
        }


        while (array[c + 1,d] == 0)
        {
            array[c,d] = s;
            s++;
            c++;
        }
        while (array[c,d - 1] == 0)
        {
            array[c,d] = s;
            s++;
            d--;
        }

        while (array[c - 1,d] == 0)
        {
            array[c,d] = s;
            s++;
            c--;
        }
    }


    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            if (array[x,y] == 0)
            {
                array[x,y] = s;
            }
        }
    }

    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            if (array[x,y] < 10)
            {
                Console.Write(array[x,y] + "  ");
            }
            else
            {
                Console.Write(array[x,y] + " ");
            }
        }
        Console.WriteLine("");
    }

}
