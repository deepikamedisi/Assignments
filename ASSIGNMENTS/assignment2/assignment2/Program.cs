using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Array_prog
    {
        public static void Avgofarray()
        {
            Console.WriteLine("enter the size of an array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("enter the elements of an array");
            for (int i=0; i<size;i++)
            {
                Console.Write($"Enter element {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
             
            }
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"average of an array {arr.Average()}");
            Console.WriteLine($"The maximum value {arr.Max()}");
            Console.WriteLine($"The minimum value {arr.Min()}");

        }

        public static void marks()
        {
            int[] ar = new int[10];
            Console.WriteLine("enter the elements of an array");
            for (int j = 0; j < ar.Length; j++)
            {
               Console.Write($"Enter element {j}: ");
               ar[j] = Convert.ToInt32(Console.ReadLine());
            }
            int total = 0;
            for (int j = 0; j < ar.Length; j++)
            {
                total = total + ar[j];
            }

            Console.WriteLine($"The total marks is {total}");
            Console.WriteLine($"average of the total marks is {ar.Average()}");
            Console.WriteLine($"minimum mark {ar.Max()}");
            Console.WriteLine($"maximum mark {ar.Min()}");

            Array.Sort(ar);
            Console.Write("Ascending order of an array is : ");
            for(int j=0;j<ar.Length;j++)
            {
                
                Console.WriteLine($" {ar[j]}");
            }
            Array.Reverse(ar);
            Console.WriteLine("Descending order of an array is :");
            for(int j=0;j<ar.Length;j++)
            {
                Console.WriteLine($" {ar[j]}");
            }
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Array_prog.Avgofarray();
            Array_prog.marks();
        }

    }
}
