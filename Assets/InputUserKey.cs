using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputUserKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        // Debug.Log(x);

        bool onSpace = Input.GetKey("space");
        if (onSpace)
        {
            Debug.Log("攻撃");
        }
        
    }
}
