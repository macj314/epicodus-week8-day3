namespace PrimeShifting
{
  public class Prime
  {
   public static List<int> createList(int input)
   {
     List<int> listNumbers = new List<int>();
     for (int i = 2; i < input; i++)
     {
       listNumbers.Add(i);
     }
     return listNumbers;
   } 
  }
}