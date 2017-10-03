using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float moveSpeed;
	private bool facingRight = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow)) {
			float y = GetComponent<Rigidbody2D> ().velocity.y;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed,y);
		}

		if (Input.GetKey(KeyCode.RightArrow)) {
			float y = GetComponent<Rigidbody2D> ().velocity.y;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed,y);
		}

		if (facingRight) {
			Flip ();
		}

		if (!facingRight) {
			Flip ();
		}

	}

	void Flip(){
		Vector3 flipScale;
		Rigidbody2D rigidBody = GetComponent<Rigidbody2D> ();
		flipScale = rigidBody.transform.localScale;
		flipScale.x *= -1; // flip horizontally, along x-axis
		rigidBody.transform.localScale = flipScale;
		facingRight = !facingRight; //facing opposite direction.
	}
		

}
