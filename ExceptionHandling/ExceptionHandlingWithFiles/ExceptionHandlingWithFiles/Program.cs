using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandlingWithFiles 
{
	class Program
	{
		
		static void Write(string filename, string message)
		{
			StreamWriter sw = new StreamWriter(filename);
			try
			{
				
				//if (!File.Exists(filename))
				//{
					throw new IOException();
				//}

				sw.WriteLine(message);
				
				Console.WriteLine("Data written");
			}

			catch (IOException iex)
			{
				
				Console.WriteLine("IO Exception Occured!");
				
			}
			finally
			{
				sw.Close();
				Console.WriteLine("Calling to close");
			}
		}

		 
		static void Main(string[] args)
		{

			Write("d.txt", "Good Morning.");
		}
	}
}
