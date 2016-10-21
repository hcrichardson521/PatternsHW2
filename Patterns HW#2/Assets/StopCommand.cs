using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class StopCommand : Commander
{
	public override void Execute()
    {
        Train t = Train.getInstance();
        t.speed = 0.0f;
    }
}
