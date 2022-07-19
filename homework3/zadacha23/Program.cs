Console.WriteLine("Введите число ");
int number = Convert.ToInt16(Console.ReadLine());
Cubic(number);
void Cubic(int number) {
    for(int i = 1; i <= number; i++) {
        Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
    }
 
}