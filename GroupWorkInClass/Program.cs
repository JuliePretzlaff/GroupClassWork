using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWorkInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a method uses two user inputs and returns the greatest value using a loop!

            int[] numberOne = new int[2];//Declaring an int array

            Console.WriteLine("Greatest number: " + Greatest(numberOne));//Console recieves the greatest number and prints it
        }
        static int Greatest(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                num[i] = int.Parse(Console.ReadLine());

            }
            int sum;
            if (num[0] < num[1])
            {
                sum = num[1];
                return sum;
            }
            else
            {
                sum = num[0];
                return sum;
            }
        }
    }
}
