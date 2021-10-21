using System;
using System.Collections.Generic;

namespace Gama.ATM.Services
{
    public static class WithdrawService
    {
        private static readonly int[] Money = new int[] { 100, 50, 20, 10, 5 };

        public static Takeout Execute(int value)
        {
            try
            {
                ValidateWithdraw(value);
                var bills = GetBills(value);
                var takeout = new Takeout(value, bills);

                return takeout;
            }
            catch (NotImplementedException)
            {
                Console.WriteLine(@"
                ------------------
                Valor inválido.
                ------------------");
                throw;
            }
        }

        private static List<(int, int)> GetBills(int value)
        {
            var currValue = value;

            var bills = new List<(int, int)>();

            foreach (int cashValue in Money)
            {
                if (currValue == 0) break;
                if (currValue < cashValue) continue;
                (int moneybill, int quantity) tuple = (cashValue, currValue / cashValue);
                bills.Add(tuple);
                currValue -= tuple.moneybill * tuple.quantity;
            }

            if (currValue != 0) throw new NotImplementedException();

            return bills;
        }

        private static void ValidateWithdraw(int value)
        {
            if (value % 5 != 0) throw new NotImplementedException();
        }
    }
}