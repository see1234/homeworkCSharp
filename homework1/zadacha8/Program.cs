Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int max = 0;
while(number != max) {
    max+=1;
   if(max % 2 == 0) {
    Console.Write(max + ",");
   }
}
Console.Write("\b ");
Console.WriteLine();