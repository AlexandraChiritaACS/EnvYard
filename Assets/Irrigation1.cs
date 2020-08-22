using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Text.RegularExpressions;


public class Irrigation1 : MonoBehaviour
{
	int time = 1000;
	public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if (UnityEngine.Random.Range(27.0f, 30.0f) > 28 && time > 0)
     		textbox.text = "Irrigation level 1: ON";
     	else
     		textbox.text = "Irrigation level 1: OFF";
    }
}
