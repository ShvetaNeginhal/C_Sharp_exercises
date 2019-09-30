using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
	public class Trainer
	{
		//Has-a relation ship ----> trainer HAS ONE organisation
		public Organisation Organisation { get; set; }

		////Trainer has 26 trainees
		//Trainee[] trainees = new Trainee[26];

		//Trainer HAS MANY trainees
		//Use Dynamic Collection -- list
		public List<Trainee> Trainees { get; set; } = new List<Trainee>();

		//Trainer HAS MANY trainings
		public List<Training> Trainings { get; set; } = new List<Training>();
	}
}
