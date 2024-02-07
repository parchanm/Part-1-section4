using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleTrigger : MonoBehaviour
{
    public GameObject cone;
    private bool hasSpawned = false; //boolean to make cone spawn only one time

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) //when player enters the range, instantiate the cone and turn the bool on
    {
        if (!hasSpawned) {
            Instantiate(cone, transform.position, transform.rotation);
            hasSpawned = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) //when player exits, switch bool to false
    {
        hasSpawned = false;
    }

    //push test
}
