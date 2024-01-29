using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triSwitch : MonoBehaviour
{
    public GameObject switchPlatform;
    public bool switchIsActive = false;

    // Start is called before the first frame update
    void Start()
    {
        switchPlatform.SetActive(false); //turn off switch platform when starting the program
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (switchIsActive == true) // turn the switch on and off on collision
        {
            switchPlatform.SetActive(false); switchIsActive = false;
        }
        else
        {
            switchPlatform.SetActive(true); switchIsActive = true;
        }
    }
}
