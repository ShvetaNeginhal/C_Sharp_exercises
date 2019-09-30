using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
	public class Module
	{

		public List<Unit> Units { get; set; } = new List<Unit>();
		//public int GetDuration()
		//{
		//	int totalhrs = 0;
		//	foreach (var item in Units)
		//	{
		//		totalhrs += item.GetDurationHours();
		//	}
		//	return totalhrs;
		//}
	}
}
