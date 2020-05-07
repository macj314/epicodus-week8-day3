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
      bool flag = true;
      for (int j = 2; j * j <= i; j++)
      {
        if (i % j == 0)
        {
          flag = false;
          break;
        }
      }
      if (flag)
      {
        listNumbers.Add(i);
      }
    }
     return listNumbers;
   }
  }
}