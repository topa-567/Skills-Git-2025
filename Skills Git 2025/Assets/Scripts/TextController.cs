﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour {
	public TextMeshPro gemCounter;
	public TextMeshPro gameTimer;
	public TextMeshPro livesCounter;
	GameObject Hero;

	int lives;
	GameObject [] totalGems;
	// Use this for initialization
	void Start () {
		Hero = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {

		totalGems = GameObject.FindGameObjectsWithTag ("redGem");
		gemCounter.text = "Gems : " + totalGems.Length.ToString();
		lives = Hero.GetComponent<HeroMovement>().lives;
		livesCounter.text = "Lives:" + lives;
		gameTimer.text = Time.timeSinceLevelLoad.ToString ("0.00");
		
	}

}
