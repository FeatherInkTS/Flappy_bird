using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Bird : MonoBehaviour {

    public float speed = 0;
    
    public float force = 240;

	public float delay = 0.1f;

	public bool alive = true;

    void Start () {    
        //GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
		GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }
    
    void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }
    
    void OnCollisionEnter2D(Collision2D coll) {
		force = 0;
		alive = false;
		StartCoroutine (Timer());
    }

	IEnumerator Timer(){
		yield return new WaitForSeconds (delay);
		if (Input.GetKeyDown (KeyCode.Space)) {
			LoadGame();
		}
		StartCoroutine (Timer());
	}

	public void LoadGame(){
		SceneManager.LoadScene ("scenestart");
	}
}
