using NUnit.Framework;


namespace TestStudying.Tests
{
    [TestFixture]
    class ProgramTests
    {
        [TestCase(3,6,9)]
        [TestCase(1, 2, 3)]
        [TestCase(4, -2, 2)]
        public void Should_Add_Given_Numbers(int x, int y, int z)
        {
            var result = CreateProgram().Add(x, y);
            Assert.AreEqual(result, z);
        }


        [Test]
        public void testMultiplication() {
            Dollar five = Money.dollar(5);
            Assert.AreEqual(Money.dollar(10), five.times(2));
            Assert.AreEqual(Money.dollar(15), five.times(3));
        }

        [Test]
        public void testFrancMultiplication() {
            Money five = Money.franc(5);
            Assert.AreEqual(Money.franc(10), five.times(2));
            Assert.AreEqual(Money.franc(15), five.times(3));
        }

        [Test]
        public void testEquality() {
            Assert.AreEqual(Money.dollar(5).Equals(Money.dollar(5)), true);
            Assert.AreEqual(Money.dollar(5).Equals(Money.dollar(6)), false);
            Assert.AreEqual(Money.franc(5).Equals(Money.franc(5)), true);
            Assert.AreEqual(Money.franc(5).Equals(Money.franc(6)), false);
            Assert.AreEqual(Money.franc(5).Equals(Money.dollar(6)), false);
        }

        [Test]
        public void testCurrency() {
            Assert.AreEqual("USD", Money.dollar(1).Currency());
            Assert.AreEqual("CHF", Money.franc(1).Currency());
        }

        [Test]
        public void testDifferentClassEquality() {
            Assert.AreEqual(new Money(10,"CHF").Equals(new Franc(10,"CHF")), true);
        }


        public Program CreateProgram()
        {
            return new Program();
        }

        

    }
}
