using System;

namespace _01.MobilePhone
{
    internal static class GSMTest
    {
        public static void Run()
        {
            var nokia = new GSM("3310", "Nokia", 5.23M, "Mia",
                new Battery("Lalallalaallal", 18, 5, BatteryType.NiCd),
                new Display(18.5, 18));

            var gsms = new[]
            {
                nokia,
                new GSM("Aria", "HTC", 500M, "Mimi",
                    new Battery("HTC", 200, 8, BatteryType.LiIon),
                    new Display(3, 65536)),
                GSM.IPhone4S
            };

            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm);
            }
        }
    }
}