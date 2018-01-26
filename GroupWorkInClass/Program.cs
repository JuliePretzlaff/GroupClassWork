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
            //    int[] numberOne = new int[2];
            //    Console.WriteLine("Greatest number: " + Greatest(numberOne));

            //Problem Two:
            int[] getNumbers = new int[2];
            Console.WriteLine(EqualityCheck(getNumbers));

            ////Problem Three:
            //string[] favFoods = new string[3];
            //Console.WriteLine(FoodList(favFoods));

            ////Problem Four:
            //double[] twoSides = new double[2];
            //Console.WriteLine("The third side squared is = " + Pathagorian(twoSides));



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

        //Problem Two:
        static bool EqualityCheck(int[] userInput)
        {
            bool result;
            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                userInput[i] = int.Parse(Console.ReadLine());
            }
            if (userInput[0] == userInput[1])
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

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

        ////Problem Four:
        //static double Pathagorian(double[] side)
        //{
        //    double thirdSide;
        //    for (int i = 0; i < side.Length; i++)
        //    {
        //        Console.WriteLine("Please enter one side of the pyramid: ");
        //        side[0] = double.Parse(Console.ReadLine());
        //    }

        //    thirdSide =(side[0] * side[0]) + (side[1] * side[1]);
        //        return thirdSide;
        //}


        }
    }

    
