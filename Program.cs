using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnCloudsAlgorithm
{
    class Program
    {
        static int JumpingOnClouds(int[] c)
        {
            int counter = -1;

            for(int i = 0; i < c.Length; i++, counter++)
            {
                Console.WriteLine("First {0}",i);
                if(i < c.Length - 2 && c[i + 2] == 0)
                {
                    i++;
                  //  Console.WriteLine("Second: {0}",i);
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("testTwo.txt");
            Console.SetIn(reader);
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = JumpingOnClouds(c);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
