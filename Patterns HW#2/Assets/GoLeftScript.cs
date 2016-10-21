using UnityEngine;
using System.Collections;

public class GoLeftScript : MonoBehaviour
{
    public LeftCommand myLeftCommand = new LeftCommand();

    void Update ()
    {
        
    }

    void OnMouseDown()
    {
        myLeftCommand.Execute();
    }
}
