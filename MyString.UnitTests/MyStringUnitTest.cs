namespace MyString.UnitTests
{
    [TestClass]
    public class MyStringUnitTest
    {
        [TestMethod, TestCategory("At")]
        public void AtTestPositiveWithinRange()
        {
            var str = new MyString("Hello");
            Assert.AreEqual("H", str.At(0));
            Assert.AreEqual("l", str.At(3));
            Assert.AreEqual("o", str.At(4));
        }

        [TestMethod, TestCategory("At")]
        public void AtTestPositiveOutsideOfRange()
        {
            var str = new MyString("Hello");
            Assert.IsNull(str.At(100));
        }

        [TestMethod, TestCategory("At")]
        public void AtTestNegativeOutsideOfRange()
        {
            var str = new MyString("Hello");
            Assert.IsNull(str.At(-100));
        }

        [TestMethod, TestCategory("At")]
        public void AtTestNegativeWithinRange()
        {
            var str = new MyString("Hello");
            Assert.AreEqual("o", str.At(-1));
            Assert.AreEqual("l", str.At(-2));
            Assert.AreEqual("e", str.At(-4));
            Assert.AreEqual("H", str.At(-5));
        }

        [TestMethod, TestCategory("Concat")]
        public void ConcatTestSingle()
        {
            var str = new MyString("Hello");
            var str1 = " World!";

            Assert.AreEqual("Hello World!", str.Concat(str1));
        }

        [TestMethod, TestCategory("Concat")]
        public void ConcatTestMultiple()
        {
            var str = new MyString("Hello");
            var str1 = " Concat test";
            var str2 = " one more";
            var str3 = " and more";
            var str4 = " even more";
            var str5 = " and last time.";
            Assert.AreEqual("Hello Concat test one more and more even more and last time.", str.Concat(str1, str2, str3, str4, str5));
        }

        [TestMethod, TestCategory("Concat")]
        public void ConcatNoArgs()
        {
            var str = new MyString("Hello");
            Assert.IsNull(str.Concat());
        }

        [TestMethod, TestCategory("Concat")]
        public void ConcatObjectWithinParams()
        {
            var str = new MyString("Hello");
            var obj1 = new Object();
            var str1 = "Test";
            var str2 = "Test2";

            Assert.AreEqual(String.Concat("Hello", obj1, str1, str2), str.Concat(obj1, str1, str2));
        }
    }
}