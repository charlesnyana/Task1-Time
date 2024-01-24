using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    public float steeringSpeed;
    public float forwardSpeed;
    public float maxSpeed;
    Rigidbody2D rigidBody;

    float steering;
    float acceleration;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        steering = Input.GetAxis("Horizontal");
        acceleration = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rigidBody.AddTorque(-steeringSpeed * steering * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forwardSpeed * Time.deltaTime;
        
        if (rigidBody.velocity.magnitude < maxSpeed)
        {
            rigidBody.AddForce(force);
        }
 
    }
}
