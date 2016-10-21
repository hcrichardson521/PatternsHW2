using UnityEngine;
using System.Collections;

public class GoRightScript : MonoBehaviour
{
    public RightCommand myRightCommand = new RightCommand();

    void Update()
    {
        
    }
    void OnMouseDown()
    {
        myRightCommand.Execute();
    }
}
