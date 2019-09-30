using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddUniqueRandomNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			//To add unique random nos into any suitable collections and display

			//Using List
			//List<int> Numbers = new List<int>();
			//int sum=0;
			Random random = new Random();
			//for (int i = 0; i<25; i++)
			//	{
			//	int num = random.Next(100);
			//	if (!Numbers.Contains(num))
			//		Numbers.Add(num);
			//	Console.WriteLine(num);
			//	}
			
			//foreach (var item in Numbers)
			//{
			//	sum = sum + item;
			//}
			//Console.WriteLine("Sum=" + sum);


			//Using Hashset
			HashSet<int> UNumbers = new HashSet<int>();
			int count = 25,h_sum = 0;
			while(count !=0)
			{
				UNumbers.Add(random.Next(100));
				count--;
			}
			foreach (var item in UNumbers)
			{
				Console.WriteLine(item);
			}
			foreach (var item in UNumbers)
			{
				h_sum += item;
			}
			Console.WriteLine("Sum Using HashSet = " + h_sum);
}
	}

}
