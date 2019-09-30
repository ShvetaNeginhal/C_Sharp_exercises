using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
	public class Training
	{
		//Training Has one Trainer
		public Trainer Trainer { get; set; }
		//training has many trainees
		public List<Trainee> Trainees { get; set; } = new List<Trainee>();
		//training has one course
		public Course Course { get; set; }
		public string GetTrainingOrganisationName()
		{
			return Trainer.Organisation.Name;
		}
		public int GetNumberOfTrainees()
		{
			return Trainees.Count;
		}
		public int GetTrainingDurationHours()
		{
			int totDuration = 0;
			//return Course.GetDuration();
			totDuration = Course.Modules.Sum(m => m.Units.Sum(u => u.DurationHrs));
			return totDuration;

		}
		


	}
}
