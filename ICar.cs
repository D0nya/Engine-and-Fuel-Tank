﻿namespace Engine_and_Fuel_Tank
{
  public interface ICar
  {
    bool EngineIsRunning { get; }

    void EngineStart();
    void EngineStop();
    void Refuel(double liters);
    void RunningIdle();
  }
}