﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgress : MonoBehaviour {

    public float record;
    public string recordTime;


    // Use this for initialization
    void Start () {
        //Give the PlayerPrefs some values to send over
       PlayerPrefs.SetFloat("Record Time", 50);
       PlayerPrefs.SetString("Record Time", "Time");

    }

    // Update is called once per frame
    void Update () {
        //PlayerPrefs.SetFloat("Record Time", record);
	}

}