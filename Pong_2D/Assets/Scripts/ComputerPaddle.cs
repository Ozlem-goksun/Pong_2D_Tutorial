using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D Ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(this.Ball.velocity.x > 0.0f)
        {
            if (this.Ball.position.y > this.transform.position.y)
            {
                Rigidbody.AddForce(Vector2.up * this.speed);
            }
            else if (this.Ball.position.y < this.transform.position.y)
            {
                Rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f)
            {
                Rigidbody.AddForce(Vector2.down * this.speed);
            }
            else
            {
                Rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
