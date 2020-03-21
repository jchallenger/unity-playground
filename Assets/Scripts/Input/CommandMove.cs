
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CommandPattern
{
    public class MoveForward : Command
    {
        //Called when we press a key
        public override void Execute(Transform boxTrans, Command command)
        {
            //Move the box
            Move(boxTrans);
            
            //Save the command
            InputHandler.oldCommands.Add(command);
        }

        //Undo an old command
        public override void Undo(Transform boxTrans)
        {
            boxTrans.Translate(-boxTrans.forward * moveDistance);
        }

        //Move the box
        public override void Move(Transform boxTrans)
        {
            boxTrans.Translate(boxTrans.forward * moveDistance);
        }
    }


    public class MoveReverse : Command
    {
        //Called when we press a key
        public override void Execute(Transform boxTrans, Command command)
        {
            //Move the box
            Move(boxTrans);

            //Save the command
            InputHandler.oldCommands.Add(command);
        }

        //Undo an old command
        public override void Undo(Transform boxTrans)
        {
            boxTrans.Translate(boxTrans.forward * moveDistance);
        }

        //Move the box
        public override void Move(Transform boxTrans)
        {
            boxTrans.Translate(-boxTrans.forward * moveDistance);
        }
    }


    public class MoveLeft : Command
    {
        //Called when we press a key
        public override void Execute(Transform boxTrans, Command command)
        {
            //Move the box
            Move(boxTrans);

            //Save the command
            InputHandler.oldCommands.Add(command);
        }

        //Undo an old command
        public override void Undo(Transform boxTrans)
        {
            boxTrans.Translate(boxTrans.right * moveDistance);
        }

        //Move the box
        public override void Move(Transform boxTrans)
        {
            boxTrans.Translate(-boxTrans.right * moveDistance);
        }
    }


    public class MoveRight : Command
    {
        //Called when we press a key
        public override void Execute(Transform boxTrans, Command command)
        {
            //Move the box
            Move(boxTrans);

            //Save the command
            InputHandler.oldCommands.Add(command);
        }

        //Undo an old command
        public override void Undo(Transform boxTrans)
        {
            boxTrans.Translate(-boxTrans.right * moveDistance);
        }

        //Move the box
        public override void Move(Transform boxTrans)
        {
            boxTrans.Translate(boxTrans.right * moveDistance);
        }
    }
}
