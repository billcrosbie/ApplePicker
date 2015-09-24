using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {

	//prefab for instantiating apples
	public GameObject applePrefab;

	//speed at whch AppleTree moves
	public float speed = 1f;

	//distance where AppleTree turns around
	public float leftAndRightEdge = 10f;

	//Chance that AppleTree will change directions
	public float chanceToChangeDirections = .1f;

	//Rate at which Apples will be instantiated
	public float secondsBetweenAppleDrops = 1f;

	void Start (){
		//dropping apples every second
		InvokeRepeating ("DropApple", 2f, secondsBetweenAppleDrops);
	}
	void DropApple(){
		GameObject apple = Instantiate (applePrefab) as GameObject;
		apple.transform.position = transform.position;
	}
	void Update (){
		//Basic movement
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
		//Changing direction
		if (pos.x < -leftAndRightEdge) {
			speed = Mathf.Abs (speed); //move right
		} else if (pos.x > leftAndRightEdge) {
			speed = -Mathf.Abs (speed); //move left
		} 
	}
	void FixedUpdate (){
		//Change direction randomly
		if (Random.value < chanceToChangeDirections) {
			speed *= -1; //Change direction 
		}
	}
}
