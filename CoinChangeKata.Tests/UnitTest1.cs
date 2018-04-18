using NUnit.Framework;

namespace CoinChangeKata.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        private CoinChanger _coinChanger;

        [SetUp]
        public void Setup()
        {
            _coinChanger = new CoinChanger();
        }

        [Test]
        public void coin_changer_exists()
        {
            Assert.IsInstanceOf<CoinChanger>(_coinChanger);
        }
    }
}
