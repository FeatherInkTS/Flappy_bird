using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNum : MonoBehaviour {

	private float x_in;
	private float x_out;
	private bool one_in = true;
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("bird_0").GetComponent<Bird> ().alive) {
			if (one_in) {
				if (transform.position.x < 0.1f && transform.position.x > -0.1f) {
					GameObject.Find ("Main Camera").GetComponent<NumberPlate> ().num++;
					one_in = false;
				}
			}
		}
	}
}
