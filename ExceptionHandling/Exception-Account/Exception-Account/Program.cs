using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Account
{
	class Program
	{
		static void Main(string[] args)
		{
			SavingsAccount account = new SavingsAccount(12345, 2000);
			account.Withdraw(500);

		}
	}
}
