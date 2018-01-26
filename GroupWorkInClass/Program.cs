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
            //    //Problem One:
            //    int[] numberOne = new int[2];//Declaring an int array
            //    Console.WriteLine("Greatest number: " + Greatest(numberOne));//Console recieves the greatest number and prints it

            ////Problem Two:
            //int[] getNumbers = new int[2];
            //Console.WriteLine(EqualityCheck(getNumbers));

            ////Problem Three:
            //string[] favFoods = new string[3];
            //Console.WriteLine(FoodList(favFoods));

            //Problem Four:
            double[] twoSides = new double[2];
            Console.WriteLine("The third side squared = " + Pathagorian(twoSides));



        }

        ////Problem One:
        //static int Greatest(int[] num)
        //{
        //    for (int i = 0; i < num.Length; i++)
        //    {
        //        Console.WriteLine("Please enter a number");
        //        num[i] = int.Parse(Console.ReadLine());

        //    }
        //    int sum;
        //    if (num[0] < num[1])
        //    {
        //        sum = num[1];
        //        return sum;
        //    }
        //    else
        //    {
        //        sum = num[0];
        //        return sum;
        //    }

        ////Problem Two:
        //static string EqualityCheck(int[] userInput)
        // {
        //   string result;
        //   for (int i = 0; i < userInput.Length; i++)
        //    {
        //       Console.WriteLine("Please enter a number");
        //       userInput[i] = int.Parse(Console.ReadLine());
        //    }
        //    if (userInput[0] == userInput[1])
        //    {
        //        result = "The two numbers you've entered are equal.";
        //    }
        //    else
        //    {
        //       result = "The two numbers you have entered are not equal";
        //    }
        //    return result;
        //}

        ////Problem 3:
        //static string FoodList(string[] foods)
        //{
        //    string foodSentence;

        //    for (int i = 0; i < foods.Length; i++)
        //    {
        //        Console.WriteLine("Please enter one of your favorite foods: ");
        //        foods[i] = Console.ReadLine();
        //    }
        //    foodSentence = foods[0] + ", " + foods[1] + ", and " + foods[2] + "are my favorite foods.";

        //    return foodSentence;
        //}

        //Problem Four:
         static double Pathagorian(double[] side)
        {
            double thirdSide;
            for (int i = 0; i < side.Length; i++)
            {
                Console.WriteLine("Please enter one side of the pyramid: ");
                side[0] = double.Parse(Console.ReadLine());
            }

            thirdSide = (side[0] * side[0]) + (side[1] * side[1]);
                return thirdSide;
        }


        }
    }

    
