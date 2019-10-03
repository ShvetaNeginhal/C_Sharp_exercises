
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; //for Classical way
using System.Diagnostics;
using System.Threading.Tasks; //for TPL

namespace MultiThreading_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In main");
            //Calling sequentially
            Console.WriteLine("Sequentially");
            Stopwatch sw = Stopwatch.StartNew();
            M1();
            M2();
            Console.WriteLine("Time taken " + sw.ElapsedMilliseconds);
            Console.WriteLine("----------------------------");

            Console.WriteLine("Running parallely using thread");
            sw = Stopwatch.StartNew();
            ThreadStart ts = new ThreadStart(M1);
            Thread t1 = new Thread(ts);
            t1.Start();

            Thread t2 = new Thread(M2);
            t2.Start();

            //to make current thread to wait for t1 and t2 thread
            t1.Join();
            t2.Join();
            Console.WriteLine("Time taken " + sw.ElapsedMilliseconds);
            Console.WriteLine("----------------------------");

            Console.WriteLine("Running Parallel using parallel class");
            sw = Stopwatch.StartNew();
            Parallel.Invoke(M1, M2);
            Console.WriteLine("Time taken " + sw.ElapsedMilliseconds);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Running Parallel for loop");
            sw = Stopwatch.StartNew();
            Parallel.Invoke(M11, M22);
            Console.WriteLine("Time taken " + sw.ElapsedMilliseconds);

        }

        
        public static void M1() //500ms = 5s
        {
            int a = 0;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
            }
            //Console.WriteLine($"M1 {Thread.CurrentThread.ManagedThreadId}");
        }
       public static void M2()
        {
            int a = 0;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
            }
            //Console.WriteLine($"M2 {Thread.CurrentThread.ManagedThreadId}");
        }

        public static void M11() 
        {
            int a = 0;
            // for (int i = 0; i < 10; i++)
            //parallel for loop
            Parallel.For(1, 11, i =>
             {
                 Thread.Sleep(500);
             });
           
            //Console.WriteLine($"M1 {Thread.CurrentThread.ManagedThreadId}");
        }
        public static void M22()
        {
            int a = 0;
            Parallel.For(1, 11, i =>
              {
                  Thread.Sleep(500);
              });
            //Console.WriteLine($"M1 {Thread.CurrentThread.ManagedThreadId}");
        }
    }

}
