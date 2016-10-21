using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class LeftCommand : Commander 
{
	public override void Execute()
    {
        Train t = Train.getInstance();
        t.speed = -1;
    }
}
