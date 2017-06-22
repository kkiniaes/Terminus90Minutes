using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour {

	public GameObject deathThingy;

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag.Equals ("Player")) {
			GameObject.Instantiate (deathThingy, other.contacts [0].point, Quaternion.identity);
			other.collider.enabled = false;
			other.rigidbody.isKinematic = true;
			Time.timeScale = 0f;
			StartCoroutine (WaitToRestart ());
		}
	}

	private IEnumerator WaitToRestart() {
		yield return new WaitForSecondsRealtime (1f);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		Time.timeScale = 1f;
		yield break;
	}
}
