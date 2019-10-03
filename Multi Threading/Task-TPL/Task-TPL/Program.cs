using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(fx1);//picks the thread
            t1.Start();

            Task t11 = new TaskFactory().StartNew(fx1); //picks the thread and starts

            //signature of task doesnt satify as the function takes arguement-->hence use lambda statements
            Task t2 = new Task(() => { fx2(100); }); //lambda statements
            t2.Start();

            //also can be done like this
            Task t22 = new TaskFactory().StartNew(fx22);

            //for the functions returning valuse with 0 parameter
            Task<int> t3 = new Task<int>(fx3);
            t3.Start();
            int retVal = t3.Result;

            //funstionc returning val and taking parameter
            Task<int> t4 = new Task<int>(() => { return fx4(100); });
            t4.Start();
            Console.WriteLine(t4.Result);
        }

        static void fx1() { }
        static void fx2(int data) { }
        static int fx3() { return 100; }
        static int fx4(int data) { return 100 + data; }
        static void fx22() { fx2(100); }
    }
}
