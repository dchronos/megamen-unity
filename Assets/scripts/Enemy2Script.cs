using UnityEngine;
using System.Collections;

public class Enemy2Script : MonoBehaviour {

	public int life = 3;
	bool movement = false;

	// Use this for initialization
	void Start () {
	
	}

	public void getHit(){
		life--;
	}
	
	// Update is called once per frame
	void Update () {
		if (life < 1) {
			Destroy (gameObject);
		}

		if (movement) {
			gameObject.GetComponent<Rigidbody2D> ().AddForce(Vector2.left*Time.deltaTime, ForceMode2D.Impulse);
		}

	}

	void OnCollisionEnter2D (Collision2D col)
	{	
		Debug.Log ("Col : " + col.gameObject.name);
		if(col.gameObject.name == "bullet(Clone)")
		{
			getHit ();
		}
	}
	void OnBecameVisible(){
		movement = true;
	}
}
