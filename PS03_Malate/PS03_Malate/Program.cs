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
            //Create a function that computes the area of a triangle using Heron’s formula.

            double HeronFormula(double s, double a, double b, double c)
            {
                return Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            }

            Console.Write("Enter Length of side A: ");
            double lengthA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Length of side B: ");
            double lengthB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Length of side C: ");
            double lengthC = Convert.ToDouble(Console.ReadLine());

            double semiPerimeter = (lengthA + lengthB + lengthC) / 2;
            double area = HeronFormula(semiPerimeter, lengthA, lengthB, lengthC);

            Console.WriteLine("The Semi-Parameter is " + semiPerimeter);
            Console.WriteLine("The area of the triangle is " + area);
            Console.ReadLine();
        }
    }
}
