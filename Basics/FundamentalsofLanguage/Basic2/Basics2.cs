using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic2
{
    class Basics2
    {
        //static void Fx()
        //{
        //    Console.WriteLine("In fx()");
        //    Account acc2 = new Account(1223, "Sitty", 30000);
        //    Console.WriteLine("End of fx()");
        //}
        static void Main(string[] args)
        {

            //Object initialization
            Account acc = new Account { AccountNo = 111, Name = "Sitty", Balance = 20000 };
            // Console.WriteLine(acc.GetBal());
            acc.Balance = 6000;
            acc.Deposit(1000);

            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc.AccountNo);
            Console.WriteLine(acc.Name);

          //  Employee e1 = new Employee { Names = "fitty", Eno = 20009 };
        }

    }

    class Account
    {
        private int accno;
        private string name;
        private double bal;
        
        //public int GetAcc() { return accno; }
        //public string GetName() { return name; }
        //public double GetBal() { return bal; }
        //public void SetAcc(int a) { accno = a; }
        //public void SetName(string n) { name = n; }
        //public void SetBal(double b) { bal = b; }
        
        //Property

            public double Balance
        {
            get { return bal; }
            set
            {
                if (value < 100)
                    throw new Exception("invalid Amount");
                bal = value; }
        }

        public int AccountNo
        {
            get;
            set;
        }
        
        public string Name
        {
            get;
            set;
        }
        public void Deposit(double amt)                 
        {                                             
            bal += amt;                               
        }                                             
        public void Withdraw(double amt)              
        {                                             
            bal -= amt;                               
        }

        //public Account() {}         
        

        //public Account(int a,string b,double c)
        //{
        //    Console.WriteLine("CONSTRUCTOR ....");
        //    this.accno = a;
        //    this.name = b;
        //    this.bal = c;
        //}
       //~Account()
       // {
       //     Console.WriteLine("Destructor...");
       // }

    }

    class Employee
    {

        public int Eno { get; set; }
        public string Names { get; set; }
        public int Deptno { get; set; }
        private double sal;
        public double Salary
        {
            get { return sal; }
            set
            {
                if (value < 100)
                    throw new Exception("invalid Amount");
                sal = value;
            }
        }

    }
}
