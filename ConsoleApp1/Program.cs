﻿using System;
using System.Threading;
using ManageCppDll;

namespace mainTest
{
    class testClass
    {
        static void Main()
        {
            testDll xxx = new testDll();
            xxx.SetA(3);
            xxx.SetB(2);
            xxx.SetC(Convert.ToSByte('t'));
            Console.WriteLine(xxx.Add());
            Console.WriteLine(xxx.Sub());
            Console.WriteLine(Convert.ToChar(xxx.GetC()));
            Console.ReadKey();
        }
    }
}

//namespace MultithreadingApplication
//{
//    class ThreadCreationProgram
//    {
//        public static void CallToChildThread()
//        {
//            Console.WriteLine("Child thread starts");
//            // 线程暂停 5000 毫秒
//            int sleepfor = 5000;
//            Console.WriteLine("Child Thread Paused for {0} seconds",
//                              sleepfor / 1000);
//            Thread.Sleep(sleepfor);
//            Console.WriteLine("Child thread resumes");
//        }

//        static void Main(string[] args)
//        {
//            ThreadStart childref = new ThreadStart(CallToChildThread);
//            Console.WriteLine("In Main: Creating the Child thread");
//            Thread childThread = new Thread(childref);
//            childThread.Start();
//            Console.ReadKey();
//        }
//    }
//}