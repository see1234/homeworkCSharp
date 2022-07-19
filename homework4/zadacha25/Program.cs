Console.WriteLine("Введите число A");
int numberA = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Результат: " + pow(numberA, numberB));
int pow(int number, int pow) {
    int count = 1;
    int pows = number;
    while(pow > count) {
        count+=1;
        number=number*pows;
    }
    return number;
}
  
