using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        // pattern 1
        // transform.position += new Vector3(0.1f, 0, 0);      

        // pattern 2
        // rb.velocity = new Vector3(0.1f, 0, 0);

        // pattern 3
        rb.AddForce(new Vector3(0, 10, 0));
    }
}
