Console.WriteLine("Введите число пятизначное, оно проверит является ли ваше число палиндромом");
string[] number = new string[5];
int count = 0;
foreach(char i in Console.ReadLine()) {
    
number[count] = i.ToString();
count+=1; 
}
if((number[0] + number[1]) == (number[4] + number[3])) {
    Console.WriteLine("да");
}
else {
    Console.WriteLine("нет");
}