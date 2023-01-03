using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : Ball
{
    // Start is called before the first frame update
    override protected void PrintMessage()
    {
        print("I'm a red ball");
    }
}
