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

            if (!Decimal.TryParse(args[0], out decimal output))
            {
                throw new Exception();
            }
        }
    }
}
