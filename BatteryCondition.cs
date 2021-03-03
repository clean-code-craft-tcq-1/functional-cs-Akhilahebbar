using System;

namespace BatteryManagement
{
    internal class BatteryCondition
    {
        public static void CheckChargeRate(float chargeRate)
        {
            Constants.BatteryStates batteryChargeRate =CheckBatteryCondition(chargeRate, Constants.minChargeRate, Constants.maxChargeRate);
            BatteryStatus.DisplayBatteryCondition("Charge Rate", batteryChargeRate);
        }

        public static void CheckChargeState(float soc)
        {
            Constants.BatteryStates batteryChargeState =CheckBatteryCondition(soc, Constants.minStateOfCharge, Constants.maxStateOfCharge);
            BatteryStatus.DisplayBatteryCondition("State of charge", batteryChargeState);
        }

        public static void CheckTemperature(float temperature)
        {
            Constants.BatteryStates batteryTemperature =CheckBatteryCondition(temperature, Constants.minTemperature, Constants.maxTemperature);
            BatteryStatus.DisplayBatteryCondition("Temperature", batteryTemperature);
        }
        public static Constants.BatteryStates CheckBatteryCondition(float currentValue, float minValue, float maxValue)
        {
            if (currentValue > maxValue)
            {
                return Constants.BatteryStates.High;

            }

            if (currentValue < minValue)
            {
                return Constants.BatteryStates.Low;

            }

            return Constants.BatteryStates.Normal;
        }
    }
}
