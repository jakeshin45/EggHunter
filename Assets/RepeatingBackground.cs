using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    private float groundHorizontalLength;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < -20)
        {
            RepositionBackground();
        }
	}

    private void RepositionBackground()
    {
        transform.position = (Vector2)transform.position + new Vector2(40, 0);
    }


}
