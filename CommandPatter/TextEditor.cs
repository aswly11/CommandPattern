using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatter
{
    public class TextEditor
    {
        private Stack<ICommand> _commandHistory;

        public TextEditor()
        {
            _commandHistory = new Stack<ICommand>();
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand lastCommand = _commandHistory.Pop();
                lastCommand.Undo(); 
            }
        }
    }
}
