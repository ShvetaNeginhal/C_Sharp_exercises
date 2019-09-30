using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
	public class Trainee
	{
		public string Name { get; set; }

		//Trainee has one Trainer
		public Trainer Trainer { get; set; }
		//trainee has many trainings
		public List<Training> Trainings { get; set; } = new List<Training>();
	}
}
