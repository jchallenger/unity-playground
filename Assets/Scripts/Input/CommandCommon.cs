
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CommandPattern
{
    //For keys with no binding
    public class DoNothing : Command
    {
        //Called when we press a key
        public override void Execute(Transform boxTrans, Command command)
        {
            //Nothing will happen if we press this key
        }
    }


    //Undo one command
    public class UndoCommand : Command
    {
        //Called when we press a key
        public override void Execute(Transform boxTrans, Command command)
        {
            List<Command> oldCommands = InputHandler.oldCommands;

            if (oldCommands.Count > 0)
            {
                Command latestCommand = oldCommands[oldCommands.Count - 1];

                //Move the box with this command
                latestCommand.Undo(boxTrans);

                //Remove the command from the list
                oldCommands.RemoveAt(oldCommands.Count - 1);
            }
        }
    }


    //Replay all commands
    public class ReplayCommand : Command
    {
        public override void Execute(Transform boxTrans, Command command)
        {
            InputHandler.shouldStartReplay = true;
        }
    }
}
