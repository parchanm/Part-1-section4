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
    public float jumpPower = 10;
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

        float direction = Input.GetAxis("Horizontal");
        float rotation = Input.GetAxis("Vertical");

        transform.Rotate(0, 0, rotation * rotationSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            taxiRigidbody.velocity = Vector2.up * jumpPower;
        }

        if (taxiRigidbody.velocity.magnitude < maxSpeed)
        {
            taxiRigidbody.AddForce(new Vector2(direction * speed, 0));
        }
    }
    private void FixedUpdate()
    {
       //taxiRigidbody.AddTorque(rotation * rotationSpeed * Time.deltaTime);
    }

}

