using System;
using System.Collections.Generic;

namespace PrimeShifting
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello! I bet I can count all of the prime numbers under any given number. Let's test that. Enter a number please.");
      string inputString = Console.ReadLine();
      if (int.TryParse(inputString, out int inputInt)) {
        Prime maxInt = new Prime(inputInt);
        List<int> listInt = maxInt.CreateList();
                foreach (int i in listInt)
        {
          Console.Write(i + ", ");
        }
        // listInt = maxInt.FindPrimeNums(listInt);
      //   Console.WriteLine("List of prime numbers: | ");
      //   foreach (int i in listInt)
      //   {
      //     Console.Write(i + ", ");
      //   }
      // } 
      // else 
      // {
        Console.WriteLine("Unfortunately I don't believe that's a number I can test. Please only enter whole numbers.");
      }
    }
  }
}