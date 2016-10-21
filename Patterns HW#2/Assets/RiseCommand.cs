using UnityEngine;
using System.Collections;

[System.Serializable]
public class RiseCommand : Commander
{
    public override void Execute()
    {
        Train t = Train.getInstance();
        Vector3 up = new Vector3(0.0f, 1, 0.0f);
        if (t.transform.position.y <= 2)
        {
            t.transform.position += up;
        }
        else if(t.transform.position.y>=0)
        {
            t.transform.position -= up;
            t.transform.position -= up;
            t.transform.position -= up;
        }
    }
}
