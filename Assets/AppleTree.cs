﻿using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {
	// Prefab for instantiating apples
	public GameObject applePrefab;
	// Speed at which the AppleTree moves in meters/second
	public float speed = 1f;
	// Distance where AppleTree turns around
	public float leftAndRightEdge = 10f;
	// Chance that the AppleTree will change directions
	public float chanceToChangeDirections = 0.1f;
	// Rate at which Apples will be instantiated
	public float secondsBetweenAppleDrops = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
		// Changing Direction
	
	}
}
