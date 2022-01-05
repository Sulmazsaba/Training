using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Command.Undoable
{
   public class History
   {
       private List<IUndoableCommand> commands = new List<IUndoableCommand>();

       public void Push(IUndoableCommand command)
       {
            commands.Add(command);
       }

       public IUndoableCommand Pop()
       {
           var cmd = commands[0];
           commands.RemoveAt(0);

           return cmd;
       }

       public int Size() => commands.Count;
   }
}
