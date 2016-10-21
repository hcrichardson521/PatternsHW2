using UnityEngine;
using System.Collections;

public class Train : MonoBehaviour
{
    public static Train myTrain;
    public float speed;
    private Rigidbody rb;

    void Start()
    {
        myTrain = this;
    }

    public static Train getInstance()
    {
        return myTrain;
    }

    void Update ()
    {
        //Debug.Log(speed);
        Vector3 movement = new Vector3(speed, 0.0f, 0.0f);
        rb = myTrain.GetComponent<Rigidbody>();
        rb.AddForce(movement);
    }
}
