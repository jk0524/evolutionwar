using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private float elapsedTime = 0;
	// Use this for initialization
	void Start ()
    {
        transform.position = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), 0);
    }
	
	// Update is called once per frame
	void Update () 
    {
        elapsedTime = Time.deltaTime + elapsedTime;
        transform.Translate(Random.Range(-1,1), 1 , Time.deltaTime);
        //transform.position = new Vector3(3,3,0);
       
    }
}
