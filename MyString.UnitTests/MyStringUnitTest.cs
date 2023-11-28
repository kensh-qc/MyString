namespace MyString.UnitTests
{
    [TestClass]
    public class MyStringUnitTest
    {
        [TestMethod, TestCategory("At")]
        public void AtTest()
        {
            var str = "Hello";

            Assert.AreEqual("H", MyString.At(0, str), "At test positive within range, 0");
            Assert.AreEqual("l", MyString.At(3, str), "At test positive within range, 3");
            Assert.AreEqual("o", MyString.At(4, str), "At test positive within range, 4");
            Assert.IsNull(MyString.At(100, str), "At test positive outside range, 100");
            Assert.IsNull(MyString.At(-100, str), "At test negative outside range, -100");
            Assert.AreEqual("o", MyString.At(-1, str), "At test negative within range, -1");
            Assert.AreEqual("l", MyString.At(-2, str), "At test negative within range, -2");
            Assert.AreEqual("e", MyString.At(-4, str), "At test negative within range, -4");
            Assert.AreEqual("H", MyString.At(-5, str), "At test negative within range, -5");
        }

        [TestMethod, TestCategory("Concat")]
        public void ConcatTest()
        {
            var str1 = "Hello";
            var str2 = " World!";
            var str3 = " and more";
            var str4 = " even more";
            var str5 = " and last time.";

            Assert.AreEqual(String.Concat(str1, str2), MyString.Concat(str1, str2), "Concat test 2 string args");
            Assert.AreEqual(String.Concat(str1, str2, str3, str4, str5), MyString.Concat(str1, str2, str3, str4, str5), "Concat test multiple agrs");
            Assert.AreEqual(String.Concat(null, null), MyString.Concat(null, null), "Concat test null in args");
        }

        [TestMethod, TestCategory("Contains")]
        public void ContainsTest()
        {
            var mainText = "Hello World! We need your help.";
            var myString = new MyString(mainText);
            var stringObj = new String(mainText);
            var searchText = "need";
            var noText = "Alex";
            var empty = "";

            Assert.AreEqual(stringObj.Contains(searchText), myString.Contains(searchText), "Contains test text positive case");
            Assert.AreEqual(stringObj.Contains(noText), myString.Contains(noText), "Contains test text negative case");
            Assert.AreEqual(stringObj.Contains(empty), myString.Contains(empty), "Contains test text is empty case");
        }

        [TestMethod, TestCategory("Join")]
        public void JoinTest()
        {
            var separator = ", ";
            var str1 = "Oleksii";
            var str2 = "Dmytro";
            var str3 = "Taras";

            Assert.AreEqual(String.Join(separator, str1, str2, str3), MyString.Join(separator, str1, str2, str3), "Join test multiple args");
            Assert.AreEqual(String.Join(null, null, null), MyString.Join(null, null, null), "Join test null in args");
        }

        [TestMethod, TestCategory("EndsWith")]
        public void EndsWithTest()
        {
            var text = "Hello World!";
            var myString = new MyString(text);
            var stringObj = new String(text);
            var testPositive = "ld!";
            var testNegative = "Check";
            var sameText = "Hello World!";
            var longText = "Check Hello World!";

            Assert.AreEqual(stringObj.EndsWith(testPositive), myString.EndsWith(testPositive), "EndsWith test positive, 3 chars");
            Assert.AreEqual(stringObj.EndsWith(testNegative), myString.EndsWith(testNegative), "EndsWith test negative");
            Assert.AreEqual(stringObj.EndsWith(longText), myString.EndsWith(longText), "EndsWith test too long text");
            Assert.AreEqual(stringObj.EndsWith(sameText), myString.EndsWith(sameText), "EndsWith test same text");
        }


    }
}