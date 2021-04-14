using System;

namespace SO_Exercises13._14._15_4._14._21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Exercise 13: Prompt user for a number. Use a for loop to output all the numbers from that number to 0.

            bool keepLoop = true;

            while (keepLoop)
            {

                Console.WriteLine("Please enter a number!");
                string userInput = Console.ReadLine();

                int number = int.Parse(userInput);

                for (int i = number; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Would you like to play again? y/n");
                string userContinue = Console.ReadLine();

                if (userContinue == "y")
                {
                   continue;
                }
                else
                {
                    Console.WriteLine("bye!");
                    break;
                }


            } */

           /*// Exercise 14: Prompt user for a number. Use a for loop to output the squares of all the numbers from 1 to that number.

            bool keepLoop = true;

            while (keepLoop)
            {

                Console.WriteLine("Please enter a number!");
                string userInput = Console.ReadLine();

                int number = int.Parse(userInput);
                int square;

                for (int i = 1; i <= number; i++)
                {
                    square = i * i;
                    Console.WriteLine(square);
                }

                Console.WriteLine("Would you like to play again? y/n");
                string userContinue = Console.ReadLine();

                if (userContinue == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("bye!");
                    break;
                }

            } */


             //Exercise 15: Prompt user for a number. Use a for loop to output the cubes of all the numbers from that number to 0.

             bool keepLoop = true;
            
            while (keepLoop)
             {
                
                try
                {
                    Console.WriteLine("Please enter a number!");
                    string userInput = Console.ReadLine();

                    int number = int.Parse(userInput);
                    int cube;

                    for (int i = 1; i <= number; i++)
                    {
                        cube = i * i * i;
                        Console.WriteLine(cube);
                    }

                    Console.WriteLine("Would you like to play again? y/n");
                    string userContinue = Console.ReadLine();

                    if (userContinue == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("bye!");
                        break;
                    }
                }

                    catch
                {
                    Console.WriteLine("That's not a number...");
                }
             }  
        }
    }
}
