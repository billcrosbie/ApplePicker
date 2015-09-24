using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour {

	public GUIText scoreGT;

	void Update () {
		//current screen position of mouse from input
		Vector3 mousePos2D = Input.mousePosition; 

		//camera's z pos
		mousePos2D.z = -Camera.main.transform.position.z; 

		//convert point from 2d into 3d
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);

		//Move x pos of basket to x pos of mouse
		Vector3 pos = this.transform.position;
		pos.x = mousePos3D.x;
		this.transform.position = pos;
	}
	void Start(){
		GameObject scoreGO = GameObject.Find ("ScoreCounter");
		scoreGT = scoreGO.GetComponent<GUIText> ();
		scoreGT.text = "0";
	}
	void OnCollisionEnter (Collision coll){
		//Find what hit basket
		GameObject collidedWith = coll.gameObject;
		if (collidedWith.tag == "Apple") {
			Destroy (collidedWith);
		}
		int score = int.Parse (scoreGT.text);
		score += 100;
		scoreGT.text = score.ToString ();

		if (score > HighScore.score) {
			HighScore.score = score;
		}
	}
}
