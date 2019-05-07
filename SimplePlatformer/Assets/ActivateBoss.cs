using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBoss : MonoBehaviour {

	public Transform spawnLoaction;
	public GameObject obejctToSpawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			//Instantiate Items/Guy
			Instantiate(obejctToSpawn, spawnLoaction.position, spawnLoaction.rotation);
			//Deactiveate GameObject
			gameObject.SetActive(false);
		}
	}
}
