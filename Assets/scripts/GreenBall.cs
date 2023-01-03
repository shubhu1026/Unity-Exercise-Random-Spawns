using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : Ball
{
    // Start is called before the first frame update
    override protected void Start()
    {
        impulseVector.x = 0.0f;
        impulseVector.y = 5f;
        base.Start();
    }

    override protected void PrintMessage()
    {
        print("I'm a green ball");
    }
}
