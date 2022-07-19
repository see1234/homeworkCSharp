int[] array = new int[8] {51,-21,5,-1,1, 23, -32, -4};
SortArray(array);
void SortArray(int[] array) {
    for (int i = 1; i < array.Length; i++)
    {
        int cur = array[i];
        int j = i;
        while (j > 0 && cur < Math.Abs(array[j - 1]))
        {
            array[j] = array[j - 1];
            j--;
        }
        array[j] = cur;
    }
}
Console.Write("[ ");
foreach(int i in array) {
    Console.Write(i + ", ");
}
Console.Write("\b\b ]");