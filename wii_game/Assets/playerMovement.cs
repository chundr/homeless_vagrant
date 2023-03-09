using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{    
    public Rigidbody smallObject;
    public Rigidbody player;

    public float forwardForce = 5000f;
    public float strafe = 500f;
    // fixedUpdate is called once per frame
    void movement()
    {
        if(Input.GetKey("w"))
        {
            player.AddForce(0,0,forwardForce * Time.deltaTime);
        }
        if(Input.GetKey("s"))
        {
            player.AddForce(0,0,-forwardForce * Time.deltaTime);
        }
        if(Input.GetKey("a"))
        {
            player.AddForce(-strafe * Time.deltaTime,0,0);
        }
        if(Input.GetKey("d"))
        {
            player.AddForce(strafe * Time.deltaTime,0,0);
        }
    }
    void FixedUpdate()
    {
        movement();
    }
}
