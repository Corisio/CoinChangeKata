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
            int[] result = new int [args.Length - 1];

            if (args.Length < 2)
            {
                throw new Exception();
            }

            for (var i = 0; i < args.Length; i++)
            {
                var value = args[i];
                if (!int.TryParse(value, out int output) || output < 0)
                {
                    throw new ArgumentException($"Invalid value ({output})");
                }

                if (i > 0)
                {
                    if (output == 0)
                    {
                        result[i-1] = 0;
                    }
                }
            }

            return result;
        }
    }
}
