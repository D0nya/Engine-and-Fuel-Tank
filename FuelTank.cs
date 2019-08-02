namespace Engine_and_Fuel_Tank
{
  public class FuelTank : IFuelTank
  {
    private readonly double maxSize = 60;
    private readonly double resLevel = 5;
    private double fillLevel;

    public FuelTank()
    {
      FillLevel = 20;
    }
    public FuelTank(double liters)
    {
      FillLevel = liters;
    }

    public double FillLevel
    {
      get { return fillLevel; }
      private set
      {
        if (value > maxSize)
          fillLevel = maxSize;
        else if (value <= 0)
          fillLevel = 0;
        else
          fillLevel = value;


        if (fillLevel == maxSize)
          IsComplete = true;
        if (fillLevel <= resLevel)
          IsOnReserve = true;
      }
    }
    public bool IsOnReserve { get; private set; } = false;
    public bool IsComplete { get; private set; } = false;

    public void Consume(double liters)
    {
      FillLevel -= liters;
    }
    public void Refuel(double liters)
    {
      FillLevel += liters;
    }
  }
}
