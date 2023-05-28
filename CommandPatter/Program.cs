using CommandPatter;

TextEditor textEditor = new TextEditor();
Document document =new Document();
document.Display();

textEditor.ExecuteCommand(new InsertTextCommand(document, "Hi aswly\n"));
document.Display();

textEditor.ExecuteCommand(new InsertTextCommand(document, "Welcome\n"));
document.Display();

textEditor.ExecuteCommand(new InsertTextCommand(document, "How are You\n"));

document.Display();
textEditor.UndoLastCommand();
document.Display();
textEditor.UndoLastCommand();
document.Display();
textEditor.UndoLastCommand();
document.Display();
