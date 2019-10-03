//Synchronization for concurrent collections
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

using System.Collections.Concurrent;

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
            //private Stack<int> nos = new Stack<int>(); //non concurrent collections

            private ConcurrentStack<int> nos = new ConcurrentStack<int>(); //concurrent collections
            public void Fill()
            {
                for (int i = 0; i <= 50000; i++)
                {
                    nos.Push(i); //critical section--> accessing global section
                }
            }
            public int Count
            {
                get { return nos.Count; }
            }
        }
    }
}
