using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnCloudsAlgorithm
{
    class Program
    {
        static int JumpingOnClouds(int[] c)
        {
            int counter = 0;

            for(int i = 0; i < c.Length; i++)
            {
                if(c[i] == 0)
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = JumpingOnClouds(c);

            Console.WriteLine(result);
        }
    }
}
