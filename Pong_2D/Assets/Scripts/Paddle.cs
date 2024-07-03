using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;

    protected Rigidbody2D Rigidbody;


    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPosition()
    {
        Rigidbody.position = new Vector2(Rigidbody.position.x, 0.0f);
        Rigidbody.velocity = Vector2.zero;
    }

}
