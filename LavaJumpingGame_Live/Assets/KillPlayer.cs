using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour {

	public GameObject deathRing;

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag.Equals ("Player")) {
			GameObject.Instantiate (deathRing, other.contacts [0].point, Quaternion.identity);
			StartCoroutine (WaitToReload ());
			Time.timeScale = 0f;
		}
	}

	private IEnumerator WaitToReload() {
		yield return new WaitForSecondsRealtime (1f);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		Time.timeScale = 1f;
	}

}
