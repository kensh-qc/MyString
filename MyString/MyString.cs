using System.Text;

namespace MyString
{
    public class MyString
    {
        private string _value;
        public MyString(string value)
        {
            this._value = value;
        }

        //String.At() - Similar to JS String method
        public static string? At(int index, string? text)
        {
            string? stringAt = null;
            if (text != null)
            {
                if (index >= 0)
                {

                    for (int i = 0; i < text.Length; i++)
                    {
                        if (i == index)
                        {
                            stringAt = text[i].ToString();
                            break;
                        }
                    }

                }
                else
                {
                    for (int i = -1; i >= -text.Length; i--)
                    {
                        if (i == index)
                        {
                            stringAt = text[text.Length + i].ToString();
                            break;
                        }
                    }

                }

            }
            return stringAt;
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
                        sb.Append(item.ToString());
                    }
                }

                concatStr = sb.ToString();
            }

            return concatStr;
        }

        //String.EndsWith()
        public string? EndsWith()
        {
            string? endsWith = null;
            return endsWith;
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
                        if (separator != null && sb.Length > 0) sb.Append(separator);
                        sb.Append(item);
                    }

                }

                joinStr = sb.ToString();
            }

            return joinStr;
        }

        //String.prototype.includes()
        //String.prototype.lastIndexOf()
        //String.prototype.padEnd()
        //String.prototype.padStart()
        //String.prototype.repeat()
        //String.prototype.replace() console.log(paragraph.replace("Ruth's", 'my'));
        // Expected output: "I think my dog is cuter than your dog!"
        //String.prototype.replaceAll() console.log(paragraph.replaceAll('dog', 'monkey'));
        // Expected output: "I think Ruth's monkey is cuter than your monkey!"
        //String.prototype.slice()
        //String.prototype.split()
        //String.prototype.startsWith()
        //String.prototype.substring()
        //String.prototype.trim()
        //String.prototype.trimEnd()
        //String.prototype.trimStart()
    }
}
