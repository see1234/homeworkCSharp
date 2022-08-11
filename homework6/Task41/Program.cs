Console.WriteLine("Введите количество чисел:");
int size = Convert.ToInt16(Console.ReadLine());
int count = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите №{i + 1} число:");
    if (Convert.ToInt16(Console.ReadLine()) > 0) count += 1;
}
Console.WriteLine("Ответ: " + count);