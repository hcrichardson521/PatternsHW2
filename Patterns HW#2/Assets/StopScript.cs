using UnityEngine;
using System.Collections;

public class StopScript : MonoBehaviour
{
    public StopCommand myStopCommand = new StopCommand();

    void Update()
    {
        
    }
    void OnMouseDown()
    {
        myStopCommand.Execute();
    }
}
