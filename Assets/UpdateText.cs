﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text sampleText = GetComponent<Text>();
        sampleText.text = "さんぷるテキスト";    
    }

    // Update is called once per frame
    void Update()
    {
    }
}
