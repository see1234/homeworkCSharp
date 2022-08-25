using MathUtils;

void Task64()
{
    Console.WriteLine("Задача 64:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("M = ");
    int M = Convert.ToInt16(Console.ReadLine());
    Console.Write("N = ");
    int N = Convert.ToInt16(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"M = {M}; N = {N}. -> \"{MathUtil.getAllNaturalNumbersAreMultiples(M, N, 3)}\"");
    /*
      Тестовый запуск
      Задача 64:
      M = 1
      N = 9
      M = 1; N = 9. -> "3, 6, 9" 
    */
}
void Task66()
{
    Console.WriteLine("Задача 66:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("M = ");
    int M = Convert.ToInt16(Console.ReadLine());
    Console.Write("N = ");
    int N = Convert.ToInt16(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"M = {M}; N = {N}. -> {MathUtil.getSumRangeFromTo(M, N)}");
    /*
      Тестовый запуск
      Задача 66:
      M = 1
      N = 15
      M = 1; N = 15. -> 120
    */
}
void Task68()
{
    Console.WriteLine("Задача 68:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("m = ");
    int M = Convert.ToInt16(Console.ReadLine());
    Console.Write("n = ");
    int N = Convert.ToInt16(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"m = {M}, n = {N} -> A(m,n) = {MathUtil.functionAckermann(M, N)}");
    /*
      Тестовый запуск
      Задача 68:
      m = 2
      n = 3
      m = 2; n = 3. -> 9
    */
}

//Task64();
//Task66();
//Task68();
void main()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Выберите задачу по индексу:");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("1: Задача 64");
    Console.WriteLine("2: Задача 66");
    Console.WriteLine("3: Задача 68");
    int index = Convert.ToInt16(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Red;
    if (index == 1 || index == 64) Task64();
    else if (index == 2 || index == 66) Task66();
    else if (index == 3 || index == 68) Task68();
    Console.ForegroundColor = ConsoleColor.White;
}
main();