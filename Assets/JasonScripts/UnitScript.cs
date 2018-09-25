using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour
{

    public float cost = 10f;
    public float hp = 1f;
    public float damage = 1f;
    public bool player1;
    public float returnRate = 0.5f;
    public float Unitdamage = 1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            //getPlayer(!this.player1);
            if (player1) {
                GameObject.Find("Player2").GetComponent<PlayerScript>().cash += cost * returnRate;
            } else {
                GameObject.Find("Player1").GetComponent<PlayerScript>().cash += cost * returnRate;
            }
            Destroy(this.gameObject);
        }
        if (this.GetComponent<Rigidbody2D>().velocity.magnitude < 1) {
            this.GetComponent<Rigidbody2D>().velocity *= 2;
        }
    }
}
