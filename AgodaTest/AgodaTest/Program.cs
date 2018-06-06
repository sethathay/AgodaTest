using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgodaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = {1,4,2,6,1,2};
            int[] result = RemoveDuplicateNumber(data);
            for (int j = 0; j < result.Length; j++) {
                Console.WriteLine(result[j]);
            }

            Console.WriteLine("==========================");

            int combination = CountCombination(5);
            Console.WriteLine(combination);
            Console.ReadLine();
        }

        public static int[] RemoveDuplicateNumber(int[] inputArray) {
            Dictionary<int, int> tempValue = new Dictionary<int, int>();
            for (int i = 0; i < inputArray.Length; i++) { 
                if(!tempValue.ContainsKey(inputArray[i])){
                    tempValue.Add(inputArray[i], 1);
                }            
            }
            return tempValue.Keys.ToArray();
        }

        static int CountStair(int n) {
            if (n <= 1) {
                return n;
            }
            return CountStair(n - 1) + CountStair(n - 2);
        }

        public static int CountCombination(int numberOfStair) {
            return CountStair(numberOfStair + 1);
        }
    }
}
