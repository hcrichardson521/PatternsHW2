using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class RightCommand : Commander
{
    public override void Execute()
    {
        Train t = Train.getInstance();
        t.speed = 1;
    }
}
