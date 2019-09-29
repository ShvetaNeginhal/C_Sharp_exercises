using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] val = new int[10];
            int[] val = { 4, 6, 77 };
            Array.Sort(val);
            Array.Reverse(val);
            int[] evenval = new int[val.Length];
            //Console.WriteLine(val.Sum());
            ////Console.WriteLine(val[2]);
            var evens = (from n in val where n % 2 == 0 select n).ToArray<int>();

            foreach (int v in evens)
            {
                Console.WriteLine(v);
            }
            
        }
    }
}
