using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    class ThreadExample1
    {
        public void test1()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void test2()
        {

            for (int i = 21; i <= 30; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Main(string[] args)
        {
            ThreadExample1 e1 = new ThreadExample1();
            Thread t1 = new Thread(e1.test1);
            Thread t2 = new Thread(ThreadExample1.test2);
            t1.Start();
            t2.Start();
        }
    }
}
