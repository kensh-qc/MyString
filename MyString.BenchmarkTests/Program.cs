using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MyString.BenchmarkTests
{
    public class MyStringBenchmark
    {
        private readonly string _string;
        private readonly MyString _myString;
        private readonly MyString _myString2;
        private readonly MyString _myString3;

        public MyStringBenchmark()
        {
            var text = "Create a new console application, write a class with methods that you want to measure, and mark them with the Benchmark attribute. In the following example, we compare the MD5 and SHA256 cryptographic hash functions";
            this._string = new String(text);
            this._myString = new MyString(text);
            this._myString2 = new MyString(text);
            this._myString3 = new MyString(text);
        }

        [Benchmark]
        public int StringIndexOf() => this._string.IndexOf("cryptographic");

        [Benchmark]
        public int MyStringIndexOf() => this._myString.IndexOf("cryptographic");

        [Benchmark]
        public int MyStringIndexOf2() => this._myString.IndexOf2("cryptographic");

        [Benchmark]
        public int MyStringIndexOf3() => this._myString.IndexOf3("cryptographic");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
