using System;

namespace BatteryManagement
{
    class Checker
    {
        static int Main()
        {
            TestBatteryStatus.CheckBatteryCondition(25, 70, 0.7f);
            TestBatteryStatus.CheckBatteryCondition(40, 60, 0.4f);
            return 0;
        }
    }
}
