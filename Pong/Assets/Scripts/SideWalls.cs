using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {
	
							//The object in the parameter "hitinfo" will be the object that triggered the method. 
	void OnTriggerEnter2D (Collider2D hitinfo) {
	if (hitinfo.name == "Ball") {
			print ("Trigger: " + this.name);
			string name = transform.name;		//Transform.name will be the name of THIS object. The object the script is attached to.
			GameManager.Score(name);			//Call score(string) method in GameManager script
			hitinfo.gameObject.SendMessage("resetBall");
		}
	}

}
