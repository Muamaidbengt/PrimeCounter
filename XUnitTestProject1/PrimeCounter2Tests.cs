using ConsoleApp1;
using FluentAssertions;
using Xunit;

namespace XUnitTestProject1
{
    public class PrimeCounter2Tests
    {
        private PrimeCounter2 _sut = new PrimeCounter2();

        [Fact]
        public void PrimesLessThanTwo()
        {
             _sut.CountPrimesLessThanOrEqualTo(1).Should().Be(0);
        }

        [Fact]
        public void PrimesEqualToTwo()
        {
            _sut.CountPrimesLessThanOrEqualTo(2).Should().Be(1);
        }
    }
}
