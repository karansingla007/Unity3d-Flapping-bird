using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatingbackground : MonoBehaviour {

	private BoxCollider2D groundcollider;
	private float groundhorizontallength;

	// Use this for initialization
	void Start () 
	{
		groundcollider = GetComponent<BoxCollider2D> ();
		groundhorizontallength = groundcollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x < -groundhorizontallength) {
		
			repositionbackground ();
		}
	}

	private void repositionbackground()
	{
		Vector2 groundoffset = new Vector2 (groundhorizontallength * 2f,0);
		transform.position = (Vector2)transform.position + groundoffset;
	}
}
