using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour {

	public float destroyTimer;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, destroyTimer);
	}
}
