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
            var startIndex = -1;
            var currentIndex = 0;
            bool matchInProgress = false;

            for (int i = 0; i < this._value.Length; i++)
            {
                if (toFind[0] == this._value[i] && !matchInProgress)
                {
                    startIndex = i;

                    if (toFind.Length == 1)
                    {
                        break;
                    }

                    currentIndex = 1;
                    matchInProgress = true;
                }
                else if (matchInProgress)
                {
                    if (toFind[currentIndex] == this._value[i])
                    {
                        if (currentIndex + 1 < toFind.Length)
                        {
                            currentIndex++;
                            continue;
                        }
                        else if (currentIndex + 1 == toFind.Length)
                        {
                            break;
                        }
                        else
                        {
                            startIndex = -1;
                            break;
                        }
                    }
                    else
                    {
                        if (toFind.Length >= this._value.Length - i)
                        {
                            startIndex = -1;
                            break;
                        }
                        else
                        {
                            matchInProgress = false;
                            continue;
                        }

                    }
                }
                else
                {
                    if (this._value.Length - i >= toFind.Length)
                    {
                        continue;
                    }
                    else
                    {
                        startIndex = -1;
                        break;
                    }
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
