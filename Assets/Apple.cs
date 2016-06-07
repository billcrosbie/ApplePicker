using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {
	public static float bottomY = -20f;
	// Use this for initialization
	void Start () {
		if ( transform.position.y < bottomY ) {
			Destroy( this.gameObject );
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
