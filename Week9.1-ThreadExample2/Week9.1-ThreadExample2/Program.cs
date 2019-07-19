using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Week9._1_ThreadExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //To create a childthread,
            //Step 1: create a delegate object, passing 
            //a callback method as a parameter.
            //The callback method contains the 
            //code you want executed when the child runs
            MyThread threadObj = new MyThread();
            ThreadStart deligateObj = threadObj.PrintThreadCode;
            deligateObj += threadObj.PrintThreadCode;
            //ThreadStart -> deligate that define a callback method that contains
            //the code to execute when the thread is run

            //Step 2: A new thread object is created and the 
            // deligate object is used to intialize the thread object
            //All children threads are children of main thread.
            Thread childThread = new Thread(deligateObj);
            
            //Step 3: The start method on the thread object causes the thread to run
            childThread.Start();//Step 3

            Random rnd = new Random();
            int sleepDuration = rnd.Next(200, 1000);
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("This is the main thread {0}", i);
                Thread.Sleep(sleepDuration);//Pause thread for 200ms
            }

            Console.ReadKey();
        }
    }

    public class MyThread
    {
        public void PrintThreadCode()
        {
            Random rnd = new Random();
            int sleepDuration = rnd.Next(200, 1000);
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("This is the child thread");
                Thread.Sleep(sleepDuration);
                //Thread.Sleep affect the current thread.
            }
        }
    }
    
}
