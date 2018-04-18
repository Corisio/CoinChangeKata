using System;

namespace CoinChangeKata
{
    public class Program
    {
        private static CoinChanger _coinChanger;

        public static void Main(string[] args)
        {
            _coinChanger = new CoinChanger();

            _coinChanger.GetChange(args);
        }
    }
}
