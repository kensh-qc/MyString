using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MyString
{
    public class MyString
    {
        private string _value;
        public MyString(string value)
        {
            this._value = value;
        }

        //String.Concat()
        public static string Concat(params string?[] text)
        {
            string concatStr = "";
            if (text.Length > 0)
            {
                var sb = new StringBuilder();
                foreach (var item in text)
                {
                    if (item != null)
                    {
                        sb.Append(item);
                    }
                }

                concatStr = sb.ToString();
            }

            return concatStr;
        }

        //String.Contains()
        public bool Contains(string text)
        {
            bool contains = false;

            Regex search = new Regex(text);

            if (search.IsMatch(this._value)) { contains = true; }

            return contains;
        }

        //String.EndsWith()
        public bool EndsWith(string text)
        {
            bool isEndsWith = false;

            if (text.Length <= this._value.Length)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] != this._value[this._value.Length - (text.Length - i)])
                    {
                        break;
                    }

                    if (i + 1 == text.Length)
                    {
                        isEndsWith = true;
                    }
                }
            }

            return isEndsWith;
        }

        //String.Join()
        public static string Join(string? separator, params string?[] text)
        {
            string joinStr = "";

            if (text.Length > 0)
            {
                var sb = new StringBuilder();

                foreach (var item in text)
                {
                    if (item != null)
                    {
                        if (separator != null && sb.Length > 0)
                        {
                            sb.Append(separator);
                        }
                        sb.Append(item);
                    }

                }

                joinStr = sb.ToString();
            }

            return joinStr;
        }

        //String.IndexOf()
        public int IndexOf(string toFind)
        {
            //Console.WriteLine($"[START] \"{this._value}\" IndexOf \"{toFind}\"");
            var startIndex = -1;
            var currentIndex = 0;
            var sbIndex = 0;
            bool matchInProgress = false;

            var sb = new StringBuilder(this._value);

            // "Hello".IndexOf("") && "".IndexOf("")
            if (toFind.Length == 0)
            {
                startIndex++;
                //Console.WriteLine($"[STOP] Found \"{this._value}\" indexOf \"{toFind}\" {startIndex}");
                return startIndex;
            }
            // "a".IndexOf("abc")
            else if (toFind.Length > this._value.Length)
            {
                //Console.WriteLine($"[STOP] NOT Found \"{this._value}\" indexOf \"{toFind}\" {startIndex}");
                return startIndex;
            }

            for (var i = 0; i < this._value.Length; i++)
            {
                if (!matchInProgress && sb[sbIndex] == toFind[currentIndex])
                {
                    startIndex = i;
                    if (currentIndex == toFind.Length - 1)
                    {
                        //Console.WriteLine($"[STOP] Found \"{this._value}\" indexOf \"{toFind}\" {startIndex}");
                        break; //Found!
                    }
                    matchInProgress = true;
                }
                else if (matchInProgress)
                {
                    currentIndex++;
                    sbIndex++;

                    if (sb[sbIndex] == toFind[currentIndex] && currentIndex == toFind.Length - 1)
                    {
                        //Console.WriteLine($"[STOP] Found \"{this._value}\" indexOf \"{toFind}\" {startIndex}");
                        break; //Found!
                    }
                    else if (sb[sbIndex] != toFind[currentIndex] && sbIndex == sb.Length - 1)
                    {
                        startIndex = -1;
                        //Console.WriteLine($"[STOP] NOT Found \"{this._value}\" indexOf \"{toFind}\" {startIndex}");
                        break; //Not found;
                    }

                    if (sb[sbIndex] != toFind[currentIndex])
                    {
                        i = startIndex - 1;
                        startIndex = -1;
                        matchInProgress = false;
                    }
                }
                else if (!matchInProgress)
                {
                    sb.Remove(0, 1);
                    sbIndex = 0;
                    currentIndex = 0;
                }
            }

            return startIndex;
        }

        public string Insert(int startIndex, string value)
        {
            throw new NotImplementedException();
        }
        public static bool IsNullOrEmpty(string? value)
        {
            throw new NotImplementedException();
        }
        public static bool IsNullOrWhiteSpace(string? value)
        {
            throw new NotImplementedException();
        }
        public int LastIndexOf(string value)
        {
            throw new NotImplementedException();
        }
        public string PadLeft(int totalWidth)
        {
            throw new NotImplementedException();
        }
        public string PadLeft(int totalWidth, char paddingChar)
        {
            throw new NotImplementedException();
        }
        public string PadRight(int totalWidth)
        {
            throw new NotImplementedException();
        }
        public string PadRight(int totalWidth, char paddingChar)
        {
            throw new NotImplementedException();
        }
        public string Remove(int startIndex)
        {
            throw new NotImplementedException();
        }
        public string Remove(int startIndex, int count)
        {
            throw new NotImplementedException();
        }
        public string Replace(string oldValue, string? newValue)
        {
            throw new NotImplementedException();
        }
        public string ReplaceLineEndings()
        {
            //Environment.NewLine;
            throw new NotImplementedException();
        }
        public string ReplaceLineEndings(string replacementText)
        {
            throw new NotImplementedException();
        }
        public string[] Split(params char[]? separator)
        {
            //Array.Resize
            throw new NotImplementedException();
        }
        public bool StartsWith(string value)
        {
            throw new NotImplementedException();
        }
        public string Substring(int startIndex)
        {
            throw new NotImplementedException();
        }
        public string Substring(int startIndex, int length)
        {
            throw new NotImplementedException();
        }
        public char[] ToCharArray(int startIndex, int length)
        {
            throw new NotImplementedException();
        }
        public char[] ToCharArray()
        {
            throw new NotImplementedException();
        }
        public string Trim()
        {
            throw new NotImplementedException();
        }
        public string Trim(params char[]? trimChars)
        {
            throw new NotImplementedException();
        }
        public string Trim(char trimChar)
        {
            throw new NotImplementedException();
        }
        public string TrimEnd()
        {
            throw new NotImplementedException();
        }
        public string TrimEnd(char trimChar)
        {
            throw new NotImplementedException();
        }
        public string TrimEnd(params char[]? trimChars)
        {
            throw new NotImplementedException();
        }
        public string TrimStart()
        {
            throw new NotImplementedException();
        }
        public string TrimStart(char trimChar)
        {
            throw new NotImplementedException();
        }
        public string TrimStart(params char[]? trimChars)
        {
            throw new NotImplementedException();
        }
        public static bool operator ==(MyString? a, MyString? b)
        {
            throw new NotImplementedException();
        }
        public static bool operator !=(MyString? a, MyString? b)
        {
            throw new NotImplementedException();
        }
        public static bool operator ==(MyString? a, string? b)
        {
            throw new NotImplementedException();
        }
        public static bool operator !=(MyString? a, string? b)
        {
            throw new NotImplementedException();
        }
        public static bool operator *(MyString? a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
