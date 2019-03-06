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
   
            class proram
        {
            static void Main(string[] args)
            {
                DelegateExercises a = new DelegateExercises();
                a.Method2();
            }
        }
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
                myDelegate();
            }
        }
    }
  