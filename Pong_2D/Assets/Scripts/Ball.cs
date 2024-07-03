using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed = 200.0f;
    private Rigidbody2D Rigidbody;

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        ResetPosition();
        AddStartingForce();
    }
    public void ResetPosition()
    {
        Rigidbody.position = Vector3.zero;
        Rigidbody.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, 0.5f) : 
                                        Random.Range(0.5f, 1.0f);
        Vector2 Direction = new Vector2(x, y);

        Rigidbody.AddForce(Direction * this.Speed);
    }

    public void AddForce(Vector2 force)
    {
        Rigidbody.AddForce(force);
    }


}
