using Utils;
Random rand = new Random();
double[] array = new double[] { 3.21, 7.04, 22.93, -2.71, 78.24 }; //примерный массив
Util utils = new Util();
Console.WriteLine(utils.printArray(array) + " -> " + Math.Round(Math.Abs(Math.Abs(utils.findMax(array)) - Math.Abs(utils.findMin(array))), 2));
