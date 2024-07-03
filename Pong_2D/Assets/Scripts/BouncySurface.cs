using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float BounceStrength;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball Ball = collision.gameObject.GetComponent<Ball>();

        if (Ball != null )
        {
            Vector2 Normal = collision.GetContact(0).normal;
            Ball.AddForce(-Normal * this.BounceStrength);
        }

    }

}
 