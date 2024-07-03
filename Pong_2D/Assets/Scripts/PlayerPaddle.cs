using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 Direction;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Direction = Vector2.down;
        }
        else
        {
            Direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (Direction.sqrMagnitude != 0)
        {
            Rigidbody.AddForce(Direction * this.speed);
        }
    }

}
