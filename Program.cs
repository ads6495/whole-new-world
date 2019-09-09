using System;

namespace whole_new_world
{
  class Program
  {
    static void Main(string[] args)

    {
      var min = 1.0;
      var max = 100.0;
      var success = false;

      while (!success)
      {
        var guess = Math.Floor((min + max) / 2);
        Console.WriteLine($"{guess}");
        var input = Console.ReadLine();
        if (input == "yes")
        {
          success = true;
          var playAgain = Console.ReadLine();

        }
        else if (input == "higher")
        {
          min = guess;

        }
        else if (input == "lower")
        {

          max = guess;

        }

      }

    }

  }
}
