using System;

namespace number_guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,this is my program on c-sharp!");
            Console.WriteLine("This program is number-guessing game");

            Console.WriteLine("Please write min value:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write max value:");
            int max = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int randomNumber = rnd.Next(min, max);
            Console.WriteLine("Fine,number is done, lets start!");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Pick you number");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == randomNumber)
                {
                    Console.WriteLine($"Wow,Great work algorithm choose a number - {randomNumber}");
                    flag = false;
                }
                else if(userNumber > randomNumber)
                {
                    Console.WriteLine("Too high, get down");
                    continue;
                }
                else
                {
                    Console.WriteLine("Too low,get up");
                    continue;
                }
                Console.WriteLine("GG,Thanks for the game!");
            }
        }
    }
}
