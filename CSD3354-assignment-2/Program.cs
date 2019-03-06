using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Student Name Jashanpreet Singh Student ID C0732125
//Student Name Vikramjot Singh Student ID C0726863
//CSD3354 Section 2
//Assignment 2
//March 6,2019

namespace CSD3354_assignment_2
{

    public class Program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }

    public delegate void MyDelegate();

    public class DelegateExercises
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");


        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
            System.Console.WriteLine(myDelegate.ToString());
        }
    }


}