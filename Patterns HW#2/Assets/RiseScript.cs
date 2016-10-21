using UnityEngine;
using System.Collections;

public class RiseScript : MonoBehaviour {

    public RiseCommand myRiseCommand = new RiseCommand();

    void Update()
    {

    }
    void OnMouseDown()
    {
        myRiseCommand.Execute();
    }
}
