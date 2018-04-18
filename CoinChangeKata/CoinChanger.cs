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
            var change = 0;
            int[] coinValues = new int[args.Length - 1];
            int[] result = new int[args.Length - 1];

            if (args.Length < 2)
            {
                throw new Exception();
            }

            change = GetParsedValues(args, coinValues, change);

            if (change == 1)
            {
                result[0] = 1;
            }

            return result;
        }

        private static int GetParsedValues(string[] args, int[] coinValues, int change)
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
                    change = output;
                }
            }

            return change;
        }
    }
}
