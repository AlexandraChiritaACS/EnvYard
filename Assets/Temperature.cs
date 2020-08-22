using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Temperature : MonoBehaviour
{

	public Text textbox;
	public float number;

    // Start is called before the first frame update
    void Start()
    {
        number = UnityEngine.Random.Range(27.0f, 30.0f);
        textbox.text = "Temperature:" + number;
    }

    // Update is called once per frame
    void Update()
    {
    	
    }
}
