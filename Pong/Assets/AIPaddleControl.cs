﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddleControl : MonoBehaviour {
    public Transform ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, ball.position.y, transform.position.z);
	}
}
