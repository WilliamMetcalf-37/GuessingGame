using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Random rand = new Random();
      int secretNumber = rand.Next(1, 11);




      for (int i = 0; i < 3; i++)
      {
        Console.WriteLine("Guess a Number between 1 and 10");
        int x;
        x = Convert.ToInt32(Console.ReadLine());




        if (x > secretNumber && i != 2)
        {
          Console.WriteLine("lower");

        }
        else if (x < secretNumber && i != 2)
        {
          Console.WriteLine("Higher");
        }
        else if (i == 2 && x != secretNumber)
        {
          Console.WriteLine($"Game Over! it was {secretNumber}");

        }
        else
        {
          Console.WriteLine($"You got it! it was {secretNumber}");
          return;

        }
      }











    }
  }
}
