using System;
using System.Linq;

namespace Kata7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] SortArray(int[] array)
        {
            int[] oddNumbers = array
                .Where(num => num % 2 != 0)
                .OrderBy(oddNum => oddNum)
                .ToArray();

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    array[i] = oddNumbers[j];
                    j++;
                }
            }

            return array;
        }
    }
}
