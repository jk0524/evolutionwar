using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimScript : MonoBehaviour {
	private const int speed = 10;
	private Vector3 movement;
	public bool player1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A) && player1) {
			goUp();
		} else if (Input.GetKey(KeyCode.D) && player1) {
			goDown();
		} else if (Input.GetKey(KeyCode.J) && !player1) {
			goUp();
		} else if (Input.GetKey(KeyCode.L) && !player1) {
			goDown();
		}
		
		
	}
	void goUp() {
		movement = new Vector3(0, speed, 0) * Time.deltaTime;
		transform.Translate(movement);
	}
	void goDown() {
		movement = new Vector3(0, -speed, 0) * Time.deltaTime;
		transform.Translate(movement);
	}
}
