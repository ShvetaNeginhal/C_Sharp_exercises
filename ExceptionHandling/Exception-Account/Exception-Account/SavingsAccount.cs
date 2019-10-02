using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Account
{
	class SavingsAccount
	{
		private int accountNumber;
		private double balance;
		public SavingsAccount(int accountNumber, double balance)
		{
			this.accountNumber = accountNumber;
			this.balance = balance;
		}
			public void Withdraw(double amount)
			{
				balance -= amount;
			}  
	}
}
