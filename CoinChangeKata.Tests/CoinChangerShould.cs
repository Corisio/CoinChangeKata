using System;
using System.Linq;
using NUnit.Framework;

namespace CoinChangeKata.Tests
{
    [TestFixture]
    public class CoinChangerShould
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

        [TestCase(null)]
        [TestCase("")]
        [TestCase("1")]
        public void throw_exception_when_there_are_less_than_two_arguments(string argument)
        {
            Assert.Throws<Exception>(() => _coinChanger.GetChange(new[] { argument }));
        }
    }
}
