using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2DisplayScript : MonoBehaviour {
	public Text textbox;
	private GameObject player2;
	private PlayerScript playerStats;
	// Use this for initialization
	void Start () {
		textbox = GetComponent<Text>();
		player2 = GameObject.Find("Player2");
	}
	
	// Update is called once per frame
	void Update () {
		playerStats = player2.GetComponent<PlayerScript>();
		textbox.text = "Player2 \nHealth: " + playerStats.hp + "\nmoney: " + playerStats.cash;
	}
}
