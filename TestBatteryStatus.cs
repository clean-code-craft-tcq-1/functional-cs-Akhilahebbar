using System;

namespace BatteryManagement
{
    internal class TestBatteryStatus
    {
    
        public static void CheckBatteryCondition(float temperature, float soc, float chargeRate)
        {
            BatteryCondition.CheckTemperature(temperature);
            BatteryCondition.CheckChargeState(soc);
            BatteryCondition.CheckChargeRate(chargeRate);
        }

        public static void DisplayBatteryCondition(string attribute, BatteryStates batteryCondition)
        {
            Console.WriteLine($"Battery {attribute} is {batteryCondition}");
        }
    }
}
