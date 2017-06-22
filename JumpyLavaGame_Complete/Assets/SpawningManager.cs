using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningManager : MonoBehaviour {

	public GameObject[] prefabs;
	public float spawnRate;
	public float moduleHeight;

	private float spawnTimer;
	private int spawnedModules;

	// Use this for initialization
	void Start () {
		spawnTimer = spawnRate;
	}
	
	// Update is called once per frame
	void Update () {
		spawnTimer += Time.deltaTime;
		if (spawnTimer > spawnRate) {
			GameObject.Instantiate (prefabs [Random.Range (0, prefabs.Length)], Vector3.up * spawnedModules * moduleHeight, Quaternion.identity);
			spawnedModules++;
			spawnTimer = 0;
		}
	}
}
