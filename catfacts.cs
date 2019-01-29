using System;

namespace Catbot9001
{
  class Catfacts
  {
    static void Main()
    {
      int numberOfCats = 1;

      string firstCat = "Whiskey";

      bool Hater = true;

      while(Hater == true)
      {
        Console.Write("Cats are indeed good and not bad! Do you agree? (y/n)");

        string response = Console.ReadLine();

        if(response.ToLower() == "y")
        {
          Console.Write("Meow! " + firstCat + " Cat agrees! Did you know... \n");
          Hater = false;
        }
        else
        {
          Console.Write("Are you feline alright? Please try again! \n");
        }
      }

      Console.Write("What would you like to name your cat?");

      numberOfCats ++;

      string catName = Console.ReadLine();

      Console.Write("Meow! " + catName + " sounds like a pretty little kitty! \n");

      Console.Write("Now " + firstCat + " has a friend and we have "
      + numberOfCats + " cats! \n");

      bool keepBreeding = true;

      while(keepBreeding == true)
      {
        Console.Write("How many cats would you like to have?");

        string desiredCats = Console.ReadLine();

        try
        {
          int numberOfDesiredCats = int.Parse(desiredCats);

          int differenceInCats = numberOfDesiredCats - numberOfCats;

          Console.Write("Meow! We are " + differenceInCats +
          " away from having that many cats! \n");

          bool notEnoughCats = true;

          while(notEnoughCats)
          {
            if(differenceInCats > 0)
            {
              numberOfCats ++;

              Console.Write("Let's add another cat! We now have " + numberOfCats +
              " cats! \n");

              differenceInCats --;
            }
            else if(differenceInCats == 0)
            {
              Console.Write("Meow! We have your purrfect number of cats! \n");
              notEnoughCats = false;
            }
            else
            {
              Console.Write("*hiss* You are a monster!!! Y u wanna kill a cat doe? \n");
              notEnoughCats = false;
            }
          keepBreeding = false;
          }
        }
        catch(FormatException)
        {
          Console.Write("It would be purrfect if you would enter a whole number! \n");
          continue;
        }
      }
    }
  }
}
