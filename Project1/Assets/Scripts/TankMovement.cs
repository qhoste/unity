using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float rotateSpeed = 90;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var transAmount = speed * Time.deltaTime;
        var rotateAmount = rotateSpeed * Time.deltaTime;

        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, transAmount);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, -transAmount);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, -rotateAmount, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, rotateAmount, 0);
        }
    }
}
