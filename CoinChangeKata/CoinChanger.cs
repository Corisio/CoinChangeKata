using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChangeKata
{
    public class CoinChanger
    {
        public int[] GetChange(string[] args)
        {
            var amount = 0;
            int[] coinValues = new int[args.Length - 1];
            int[] change = new int[args.Length - 1];

            if (args.Length < 2)
            {
                throw new Exception();
            }

            amount = GetParsedValues(args, coinValues, amount);

            change[0] = amount;

            return change;
        }

        private static int GetParsedValues(string[] args, int[] coinValues, int amount)
        {
            for (var i = 0; i < args.Length; i++)
            {
                var value = args[i];
                if (!int.TryParse(value, out int output) || output < 0)
                {
                    throw new ArgumentException($"Invalid value ({output})");
                }

                if (i > 0)
                {
                    coinValues[i - 1] = output;
                }
                else
                {
                    amount = output;
                }
            }

            if (amount < coinValues[0] && amount > 0)
            {
                throw new Exception();
            }

            return amount;
        }
    }
}
