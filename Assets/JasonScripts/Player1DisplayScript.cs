using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1DisplayScript : MonoBehaviour {
	public Text textbox;
	private GameObject player1;
	private PlayerScript playerStats;
	// Use this for initialization
	void Start () {
		textbox = GetComponent<Text>();
		player1 = GameObject.Find("Player1");
	}
	
	// Update is called once per frame
	void Update () {
		playerStats = player1.GetComponent<PlayerScript>();
		textbox.text = "Player1 \nHealth: " + playerStats.hp + "\nmoney: " + playerStats.cash;
	}
}
