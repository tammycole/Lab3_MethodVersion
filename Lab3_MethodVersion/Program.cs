using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_MethodVersion
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Learn your squares and cubes!");

                bool run = true;
                while (run == true)

                {
                    Console.WriteLine("Enter an integer:");
                    int enteredValue = int.Parse(Console.ReadLine());

                    Console.WriteLine("Number\tSquared\tCubed");
                    Console.WriteLine("=======\t=======\t=======");

                    for (int i = 1; i <= enteredValue; i++)
                    {
                        int squared = CalcSquared(i);
                        int cubed =CalcCubed(i);
                        Console.WriteLine(i + "\t" + squared + "\t" + cubed);
                    }
                    run = Continue();
                }
                Console.ReadKey();
         }

        public static int CalcSquared(int j)
            {
            int squared = j * j;
            return squared;
            }

            public static int CalcCubed(int j)
            {
            int cubed = j * j * j;
            return cubed;
            }

            public static bool Continue()
            {
                Console.WriteLine("Do you want to continue? y/n");
                string response = Console.ReadLine().ToLower();
                bool goOn;

                if (response == "y")
                {
                    goOn = true;
                }
                else if (response == "n")
                {
                    goOn = false;
                }
                else
                {
                    Console.WriteLine("I don't understand your response. Please respond with y or n");
                    goOn = Continue();
                }
                return goOn;
            }
        }
    }
