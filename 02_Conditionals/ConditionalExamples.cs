﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4;
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool isTrue = true;
            if (true)
            {
                //Do something
            }

            int age = 24;

            if (age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else if (age > 6)
            {
                Console.WriteLine("You're still a kid");
            }
            else if (age > 0)
            {
                Console.WriteLine("You're far to young to be using a computer");
            }
            else
            {
                Console.WriteLine("You're not even born yet");
            }


            if (age > 64 && age < 18)
            {
                // And Comparison &&
            }

            if (age <= 65 || age >= 18)
            {
                // Or comparison ||
            }

            if (age == 17)
            {
                // Is equal to
            }

            if (age != 19)
            {
                // Not equal to
                // ! bang operator
            }
        }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 42;

            switch (age)
            {
                case 18:
                    // Code for if age is 18
                    break;
                case 19:
                    //Code for if age is 19
                    break;
                case 20:
                    //Code for if age is 20
                    break;
                case 21:
                case 22:
                case 23:
                    //Code for if age is 21, 22, or 23
                    break;
                default:
                    // Catch all code
                    Console.WriteLine("You are not 18 - 23");
                    break;
            }
        }

        [TestMethod]
        public void MyTestMethod()
        {
            int age = 37;

            //bool someVariable = (boolean statement) ? trueValue : falseValue;

            bool isAge = (age == 24) ? true : false;
        }
    }
}
