using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionTest
{
	class Program 
	{

		
		static void Main(string[] args)
		{
			int[] arr = new int[10];
			int a, b, res,n;
			try
			{
				Console.WriteLine("Enter a number < 10");
				n = int.Parse(Console.ReadLine());
				for (int i = 0; i < n; i++)
				{
					arr[i] = 244;
				}
				
				Console.WriteLine("Enter  two integers");
				a = int.Parse(Console.ReadLine());
				b = int.Parse(Console.ReadLine());
				res = a / b;
				Console.WriteLine("Division = " + res);

			}
			//catch(IndexOutOfRangeException iex)
			//{
			//	Console.WriteLine("Index Out of range exception");
			//	//Console.WriteLine(iex.Message);
			//	//Console.WriteLine(iex.StackTrace);
			//	//Console.WriteLine("/n");
			//	//Console.WriteLine(iex.ToString());
			//}
			//catch(DivideByZeroException dex)
			//{
			//	Console.WriteLine("Divide by zero exception");
			//}
			catch(Exception ex)
			{
				Console.WriteLine("Invalid input!");
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
			}
	
		}
	}
}
