using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareJump : CommandExecutor
{

    private Command buttonW, buttonS, buttonA, buttonD, buttonB, buttonZ, buttonR;

    // Start is called before the first frame update
    public void Start()
    {
        base.Start();
        //Bind keys with commands
        buttonB = new CommandNothing();

        buttonW = new MoveForward();
        buttonS = new MoveReverse();
        buttonA = new MoveLeft();
        buttonD = new MoveRight();

        buttonZ = new CommandUndo();
        buttonR = new CommandReplay();
    }

    // Update is called once per frame
    void Update()
    {
      if (!isReplaying)
      {
        HandleInput();
      }

      StartReplay();
    }

    //Check if we press a key, if so do what the key is binded to 
    public void HandleInput()
    {
      if (Input.GetKeyDown(KeyCode.A))
      {
        buttonA.ExecuteAction(this.Target);
      }
      else if (Input.GetKeyDown(KeyCode.B))
      {
        buttonB.ExecuteAction(this.Target);
      }
      else if (Input.GetKeyDown(KeyCode.D))
      {
        buttonD.ExecuteAction(this.Target);
      }
      else if (Input.GetKeyDown(KeyCode.R))
      {
        buttonR.ExecuteAction(this.Target);
      }
      else if (Input.GetKeyDown(KeyCode.S))
      {
        buttonS.ExecuteAction(this.Target);
      }
      else if (Input.GetKeyDown(KeyCode.W))
      {
        buttonW.ExecuteAction(this.Target);
      }
      else if (Input.GetKeyDown(KeyCode.Z))
      {
        buttonZ.ExecuteAction(this.Target);
      }
    }

}
