using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreading1
{
    class ThreadMethods
    {
        public static void test1()
        {
           
            Console.WriteLine("test1 method");
            Console.WriteLine(Thread.CurrentThread.Name +"is running");

         
          
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);

                }  
                
             }

        

        public void test2(Object j)
        {
           // Console.WriteLine("test2 method " + j);

            lock (this) {

                for (int i = 11; i <= 20; i++)
                {
                    Console.WriteLine(i);

                    Thread.Sleep(200);


                }

            }

        }
        public static void Main(string[] args)
        {
            ThreadMethods tm = new ThreadMethods();
            Thread t = new Thread(ThreadMethods.test1);
            t.Name = "player1";
            t.Start();
           

            //  t.Join();




            Thread t1 = new Thread(new ParameterizedThreadStart(tm.test2));
            t1.Start(100);

            Thread t3 = new Thread(new ParameterizedThreadStart(tm.test2));
            t3.Start(100);


            Thread t2 = new Thread(ThreadMethods.test1);
            t2.Name = "player2";
            t2.Start();
            


        }
    }
}
