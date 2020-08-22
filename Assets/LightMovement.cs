using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float panSpeed = 20f;
    public int limit = 100;
    public bool direction = true;

    // Update is called once per frame
    void Update()
    {
    	/*Vector3 pos = transform.position;
    	if (limit == 0) {
    		limit = 100;
    		direction = !direction;
    	}

    	if (direction == true) {
    		pos.z += panSpeed * Time.deltaTime;
    	} else {
    		pos.z -= panSpeed * Time.deltaTime;
    	}

    	limit--;
        transform.position = pos;*/
    }
}
