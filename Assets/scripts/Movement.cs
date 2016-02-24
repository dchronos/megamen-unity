using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Animator anim;
	float velocity = 0;
	float jump = 0;
	float side = 1;
	bool jumping = false;
	public SpriteRenderer srender;
	public Rigidbody2D rdb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		velocity = Input.GetAxis ("Horizontal");
		jump = Input.GetAxis ("Vertical");
		jumping = Input.GetButtonDown ("Jump");

		if (jumping && anim.GetFloat("alt") < 0.7	) {
			rdb.AddForce (Vector2.up * 5, ForceMode2D.Impulse);
		}
		
		anim.SetFloat ("vel", velocity);
		if (velocity > 0) {
			srender.flipX = false;
			side = 1;
		}
		if (velocity < 0) {
			srender.flipX = true;
			side = -1;
		}
		anim.SetFloat ("vel", Mathf.Abs(velocity));
		RaycastHit2D hit = Physics2D.Raycast (transform.position, new Vector2 (0, -1));
		RaycastHit2D hitside = Physics2D.Raycast (transform.position, transform.right * side);
		//Debug.Log (hit.distance);
		Debug.DrawLine (transform.position, hitside.point);

		if (hit != null) {
			Debug.DrawLine (transform.position, hit.point);
			anim.SetFloat ("alt",hit.distance);
		}
		if (hitside != null) {
			anim.SetFloat ("side", hitside.distance);
		}

	}

	void FixedUpdate () {
		//rdb.AddForce (Vector2.right * velocity * (14 - Mathf.Abs (rdb.velocity.x)));
		rdb.velocity = new Vector2 (velocity*4, rdb.velocity.y);

	}
}
