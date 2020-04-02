using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveReverse : Command
{
    public float moveDistance = 1.0f;

    //Called when we press a key
    public override void ExecuteAction(GameObject target)
    {
        CommandExecutor.commandStack.Push(this);

        
        // move
        Move(target);
    }

    //Undo an old command
    public override void UndoAction(GameObject target)
    {
        target.transform.Translate(target.transform.forward * moveDistance);
    }

    public void Move(GameObject target){
        target.transform.Translate(-target.transform.forward * moveDistance);
    }

}

public class MoveForward : Command
{
    public float moveDistance = 1.0f;

    //Called when we press a key
    public override void ExecuteAction(GameObject target)
    {
        CommandExecutor.commandStack.Push(this);


        // move
        target.transform.Translate(target.transform.forward * moveDistance);
    }

    //Undo an old command
    public override void UndoAction(GameObject target)
    {
        target.transform.Translate(-target.transform.forward * moveDistance);
    }
}


public class MoveLeft : Command
{
    public float moveDistance = 1.0f;

    //Called when we press a key
    public override void ExecuteAction(GameObject target)
    {
        CommandExecutor.commandStack.Push(this);


        // move
        target.transform.Translate(-target.transform.right * moveDistance);
    }

    //Undo an old command
    public override void UndoAction(GameObject target)
    {
        target.transform.Translate(target.transform.right * moveDistance);
    }
}


public class MoveRight : Command
{
    public float moveDistance = 1.0f;

    //Called when we press a key
    public override void ExecuteAction(GameObject target)
    {
        CommandExecutor.commandStack.Push(this);


        // move
        target.transform.Translate(target.transform.right * moveDistance);
    }

    //Undo an old command
    public override void UndoAction(GameObject target)
    {
        target.transform.Translate(-target.transform.right * moveDistance);
    }
}