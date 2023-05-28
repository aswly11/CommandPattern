using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatter
{
    public class Document
    {
        public string _text { get; set; } = string.Empty;
        
        public void InsertText(string text)
        {
            _text += text;
        }

        public void DeleteText(int startIndex, int length)
        {
            _text= _text.Remove(startIndex, length);
        }
        public void Display()
        {
            Console.WriteLine(_text);
        }
    }
}
