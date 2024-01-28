using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triSwitch : MonoBehaviour
{
    public GameObject switchPlatform;
    public bool switchIsActive = true;

    // Start is called before the first frame update
    void Start()
    {
        switchPlatform.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (switchIsActive == true)
        {
            switchPlatform.SetActive(false); switchIsActive = false;
        }
        else
        {
            switchPlatform.SetActive(true); switchIsActive = true;
        }
    }
}
