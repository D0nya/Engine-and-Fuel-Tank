namespace Engine_and_Fuel_Tank
{
  public class Engine : IEngine
  {
    private readonly IFuelTank fuelTank;

    public Engine()
    {
      fuelTank = null;
    }
    public Engine(IFuelTank ft)
    {
      fuelTank = ft;
    }

    public bool IsRunning { get; private set; }

    public void Consume(double liters)
    {
      if (IsRunning)
        fuelTank.Consume(liters);
      if (fuelTank.FillLevel <= 0)
        IsRunning = false;
    }
    public void Start()
    {
      if (fuelTank.FillLevel > 0)
        IsRunning = true;
    }
    public void Stop()
    {
      IsRunning = false;
    }
  }
}
