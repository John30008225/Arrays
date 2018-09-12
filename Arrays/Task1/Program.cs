using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            int i;
            Console.Write("\n\nRead and Print elements of an array:\n");

            Console.Write("Add 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("Array {0} : ", i);
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", nums[i]);

            }
            Console.ReadLine();
            Console.Write("\n");
        }
    }
}
