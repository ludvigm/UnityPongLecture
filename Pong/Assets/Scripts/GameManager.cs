using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	static int player1Score = 0;
	static int player2Score = 0;

	public GUISkin scoreSkin;

	public static void Score (string wallName) {
		if(wallName == "rajtWål") {
			player2Score +=1;
		} else if(wallName == "LEFTWALL") {
			player1Score +=1;
		}
	}


	void OnGUI() {
		GUI.skin = scoreSkin;
		GUI.Label (new Rect (Screen.width / 2 - 150-12, 20, 100, 100), "" + player2Score);
		GUI.Label (new Rect (Screen.width / 2 + 150-12, 20, 100, 100), "" + player1Score);
	}
}
