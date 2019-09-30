using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Organisation org = new Organisation { Name = "ABC Training Co." };
			Trainer trainer = new Trainer();
			trainer.Organisation = org;
			Trainee t1 = new Trainee();
			Trainee t2 = new Trainee();
			Trainee t3 = new Trainee();
			Trainee t4 = new Trainee();
			Trainee t5 = new Trainee();
			Trainee t6 = new Trainee();

			Training traning = new Training();
			traning.Trainer = trainer;

			trainer.Trainees.Add(t1);
			trainer.Trainees.Add(t2);
			trainer.Trainees.Add(t3);
			trainer.Trainees.Add(t4);
			trainer.Trainees.Add(t5);
			trainer.Trainees.Add(t6);

			traning.Trainees.Add(t1);
			traning.Trainees.Add(t2);
			traning.Trainees.Add(t3);
			traning.Trainees.Add(t4);
			traning.Trainees.Add(t5);
			traning.Trainees.Add(t6);

			Course course = new Course();
			traning.Course = course;

			Module m1 = new Module();
			Module m2 = new Module();
			Module m3 = new Module();
			Module m4 = new Module();
			Module m5 = new Module();
			course.Modules.Add(m1);
			course.Modules.Add(m2);
			course.Modules.Add(m3);
			course.Modules.Add(m4);
			course.Modules.Add(m5);

			Unit u1 = new Unit { DurationHrs = 10 };
			m1.Units.Add(u1);
			Unit u2= new Unit { DurationHrs = 20 };
			m1.Units.Add(u2);
			Unit u3 = new Unit { DurationHrs = 40 };
			m1.Units.Add(u3);
			Unit u4 = new Unit { DurationHrs = 50 };
			m1.Units.Add(u4);

			Console.WriteLine(traning.GetTrainingOrganisationName());
			Console.WriteLine(traning.GetNumberOfTrainees());
			Console.WriteLine(traning.GetTrainingDurationHours());

		}
	}
}
