using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	public Transform target;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = Vector3.Lerp(transform.position, offset + target.position, Time.fixedDeltaTime*3f);
	}
}
