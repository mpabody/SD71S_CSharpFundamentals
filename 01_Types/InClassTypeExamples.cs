using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class InClassTypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            int age = 32;

            byte someByte = 23;

            int anotherNumber = 23;

            anotherNumber = 256;

            double someDouble = 23.3453643545;
            float someFloat = 23.34456456f;
            decimal someDecimal = 23.452665473565m;

            char letter = 'm';
            bool trueOrFalseValue = true;
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string randomCharacters = "alkjfi dk12343 @ #.";
            string specialCharacters = "\"Micahel\"";
            string otherSpecialCharacter = "\n"; // line return
            Console.WriteLine(specialCharacters);

            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            TimeSpan age = DateTime.Now - new DateTime(1988, 04, 11);
            Console.WriteLine(age);

            string[] names = { "Casey", "Michael", "Simon" };
            List<string> fruits = new List<string>();
            fruits.Add("grape");
            fruits.Add("apple");

            Dictionary<char, double> dictionary = new Dictionary<char, double>();
            dictionary.Add('x', 3.1459);
            dictionary['x'] = 3423425.2423; // changing the value in the key value pair.

            Console.WriteLine(fruits[0]);
            Console.WriteLine(dictionary['x']);
        }
    }
}
