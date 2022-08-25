using System;


namespace MathUtils
{
    class MathUtil
    {

        public static string getAllNaturalNumbersAreMultiples(int m, int n, int multiples = 3, string result = "")
        {
            if (m > n)
            {
                result += "\b\b";
                return result;
            }
            if (m % 3 == 0)
            {
                result += m + ", ";
                m += 3;
            }
            else m += 1;
            return getAllNaturalNumbersAreMultiples(m, n, multiples, result);
        }
        public static int getSumRangeFromTo(int from, int to, int sum = 0)
        {
            if (from == to + 1) return sum;
            sum += from;
            from += 1;
            return getSumRangeFromTo(from, to, sum);
        }
        public static int functionAckermann(int m, int n, int answer = 0)
        {
            if (m == 0) answer = n + 1;
            else if (n == 0) answer = functionAckermann(m - 1, 1);
            else answer = functionAckermann(m - 1, functionAckermann(m, n - 1));
            return answer;
        }
    }
}