namespace MyString
{
    public class MyString
    {
        private string _value;
        public MyString(string value)
        {
            this._value = value;
        }
        //String.prototype.at()
        //String.prototype.concat() read about string builder C#
        //String.prototype.endsWith()
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
        public string? At(int index)
        {
            //Hello
            string? stringAt = null;

            for (int i = 0; i < this._value.Length; i++)
            {
                if (i == index)
                {
                    stringAt = this._value[i].ToString();
                    break;
                }
            }

            return stringAt;
        }
    }
}
