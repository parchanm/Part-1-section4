using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;
    public bool doorIsActive = true;

    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (doorIsActive == true)
        {
            door.SetActive(false); doorIsActive = false;
        } else
        {
            door.SetActive(true);  doorIsActive = true;
        }

        Debug.Log(doorIsActive);
    }
}
