using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CommandPatter
{
    public class InsertTextCommand : ICommand
    {
        private readonly string _text;
        private Document _document;

        private int startindex = 0;
        public InsertTextCommand(Document document, string text)
        {
            _document = document;
            _text = text;
            startindex = _document._text.Length;
        }
        public void Execute()
        {
           _document.InsertText(_text);
        }

        public void Undo()
        {
            _document.DeleteText(startindex, _text.Length);
        }
    }
}
