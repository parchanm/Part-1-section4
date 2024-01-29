using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class taxi : MonoBehaviour
{
    public Rigidbody2D taxiRigidbody;

    //public float rotation;
    public float jumpPower = 10; //public float for jump, speed, rotationspeed, maxspeed
    public float speed = 5;
    public float rotationSpeed = 50;
    public float maxSpeed = 50;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //float turning = rotation = Input.GetAxis("Vertical");
        //transform.Translate(direction * speed * Time.deltaTime, 0, 0);

        float direction = Input.GetAxis("Horizontal"); //input for going forwad
        float rotation = Input.GetAxis("Vertical"); //input for rotating the taxi

        transform.Rotate(0, 0, rotation * rotationSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) == true) //input for the jump
        {
            taxiRigidbody.velocity = Vector2.up * jumpPower;
        }

        if (taxiRigidbody.velocity.magnitude < maxSpeed) // adding constraint so taxi can't go faster than maxspeed
        {
            taxiRigidbody.AddForce(new Vector2(direction * speed, 0));
        }
    }
    private void FixedUpdate()
    {
       //taxiRigidbody.AddTorque(rotation * rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("cone")) //when collided with object tagged "cone", destroy the taxi
        {
            Destroy(gameObject);
        }
    }
}

