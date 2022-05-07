using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouveRacket : MonoBehaviour
{

    //this is the speed of the racket mouvement 
    public float speed = 30;
    public string axis;
    public void FixedUpdate()
    {
        //this is our GetAxisRaw input
        float v = Input.GetAxisRaw(axis) * speed;
        //just calling the Rigidbody2D component to change its velocity value
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v);
    }
}
