using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float moveSpeed = 3f;
	public float jumpForce = 3f;

	private bool grounded;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right*Time.deltaTime*moveSpeed);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left*Time.deltaTime*moveSpeed);
		}
		if (grounded && Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.up*jumpForce, ForceMode.VelocityChange);
			grounded = false;
			transform.localScale = new Vector3 (1f, 1.5f, 1f);
		}
		if (!grounded && GetComponent<Rigidbody> ().velocity.y <= 2f) {
			GetComponent<Rigidbody> ().AddForce (-Vector3.up, ForceMode.VelocityChange);
		}
		transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1f, Mathf.Max(1f,GetComponent<Rigidbody>().velocity.y/jumpForce), 1f), Time.deltaTime*2f);
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag.Equals ("Floor")) {
			grounded = true;
			transform.localScale = new Vector3 (1.5f, 1f, 1f);
		}
	}

	void OnCollisionExit(Collision other) {
		if (other.gameObject.tag.Equals ("Floor")) {
			grounded = false;
		}
	}
}
