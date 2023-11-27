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

        //String.prototype.endsWith()
        public string? EndsWith()
        {
            string? endsWith = null;
            return endsWith;
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

        //String.At() - Similar to JS String method
        public string? At(int index)
        {
            //Hello
            string? stringAt = null;
            if (index >= 0)
            {
                for (int i = 0; i < this._value.Length; i++)
                {
                    if (i == index)
                    {
                        stringAt = this._value[i].ToString();
                        break;
                    }
                }
            }
            else
            {
                for (int i = -1; i >= -this._value.Length; i--)
                {
                    if (i == index)
                    {
                        stringAt = this._value[this._value.Length + i].ToString();
                        break;
                    }
                }
            }


            return stringAt;
        }

        //String.Concat() read about string builder C#
        public string? Concat(params object[] text)
        {
            string? concatStr = null;
            if (text.Length > 0)
            {
                var sb = new StringBuilder(this._value);
                foreach (var item in text)
                {
                    sb.Append(item.ToString());
                }

                concatStr = sb.ToString();
            }


            return concatStr;
        }
        /// <summary>
        /// Concatenates the elements of a specified array or the members of a collection, 
        /// using the specified separator between each element or member.
        /// </summary>
        /// <returns>joinStr or null</returns>
        public string? Join(string separator, params object[] text)
        {
            string? joinStr = null;

            if (text.Length > 0)
            {
                var sb = new StringBuilder(this._value);
                foreach (var item in text)
                {
                    sb.Append(separator);
                    sb.Append(item.ToString());
                }

                joinStr = sb.ToString();
            }

            return joinStr;
        }
    }
}
