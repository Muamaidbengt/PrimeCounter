using ConsoleApp1;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        public ITestOutputHelper Logger { get; }
        private readonly PrimeCounter _sut;

        public UnitTest1(ITestOutputHelper logger)
        {
            Logger = logger;
            _sut = new PrimeCounter(25);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(83)]
        public void IsPrime(long n)
        {
            Assert.True(_sut.IsPrime(n));
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(93)]
        public void IsNotPrime(long n)
        {
            Assert.False(_sut.IsPrime(n));
        }

        [Fact]
        public void TwentyFifthPrime()
        {
            Assert.Equal(97, _sut.LargestPrime);
        }
    }
}
