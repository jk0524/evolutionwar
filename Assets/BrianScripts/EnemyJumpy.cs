using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumpy : MonoBehaviour
{

    private int radius = 5;
    private float elapsedTime = 0;
    private int jumpyCountDown = 0;
    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), 0);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.deltaTime + elapsedTime;
        jumpyCountDown++;
        //transform.Translate(Random.Range(-50,50), -20 , elapsedTime);
        if(jumpyCountDown == 20){
            jumpyCountDown = 0;
            transform.position = new Vector3(Random.Range(-5, 5), radius * Mathf.Sin(elapsedTime), 0);
        }

    }
}
