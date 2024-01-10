using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float mSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform. Translate(0.3f + mSpeed * Time.deltaTime, 0, 0);
    }
}
