Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine().Replace("-", ""));
int result = number;
 
char[] massivnumber = Convert.ToString(number).ToCharArray();
int lenghtmassiv = massivnumber.Length - 3;
 
if (massivnumber.Length <= 2) 
{
        Console.WriteLine("третьей цифры нет");
}
else
{
        while(lenghtmassiv != 0) {
          result /= 10;
          lenghtmassiv-=1;
        }
        result = result % 10;
        Console.WriteLine($"{result}");
}