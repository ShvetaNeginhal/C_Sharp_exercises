using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceEvaluation
{
	class Program
	{
		static void Main(string[] args)
		{
			Professor p1 = new Professor { Name = "ABC", BooksPublished = 4 };
			Professor p2 = new Professor { Name = "XYZ", BooksPublished = 6 };
			Professor p3 = new Professor { Name = "MNO", BooksPublished = 9 };
			Student s1 = new Student { Name = "rita", Percentage = 90 };
			Student s2 = new Student { Name = "reema", Percentage = 75 };
			Student s3 = new Student { Name = "prada", Percentage = 95 };

			List<Person> People = new List<Person>();
			People.Add(p1);
			People.Add(p2);
			People.Add(p3);
			People.Add(s1);
			People.Add(s2);
			People.Add(s3);

			//Down-Casting 
			for (int i = 0; i < People.Count; i++)
			{
				if(People[i].IsOutStanding())
				{	//Check if person is student or professor
					if(People[i] is Student)
					{	
						//Down-Casting
						Student st = People[i] as Student;
						st.Display();
					}
					else
					{
						Professor pro = People[i] as Professor;
						pro.print();
					}
				}
			}

		}
		
	}
}
