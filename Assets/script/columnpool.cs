using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnpool : MonoBehaviour {

	// Use this for initialization
	public float spawnrate = 4f;
	public int columnsize = 5;
	public float columnmin = -1f;
	public float columnmax = 3.5f;
	public GameObject columnprefab;

	private GameObject[] columns;
	private Vector2 objectpoolposition = new Vector2(-15f,-25f);
	private float time;
	private float spawnxposition = 10f;
	private int currentcolumn =0;


	void Start () {

		columns = new GameObject[columnsize];
		for (int i = 0; i < columnsize; i++) 
		{
			columns [i] = (GameObject)Instantiate (columnprefab, objectpoolposition, Quaternion.identity);
		}
		
	}
	
	// Update is called once per frame
	void Update () 
	{	
		time += Time.deltaTime;

		if (gamecontroller.instance.gameover == false && time >= spawnrate) {
		
			time = 0;
			float spawnyposition = Random.Range (columnmin,columnmax);

			columns [currentcolumn].transform.position = new Vector2 (spawnxposition, spawnyposition);
			currentcolumn++;
			if (currentcolumn >= columnsize) {
			
				currentcolumn = 0;

			}
		}
	}
}
