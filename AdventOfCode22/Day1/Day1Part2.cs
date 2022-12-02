using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode22.Day1
{
    class Day1Part2
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

            List<int> values = new List<int>();

            //for each string
            foreach (var line in calories)
            {

                //if it's a num
                if (line != "")
                {
                    //Parse string into num, add into sum
                    int num = int.Parse(line);
                    sum += num;
                }
                else
                {
                    values.Add(sum);

                    //reset sum for next group of strings
                    sum = 0;
                }

            }

            values.Sort();

            values.Reverse();

            Console.WriteLine(values[0] + values[1] + values[2]);



        }


    }
}

