using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstBehaviour : MonoBehaviour {
    public int repeatNo;
    private int cpt = 0;
	// Use this for initialization
	void Start () {
        Debug.Log("Hello World");
        Debug.Log(transform.position);
    }
	
	// Update is called once per frame
	void Update () {
        cpt++;
        while (repeatNo > 0)
        {
            if (cpt == 50)
            {
                cpt = 0;
                print(repeatNo);
                repeatNo--;
            }
        }
	}
}
