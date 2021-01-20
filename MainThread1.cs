using System;
using System.Threading;

namespace MultiThreading
{
    class MainThread1
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
             t.Name=" MainThread";
            Console.WriteLine(t.Name);
        }
    }
}

