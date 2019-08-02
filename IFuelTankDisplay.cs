namespace Engine_and_Fuel_Tank
{
  public interface IFuelTankDisplay
  {
    double FillLevel { get; }
    bool IsOnReserve { get; }
    bool IsComplete { get; }
  }
}