using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
	void Update() {
    	//transform.RotateAround(transform.position, transform.forward, 100*Time.deltaTime);
    	var pos = transform.position;
    	pos.x += 0.0005f;
    	transform.position = pos;
 	}
}
