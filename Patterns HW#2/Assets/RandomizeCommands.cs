using UnityEngine;
using System.Collections;

public class RandomizeCommands : MonoBehaviour
{
    private RandomCommand myRandomCommand = new RandomCommand();

    void Update()
    {
        
    }
    void OnMouseDown()
    {
        myRandomCommand.Execute();
    }
}
