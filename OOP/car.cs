using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class car
    {
        public string Type { get; set; }
        public string Brand { get; }
        public string Fuel { get; set; }
        public double EngineVolume { get; set; }
        public int FuelLevel { get; set; }
        public int Distance { get; set; }
        public double PneuState { get; set; }
        public int Speedometer { get; set; }

        public car(string brand)
        {
            Type = "Unknown";
            Brand = brand;
            Fuel = "Gas";
            EngineVolume = 1000;
            FuelLevel = 100;
            Distance = 0;
            PneuState = 100;
            Speedometer = 0;

        }
        public void Move()
        {
            FuelLevel -= 1;
            Distance += 10;
            PneuState -= 0.01;
            if (Speedometer > 0)
            {
                FuelLevel = Math.Max(0, FuelLevel - 1);

                // FuelLevel = Math.Min(100, FuelLevel + 50);

                if (FuelLevel > 0)
                {
                    Distance += Speedometer;
                    PneuState -= Speedometer / 100D;
                }
            }
        }

        public void SpeedUp()
        {
            Speedometer = Math.Min(100, Speedometer + 1);
        }

        public void SpeedDown()
        {
            Speedometer = Math.Max(0, Speedometer - 1);
        }
    }

}
