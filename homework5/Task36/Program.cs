Random rand = new Random();
int[] array = new int[] { rand.Next(1, 1000), rand.Next(1, 1000),
 rand.Next(1, 1000), rand.Next(1, 1000) }; //примерный массив
Console.WriteLine(printArray(array) + " -> " + getCountEvenNumber(array));

int getCountEvenNumber(int[] array) {
    int count = 0;
    int allcount = 0;
    foreach(int number in array) {
        if(count % 2 != 0) {
            allcount+=number;
        }
        count++;
    }  
    return allcount;
}

string printArray(int[] array) {
    string str = "[";
    foreach(int number in array) {
        str+=Convert.ToString(number) + ", ";
    }  
    str=str + "\b\b]";
    return str;
}