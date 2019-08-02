﻿namespace Engine_and_Fuel_Tank
{
  public interface IEngine
  {
    bool IsRunning { get; }

    void Consume(double liters);
    void Start();
    void Stop();
  }
}