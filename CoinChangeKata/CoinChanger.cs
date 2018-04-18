using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChangeKata
{
    public class CoinChanger
    {
        public void GetChange(string[] args)
        {
            if (args.Length < 2)
            {
                throw new Exception();
            }

            foreach (var value in args)
            {
                if (!Decimal.TryParse(value, out decimal output) || output < 0 || output != Math.Truncate(output))
                {
                    throw new ArgumentException($"Invalid value ({output}");
                }

            }
        }
    }
}
