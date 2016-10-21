using UnityEngine;
using System.Collections;
using System;

public class RandomCommand : Commander
{
    public Commander temp = new RightCommand();
    public Commander c1 = new RightCommand();
    public Commander c2 = new LeftCommand();
    public Commander c3 = new StopCommand();

    public override void Execute()
    {
        int num = UnityEngine.Random.Range(1, 4);
        if(num==1)
        {
            temp = c1;
            c1 = c3;
            c3 = c2;
            c2 = temp;
            Debug.Log("In num 1");
        }
        else if(num==2)
        {
            temp = c2;
            c2 = c1;
            c1 = c3;
            c3 = temp;
            Debug.Log("In num 2");           
        }
        else if(num==3)
        {
            temp = c3;
            c3 = c2;
            c2 = c1;
            c1 = temp;
            Debug.Log("In num 3");
        }
    }
}
