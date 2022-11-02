using NUnit.Framework;

namespace Common
{
    [TestFixture]
    public class SumTest
    {
        [Test]
        public void DoIt_2And3_Is5()
        {
            Assert.That(Sum.DoIt(2, 3), Is.EqualTo(5));
        }
    }
}
