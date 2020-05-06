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
          Console.WriteLine(i);
        }
        //Call method that returns list of prime numbers. Param (list)
      } 
      else 
      {
        Console.WriteLine("Unfortunately I don't believe that's a number I can test. Please only enter whole numbers.");
      }
    }
  }
}