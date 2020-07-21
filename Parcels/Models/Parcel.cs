namespace Parcels.Models
{
  public class Parcel
  {
    public int Height {get; set; }

    public int Width {get; set; }

    public int Length {get; set; }

    public int Weight {get; set; }
  
    public Parcel(int height, int width, int length, int weight)
    {
      Height = height;
      Width = width;
      Length = length;
      Weight = weight;
    }
  
    public int Volume()
    {   int volume = 0;
        volume = Length * Width * Weight;

        return volume;
    }
  
    public int CostToShip(int volume)
    {
      int cost = volume * 2;
      return cost;
    }
  
  }
}