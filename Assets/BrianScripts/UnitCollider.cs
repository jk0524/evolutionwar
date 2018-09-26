using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCollider : MonoBehaviour {

    // Use this for initialization
    private Vector3 opposite;
    //private UnitScript unitStats = Unit.gameObject.GetComponent<UnitScript>();

    void Start () {

    }


    /*
     * On Collision:
     * -bounce
     * -if col = unit: deal damage to other collider's health = to this ones damage
     * -if col = player/base: bases health -= this.health;
     */
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("collide");
       
        if(col.gameObject.GetComponent<UnitScript>()){
            if (col.gameObject.GetComponent<UnitScript>().player1
         != this.gameObject.GetComponent<UnitScript>().player1)
            {
                col.gameObject.GetComponent<UnitScript>().hp -=
                   this.gameObject.GetComponent<UnitScript>().Unitdamage;
            }
        }

        if(col.gameObject.GetComponent<PlayerScript>()){
            if(col.gameObject.GetComponent<PlayerScript>().player1 !=
               this.gameObject.GetComponent<UnitScript>().player1){
                Debug.Log("BASEBASEBAse");
                col.gameObject.GetComponent<PlayerScript>().hp -=
                this.gameObject.GetComponent<UnitScript>().hp * this.gameObject.GetComponent<UnitScript>().damage;
                this.gameObject.GetComponent<UnitScript>().hp = 0;
            }
           
        }
       

    


    }
}
