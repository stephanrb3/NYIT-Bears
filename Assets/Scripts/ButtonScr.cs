﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScr : MonoBehaviour {

	public GameObject barrier;
    public bool barrierdown;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		GetComponent<Animator>().SetBool("ButtonPressed",true);
		Destroy(barrier);
        barrierdown = true;
	}

}
