using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    public int health = 10;
    public int damage = 5;
    public int UnitDamage = 0;
    public bool isUnit = true;
    Rigidbody2D playerRB;

    // Use this for initialization
    void Start () {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if(health <= 0){
            Destroy(this.gameObject);
        }
	}
}
