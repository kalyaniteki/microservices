using NUnit.Framework;

namespace NunitTestproject
{
    [TestFixture]
    public class TestCalculate
    {
        Calculate obj = null;
        [SetUp]
        public void Setup()
        {
            obj = new Calculate();
        }

        [Test]
        public void TestAdd()
        {
            int actual = obj.Add(3, 5);
            int expected = 8;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [Description("Test Greet method")]
        public void GreetTest()
        {
            string result = obj.Greet("Sachin");
            Assert.NotNull(result);
            Assert.AreEqual("Hello Sachin",result);
        }
    }
}