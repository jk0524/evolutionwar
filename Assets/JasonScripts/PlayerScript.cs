using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	public float hp = 10f;
	public bool player1;
	public float cash = 100f;
    private float incomeCounter;
    private float income = 100f;
    private float incomeRate = 20f;


	// Use this for initialization
	void Start () {
        incomeCounter = 0;
	}

    // Update is called once per frame
    void Update()
    {   
        if (incomeCounter <= 0) {
            incomeCounter = incomeRate;
            cash += income;
        } else {
            incomeCounter -= Time.deltaTime;
        }

        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
