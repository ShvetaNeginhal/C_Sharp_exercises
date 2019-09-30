using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceEvaluation
{
	abstract class Person
	{
		public string Name { get; set; }
		abstract public bool IsOutStanding();

	}
}
