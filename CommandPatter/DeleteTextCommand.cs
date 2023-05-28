using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatter
{
    internal class DeleteTextCommand
    {
        private Document _document;
        private int _startIndex;
        private int _length;

        public DeleteTextCommand(Document document, int startIndex, int length)
        {
            _document = document;
            _startIndex = startIndex;
            _length = length;
        }

        public void Execute()
        {
            _document.DeleteText(_startIndex, _length);
        }
    }
}
