using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

	public Vector3 patrolDistance;
	public float patrolSpeed;

	private Vector3 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = startPosition + Mathf.Sin (Time.time * patrolSpeed) * patrolDistance;
	}
}
