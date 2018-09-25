using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	public Vector2 speed = new Vector2(10, 10);
	
	public Vector2 direction = new Vector2(-1, 0);

	Rigidbody2D Unit;
	void Awake() {
		Unit = gameObject.GetComponent<Rigidbody2D>();
		Vector2 movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y);

		 // 4 - Movement per direction
		Unit.velocity = movement;
		
	}
	// Update is called once per frame
	void Update () {
		
		
		
	}
}
