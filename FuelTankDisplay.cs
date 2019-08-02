using System;

namespace Engine_and_Fuel_Tank
{
  public class FuelTankDisplay : IFuelTankDisplay
  {
    private readonly IFuelTank fuelTank;
    public FuelTankDisplay()
    {
      fuelTank = null;
    }
    public FuelTankDisplay(IFuelTank ft)
    {
      fuelTank = ft;
    }

    public double FillLevel
    {
      get { return Math.Round(fuelTank.FillLevel, 2); }
    }
    public bool IsOnReserve
    {
      get { return fuelTank.IsOnReserve; }
    }
    public bool IsComplete
    {
      get { return fuelTank.IsComplete; }
    }
  }
}
