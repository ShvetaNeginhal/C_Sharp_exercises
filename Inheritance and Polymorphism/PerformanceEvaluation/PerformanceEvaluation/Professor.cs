using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceEvaluation
{
	class Professor : Person
	{
		
		public int BooksPublished { get; set; }
	
		public void print()
		{
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine("Books Published " + BooksPublished);

		}
		public override bool IsOutStanding()
		{
			if (BooksPublished > 4)
				return true;
			else
				return false;
		}

	}
}
