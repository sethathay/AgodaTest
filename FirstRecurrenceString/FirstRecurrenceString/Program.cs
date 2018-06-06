using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRecurrenceString
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputString = "ADBAD";
            //findFirstRecurringMethod1(inputString);
            findFirstRecurringMethod2(inputString);
            Console.ReadLine();
        }

        public static void findFirstRecurringMethod1(String inputString)
        {
            int lastIndex = inputString.Length - 1;
            for (int i = 0; i <= lastIndex; i++)
            {
                for (int j = i + 1; j <= lastIndex; j++)
                {
                    if (inputString[i] == inputString[j])
                    {
                        Console.WriteLine(inputString[j]);
                        return;
                    }
                }
                if (i == lastIndex)
                {
                    Console.WriteLine("Not Found");
                }
            }
        }

        public static void findFirstRecurringMethod2(String inputString)
        {
            Dictionary<Char, Int32> maps = new Dictionary<Char, Int32>();
            int lastIndex = inputString.Length - 1;
            for (int i = 0; i <= lastIndex; i++)
            {
                if (maps.ContainsKey(inputString[i]))
                {
                    Console.WriteLine(inputString[i]);
                    return;
                }
                else
                {
                    maps.Add(inputString[i], 1);
                }
                if (i == lastIndex)
                {
                    Console.WriteLine("Not Found");
                }
            }
        }
    }
}
