using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
	class Program
	{
		//Task 1 :Get sum of two numbers entered infinitely
		//Task 2 :Return the sum of only even numbers
		static void Main(string[] args)
		{
			int fno, sno, res = 0;
			while(true)
			{
				try
				{
					Console.WriteLine("enter first number");
					fno = int.Parse(Console.ReadLine());
					Console.WriteLine("enter second number");
					//Open db connection

					sno = int.Parse(Console.ReadLine());
					Calculator c = new Calculator();
					res = c.FindEvenSum(fno, sno);

					//res = fno / sno;
					Console.WriteLine("Sum of even numbers =" +res );
				}
				catch(FormatException ex)
				{
					Console.WriteLine("Enter numbers only!");
				}
				catch(OverflowException oex)
				{
					Console.WriteLine("Enter small numbers only!");
				}
				catch(DivideByZeroException dex)
				{
					Console.WriteLine("Divide by zero error");
				}
				//Custom Exception
				catch(NotEvenNumberException nex)
				{
					Console.WriteLine(nex.Message);
				}
				//To catch any type of Exception ---> catch all block
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);

				}
				finally
				{
					Console.WriteLine("In finally block");
				}

			}
			
		}
	}
}
