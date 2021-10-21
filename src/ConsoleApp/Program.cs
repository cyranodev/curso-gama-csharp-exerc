using System;
using Gama.ATM;
using Gama.ATM.Entities;
using Gama.ATM.Infra;
using Gama.ATM.Queries;
using Gama.ATM.Shared.Interfaces;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var repository = new Repository<Takeout>();
            var writeRepo = (IWriteRepository<Takeout>)repository;
            var readRepo = (IReadRepository<Takeout>)repository;

            Console.WriteLine(ATM.Withdraw(100, writeRepo));

            Console.WriteLine(ATM.Withdraw(105, writeRepo));

            Console.WriteLine(ATM.Withdraw(7, writeRepo));

            var readAllQuery = new ReadWithdrawalsQuery(readRepo);

            var storedWithdrawals = readAllQuery.ReadAll();

            foreach (var takeout in storedWithdrawals)
            {
                string summary = $"Withdrawal of {takeout.Value} as:\n";
                foreach (var bill in takeout.Cash)
                {
                    summary += $"{bill.quantity} notes of {bill.moneybill}\n";
                }
                Console.WriteLine($"{summary}\n");
            }
        }
    }
}