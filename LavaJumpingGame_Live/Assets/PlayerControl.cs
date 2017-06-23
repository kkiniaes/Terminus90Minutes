using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float speed = 4f;
	public float jumpVelocity = 4f;
	public float fallSpeed = 4f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left*Time.deltaTime*speed);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right*Time.deltaTime*speed);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.up*jumpVelocity, ForceMode.VelocityChange);
			transform.localScale = new Vector3 (1f, 1.5f, 1f);
		}

		if (GetComponent<Rigidbody> ().velocity.y < 2f) {
			GetComponent<Rigidbody> ().AddForce (Vector3.down * fallSpeed);
		}

		transform.localScale = Vector3.Lerp (transform.localScale, Vector3.one, Time.deltaTime * 5f);
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag.Equals ("Floor")) {
			transform.localScale = new Vector3 (1f, 0.5f, 1f);
		}
	}
}
