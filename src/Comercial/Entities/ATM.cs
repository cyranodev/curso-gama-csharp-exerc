using System;
using Gama.ATM.Queries;
using Gama.ATM.Services;
using Gama.ATM.Shared.Interfaces;

namespace Gama.ATM.Entities
{
    public static class ATM
    {
        public static Takeout Withdraw(int value, IWriteRepository<Takeout> repository)
        {
            try
            {
                var takeout = WithdrawService.Execute(value);
                using (var query = new WriteWithdrawQuery(repository))
                {
                    query.Write(takeout);
                }
                return takeout;
            }
            catch (NotImplementedException e)
            {
                return null;
            }
        }
    }
}