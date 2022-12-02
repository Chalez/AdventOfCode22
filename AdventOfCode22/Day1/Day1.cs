using System;
using System.IO;
using System.Transactions;

namespace AdventOfCode22.Day1
{
    class Day1
    {

        public static string readFromFile()
        {
            string path = @"input";

            return File.ReadAllText(path);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! This is Day 1");

            string puzzleInput = readFromFile();

            //Separate string input into an array of strings split by '\n'
            string[] calories = puzzleInput.Split("\n");

            int max = 0;
            int sum = 0;


            //for each string
            foreach (var line in calories) {

                //if it's a num
                if (line != "")
                {
                    //Parse string into num, add into sum
                    int num = int.Parse(line);
                    sum += num;
                }
                else
                {
                    //if sum is greater than max
                    if (sum > max)
                    {
                        //it is the new max
                        max = sum;
                    }
                    //reset sum for next group of strings
                    sum = 0;
                }
                

            }

            Console.WriteLine(max);


        }


    }
}
