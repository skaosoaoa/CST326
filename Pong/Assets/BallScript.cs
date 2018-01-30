using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody>().AddForce(new Vector3(100, 10, 0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
