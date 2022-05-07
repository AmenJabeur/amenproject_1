using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{
    float gravity = 0f;
    Vector2 speed;
    // Start is called once per frame
    public void Start()
    {
        Vector2 speed = new Vector2(1, 1);
        GetComponent<Rigidbody2D>().velocity = speed;
    }
    void update()
    {
        gravity = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().gravityScale = gravity;
    }
}


