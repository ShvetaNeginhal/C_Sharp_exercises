using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
	public class Course
	{
		public List<Training> Trainings { get; set; } = new List<Training>();
		//Course has many modules
		public List<Module> Modules { get; set; } = new List<Module>();
		//public int GetDuration()
		//{
		//	int totalhrs = 0;
		//	foreach (var item in Modules)
		//	{
		//		totalhrs += item.GetDuration();	
		//	}
		//	return totalhrs;
		//}


	}
}
