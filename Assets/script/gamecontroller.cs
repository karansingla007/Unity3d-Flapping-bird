using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour {

	public static gamecontroller instance;
	public GameObject gameovertext;
	public bool gameover = false;
	public float scrollspeed = -1.5f;
	public Text scoretext;

	private int score =0;

	// Use this for initialization
	void Awake () {

		if (instance == null) {
		
			instance = this;
		} else if (instance != this) {
		
			Destroy (gameObject);
		}
		
	}
	
	// Update is called once per frame
	void Update () {

		if (gameover == true && Input.GetMouseButtonDown(0)) {
		
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
		
	}

	public void birdscored()
	{
		if (gameover == false) {
			score++;
			scoretext.text = "Score: "+score.ToString ();
		} else
			return;
	}
	public void BirdDied ()
	{
		gameovertext.SetActive (true);
		gameover = true;
	}
}
