
using System;

//Student Name Jashanpreet Singh Student ID C0732125
//Student Name Vikramjot Singh Student ID C0726863
//CSD3354 Section 2
//Assignment 2
//March 6,2019using System;


namespace DelegatesAndEvents
{
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate(50);
        }

    }
}