using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
	class Calculator
	{
		public int FindEvenSum(int a,int b)
		{
			if(a%2 !=0 | b%2 !=0)
			{
				throw new NotEvenNumberException("Kindly enter only Even Number!");
			}
			return a + b;
		}
	}
}
