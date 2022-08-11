namespace Utils
{
    public class Util
    {
        public string printArray(double[] array)
        {
            string str = "[";
            foreach (double number in array)
            {
                str += Convert.ToString(number) + " ";
            }
            str = str + "\b]";
            return str;
        }
        public double findMax(double[] array)
        {
            double max = array[0];
            foreach (double i in array)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
        public double findMin(double[] array)
        {
            double min = array[0];
            foreach (double i in array)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
        public int getNumberOnPositionNoEven(int[] array)
        {
            int count = 0;
            int allcount = 0;
            foreach (int number in array)
            {
                if (count % 2 != 0)
                {
                    allcount += number;
                }
                count++;
            }
            return allcount;
        }

        public string printArray(int[] array)
        {
            string str = "[";
            foreach (int number in array)
            {
                str += Convert.ToString(number) + ", ";
            }
            str = str + "\b\b]";
            return str;
        }
        public int getCountEvenNumber(int[] array)
        {
            int count = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0) count++;
            }
            return count;
        }
    }
}