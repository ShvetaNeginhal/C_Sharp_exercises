using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceEvaluation
{
	class Student : Person
	{
		public double Percentage { get; set; }
		public void Display()
		{
			Console.WriteLine("Name:" + Name);
			Console.WriteLine("Precentage" + Percentage);
		}
		public override bool IsOutStanding()
		{
			if(Percentage >85)
				return true;
			else
				return false;
		}
	}
}
