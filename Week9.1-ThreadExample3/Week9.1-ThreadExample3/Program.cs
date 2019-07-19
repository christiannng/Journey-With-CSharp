using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Week9._1_ThreadExample3
{
    class Program
    {
        static int n = 10; //common resource
                           //why is this static??
                           //static and global?

        static void Main(string[] args)
        {
            //This program implements multi threading
            //This program will demonstrate can access
            //a common resource


            Console.WriteLine("Main thread starting");
            ThreadStart ts1 = new ThreadStart(ThreadCode);
            Thread child1 = new Thread(ts1);

            ThreadStart ts2 = new ThreadStart(ThreadCode);
            Thread child2 = new Thread(ts2);//Why can't we use ts1 as the param.

            //You don't know the order when each thread is executed.
            child1.Name = "Child1";
            child2.Name = "Child2";

            child1.Start();
            child2.Start();

            Console.WriteLine("The value of n is {0}", n);
            Console.ReadKey();
        }

        static void ThreadCode()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " is running");
            n++;
        }
    }
}
