using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    public float speed = 5;
    public float thrustForce = 15;
    private Rigidbody2D rb;
    private Vector2 speedVector;
    private Vector2 thrustVector;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speedVector = new Vector2(speed, 0);
        thrustVector = new Vector2(0, thrustForce);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(speedVector);
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(speedVector * -1);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(thrustVector);
    }
}
