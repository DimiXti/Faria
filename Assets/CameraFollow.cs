﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    GameObject player;
    Vector3 offset;

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
         
        offset = player.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LateUpdate()
    {
        transform.position = player.transform.position - offset;
    }
}