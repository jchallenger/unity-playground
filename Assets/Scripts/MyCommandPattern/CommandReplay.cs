using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandReplay : Command
{
    public override void ExecuteAction(GameObject target)
    {
        CommandExecutor.shouldStartReplay = true;
    }
}