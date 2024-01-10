using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float rSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float aim = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, aim * rSpeed * Time.deltaTime);
    }
}
