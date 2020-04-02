using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandExecutor : MonoBehaviour
{
    public static Stack<Command> commandStack = new Stack<Command>();
    public static bool shouldStartReplay;
    public bool isReplaying = false;
    private IEnumerator replayCoroutine;

    public GameObject Target;
    private GameObject TargetBackup;

    // Start is called before the first frame update
    public void Start()
    {
        TargetBackup = Object.Instantiate(Target);
        TargetBackup.SetActive(false);
    }
    
    //Checks if we should start the replay
    public void StartReplay()
    {
      if (shouldStartReplay && commandStack.Count > 0)
      {
        shouldStartReplay = false;

        //Stop the coroutine so it starts from the beginning
        if (replayCoroutine != null)
        {
          StopCoroutine(replayCoroutine);
        }

        //Start the replay
        replayCoroutine = ReplayCommands();
        StartCoroutine(replayCoroutine);
      }
    }


    //The replay coroutine
    IEnumerator ReplayCommands()
    {
        //So we can't move the box with keys while replaying
        isReplaying = true;

        // Restore to original state?
        Object.Destroy(Target);

        Target = Object.Instantiate(TargetBackup);
        Target.SetActive(true);

        var stack = commandStack.ToArray();
        yield return new WaitForSeconds(1.0f);
        for (int ii = stack.Length - 1; ii > 0 ; ii--)
        {
            stack[ii].ExecuteAction(Target);
            //HACK Pop Stack... 
            commandStack.Pop();

            yield return new WaitForSeconds(0.5f);
        }

        //We can move the box again
        isReplaying = false;
    }
}
