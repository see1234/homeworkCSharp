Console.WriteLine("Введите число a");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB) {
    Console.WriteLine("Максимальное число " + numberA);
    Console.WriteLine("Минимальное число " + numberB);
}
else if(numberA == numberB) {
       Console.WriteLine("Числа одинаковые - " + numberA);
 
}
else {
        Console.WriteLine("Максимальное число " + numberB);
    Console.WriteLine("Минимальное число " + numberA);
}