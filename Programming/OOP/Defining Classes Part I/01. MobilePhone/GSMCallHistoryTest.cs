using System;
using System.Collections.Generic;

namespace _01.MobilePhone
{
    public static class GSMCallHistoryTest
    {
        private static Call GetLongest(List<Call> calls)
        {
            var longest = calls[0];

            for (int i = 1; i < calls.Count; i++)
            {
                if (longest.Duration < calls[i].Duration)
                {
                    longest = calls[i];
                }
            }

            return longest;
        }

        public static void Run()
        {
            GSM test = GSM.IPhone4S;

            var testCall1 = new Call(DateTime.Now, "+1564897133548", new TimeSpan(0, 22, 05, 46));
            var testCall2 = new Call(DateTime.Now, "+359888888888", new TimeSpan(0, 5, 26, 1));
            var testCall3 = new Call(DateTime.Now, "+0492326646548", new TimeSpan(0, 0, 5, 46));
            var testCall4 = new Call(DateTime.Now, "+228845664564687", new TimeSpan(0, 0, 26, 03));
            var testCall5 = new Call(DateTime.Now, "+00178789777777", new TimeSpan(0, 1, 18, 48));

            test.AddCalls(testCall1, testCall2, testCall3, testCall4, testCall5);

            Console.WriteLine(string.Join(Environment.NewLine, test.CallHistory));
            Console.WriteLine("Total price: {0:c}", test.CalculateTotalCallPrice(0.37M));
            Console.WriteLine();

            test.RemoveCall(GetLongest(test.CallHistory));

            Console.WriteLine(string.Join(Environment.NewLine, test.CallHistory));
            Console.WriteLine("Total price: {0:C}", test.CalculateTotalCallPrice(0.37M));
            Console.WriteLine();

            test.ClearCallHistory();
        }
    }
}