using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("left"))
            RotateLeft();
    }

    void RotateLeft()
    {
        //rotate counterclockwise
        transform.Rotate(Vector3.forward);

        //rotate clockwise
        transform.Rotate(Vector3.back);
    }
}
