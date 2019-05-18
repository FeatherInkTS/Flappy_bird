using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberPlate : MonoBehaviour {
	public Sprite[] sprites;
	public int num = 0;
	public  int[] m;
	// Update is called once per frame
	void Update () {
		m [0] = num % 10;
		m [1] = (num / 10) % 10;
		m [2] = num / 100;

		if(m[0]==0)
			GameObject.Find ("n1").GetComponent<SpriteRenderer> ().sprite = sprites[0];
		if(m[0]==1)
			GameObject.Find ("n1").GetComponent<SpriteRenderer> ().sprite = sprites[1];
		if(m[0]==2)
			GameObject.Find ("n1").GetComponent<SpriteRenderer> ().sprite = sprites[2];
		if(m[0]==3)
			GameObject.Find ("n1").GetComponent<SpriteRenderer> ().sprite = sprites[3];
		if(m[0]==4)
			GameObject.Find ("n1").GetComponent<SpriteRenderer> ().sprite = sprites[4];
		if(m[0]==5)
			GameObject.Find ("n1").GetComponent<SpriteRenderer> ().sprite = sprites[5];
		if(m[0]==6)
			GameObject.Find ("n1").GetComponent<SpriteRenderer> ().sprite = sprites[6];
		if(m[0]==7)
			GameObject.Find ("n1").GetComponent<SpriteRenderer> ().sprite = sprites[7];
		if(m[0]==8)
			GameObject.Find ("n1").GetComponent<SpriteRenderer> ().sprite = sprites[8];
		if(m[0]==9)
			GameObject.Find ("n1").GetComponent<SpriteRenderer> ().sprite = sprites[9];

		if(m[1]==0)
			GameObject.Find ("n2").GetComponent<SpriteRenderer> ().sprite = sprites[0];
		if(m[1]==1)
			GameObject.Find ("n2").GetComponent<SpriteRenderer> ().sprite = sprites[1];
		if(m[1]==2)
			GameObject.Find ("n2").GetComponent<SpriteRenderer> ().sprite = sprites[2];
		if(m[1]==3)
			GameObject.Find ("n2").GetComponent<SpriteRenderer> ().sprite = sprites[3];
		if(m[1]==4)
			GameObject.Find ("n2").GetComponent<SpriteRenderer> ().sprite = sprites[4];
		if(m[1]==5)
			GameObject.Find ("n2").GetComponent<SpriteRenderer> ().sprite = sprites[5];
		if(m[1]==6)
			GameObject.Find ("n2").GetComponent<SpriteRenderer> ().sprite = sprites[6];
		if(m[1]==7)
			GameObject.Find ("n2").GetComponent<SpriteRenderer> ().sprite = sprites[7];
		if(m[1]==8)
			GameObject.Find ("n2").GetComponent<SpriteRenderer> ().sprite = sprites[8];
		if(m[1]==9)
			GameObject.Find ("n2").GetComponent<SpriteRenderer> ().sprite = sprites[9];

		if(m[2]==0)
			GameObject.Find ("n3").GetComponent<SpriteRenderer> ().sprite = sprites[0];
		if(m[2]==1)
			GameObject.Find ("n3").GetComponent<SpriteRenderer> ().sprite = sprites[1];
		if(m[2]==2)
			GameObject.Find ("n3").GetComponent<SpriteRenderer> ().sprite = sprites[2];
		if(m[2]==3)
			GameObject.Find ("n3").GetComponent<SpriteRenderer> ().sprite = sprites[3];
		if(m[2]==4)
			GameObject.Find ("n3").GetComponent<SpriteRenderer> ().sprite = sprites[4];
		if(m[2]==5)
			GameObject.Find ("n3").GetComponent<SpriteRenderer> ().sprite = sprites[5];
		if(m[2]==6)
			GameObject.Find ("n3").GetComponent<SpriteRenderer> ().sprite = sprites[6];
		if(m[2]==7)
			GameObject.Find ("n3").GetComponent<SpriteRenderer> ().sprite = sprites[7];
		if(m[2]==8)
			GameObject.Find ("n3").GetComponent<SpriteRenderer> ().sprite = sprites[8];
		if(m[2]==9)
			GameObject.Find ("n3").GetComponent<SpriteRenderer> ().sprite = sprites[9];
	}
}