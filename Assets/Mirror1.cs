using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Mirror1 : MonoBehaviour
{
	public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var position = SunPosition.CalculateSunPosition(DateTime.Now, latitude:1222223, longitude:322323);
    	float ang = (float)(position.Azimuth - 2.0944);
        textbox.text = "Angle mirror 1:" + ang;
        this.transform.RotateAround(transform.position, new Vector3 (0f, 0f, 1f), ang);
    }
}
