﻿using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	void OnCollisionEnter2D(Collision2D collision) {
		print ("Collision");
	}

	void OnTriggerEnter2D(Collider2D collider) {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		levelManager.LoadLevel("Lose");
	}

}
