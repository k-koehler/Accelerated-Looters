﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemiesKilled : MonoBehaviour {


	public int enemies = 0;
	public Text enemiesKilled;

	public KillEnemy k;

	// Use this for initialization
	void Start()
	{
	
		k = FindObjectOfType<KillEnemy>();
	}

	// Update is called once per frame
	void Update()
	{
		
		enemies = k.enemyKilled;
		enemiesKilled.text = ("Enemies Killed = "+ enemies);

	}
}