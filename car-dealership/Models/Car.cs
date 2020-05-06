namespace Dealership.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;

    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

        public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

        public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public bool WorthBuying(int maxPrice, int maxMile)
    {
      return (_price < maxPrice && _miles < maxMile);
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
  }
}
