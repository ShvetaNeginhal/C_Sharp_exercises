using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
	public class Unit
	{
		public int DurationHrs;
		public List<Topic> Topics { get; set; } = new List<Topic>();
		//public int GetDurationHours()
		//{
		//	return DurationHrs;
		//}
	}
}
