using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject launcher;
    public float spawnRate = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        activateLauncher();

    }

    void activateLauncher()
    {
        Instantiate(launcher, transform.position, transform.rotation);

        //if (timer < spawnRate)
        //{
        //    timer = timer + Time.deltaTime;
        //}
        //else
        //{
        //    activateLauncher();
        //    timer = 0;
        //}

        //Debug.Log(timer);
    }
}
