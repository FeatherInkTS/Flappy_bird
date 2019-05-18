using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WindowsSetting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.SetResolution(576, 1024, false);
	}
	void Update(){
		if (Input.GetKeyDown(KeyCode.Space))
			LoadGame();
	}
	public void LoadGame(){
		SceneManager.LoadScene ("scene");
	}
}
