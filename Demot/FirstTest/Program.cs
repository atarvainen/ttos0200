/*using System;

// namespace
namespace FirstTest
{
    // class
    class Program
    {
        // method
        static void Main(string[] args)
        {
            // both numbers are stored in a stack. Both have own memory allocation.
            int numberA = 100;
            int numberB = 200;

            // set numberA to numberB
            numberB = numberA;
            numberA = 300;
            Console.WriteLine(numberA); // prints 300
            Console.WriteLine(numberB); // prints 100

            int number = 10;
            Add2(ref number); // value type
            Console.WriteLine("number = " + number); // prints 10
        }
        // method
        static void Add(int number) // copy, original doesn't change
        {
            number++;
        }

        // method
        static void Add2(ref int number)
        {
            number++;
        }
    }
}
*/
using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
class BlackJack
{
  public static void Main()
  {
    int myNumber = 17;
    int theirNumber;


    System.Console.WriteLine("*** BlackJack! ***");
        do
        {
            System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
            theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
        } while (theirNumber < 1 || theirNumber > 21);

        {
            Console.WriteLine("The given number is out of limits, try again.");
        }

    if (theirNumber < 1 || theirNumber > 21)
    {
      Console.WriteLine("The given number is out of limits, try again.");
    }
    else {
      // comparing
      if (theirNumber >= myNumber && theirNumber <= 21)
      {
        System.Console.WriteLine("You win.");
      }
      else {
        System.Console.WriteLine("You lose.");
      }
    }
  }
}