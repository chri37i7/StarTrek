using System;
using System.Collections.Generic;

namespace StarTrek
{
    class Program
    {
        static List<string> validVulcanNames = new List<string>();

        static void Main()
        {
            GenerateVulcanNames();


        }

        static void GenerateVulcanNames()
        {
            // Arrays for name combinations 
            string[] firstArray = { "S", "Sp", "Sk", "St", "T" };
            string[] secondArray = { "a", "e", "i", "o", "u", "y" };
            string[] thirdArray = { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" };
            string[] fourthArray = { "a", "e", "i", "o", "u", "y" };
            string[] fifthArray = { "q", "p", "k", "ck", "l" };


            // Loop until all combinations have been made
            while(validVulcanNames.Count != 10800)
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

                string name = firstArray[firstNumber] + secondArray[secondNumber] + thirdArray[thirdNumber] + fourthArray[fourthNumber] + fifthArray[fifthNumber];

                if(!validVulcanNames.Contains(name))
                {
                    validVulcanNames.Add(name);
                }
            }
        }
    }
}
