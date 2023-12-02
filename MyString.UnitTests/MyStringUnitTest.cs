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

        [TestMethod, TestCategory("LastIndexOf")]
        public void LastIndexOfTest()
        {
            Assert.AreEqual(new String("Hello").LastIndexOf("e"), new MyString("Hello").LastIndexOf("e"), "Hello, e");
            Assert.AreEqual(new String("Hello World!").LastIndexOf("ld!"), new MyString("Hello World!").LastIndexOf("ld!"), "Hello World!, ld!");
            Assert.AreEqual(new String("Hello World!").LastIndexOf("World"), new MyString("Hello World!").LastIndexOf("World"), "Hello World!, World");
            Assert.AreEqual(new String("Hello World!").LastIndexOf("WorldDDD"), new MyString("Hello World!").LastIndexOf("WorldDDD"), "Hello World!, WorldDDD");
            Assert.AreEqual(new String("Hello World!").LastIndexOf("a"), new MyString("Hello World!").LastIndexOf("a"), "Hello World!, a");
            Assert.AreEqual(new String("Hello World!").LastIndexOf("ld."), new MyString("Hello World!").LastIndexOf("ld."), "Hello World!, ld.");
            Assert.AreEqual(new String("Hello World!").LastIndexOf("Ae"), new MyString("Hello World!").LastIndexOf("Ae"), "Hello World!, Ae");
            Assert.AreEqual(new String("Hello").LastIndexOf("Hello"), new MyString("Hello").LastIndexOf("Hello"), "Hello, Hello");
            Assert.AreEqual(new String("a").LastIndexOf("a"), new MyString("a").LastIndexOf("a"), "a");
            Assert.AreEqual(new String("ababababc").LastIndexOf("abc"), new MyString("ababababc").LastIndexOf("abc"), "ababababc, abc");
            Assert.AreEqual(new String("ababababc").LastIndexOf("bab"), new MyString("ababababc").LastIndexOf("bab"), "ababababc, bab");
            Assert.AreEqual(new String("").LastIndexOf(""), new MyString("").LastIndexOf(""), "(empty string value and indexOf)");
            Assert.AreEqual(new String("aaaabc").LastIndexOf("aabc"), new MyString("aaaabc").LastIndexOf("aabc"), "(aaaabc, aabc)");
            Assert.AreEqual(new String("aaaaabc").LastIndexOf("aaabc"), new MyString("aaaaabc").LastIndexOf("aaabc"), "(aaaaabc, aaabc)");
            Assert.AreEqual(new String("Hello").LastIndexOf(""), new MyString("Hello").LastIndexOf(""), "(empty string)");
            Assert.AreEqual(new String("a").LastIndexOf("abc"), new MyString("a").LastIndexOf("abc"), "abc");
            Assert.AreEqual(new String("abcabcd").LastIndexOf("abcd"), new MyString("abcabcd").LastIndexOf("abcd"), "abcd");
            Assert.AreEqual(new String("abcdeabcda").LastIndexOf("abcda"), new MyString("abcdeabcda").LastIndexOf("abcda"), "abcda");
        }

        [TestMethod, TestCategory("IndexOfFuzzy")]
        public void IndexOfFuzzyTest()
        {
            // "Hello World"
            // "*ello" indexOfFuzzy == 0
            Assert.AreEqual(0, new MyString("").IndexOfFuzzy(""), "empty string, empty string");
            Assert.AreEqual(0, new MyString("*").IndexOfFuzzy(""), "*, empty string");
            Assert.AreEqual(-1, new MyString("Hello").IndexOfFuzzy("*d"), "Hello, *d");
            Assert.AreEqual(0, new MyString("Hello World").IndexOfFuzzy("*ello"), "Hello World, *ello");
            Assert.AreEqual(3, new MyString("Hello World").IndexOfFuzzy("*o***"), "Hello World, *o***");
            Assert.AreEqual(0, new MyString("Hello World").IndexOfFuzzy("*****"), "Hello World, *****");
            Assert.AreEqual(0, new MyString("Hello World").IndexOfFuzzy("*"), "Hello World, *");
            Assert.AreEqual(0, new MyString("*").IndexOfFuzzy("*"), "*, *");
            Assert.AreEqual(9, new MyString("Hello World").IndexOfFuzzy("*d"), "Hello World, *d");
            Assert.AreEqual(9, new MyString("Hello World").IndexOfFuzzy("[d", '['), "Hello World, [d");
        }

        [TestMethod, TestCategory("Insert")]
        public void InsertTest()
        {
            Assert.AreEqual(new String("hello ").Insert(6, "world"), new MyString("hello ").Insert(6, "world"));
            Assert.AreEqual(new String("hello ").Insert(6, ""), new MyString("hello ").Insert(6, ""));
            Assert.AreEqual(new String("hello ").Insert(0, "Test"), new MyString("hello ").Insert(0, "Test"));
            Assert.AreEqual(new String("hello test message").Insert(6, "world"), new MyString("hello test message").Insert(6, "world"));
        }

        [TestMethod, TestCategory("IsNullOrEmpty")]
        public void IsNullOrEmptyTest()
        {
            Assert.AreEqual(String.IsNullOrEmpty(""), MyString.IsNullOrEmpty(""));
            Assert.AreEqual(String.IsNullOrEmpty(null), MyString.IsNullOrEmpty(null));
            Assert.AreEqual(String.IsNullOrEmpty("test"), MyString.IsNullOrEmpty("test"));
        }

        [TestMethod, TestCategory("IsNullOrWhiteSpace")]
        public void IsNullOrWhiteSpaceTest()
        {
            Assert.AreEqual(String.IsNullOrEmpty(" "), MyString.IsNullOrEmpty(" "));
            Assert.AreEqual(String.IsNullOrEmpty(null), MyString.IsNullOrEmpty(null));
            Assert.AreEqual(String.IsNullOrEmpty("test"), MyString.IsNullOrEmpty("test"));
        }

        [TestMethod, TestCategory("PadLeft")]
        public void PadLeft()
        {
            Assert.AreEqual(new String("Hello").PadLeft(4), new MyString("Hello").PadLeft(4));
            Assert.AreEqual(new String("Hello").PadLeft(7), new MyString("Hello").PadLeft(7));
            Assert.AreEqual(new String("Hello").PadLeft(20), new MyString("Hello").PadLeft(20));
            Assert.AreEqual(new String("Hello").PadLeft(0), new MyString("Hello").PadLeft(0));
            Assert.AreEqual(new String("Hello").PadLeft(8, '*'), new MyString("Hello").PadLeft(8, '*'));
            Assert.AreEqual(new String("Hello").PadLeft(0, '*'), new MyString("Hello").PadLeft(0, '*'));
        }

        [TestMethod, TestCategory("PadRight")]
        public void PadRight()
        {
            Assert.AreEqual(new String("Hello").PadRight(4), new MyString("Hello").PadRight(4));
            Assert.AreEqual(new String("Hello").PadRight(7), new MyString("Hello").PadRight(7));
            Assert.AreEqual(new String("Hello").PadRight(20), new MyString("Hello").PadRight(20));
            Assert.AreEqual(new String("Hello").PadRight(0), new MyString("Hello").PadRight(0));
            Assert.AreEqual(new String("Hello").PadRight(8, '*'), new MyString("Hello").PadRight(8, '*'));
            Assert.AreEqual(new String("Hello").PadRight(0, '*'), new MyString("Hello").PadRight(0, '*'));
        }
    }
}