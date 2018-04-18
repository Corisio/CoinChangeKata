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

        [TestCase("1,j")]
        [TestCase("a,1")]
        [TestCase("1,1,j")]
        [TestCase("1,1,1,j")]
        [TestCase("1.1,j")]
        [TestCase("a,1.4")]
        [TestCase("-1,j")]
        [TestCase("a,-1")]
        public void throw_argument_exception_when_any_argument_is_not_a_natural_number_or_zero(string argument)
        {
            Assert.Throws<ArgumentException>(() => _coinChanger.GetChange(argument.Split(',')));
        }

        [TestCase("0,1,2,5,10,20,50,100,200")]
        public void return_not_empty_result_when_the_values_are_valid(string argument)
        {
            var result = _coinChanger.GetChange(argument.Split(','));

            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }

        [TestCase("0,1,2,5,10,20,50,100,200")]
        public void return_all_zeroes_when_the_change_is_zero(string argument)
        {
            var result = _coinChanger.GetChange(argument.Split(','));

            foreach (var numberOfCoins in result)
            {
                Assert.AreEqual(0, numberOfCoins);
            }
        }

        [Test]
        public void return_one_coin_for_one_as_input()
        {
            var result = _coinChanger.GetChange(new[] {"1", "1"});

            foreach (var numberOfCoins in result)
            {
                Assert.AreEqual(1, numberOfCoins);
            }
        }
    }
}
