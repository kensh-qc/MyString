namespace MyString.UnitTests
{
    [TestClass]
    public class MyStringUnitTest
    {
        [TestMethod]
        public void AtTestPositiveWithinRange()
        {
            var str = new MyString("Hello");
            Assert.AreEqual("H", str.At(0));
            Assert.AreEqual("l", str.At(3));
            Assert.AreEqual("o", str.At(4));
        }

        [TestMethod]
        public void AtTestPositiveOutsideOfRange()
        {
            var str = new MyString("Hello");
            Assert.IsNull(str.At(100));
        }
        [TestMethod]
        public void AtTestNegativeWithinRange()
        {
            var str = new MyString("Hello");
            Assert.AreEqual("o", str.At(-1));
            Assert.AreEqual("l", str.At(-2));
            Assert.AreEqual("e", str.At(-4));
            Assert.AreEqual("H", str.At(-5));
        }
    }
}