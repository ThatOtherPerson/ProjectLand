﻿using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour {

	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D () {
		PlayerController.instance.IncrementCounter ();
		Destroy (this.gameObject);
	}
}
