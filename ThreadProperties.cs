using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreading1
{
    class ThreadProperties
    {
        public static void sample()
        {
            Console.WriteLine("sample method");
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.IsBackground);
            Console.WriteLine(t.ManagedThreadId);
            Console.WriteLine(t.ThreadState);

            for (int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Main(string[] args)
        {

            Console.WriteLine(Thread.CurrentThread);
            Thread t = Thread.CurrentThread;
            t.Name = "MainThread";
            Console.WriteLine(t.Name);
            Console.WriteLine(t.IsAlive);
            Console.WriteLine(t.IsBackground);
            Console.WriteLine(t.ManagedThreadId);
            Console.WriteLine(t.ThreadState);
            Thread th = new Thread(ThreadProperties.sample);
            th.Start();
            Console.WriteLine("Thread states..");
            Console.WriteLine(t.ThreadState);
            Console.WriteLine(th.ThreadState);


        }
    }
}
