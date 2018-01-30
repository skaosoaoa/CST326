﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRPaddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow) && transform.position.y < 3.0f)
        {
            transform.position += new Vector3(0, 0.1f , 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -3.0f)
        {
            transform.position += new Vector3(0, -0.1f, 0);
        }
	}
}
