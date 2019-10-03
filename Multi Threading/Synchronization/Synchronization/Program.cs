
//Synchronization for non-concurrent collections
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace Synchronization
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberList nos = new NumberList();
            Parallel.Invoke(nos.Fill, nos.Fill);
            Console.WriteLine(nos.Count); 
        }

        class NumberList
        {
            private Stack<int> nos = new Stack<int>();
            
           // [MethodImpl(MethodImplOptions.Synchronized)]  //Method level -- allowing one thread only to execute the following method
            public void Fill()
            {
                for (int i = 0; i <= 50000; i++)
                {
                    // Monitor.Enter(this); // allows only one thread to execute in its block(until Exit)

                    lock (this)   //better way of Monitor - as it is unlocked by complier only
                    {
                        nos.Push(i); //critical section--> accessing global section
                    }
                    
                   // Monitor.Exit(this);
                }
            }
            public int Count
            {
                get{ return nos.Count; }
            }
        }
    }
}
