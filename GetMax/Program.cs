using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static int  GetMax (int firstNum, int secondNum, int thirdNum)
        {
            int maxNum=firstNum;
            if (firstNum < secondNum)
            {
                maxNum=secondNum;
            }
            if (secondNum < thirdNum)
            {
                 maxNum=thirdNum;
            }

            else
            { thirdNum = maxNum; }
            return maxNum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number here:");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number here:");
            int numTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number here:");
            int numThree = int.Parse(Console.ReadLine());
            Console.WriteLine("The biggest number of this three is: {0} ", GetMax(numOne, numTwo, numThree)); 
        }
    }
}
