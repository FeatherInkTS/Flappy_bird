using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] prefabs;

	public float delay = 2.0f;

	public bool active = true;

	// Use this for initialization
	void Start () {
		Instantiate (prefabs [0], new Vector3(transform.position.x,4.5f,-1), Quaternion.identity);
		Instantiate (prefabs [1], new Vector3(transform.position.x,-4.5f,-1), Quaternion.identity);
		StartCoroutine (Pipe());
	}

	IEnumerator Pipe(){
		yield return new WaitForSeconds (delay);

		float y = transform.position.y + Random.Range (-2.5f, 2.5f);

		if (active) {
			Instantiate (prefabs [0], new Vector3(transform.position.x,y+4.5f,-1), Quaternion.identity);
			Instantiate (prefabs [1], new Vector3(transform.position.x,y-4.5f,-1), Quaternion.identity);
		}
		StartCoroutine (Pipe());
	}
}
