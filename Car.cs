namespace Engine_and_Fuel_Tank
{
  public class Car : ICar
  {
    public IFuelTankDisplay fuelTankDisplay;
    private IEngine engine;
    private IFuelTank fuelTank;
    private readonly double consumption = 0.0003;

    public Car()
    {
      fuelTank = new FuelTank();
      fuelTankDisplay = new FuelTankDisplay(fuelTank);
      engine = new Engine(fuelTank);
    }
    public Car(double fuelLevel)
    {
      fuelTank = new FuelTank(fuelLevel);
      fuelTankDisplay = new FuelTankDisplay(fuelTank);
      engine = new Engine(fuelTank);
    }

    public bool EngineIsRunning
    {
      get { return engine.IsRunning; }
    }

    public void EngineStart()
    {
      engine.Start();
    }
    public void EngineStop()
    {
      engine.Stop();
    }
    public void Refuel(double liters)
    {
      fuelTank.Refuel(liters);
    }
    public void RunningIdle()
    {
      engine.Consume(consumption);
    }
  }
}
