using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
	//Creating a Custom Exception
	public class NotEvenNumberException : ApplicationException
	{
		public NotEvenNumberException(string msg) : base(msg)
		{
			
		}
	}
}
