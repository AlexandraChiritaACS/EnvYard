using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Text.RegularExpressions;

public class SolarCells : MonoBehaviour
{

	public Text textbox;
	static float energy = 0f; // W
	public float surface = 200;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	energy += surface;
    	energy -= UnityEngine.Random.Range(20.0f, energy);
    	textbox.text = "Energy level: " + energy + "W";
    }
}
