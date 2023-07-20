using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowGreatestvalue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,max, n;
            int[] a = new int[5];

            Console.Write("Input the five number of integers  :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} number of integers in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("integer {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The values store into the array are : ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}  ", a[i]);
            }

            max = a[0];

            for (i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }

            }
            Console.WriteLine("Maximum element is : {0}", max);
           
        }
    }
    
}
