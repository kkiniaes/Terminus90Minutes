﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public Vector3 moveVector;
	
	// Update is called once per frame
	void Update () {
		transform.position += moveVector * Time.deltaTime;
	}
}
