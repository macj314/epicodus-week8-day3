using System;
using System.Linq;
using System.Collections.Generic;


namespace PrimeShifting
{
  public class Prime
  {
    private int _input;

    public Prime(int input){
      _input = input;
    }

   public List<int> CreateList()
   {
     List<int> listNumbers = new List<int>();
     for (int i = 2; i <= _input; i++)
     {
       for (int j = 2; j * j <= i; j++)
       {
         Console.WriteLine("i=" + i);
         Console.WriteLine("j=" + j);
         Console.WriteLine(i%j);
         if (i % j != 0)
         {
           listNumbers.Add(i);
         }
       }
     }
     return listNumbers;
   }

  //  public List<int> FindPrimeNums(List<int> listInt)
  //  {
  //    int max = listInt.Last();
  //    for (int prime = 2; prime <= max; prime++)
  //    {
  //      for (int i = 2; i * i <= prime; i++)
  //      {
  //        if (prime % i == 0)
  //        {
  //          listInt.Remove(prime);
  //        }
  //      }
  //    }
  //    return listInt;
  //  }
  // }
}
}