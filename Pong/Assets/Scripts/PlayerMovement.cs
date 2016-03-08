using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public KeyCode moveUp;
	public KeyCode moveDown;

	public float speed;
	// Update is called once per frame

	private Rigidbody2D rb;

	void Start() {
		rb = gameObject.GetComponent<Rigidbody2D> ();
	}
	void Update () {
		if (Input.GetKey (moveUp)) {
			rb.velocity = new Vector2(0,speed);
		} else if (Input.GetKey (moveDown)) {
			rb.velocity = new Vector2(0,-speed);
		} else {
			rb.velocity = new Vector2(0,0);
		}
	}
}
