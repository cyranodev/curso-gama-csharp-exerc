using System.Collections.Generic;
using Gama.ATM.Shared.Entities;

namespace Gama.ATM
{
    public class Takeout : Entity
    {
        public Takeout(int value, List<(int, int)> cash)
        {
            Value = value;
            Cash = cash;
        }

        public List<(int moneybill, int quantity)> Cash { get; init; }
        public int Value { get; private set; }

        public override string ToString()
        {
            return $"Takeout value of {Value}";
        }
    }
}