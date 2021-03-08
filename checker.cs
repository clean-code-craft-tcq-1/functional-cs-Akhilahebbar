using System;

namespace BatteryManagement
{
    class Checker
    {
        static int Main()
        {
            BatteryStatus.CheckBatteryCondition(25, 70, 0.7f);
            BatteryStatus.CheckBatteryCondition(40, 60, 0.4f);
            return 0;
        }
    }
}
