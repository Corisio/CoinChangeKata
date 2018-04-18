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

        [TestCase("22,1,2,5,10,20,50,100,200")]
        public void return_not_empty_result_when_the_values_are_valid(string argument)
        {
            var result = _coinChanger.GetChange(argument.Split(','));

            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }

        [TestCase("0,1,2,5,10,20,50,100,200")]
        public void return_all_zeroes_when_the_amount_is_zero(string argument)
        {
            var result = _coinChanger.GetChange(argument.Split(','));

            foreach (var numberOfCoins in result)
            {
                Assert.AreEqual(0, numberOfCoins);
            }
        }

        [TestCase("1,5")]
        public void throw_exception_when_the_amount_is_not_zero_and_lower_than_the_smallest_coin(string argument)
        {
            Assert.Throws<Exception>(() => _coinChanger.GetChange(argument.Split(',')));
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

        [Test]
        public void return_two_one_coins_for_two_as_input()
        {
            var result = _coinChanger.GetChange(new[] {"2", "1"});

            foreach (var numberOfCoins in result)
            {
                Assert.AreEqual(2, numberOfCoins);
            }
        }

        [TestCase("6,1,5,10,25,100", "1,1,0,0,0")]
        [TestCase("11,1,5,10,25,100", "1,0,1,0,0")]
        public void return_valid_number_of_coins_for_multiple_coin_values(string arguments, string expectedResult)
        {
            var parsedExpectedResult = expectedResult.Split(',').Select(int.Parse).ToArray();
            var result = _coinChanger.GetChange(arguments.Split(','));

            Assert.AreEqual(parsedExpectedResult.Length, result.Length);

            for (int i = 0; i < parsedExpectedResult.Length; i++)
            {
                Assert.AreEqual(parsedExpectedResult[i], result[i]);
            }
        }
    }
}
