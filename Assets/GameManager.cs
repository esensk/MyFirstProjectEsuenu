using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text titleText;
    // Start is called before the first frame update
    void Start()
    {
        titleText.text = "たいとる";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
