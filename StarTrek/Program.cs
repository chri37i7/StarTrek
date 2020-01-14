using System;
using System.Collections.Generic;

namespace StarTrek
{
    class Program
    {
        static List<string> validMaleVulcanNames = new List<string>();
        static List<string> validFemaleVulcanNames = new List<string>();

        static void Main()
        {
            // Generate Male & Female names
            GenerateMaleVulcanNames();
            GenerateFemaleVulcanNames();


            // Test to see if it generates correctly
            Console.WriteLine(validMaleVulcanNames[10799]);
            Console.WriteLine(validFemaleVulcanNames[89]);
        }

        static void GenerateMaleVulcanNames()
        {
            // Arrays for name combinations 
            string[] firstArray = { "S", "Sp", "Sk", "St", "T" };
            string[] secondArray = { "a", "e", "i", "o", "u", "y" };
            string[] thirdArray = { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" };
            string[] fourthArray = { "a", "e", "i", "o", "u", "y" };
            string[] fifthArray = { "q", "p", "k", "ck", "l" };


            // Loop until all combinations have been made
            while(validMaleVulcanNames.Count != 10800)
            {
                Random firstRndNum = new Random();
                int firstNumber = firstRndNum.Next(0, firstArray.Length);

                Random secondRndNum = new Random();
                int secondNumber = secondRndNum.Next(0, secondArray.Length);

                Random thirdRndNum = new Random();
                int thirdNumber = thirdRndNum.Next(0, thirdArray.Length);

                Random fourthRndNum = new Random();
                int fourthNumber = fourthRndNum.Next(0, fourthArray.Length);

                Random fifthRndNum = new Random();
                int fifthNumber = fifthRndNum.Next(0, fifthArray.Length);

                // Combine strings
                string maleName = firstArray[firstNumber] + secondArray[secondNumber] + thirdArray[thirdNumber] + fourthArray[fourthNumber] + fifthArray[fifthNumber];

                // Check if already created
                if(!validMaleVulcanNames.Contains(maleName))
                {
                    validMaleVulcanNames.Add(maleName);
                }
            }
        }

        static void GenerateFemaleVulcanNames()
        {
            // Arrays for name combinations
            string[] firstArray = { "T’" };
            string[] secondArray = { "P", "K", "Q" };
            string[] thirdArray = { "a", "e", "i", "o", "u", "y" };
            string[] fourthArray = { "r", "j", "’p", "k", "l" };


            // Loop untill all combinations have been made
            while(validFemaleVulcanNames.Count != 90)
            {
                Random firstRndNum = new Random();
                int firstNumber = firstRndNum.Next(0, firstArray.Length);

                Random secondRndNum = new Random();
                int secondNumber = secondRndNum.Next(0, secondArray.Length);

                Random thirdRndNum = new Random();
                int thirdNumber = thirdRndNum.Next(0, thirdArray.Length);

                Random fourthRndNum = new Random();
                int fourthNumber = fourthRndNum.Next(0, fourthArray.Length);

                // Combine strings
                string femaleName = firstArray[firstNumber] + secondArray[secondNumber] + thirdArray[thirdNumber] + fourthArray[fourthNumber];

                // Check if already created
                if(!validFemaleVulcanNames.Contains(femaleName))
                {
                    validFemaleVulcanNames.Add(femaleName);
                }
            }
        }
    }
}
