using System;
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
       listNumbers.Add(i);
     }
     return listNumbers;
   } 
  }
}