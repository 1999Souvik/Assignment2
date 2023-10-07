using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Sum_of_Element
    {
        static int Sum_of_Elements(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            
            int[] num = { 10, 20, 30, 40, 50 };

            int sum = Sum_of_Elements(num);

            Console.WriteLine("Sum of all elements in the array: " + sum);
            Console.ReadLine();
;        }
    }
}
