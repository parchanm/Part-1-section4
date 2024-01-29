using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conePhysics : MonoBehaviour
{
    public Rigidbody2D coneRigidbody;
    public float coneSpeed = 20;
    public float deadZone = -50;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //reference to logic script
        coneRigidbody.velocity = Vector2.up * coneSpeed; //make the cone jump when spawned
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deadZone)
        {
            Destroy(gameObject); // destroys the cone object when it reaches deadzone
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("taxi"))
        {
            logic.gameOver(); // activate logic script
        }
    }
}
