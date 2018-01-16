﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	GameObject rocket;
	Vector3 cameraOffset;

	void Start () {
		rocket = GameObject.Find("Rocket Ship");
		cameraOffset = new Vector3 (0, 1, -20);

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = rocket.transform.position + cameraOffset;	
	}
}
