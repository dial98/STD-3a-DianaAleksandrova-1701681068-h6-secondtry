using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static double triangleArea(double side, double height)
           {            
            return (side*height)/2;
           }
        static double squareArea(double side1)
           {
            return (side1 * side1);
           }
        static double getRadians(double degrees,double radians)
           {
            return (Math.PI/180*degrees);
           }


        static void Main(string[] args)
        {
            Console.WriteLine("Choose option (triangle, square or radians):");
            string figureType = Console.ReadLine().ToLower();
                     
                   
            switch (figureType)
            {
                case "triangle":
                    Console.WriteLine("Enter side:");
                    int side = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter height:");
                    int height = int.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the {0} is:{1:f2}","triangle", triangleArea(side, height));
                    break;

                case "square":
                    Console.WriteLine("Enter side:");
                    int side1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter height:");
                    int height1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the {0} is: {1:f2}","square",squareArea(side1));
                    break;

                case "radians":

                    Console.WriteLine("Enter the degrees you want to transform in radians:");
                    double degrees = double.Parse(Console.ReadLine());
                    double radians=0;
                    Console.WriteLine("Your degrees in radians are:{0}",getRadians(degrees,radians));
                    break;
            }
            
            
            
        }
    }
}
