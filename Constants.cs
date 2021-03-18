using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
   
   public static class Constants
    {
        public static float minChargeRate = 0.3f;
        public static float maxChargeRate = 0.8f;
        public static float minStateOfCharge = 20;
        public static float maxStateOfCharge = 80;
         public static float minTemperature = 0;
        public static float maxTemperature = 45;

      
    }
       public  enum BatteryStates
        {
            Low,
            Normal,
            High
        }
}
