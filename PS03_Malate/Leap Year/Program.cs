using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS03_Malate
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a function that determines whether a given year is a leap year or not.

            void LoopYear(int y)
            {
                if (y % 4 == 0)
                {
                    if (y % 100 == 0 && y % 400 != 0)
                    {
                        Console.WriteLine("Not a Loop Year.");
                    }

                    else
                    {
                        Console.WriteLine("Loop Year.");
                    }
                }

                else
                {
                    Console.WriteLine("Not a Loop Year.");
                }
            }

            Console.Write("Enter a Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            LoopYear(year);

            Console.ReadLine();
        }
    }
}