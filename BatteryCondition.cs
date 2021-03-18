using System;

namespace BatteryManagement
{
    internal static class BatteryCondition
    {
        public static void CheckChargeRate(float chargeRate)
        {
          BatteryStates batteryChargeRate =CheckBatteryCondition(chargeRate, Constants.minChargeRate, Constants.maxChargeRate);
            TestBatteryStatus.DisplayBatteryCondition("Charge Rate", batteryChargeRate);
        }

        public static void CheckChargeState(float soc)
        {
           BatteryStates batteryChargeState =CheckBatteryCondition(soc, Constants.minStateOfCharge, Constants.maxStateOfCharge);
            TestBatteryStatus.DisplayBatteryCondition("State of charge", batteryChargeState);
        }

        public static void CheckTemperature(float temperature)
        {
            BatteryStates batteryTemperature =CheckBatteryCondition(temperature, Constants.minTemperature, Constants.maxTemperature);
            TestBatteryStatus.DisplayBatteryCondition("Temperature", batteryTemperature);
        }
        public static BatteryStates CheckBatteryCondition(float actualValue, float minValue, float maxValue)
        {
            if (CheckMaxCondition(actualValue, maxValue) == BatteryStates.High)
            {
                return BatteryStates.High;
            }

            if (CheckMinCondition(actualValue, minValue) == BatteryStates.Low)
            {
                return BatteryStates.Low;

            }

            return BatteryStates.Normal;
        }
         private static BatteryStates CheckMaxCondition(float actualValue, float maxValue)
        {
            if (actualValue > maxValue)
            {
                return BatteryStates.High;
            }
            return BatteryStates.Normal;
        }

        private static BatteryStates CheckMinCondition(float actualValue, float minValue)
        {
            if (actualValue < minValue)
            {
                return BatteryStates.Low;
            }
            return BatteryStates.Normal;
        }
    }
}
