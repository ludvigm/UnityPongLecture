using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (2f);
		goBall();
	}

	//This is called when a player scores. 
	public IEnumerator resetBall() {
		Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (0f, 0f);	//stop its movement
		transform.position = new Vector2 (0f, 0f);		//Move to middle
		yield return new WaitForSeconds (2f);		//Wait for 2 seconds, then call goBall().
		goBall();
	}

	//Used to initialize the ball movement. Randoms the initial direction in a shitty way.
	void goBall() {
		float randomNumber = Random.Range (0, 2);
		Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D> ();
		if (randomNumber <= 0.5) {
			rb.AddForce(new Vector2(80,20));
		} else {
			rb.AddForce(new Vector2(-80,20));
		}
	}

	//Gets called on collision.
	void OnCollisionEnter2D(Collision2D colInfo) {
		Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D> ();
		if(colInfo.collider.tag == "Player") {		//if colliding with a player, bounce. The next line is modified to transfer player movement into the balls bounce, making the player able somewhat "aim" the ball.
			rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y / 2 + colInfo.collider.attachedRigidbody.velocity.y / 3);
		}
	}
}
