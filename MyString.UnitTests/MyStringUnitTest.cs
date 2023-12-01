namespace MyString.UnitTests
{
    [TestClass]
    public class MyStringUnitTest
    {
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

            Assert.AreEqual(
                stringObj.EndsWith(testPositive),
                myString.EndsWith(testPositive),
                "EndsWith test positive, 3 chars"
            );
            Assert.AreEqual(stringObj.EndsWith(testNegative), myString.EndsWith(testNegative), "EndsWith test negative");
            Assert.AreEqual(stringObj.EndsWith(longText), myString.EndsWith(longText), "EndsWith test too long text");
            Assert.AreEqual(stringObj.EndsWith(sameText), myString.EndsWith(sameText), "EndsWith test same text");
        }

        [TestMethod, TestCategory("IndexOf")]
        public void IndexOfTest()
        {
            Assert.AreEqual(new String("Hello").IndexOf("e"), new MyString("Hello").IndexOf("e"), "Hello, e");
            Assert.AreEqual(new String("Hello World!").IndexOf("ld!"), new MyString("Hello World!").IndexOf("ld!"), "Hello World!, ld!");
            Assert.AreEqual(new String("Hello World!").IndexOf("World"), new MyString("Hello World!").IndexOf("World"), "Hello World!, World");
            Assert.AreEqual(new String("Hello World!").IndexOf("WorldDDD"), new MyString("Hello World!").IndexOf("WorldDDD"), "Hello World!, WorldDDD");
            Assert.AreEqual(new String("Hello World!").IndexOf("a"), new MyString("Hello World!").IndexOf("a"), "Hello World!, a");
            Assert.AreEqual(new String("Hello World!").IndexOf("ld."), new MyString("Hello World!").IndexOf("ld."), "Hello World!, ld.");
            Assert.AreEqual(new String("Hello World!").IndexOf("Ae"), new MyString("Hello World!").IndexOf("Ae"), "Hello World!, Ae");
            Assert.AreEqual(new String("Hello").IndexOf("Hello"), new MyString("Hello").IndexOf("Hello"), "Hello");
            Assert.AreEqual(new String("a").IndexOf("a"), new MyString("a").IndexOf("a"), "a");
            Assert.AreEqual(new String("ababababc").IndexOf("abc"), new MyString("ababababc").IndexOf("abc"), "ababababc, abc");
            Assert.AreEqual(new String("ababababc").IndexOf("bab"), new MyString("ababababc").IndexOf("bab"), "ababababc, bab");
            Assert.AreEqual(new String("").IndexOf(""), new MyString("").IndexOf(""), "(empty string value and indexOf)");
            Assert.AreEqual(new String("aaaabc").IndexOf("aabc"), new MyString("aaaabc").IndexOf("aabc"), "(aaaabc, aabc)");
            Assert.AreEqual(new String("aaaaabc").IndexOf("aaabc"), new MyString("aaaaabc").IndexOf("aaabc"), "(aaaaabc, aaabc)");
            Assert.AreEqual(new String("Hello").IndexOf(""), new MyString("Hello").IndexOf(""), "(empty string)");
            Assert.AreEqual(new String("a").IndexOf("abc"), new MyString("a").IndexOf("abc"), "abc");
            Assert.AreEqual(new String("abcabcd").IndexOf("abcd"), new MyString("abcabcd").IndexOf("abcd"), "abcd");
            Assert.AreEqual(new String("abcdeabcda").IndexOf("abcda"), new MyString("abcdeabcda").IndexOf("abcda"), "abcda");
        }
    }
}