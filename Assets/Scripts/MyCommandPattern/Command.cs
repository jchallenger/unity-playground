using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The parent class
public abstract class Command
{
    //Move and maybe save command
    public abstract void ExecuteAction(GameObject target);

    //Undo an old command
    public virtual void UndoAction(GameObject target) { }

}