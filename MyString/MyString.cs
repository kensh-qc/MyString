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

        // String.Concat()
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

        // String.Contains()
        public bool Contains(string text)
        {
            bool contains = false;

            Regex search = new Regex(text);

            if (search.IsMatch(this._value)) { contains = true; }

            return contains;
        }

        // String.EndsWith()
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

        // String.Join()
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
        // String.IndexOf3()
        public int IndexOf3(string query)
        {
            if (query.Length == 0)
            {
                return 0;
            }

            for (var i = 0; i < _value.Length; i++)
            {
                if (i < query.Length - 1) continue;

                for (int c = 0; c < query.Length; c++)
                {
                    if (_value[i - ((query.Length - 1) - c)] != query[c])
                    {
                        break;
                    }

                    if (c == query.Length - 1)
                    {
                        return i - (query.Length - 1);
                    }
                }
            }

            return -1;
        }
        // String.IndexOf2()
        public int IndexOf2(string query)
        {
            if (query.Length == 0)
            {
                return 0;
            }

            var sb = new StringBuilder();

            for (var i = 0; i < _value.Length; i++)
            {
                sb.Append(_value[i]);

                if (sb.Length == query.Length)
                {
                    if (sb.ToString() == query)
                    {
                        return i - (query.Length - 1);
                    }

                    sb.Remove(0, 1);
                }

            }

            return -1;
        }
        // String.IndexOf()
        public int IndexOf(string toFind)
        {
            // "Hello".IndexOf("") && "".IndexOf("")
            if (toFind.Length == 0)
            {
                return 0;
            }
            // "a".IndexOf("abc")
            else if (toFind.Length > this._value.Length)
            {
                return -1;
            }

            var startIndex = -1;
            var currentIndex = 0;
            var sbIndex = 0;
            bool matchInProgress = false;
            var sb = new StringBuilder(this._value);

            for (var i = 0; i < this._value.Length; i++)
            {
                if (!matchInProgress && sb[sbIndex] == toFind[currentIndex])
                {
                    startIndex = i;
                    if (currentIndex == toFind.Length - 1)
                    {
                        break; // Found
                    }
                    matchInProgress = true;
                }
                else if (matchInProgress)
                {
                    currentIndex++;
                    sbIndex++;

                    if (sb[sbIndex] == toFind[currentIndex] && currentIndex == toFind.Length - 1)
                    {
                        break; // Found
                    }
                    else if (sb[sbIndex] != toFind[currentIndex] && sbIndex == sb.Length - 1)
                    {
                        startIndex = -1;
                        break; // Not found
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
        // String.IndexOfFuzzy()
        public int IndexOfFuzzy(string query, char fuzzyChar = '*')
        {
            if (query.Length == 0)
            {
                return 0;
            }

            for (var i = 0; i < _value.Length; i++)
            {
                if (i < query.Length - 1) continue;

                for (int c = 0; c < query.Length; c++)
                {
                    if (_value[i - ((query.Length - 1) - c)] != query[c] && query[c] != fuzzyChar)
                    {
                        break;
                    }

                    if (c == query.Length - 1)
                    {
                        return i - (query.Length - 1);
                    }
                }
            }

            return -1;
        }
        // String.Insert()
        public string Insert(int startIndex, string query)
        {
            if (query.Length == 0)
            {
                return _value;
            }
            else if (query.Length > _value.Length)
            {

            }

            var result = new StringBuilder(_value);
            var end = new StringBuilder(_value);

            result.Remove(startIndex, _value.Length - startIndex);
            result.Append(query);

            end.Remove(0, startIndex);
            result.Append(end);

            return result.ToString();
        }
        public static bool IsNullOrEmpty(string? value)
        {
            if (value is null || value.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsNullOrWhiteSpace(string? value)
        {
            if (value is null || value.Length == 1 && value[0] == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int LastIndexOf(string toFind)
        {
            // "".LastIndexOf("")
            if (toFind.Length == 0 && _value.Length == 0)
            {
                return 0;
            }
            // "Hello".LastIndexOf("")
            else if (toFind.Length == 0 && _value.Length > 0)
            {
                return _value.Length;
            }
            // "a".LastIndexOf("abc")
            else if (toFind.Length > this._value.Length)
            {
                return -1;
            }

            var startIndex = -1;
            var currentIndex = toFind.Length - 1;
            var sbIndex = _value.Length - 1;
            bool matchInProgress = false;
            var sb = new StringBuilder(this._value);

            for (var i = this._value.Length - 1; i >= 0; i--)
            {
                if (!matchInProgress && sb[sbIndex] == toFind[currentIndex])
                {
                    startIndex = i;
                    if (currentIndex == 0)
                    {
                        break; // Found
                    }
                    matchInProgress = true;
                }
                else if (matchInProgress)
                {
                    currentIndex--;
                    sbIndex--;

                    if (sb[sbIndex] == toFind[currentIndex] && currentIndex == 0)
                    {
                        startIndex = i;
                        break; // Found
                    }
                    else if (sb[sbIndex] != toFind[currentIndex] && sbIndex == 0)
                    {
                        startIndex = -1;
                        break; // Not found
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
                    sb.Remove(sb.ToString().Length - 1, 1);
                    sbIndex = sb.ToString().Length - 1;
                    currentIndex = toFind.Length - 1;
                }
            }

            return startIndex;
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
