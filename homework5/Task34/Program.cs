using Utils;
Random rand = new Random();
int[] array = new int[] { rand.Next(100, 1000), rand.Next(100, 1000),
 rand.Next(100, 1000), rand.Next(100, 1000) }; //примерный массив
Util utils = new Util();
Console.WriteLine(utils.printArray(array) + " -> " + utils.getCountEvenNumber(array));

 