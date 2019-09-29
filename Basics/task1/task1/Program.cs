using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
			double[] arr1 = new double[] { 10.0, 20.0, 30.0};

			double[] arr2 = { 20.0, 50.0, 30.0, 70.0, 80.0 };
			int big;
			if (arr2.Length > arr1.Length)
				big = arr2.Length;
			else
				big = arr1.Length;
			Array.Resize<double>(ref arr1, big);
			//Console.WriteLine(arr1.Length);	
			//Console.WriteLine(arr1[4]);

			int[] arr3 = new int[big];

			for (int i = 0; i < big; i++)
			{
				arr3[i] = Convert.ToInt16((arr1[i] + arr2[i]));
			}
			foreach (var item in arr3)
			{
				Console.WriteLine(item);
			}

        }
    }
}
