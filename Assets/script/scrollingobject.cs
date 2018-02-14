using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingobject : MonoBehaviour {

	// Use this for initialization
	private Rigidbody2D rb2d;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = new Vector2 (gamecontroller.instance.scrollspeed, 0);
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (gamecontroller.instance.gameover == true) {
		
			rb2d.velocity = Vector2.zero;
		}
		
	}
}
