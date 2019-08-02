using System;
using System.Linq;

namespace Engine_and_Fuel_Tank
{
  class Program
  {
    static void Main()
    {
      Car c = new Car(1);
      Console.WriteLine($"EngineIsRunning: {c.EngineIsRunning}");
      Console.WriteLine($"Fill level:\t {c.fuelTankDisplay.FillLevel}");
      Console.WriteLine($"IsComplete:\t {c.fuelTankDisplay.IsComplete}");
      Console.WriteLine($"IsOnReserve:\t {c.fuelTankDisplay.IsOnReserve}");
      c.EngineStart();
      Console.WriteLine($"EngineIsRunning: {c.EngineIsRunning}");
      c.Refuel(1);
      c.RunningIdle();
      Console.WriteLine($"Fill level:\t {c.fuelTankDisplay.FillLevel}");
      Console.WriteLine($"IsComplete:\t {c.fuelTankDisplay.IsComplete}");
      Console.WriteLine($"IsOnReserve:\t {c.fuelTankDisplay.IsOnReserve}");
      Enumerable.Range(0, 1200).ToList().ForEach(s => c.RunningIdle());
      Console.WriteLine($"Fill level:\t {c.fuelTankDisplay.FillLevel}");
      c.EngineStop();
      Console.WriteLine($"EngineIsRunning: {c.EngineIsRunning}");
    }
  }
}