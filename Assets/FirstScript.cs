using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        List<int> numbers = new List<int>() { 1, 2, 3 };
        numbers.Add(4);
        numbers.RemoveAt(numbers.Count - 1);

        foreach (int num in numbers)
        {
            Debug.Log(num);
        }
    }

    // Update is called once per frame
    void Update()
    {}
}
