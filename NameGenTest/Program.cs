using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace NameGenTest
{
    class Program
    {
        static string path = @"C:\Users\chri37i7\Documents\startrek.txt";
        static List<string> fileNamesList = new List<string>();

        static void Main()
        {
            // FirstTaskMethod();
            // SecondTaskMethod();
            // ThirdTaskMethod();
        }

        static void FirstTaskMethod()
        {
            // Opgave 1   
            string[] firstArray = { "S", "Sp", "Sk", "St", "T" };
            string[] secondArray = { "a", "e", "i", "o", "u", "y" };
            string[] thirdArray = { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" };
            string[] fourthArray = { "a", "e", "i", "o", "u", "y" };
            string[] fifthArray = { "q", "p", "k", "ck", "l" };

            for(int i = 0; i != 25000; i++)
            {
                CreateNameList();

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

                if(!fileNamesList.Contains(name))
                {
                    using(StreamWriter writer = new StreamWriter(path, true, Encoding.Default))
                    {
                        writer.WriteLine(name);

                        fileNamesList.Clear();
                    }
                }
            }
        }

        static void SecondTaskMethod()
        {
            // Opgave 2
            string[] firstArray = { "S", "Sp", "Sk", "St", "T" };
            string[] secondArray = { "a", "e", "i", "o", "u", "y" };
            string[] thirdArray = { "q", "p", "k", "ck", "l" };


            for(int i = 0; i != 1500; i++)
            {
                CreateNameList();

                Random firstRndNum = new Random();
                int firstNumber = firstRndNum.Next(0, firstArray.Length);

                Random secondRndNum = new Random();
                int secondNumber = secondRndNum.Next(0, secondArray.Length);

                Random thirdRndNum = new Random();
                int thirdNumber = thirdRndNum.Next(0, thirdArray.Length);

                string firstName = firstArray[firstNumber] + secondArray[secondNumber] + thirdArray[thirdNumber];

                if(!fileNamesList.Contains(firstName))
                {
                    using(StreamWriter writer = new StreamWriter(path, true, Encoding.Default))
                    {
                        writer.WriteLine(firstName);

                        fileNamesList.Clear();
                    }
                }
            }
        }

        static void ThirdTaskMethod()
        {
            // Opgave 3
            string[] firstArray = { "T’" };
            string[] secondArray = { "P", "K", "Q" };
            string[] thirdArray = { "a", "e", "i", "o", "u", "y" };
            string[] fourthArray = { "r", "j", "’p", "k", "l" };


            for(int i = 0; i != 1000; i++)
            {
                CreateNameList();

                Random firstRndNum = new Random();
                int firstNumber = firstRndNum.Next(0, firstArray.Length);

                Random secondRndNum = new Random();
                int secondNumber = secondRndNum.Next(0, secondArray.Length);

                Random thirdRndNum = new Random();
                int thirdNumber = thirdRndNum.Next(0, thirdArray.Length);

                Random fourthRndNum = new Random();
                int fourthNumber = fourthRndNum.Next(0, fourthArray.Length);

                string name = firstArray[firstNumber] + secondArray[secondNumber] + thirdArray[thirdNumber] + fourthArray[fourthNumber];

                if(!fileNamesList.Contains(name))
                {
                    using(StreamWriter writer = new StreamWriter(path, true, Encoding.Default))
                    {
                        writer.WriteLine(name);

                        fileNamesList.Clear();
                    }
                }
            }
        }

        static void CreateNameList()
        {
            // FileStream & StreamReader for reading the textfile
            using(FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader reader = new StreamReader(fileStream))
                {
                    while(!reader.EndOfStream)
                    {
                        string documentLine;
                        // Read until end is reached
                        while((documentLine = reader.ReadLine()) != null)
                        {
                            // Split document lines into array
                            string[] lineArray = documentLine.Split("\t");

                            // Create film object with array
                            string textLine = lineArray[0];
                            // Add film to list
                            fileNamesList.Add(textLine);
                        }
                    }
                }
            }
        }
    }

}