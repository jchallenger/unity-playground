using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandUndo : Command
{
    //Called when we press a key
    public override void ExecuteAction(GameObject target)
    {
        if (CommandExecutor.commandStack.Count > 0)
        {
            Command latestCommand = CommandExecutor.commandStack.Pop();
            //Move the box with this command
            latestCommand.UndoAction(target);
        }
    }
}