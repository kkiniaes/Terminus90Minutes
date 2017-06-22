using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PatrollingEnemy : MonoBehaviour {

	public Vector3 patrolDistance;
	public float patrolSpeed;

	private Vector3 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = startPosition + Mathf.Sin (Time.time) * patrolDistance * patrolSpeed;
	}
}
